using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ProjectManagement.Entities;
using ProjectManagement.Entities.Enums;
using ProjectManagement.Models.Requests.Team;
using ProjectManagement.Services;

namespace ProjectManagement.Pages.Teams;

[Authorize(Roles = "Admin,Manager")]
public class Edit : PageModel
{
    private readonly ITeamService _teamService;
    private readonly UserManager<User> _userManager;

    public Edit(ITeamService teamService, UserManager<User> userManager)
    {
        _teamService = teamService;
        _userManager = userManager;
    }
    
    [TempData]
    public string StatusMessage { get; set; }
    
    [BindProperty]
    public CreateTeamRequest Input { get; set; }
    
    public IList<User> ManagerOptions { get; set; }
    
    private async Task LoadAsync(Team team)
    {
        var name = team.Name;

        Input = new CreateTeamRequest
        {
            Name = name,
            OwnerId = team.OwnerId
        };
        
        var managers = await _userManager.GetUsersInRoleAsync(Roles.Manager.ToString());

        ManagerOptions = managers;
    }
    
    public async Task<IActionResult> OnGetAsync(string id)
    {
        var user = await _userManager.GetUserAsync(User);
        if (user == null)
        {
            return RedirectToPage("/Account/Login", new { area = "Identity" });
        }
        
        var team = await _teamService.GetByIdAsync(id);
        
        if (team == null)
        {
            return base.BadRequest($"Unable to load team with ID '{id}'.");
        }
        
        var roles = await _userManager.GetRolesAsync(user);
        
        if (roles.Contains(Roles.Manager.ToString()))
        {
            if(team.OwnerId != user.Id)
            {
                return RedirectToPage("/Teams/Index");
            }
        }
        
        await LoadAsync(team);

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
        
        var team = await _teamService.GetByIdAsync(id);
        
        if (team == null)
        {
            return base.BadRequest($"Unable to load team with ID '{id}'.");
        }
        
        var name = team?.Name;
        if (Input.Name != name)
        {
            team.Name = Input.Name;
        }
        
        var ownerId = team?.OwnerId;
        if (Input.OwnerId != ownerId)
        {
            team.OwnerId = Input.OwnerId;
        }
        
        await _teamService.UpdateAsync(team);

        StatusMessage = "Team details have been updated";

        return Page();
    }
}