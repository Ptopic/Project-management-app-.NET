using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ProjectManagement.Entities;
using ProjectManagement.Models.Views.Team;
using ProjectManagement.Services;

namespace ProjectManagement.Pages.Teams;

[Authorize(Roles = "Admin")]
public class Members : PageModel
{
    private readonly ITeamService _teamService;

    public Members(ITeamService teamService)
    {
        _teamService = teamService;
    }
    
    public Team Team { get; set; }

    public async Task<PageResult> OnGetAsync(string id, string searchString, int? pageIndex)
    {
        var team = await _teamService.GetByIdAsync(id);
        
        // ViewData["Keyword"] = searchString;
        // teams = _teamService.Search(teams, searchString);
        //
        // Teams = PaginatedList<TeamView>.Create(teams, pageIndex ?? 1, 5);

        Team = team;
        
        return Page();
    }
}