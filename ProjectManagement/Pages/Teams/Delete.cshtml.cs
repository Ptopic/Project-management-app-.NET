using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ProjectManagement.Entities;
using ProjectManagement.Entities.Enums;
using ProjectManagement.Services;

namespace ProjectManagement.Pages.Teams;

[Authorize(Roles = "Admin,Manager")]
public class Delete(ITeamService _teamService, UserManager<User> _userManager) : PageModel
{
    public string Name { get; set; }
    
    public async Task<IActionResult> OnGetAsync(string Id)
    {
        var user = await _userManager.GetUserAsync(User);
        if (user == null)
        {
            return RedirectToPage("/Account/Login", new { area = "Identity" });
        }
        
        var team = await _teamService.GetByIdAsync(Id);
        if (team == null)
        {
            return base.BadRequest($"Unable to load team with ID '{Id}'.");
        }
        
        var roles = await _userManager.GetRolesAsync(user);
        
        if (roles.Contains(Roles.Manager.ToString()))
        {
            if(team.OwnerId != user.Id)
            {
                return RedirectToPage("/Teams/Index");
            }
        }

        Name = team.Name; 

        return Page();
    }
    
    public async Task<IActionResult> OnPostAsync(string Id)
    {
        var team = await _teamService.GetByIdAsync(Id);
        if (team == null)
        {
            return base.BadRequest($"Unable to load team with ID '{Id}'.");
        }

        await _teamService.DeleteAsync(team);

        return Redirect("~/Teams/Index");
    }
}