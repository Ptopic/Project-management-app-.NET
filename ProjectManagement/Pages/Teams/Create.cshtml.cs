using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ProjectManagement.Models.Requests.Team;
using ProjectManagement.Services;

namespace ProjectManagement.Pages.Teams;

[Authorize(Roles = ("Admin"))]
public class Create : PageModel
{
    private readonly ITeamService _teamService;

    public Create(ITeamService teamService)
    {
        _teamService = teamService;
    }
    
    
    [BindProperty]
    public CreateTeamRequest Input { get; set; }

    
    public void OnGet()
    {
        
    }
    
    public async Task<IActionResult> OnPostAsync(string id)
    {
        try
        {
            await _teamService.CreateAsync(Input);
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }

        return Redirect("~/Teams/Index");
    }
}