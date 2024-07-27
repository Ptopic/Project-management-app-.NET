using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ProjectManagement.Entities.Enums;
using ProjectManagement.Models.Views.Team;
using ProjectManagement.Models.Views.Users;
using ProjectManagement.Services;

namespace ProjectManagement.Pages.Teams;

[Authorize(Roles = "Admin")]
public class Index : PageModel
{
    private readonly ITeamService _teamService;

    public IEnumerable<TeamView> Teams { get; private set; } = new List<TeamView>();

    public Index(ITeamService teamService)
    {
        _teamService = teamService;
    }
    
    public async Task<PageResult> OnGetAsync(string searchString, string currentFilter)
    {
        Teams = await _teamService.GetAllAsync();
        
        ViewData["Keyword"] = searchString;
        Teams = _teamService.Search(Teams, searchString);

        return Page();
    }
}