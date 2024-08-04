using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ProjectManagement.Entities.Enums;
using ProjectManagement.Models;
using ProjectManagement.Models.Views.Team;
using ProjectManagement.Models.Views.Users;
using ProjectManagement.Services;

namespace ProjectManagement.Pages.Teams;

[Authorize(Roles = "Admin")]
public class Index : PageModel
{
    private readonly ITeamService _teamService;

    public PaginatedList<TeamView> Teams { get; set; }

    public Index(ITeamService teamService)
    {
        _teamService = teamService;
    }
    
    public async Task<PageResult> OnGetAsync(string searchString, string currentFilter, int? pageIndex)
    {
        var teams = await _teamService.GetAllAsync();
        
        ViewData["Keyword"] = searchString;
        teams = _teamService.Search(teams, searchString);

        Teams = PaginatedList<TeamView>.Create(teams, pageIndex ?? 1, 5);
        
        return Page();
    }
}