using DSMS.Application.Exceptions;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ProjectManagement.Entities;
using ProjectManagement.Entities.Enums;
using ProjectManagement.Models.Requests.Project;
using ProjectManagement.Models.Views.Team;
using ProjectManagement.Repositories;
using ProjectManagement.Services;

namespace ProjectManagement.Pages.Projects;

[Authorize(Roles = "Admin,Manager")]
public class Edit(
    IProjectService _projectService, 
    UserManager<User> _userManager, 
    ITeamService _teamService,
    IUserRepository _userRepository,
    ITeamRepository _teamRepository
    )  : PageModel
{
    [TempData]
    public string StatusMessage { get; set; }
    
    [BindProperty]
    public CreateProjectRequest Input { get; set; }
    
    public IList<User> ManagerOptions { get; set; }
    
    public IEnumerable<TeamView> TeamOptions { get; set; }
    
    private async Task LoadAsync(Project project)
    {
        Input = new CreateProjectRequest()
        {
            Name = project.Name,
            Description = project.Description,
            Key = project.Key,
            StartDate = project.StartDate,
            EndDate = project.EndDate,
            ManagerId = project.ManagerId.ToString(),
            TeamId = project.Team.Id.ToString()
        };
    }
    
    public async Task<IActionResult> OnGetAsync(string id)
    {
        var user = await _userManager.GetUserAsync(User);
        if (user == null)
        {
            return RedirectToPage("/Account/Login", new { area = "Identity" });
        }
        
        var managers = await _userManager.GetUsersInRoleAsync(Roles.Manager.ToString());

        ManagerOptions = managers;

        IEnumerable<TeamView> teams;

        if (User.IsInRole(Roles.Admin.ToString()))
        {
            teams = await _teamService.GetAllAsync();
        }
        else
        {
            teams = await _teamService.GetByManagerIdAsync(user.Id);
        }

        TeamOptions = teams;
        
        var project = await _projectService.GetByIdAsync(id);
        
        if (project == null)
        {
            throw new NotFoundException("Project not found");
        }
        
        await LoadAsync(project);
        
        return Page();
    }
    
    public async Task<IActionResult> OnPostAsync(string id)
    {
        if (User.IsInRole(Roles.Manager.ToString()))
        {
            var user = await _userManager.GetUserAsync(User);
            if (user == null)
            {
                return RedirectToPage("/Account/Login", new { area = "Identity" });
            }

            Input.ManagerId = user.Id;
        }
        
        var project = await _projectService.GetByIdAsync(id);
        
        if(project == null)
        {
            throw new NotFoundException("Project not found");
        }
        
        var name = project?.Name;
        if (Input.Name != name)
        {
            project.Name = Input.Name;
        }
        
        var description = project?.Description;
        if (Input.Description != description)
        {
            project.Description = Input.Description;
        }
        
        var startDate = project?.StartDate;
        if (Input.StartDate != startDate)
        {
            project.StartDate = Input.StartDate;
        }
        
        var endDate = project?.EndDate;
        if (Input.EndDate != endDate)
        {
            project.EndDate = Input.EndDate;
        }
        
        var managerId = project?.ManagerId;
        if (Input.ManagerId != managerId)
        {
            project.ManagerId = Input.ManagerId;
        }
        
        var manager = await _userRepository.GetByIdAsync(Input.ManagerId);
        
        if (manager == null)
        {
            throw new NotFoundException("Manager not found");
        }
        
        project.Manager = manager;
        
        var team = await _teamRepository.GetByIdAsync(new Guid(Input.TeamId));
        
        if (team == null)
        {
            throw new NotFoundException("Team not found");
        }

        project.Team = team;
        
        await _projectService.UpdateAsync(project);

        StatusMessage = "Project details have been updated";

        return RedirectToPage("/Projects/Edit", new { id });
    }
}