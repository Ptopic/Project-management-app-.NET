using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ProjectManagement.Entities;
using ProjectManagement.Entities.Enums;
using ProjectManagement.Models;
using ProjectManagement.Models.Requests.Team;
using ProjectManagement.Models.Views.Team;
using ProjectManagement.Services;

namespace ProjectManagement.Pages.Teams;

[Authorize(Roles = "Admin")]
public class Members : PageModel
{
    private readonly ITeamService _teamService;
    private readonly IUserService _userService;
    private readonly UserManager<User> _userManager;

    public Members(ITeamService teamService, IUserService userService, UserManager<User> userManager)
    {
        _teamService = teamService;
        _userService = userService;
        _userManager = userManager;
    }
    
    public List<User> UserOptions { get; set; }
    
    [BindProperty]
    public AddMemberRequest Input { get; set; }
    
    public Team Team { get; set; }
    
    public PaginatedList<User> MembersList { get; set; }

    public async Task<PageResult> OnGetAsync(string id, string searchString, int? pageIndex)
    {
        var team = await _teamService.GetByIdAsync(id);
        
        var users = await _userManager.GetUsersInRoleAsync(Roles.User.ToString());
        
        ViewData["Keyword"] = searchString;
        var members = _teamService.SearchMembers(team.Members, searchString);
        
        MembersList = PaginatedList<User>.Create(members, pageIndex ?? 1, 3);
        
        Team = team;
        UserOptions = users.ToList();
        Input = new AddMemberRequest();
        
        return Page();
    }
    
    public async Task<IActionResult> OnPostAsync(string teamId)
    {
        if (string.IsNullOrEmpty(teamId))
        {
            return NotFound();
        }

        if (!ModelState.IsValid)
        {
            return RedirectToPage("/Teams/Members", new { id = teamId });
        }

        var user = await _userService.GetByIdAsync(Input.UserId);
        
        var team = await _teamService.GetByIdAsync(teamId);
        
        if (user == null || team == null)
        {
            return NotFound();
        }

        user.Teams.Add(team);
        
        await _userManager.UpdateAsync(user);
        
        return RedirectToPage("/Teams/Members", new { id = teamId });
    }
    
    public async Task<IActionResult> OnPostRemoveMemberAsync(string userId, string teamId)
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

        return RedirectToPage("Members", new { id = teamId });
    }
}