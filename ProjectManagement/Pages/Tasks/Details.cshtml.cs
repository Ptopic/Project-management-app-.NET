using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ProjectManagement.Entities;
using ProjectManagement.Models.Requests.Task;
using ProjectManagement.Services;
using TaskStatus = ProjectManagement.Entities.Enums.TaskStatus;

namespace ProjectManagement.Pages.Tasks;

public class Details(ITaskService _taskService, IProjectService _projectService, IUserService _userService, ITeamService _teamService) : PageModel
{
    [BindProperty]
    public UpdateTaskRequest Input { get; set; }
    
    public Project Project { get; set; }
    
    public List<User> UserOptions { get; set; }
    
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
            return base.BadRequest($"Unable to load task with ID '{id}'.");
        }
        
        var project = await _projectService.GetByIdAsync(projectId);
        
        if (project == null)
        {
            return base.BadRequest($"Unable to load project with ID '{projectId}'.");
        }
        
        Project = project;
        
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
            return base.BadRequest($"Unable to load task with ID '{id}'.");
        }
        
        Console.WriteLine(Input.AssigneeId);
        Console.WriteLine(Input.Status);
        
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

        if (Input.AssigneeId != "")
        {
            var user = await _userService.GetByIdAsync(Input.AssigneeId);
            task.Assignee = user;
        }
        else
        {
            task.Assignee = null;
        }
        
        // var assignee = task.Assignee.Id;
        // if (assignee != null && Input.AssigneeId != assignee)
        // {
        //     var user = await _userService.GetByIdAsync(Input.AssigneeId);
        //     task.Assignee = user;
        // }
        
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
}