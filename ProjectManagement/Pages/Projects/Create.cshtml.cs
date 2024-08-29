using DSMS.Application.Exceptions;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ProjectManagement.Entities;
using ProjectManagement.Entities.Enums;
using ProjectManagement.Models.Requests.Project;
using ProjectManagement.Models.Requests.Team;
using ProjectManagement.Models.Views.Team;
using ProjectManagement.Services;

namespace ProjectManagement.Pages.Projects;

[Authorize(Roles = "Admin,Manager")]
public class Create(IProjectService _projectService, UserManager<User> _userManager, ITeamService _teamService) : PageModel
{
    [BindProperty]
    public CreateProjectRequest Input { get; set; }
    
    public IList<User> ManagerOptions { get; set; }
    
    public IEnumerable<TeamView> TeamOptions { get; set; }
    
    public async Task<IActionResult> OnGetAsync()
    {
        var user = await _userManager.GetUserAsync(User);
        if (user == null)
        {
            return RedirectToPage("/Account/Login", new { area = "Identity" });
        }
        
        var managers = await _userManager.GetUsersInRoleAsync(Roles.Manager.ToString());

        ManagerOptions = managers;

        IEnumerable<TeamView> teams;

        if (User.IsInRole(Roles.Admin.ToString()))
        {
            teams = await _teamService.GetAllAsync();
        }
        else
        {
            teams = await _teamService.GetByManagerIdAsync(user.Id);
        }

        TeamOptions = teams;
        

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

            Input.ManagerId = user.Id;
        }
        
        if (Input.ManagerId == null)
        {
            return RedirectToPage("/Teams/Index");
        }
        
        try
        {
            await _projectService.CreateAsync(Input);
        }
        catch (Exception ex)
        {
            throw new BadRequestException(ex.Message);
        }

        return Redirect("~/Projects/Index");
    }
}