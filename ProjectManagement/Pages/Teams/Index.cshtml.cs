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

[Authorize(Roles = "Admin,Manager")]
public class Index : PageModel
{
    private readonly ITeamService _teamService;

    public PaginatedList<TeamView> Teams { get; set; }
    private readonly UserManager<User> _userManager;

    public Index(ITeamService teamService, UserManager<User> userManager)
    {
        _teamService = teamService;
        _userManager = userManager;
    }
    
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
        else
        {
            teams = await _teamService.GetByManagerIdAsync(user.Id);
        }
        
        ViewData["Keyword"] = searchString;
        
        teams = _teamService.Search(teams, searchString);

        Teams = PaginatedList<TeamView>.Create(teams, pageIndex ?? 1, 5);
        
        return Page();
    }
}