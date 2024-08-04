using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ProjectManagement.Services;

namespace ProjectManagement.Pages.Teams;

[Authorize(Roles = ("Admin"))]
public class Delete(ITeamService _teamService) : PageModel
{
    public string Name { get; set; }
    
    public async Task<IActionResult> OnGetAsync(string Id)
    {
        var team = await _teamService.GetByIdAsync(Id);
        if (team == null)
        {
            return base.BadRequest($"Unable to load team with ID '{Id}'.");
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