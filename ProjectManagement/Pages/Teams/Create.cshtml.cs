using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ProjectManagement.Entities;
using ProjectManagement.Entities.Enums;
using ProjectManagement.Models.Requests.Team;
using ProjectManagement.Services;
using ProjectManagement.Services.Impl;

namespace ProjectManagement.Pages.Teams;

[Authorize(Roles = "Admin,Manager")]
public class Create(ITeamService _teamService, UserManager<User> _userManager) : PageModel
{
    [BindProperty]
    public CreateTeamRequest Input { get; set; }

    public IList<User> ManagerOptions { get; set; }
    
    public async Task<IActionResult> OnGetAsync()
    {
        var managers = await _userManager.GetUsersInRoleAsync(Roles.Manager.ToString());

        ManagerOptions = managers;

        return Page();
    }
    
    public async Task<IActionResult> OnPostAsync(string id)
    {
        if (User.IsInRole(Roles.Manager.ToString()))
        {
            var user = await _userManager.GetUserAsync(User);
            if (user == null)
            {
                return RedirectToPage("/Account/Login", new { area = "Identity" });
            }

            Input.OwnerId = user.Id;
        }
        
        if (Input.OwnerId == null)
        {
            return RedirectToPage("/Teams/Index");
        }
        
        try
        {
            await _teamService.CreateAsync(Input, Input.OwnerId);
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }

        return Redirect("~/Teams/Index");
    }
}