using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ProjectManagement.Entities;
using ProjectManagement.Entities.Enums;
using ProjectManagement.Models;
using ProjectManagement.Models.Views.Team;
using ProjectManagement.Models.Views.Users;
using ProjectManagement.Services;

namespace ProjectManagement.Pages.Teams;

public class Index(ITeamService _teamService, IUserService _userService, UserManager<User> _userManager) : PageModel
{
    public PaginatedList<TeamView> Teams { get; set; }
    
    public User CurrentUser { get; set; }
    
    public async Task<IActionResult> OnGetAsync(string searchString, int? pageIndex)
    {
        var user = await _userManager.GetUserAsync(User);
        if (user == null)
        {
            return RedirectToPage("/Account/Login", new { area = "Identity" });
        }
        
        var roles = await _userManager.GetRolesAsync(user);

        IEnumerable<TeamView> teams;
        
        if (roles.Contains(Roles.Admin.ToString()))
        {
            teams = await _teamService.GetAllAsync();
        }
        else if(roles.Contains(Roles.Manager.ToString()))
        {
            teams = await _teamService.GetByManagerIdAsync(user.Id);
        }
        else
        {
            teams = await _teamService.GetAllWhereUserIsMember(user.Id);
            
            CurrentUser = user;
        }

        if (teams == null)
        {
            return RedirectToPage("/Index");
        }
        
        ViewData["Keyword"] = searchString;
        
        teams = _teamService.Search(teams, searchString);

        Teams = PaginatedList<TeamView>.Create(teams, pageIndex ?? 1, 5);
        
        return Page();
    }
    
    public async Task<IActionResult> OnPostLeaveTeamAsync(string userId, string teamId)
    {
        var team = await _teamService.GetByIdAsync(teamId);
        var user = await _userService.GetByIdAsync(userId);
        
        if (team == null || user == null)
        {
            return NotFound();
        }

        team.Members.Remove(user);

        user.Teams.Remove(team);
        
        await _teamService.UpdateAsync(team);

        await _userManager.UpdateAsync(user);

        return RedirectToPage("/Teams/Index");
    }
}