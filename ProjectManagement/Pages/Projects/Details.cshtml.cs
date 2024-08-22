using DSMS.Application.Exceptions;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ProjectManagement.Common.Email;
using ProjectManagement.Entities;
using ProjectManagement.Entities.Enums;
using ProjectManagement.Models.Requests.Task;
using ProjectManagement.Models.Views.Tasks;
using ProjectManagement.Services;
using TaskStatus = ProjectManagement.Entities.Enums.TaskStatus;

namespace ProjectManagement.Pages.Projects;

[Authorize]
public class Details(IProjectService _projectService, UserManager<User> _userManager, ITaskService _taskService, IUserService _userService, ITeamService _teamService, IEmailService _emailService) : PageModel
{
    [BindProperty]
    public CreateTaskRequest Input { get; set; }
    
    public List<User> UserOptions { get; set; }

    public int MemberCount;
    
    public Project Project { get; set; }
    
    public IEnumerable<TaskView> TODOTasks { get; set; }
    
    public IEnumerable<TaskView> INPROGRESSTasks { get; set; }
    
    public IEnumerable<TaskView> INREVIEWTasks { get; set; }
    
    public IEnumerable<TaskView> DONETasks { get; set; }
    
    public async Task<IActionResult> OnGetAsync(string id, string searchString, string currentFilter)
    {
        var project = await _projectService.GetByIdAsync(id);
        if (project == null)
        {
            throw new NotFoundException("Project not found");
        }
        
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

        Project = project;
        
        var projectTasks = await _taskService.GetByProjectIdAsync(id);

        var userOptions = new List<User>();
        
        var manager = await _userService.GetByIdAsync(project.Manager.Id);
        
        userOptions.Add(manager);
        
        var team = await _teamService.GetByIdAsync(project.Team.Id.ToString());

        var usersInTeam = team.Members;
        
        userOptions.AddRange(usersInTeam);
        
        UserOptions = userOptions;
        
        MemberCount = userOptions.Count;

        ViewData["Keyword"] = searchString;
        projectTasks = _taskService.Search(projectTasks, searchString);
        
        ViewData["CurrentFilter"] = currentFilter;
        
        // TODO - Not working when there is no tasks for specific user
        var filteredProjectTasks = _taskService.Filter(projectTasks, currentFilter);

        TODOTasks = filteredProjectTasks.Where(x => x.Status == TaskStatus.TODO);
        INPROGRESSTasks = filteredProjectTasks.Where(x => x.Status == TaskStatus.IN_PROGRESS);
        INREVIEWTasks = filteredProjectTasks.Where(x => x.Status == TaskStatus.IN_REVIEW);
        DONETasks = filteredProjectTasks.Where(x => x.Status == TaskStatus.DONE);
        
        return Page();
    }
    
    public async Task<IActionResult> OnPostAsync(string id)
    {
        if (!ModelState.IsValid)
        {
            return BadRequest(ModelState);
        }
        
        var project = await _projectService.GetByIdAsync(id);
        if (project == null)
        {
            throw new NotFoundException("Project not found");
        }
        
        var user = await _userManager.GetUserAsync(User);
        if (user == null)
        {
            return RedirectToPage("/Account/Login", new { area = "Identity" });
        }

        int taskNumber;

        var latestTask = await _taskService.GetLatestTaskByProjectIdAsync(id);
        
        if (latestTask != null)
        {
            taskNumber = latestTask.TaskNumber + 1;
        }
        else
        {
            taskNumber = 1;
        }
        
        var task = new TaskDefinition
        {
            Project = project,
            Assignee = null,
            Name = Input.Name,
            Description = "",
            TaskIdentifier = project.Key + " " + taskNumber,
            TaskNumber = taskNumber,
            CreatedDate = DateTime.UtcNow,
            UpdatedDate = DateTime.UtcNow,
            Status = Input.Status
        };
        
        await _taskService.CreateAsync(task);

        return RedirectToPage("/Projects/Details", new { id });
    }
    
    public async Task<IActionResult> OnPostRemoveTaskAsync(string projectId, string taskId)
    {
        var task = await _taskService.GetByIdAsync(taskId);
        
        if (task == null)
        {
            return RedirectToPage("Details", new { id = projectId });
        }

        task.Assignee = null;
        
        await _taskService.DeleteAsync(task);

        return RedirectToPage("Details", new { id = projectId });
    }
    
    public async Task<IActionResult> OnPostAssignUserToTaskAsync(string taskId, string userId, string projectId)
    {
        var task = await _taskService.GetByIdAsync(taskId);
        
        if (task == null)
        {
            return RedirectToPage("Details", new { id = projectId });
        }

        var project = await _projectService.GetByIdAsync(projectId);
        
        var taskCurrentAssignee = await _userService.GetByIdAsync(task.Assignee.Id);
        
        var user = await _userManager.FindByIdAsync(userId);
        
        if (user == null)
        {
            task.Assignee = null;
            
            await _taskService.UpdateAsync(task);
            
            return RedirectToPage("Details", new { id = projectId });
        }
        
        if (!string.IsNullOrEmpty(taskCurrentAssignee.Email))
        {
            var emailMessage =
                EmailMessage.Create(taskCurrentAssignee.Email, $"You were unassigned from task <b>{task.Name}</b> in project <b>{project.Name}</b>", "ProjectManagement - Unassigned from task");
            await _emailService.SendEmailAsync(emailMessage);
        }
        
        task.Assignee = user;
        task.UpdatedDate = DateTime.UtcNow;
        
        if (!string.IsNullOrEmpty(user.Email))
        {
            var emailMessage =
                EmailMessage.Create(user.Email, $"You were assigned to task <b>{task.Name}</b> in project <b>{project.Name}</b>", "ProjectManagement - Assigned to task");
            await _emailService.SendEmailAsync(emailMessage);
        }
        
        await _taskService.UpdateAsync(task);

        return RedirectToPage("Details", new { id = projectId });
    }
}