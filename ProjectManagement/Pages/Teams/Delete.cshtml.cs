using DSMS.Application.Exceptions;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ProjectManagement.Entities;
using ProjectManagement.Entities.Enums;
using ProjectManagement.Repositories;
using ProjectManagement.Services;

namespace ProjectManagement.Pages.Teams;

[Authorize(Roles = "Admin,Manager")]
public class Delete(ITeamService _teamService, UserManager<User> _userManager, IUserRepository _userRepository) : PageModel
{
    public string Name { get; set; }
    
    public async Task<IActionResult> OnGetAsync(string Id)
    {
        var user = await _userManager.GetUserAsync(User);
        if (user == null)
        {
            return RedirectToPage("/Account/Login", new { area = "Identity" });
        }
        
        var team = await _teamService.GetByIdAsync(Id);
        if (team == null)
        {
            throw new NotFoundException("Team not found");
        }
        
        var roles = await _userManager.GetRolesAsync(user);
        
        if (roles.Contains(Roles.Manager.ToString()))
        {
            if(team.OwnerId != user.Id)
            {
                return RedirectToPage("/Teams/Index");
            }
        }

        Name = team.Name; 

        return Page();
    }
    
    public async Task<IActionResult> OnPostAsync(string Id)
    {
        var team = await _teamService.GetByIdAsync(Id);
        if (team == null)
        {
            throw new NotFoundException("Team not found");
        }
        
        var membersOfTeam = await _teamService.GetMembersOfTeamAsync(team.Id.ToString());

        if (membersOfTeam != null)
        {
            var membersToUpdate = new List<User>();
            foreach (var member in membersOfTeam)
            {
                member.Teams.Remove(team);
                membersToUpdate.Add(member);
            }

            foreach (var member in membersToUpdate)
            {
                await _userRepository.UpdateAsync(member);
            }
        }
        
        await _teamService.DeleteAsync(team);

        return Redirect("~/Teams/Index");
    }
}