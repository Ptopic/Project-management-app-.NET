using DSMS.Application.Exceptions;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ProjectManagement.Common.Email;
using ProjectManagement.Entities;
using ProjectManagement.Entities.Enums;
using ProjectManagement.Models.Requests.Task;
using ProjectManagement.Services;
using TaskStatus = ProjectManagement.Entities.Enums.TaskStatus;

namespace ProjectManagement.Pages.Tasks;

public class Details(ITaskService _taskService, IProjectService _projectService, IUserService _userService, ITeamService _teamService, UserManager<User> _userManager, IEmailService _emailService) : PageModel
{
    [BindProperty]
    public UpdateTaskRequest Input { get; set; }
    
    public Project Project { get; set; }
    
    public List<User> UserOptions { get; set; }
    
    public TaskDefinition Task { get; set; }
    
    private async Task LoadAsync(TaskDefinition task)
    {
        Input = new UpdateTaskRequest
        {
            Name = task.Name,
            Description = task.Description,
            AssigneeId = task.Assignee?.Id ?? null,
            Status = task.Status
        };
    }
    
    public async Task<IActionResult> OnGetAsync(string id, string projectId)
    {
        var task = await _taskService.GetByIdAsync(id);
        
        if (task == null)
        {
            throw new NotFoundException("Task not found");
        }

        Task = task;
        
        var project = await _projectService.GetByIdAsync(projectId);
        
        if (project == null)
        {
            throw new NotFoundException("Project not found");
        }
        
        Project = project;
        
        if (User.IsInRole(Roles.User.ToString()))
        {
            var projectTeamId = project.Team.Id;
            
            var user = await _userManager.GetUserAsync(User);
            if (user == null)
            {
                return RedirectToPage("/Account/Login", new { area = "Identity" });
            }
            
            var isUserMemberOfTeam = _teamService.IsUserMemberOfTeam(projectTeamId.ToString(), user);

            if (!isUserMemberOfTeam)
            {
                return RedirectToPage("/Projects/Index");
            }
        }

        if (User.IsInRole(Roles.Manager.ToString()))
        {
            var projectManager = project.Manager;
            
            var user = await _userManager.GetUserAsync(User);
            if (user == null)
            {
                return RedirectToPage("/Account/Login", new { area = "Identity" });
            }

            if (projectManager != user)
            {
                var isManagerMemberOfTeam = _teamService.IsUserMemberOfTeam(project.Team.Id.ToString(), user);
                
                if (!isManagerMemberOfTeam)
                {
                    return RedirectToPage("/Projects/Index");
                }
            }
        }
        
        var userOptions = new List<User>();
        
        var manager = await _userService.GetByIdAsync(project.Manager.Id);
        
        userOptions.Add(manager);
        
        var team = await _teamService.GetByIdAsync(project.Team.Id.ToString());

        var usersInTeam = team.Members;
        
        userOptions.AddRange(usersInTeam);
        
        UserOptions = userOptions;
        
        await LoadAsync(task);
        
        return Page();
    }
    
    public async Task<IActionResult> OnPostAsync(string id, string projectId)
    {
        var task = await _taskService.GetByIdAsync(id);
        if (task == null)
        {
            throw new NotFoundException("Task not found");
        }
        
        var project = await _projectService.GetByIdAsync(projectId);
        
        if (project == null)
        {
            return RedirectToPage("Details", new { id = projectId });
        }
        
        var name = task.Name;
        if (Input.Name != name)
        {
            task.Name = Input.Name;
        }

        var description = task.Description;
        if (Input.Description != description)
        {
            task.Description = Input.Description;
        }

        var user = await _userManager.FindByIdAsync(Input.AssigneeId);
        
        if (user != null)
        {
            if (task.Assignee != null)
            {
                var taskCurrentAssignee = await _userService.GetByIdAsync(task.Assignee.Id);
        
                if (!string.IsNullOrEmpty(taskCurrentAssignee.Email))
                {
                    var emailMessage =
                        EmailMessage.Create(taskCurrentAssignee.Email, $"You were unassigned from task <b>{task.Name}</b> in project <b>{project.Name}</b>", "ProjectManagement - Unassigned from task");
                    await _emailService.SendEmailAsync(emailMessage);
                }   
            }
        
            task.Assignee = user;
            task.UpdatedDate = DateTime.UtcNow;
        
            if (!string.IsNullOrEmpty(user.Email))
            {
                var emailMessage =
                    EmailMessage.Create(user.Email, $"You were assigned to task <b>{task.Name}</b> in project <b>{project.Name}</b>", "ProjectManagement - Assigned to task");
                await _emailService.SendEmailAsync(emailMessage);
            }
        }
        else
        {
            if (task.Assignee != null)
            {
                var taskCurrentAssignee = await _userService.GetByIdAsync(task.Assignee.Id);
        
                if (!string.IsNullOrEmpty(taskCurrentAssignee.Email))
                {
                    var emailMessage =
                        EmailMessage.Create(taskCurrentAssignee.Email, $"You were unassigned from task <b>{task.Name}</b> in project <b>{project.Name}</b>", "ProjectManagement - Unassigned from task");
                    await _emailService.SendEmailAsync(emailMessage);
                }   
            }
            
            task.Assignee = null;
        }
        
        var status = task.Status;
        if (Input.Status != null && Input.Status != status)
        {
            task.Status = Input.Status.Value;
        }
        else
        {
            task.Status = TaskStatus.TODO;
        }

        await _taskService.UpdateAsync(task);
        
        return RedirectToPage("/Projects/Details", new { id = projectId });
    }
    
    public DateTime ConvertToTimeZone(DateTime dateTime, string timeZoneId)
    {
        var timeZoneInfo = TimeZoneInfo.FindSystemTimeZoneById(timeZoneId);
        return TimeZoneInfo.ConvertTimeFromUtc(dateTime, timeZoneInfo);
    }
}