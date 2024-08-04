using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ProjectManagement.Entities;
using ProjectManagement.Models.Requests.Team;
using ProjectManagement.Services;

namespace ProjectManagement.Pages.Teams;

[Authorize(Roles = ("Admin"))]
public class Edit : PageModel
{
    private readonly ITeamService _teamService;

    public Edit(ITeamService teamService)
    {
        _teamService = teamService;
    }
    
    [TempData]
    public string StatusMessage { get; set; }
    
    [BindProperty]
    public CreateTeamRequest Input { get; set; }
    
    private async Task LoadAsync(Team team)
    {
        var name = team.Name;

        Input = new CreateTeamRequest
        {
            Name = name
        };
    }
    
    public async Task<IActionResult> OnGetAsync(string id)
    {
        var team = await _teamService.GetByIdAsync(id);
        
        if (team == null)
        {
            return base.BadRequest($"Unable to load team with ID '{id}'.");
        }
        
        await LoadAsync(team);

        return Page();
    }
    
    public async Task<IActionResult> OnPostAsync(string id)
    {
        var team = await _teamService.GetByIdAsync(id);
        
        if (team == null)
        {
            return base.BadRequest($"Unable to load team with ID '{id}'.");
        }

        if (!ModelState.IsValid)
        {
            await LoadAsync(team);
            return Page();
        }
        
        var name = team?.Name;
        if (Input.Name != name)
        {
            team.Name = Input.Name;
        }
        
        await _teamService.UpdateAsync(team);

        StatusMessage = "Team details have been updated";

        return Page();
    }
}