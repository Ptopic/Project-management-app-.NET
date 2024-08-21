using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ProjectManagement.Entities;
using ProjectManagement.Models.Requests.Task;
using ProjectManagement.Services;
using TaskStatus = ProjectManagement.Entities.Enums.TaskStatus;

namespace ProjectManagement.Pages.Projects;

[Authorize]
public class Details(IProjectService _projectService, UserManager<User> _userManager, ITaskService _taskService) : PageModel
{
    [BindProperty]
    public CreateTaskRequest Input { get; set; }
    
    public Project Project { get; set; }
    
    public async Task<IActionResult> OnGetAsync(string id)
    {
        var project = await _projectService.GetByIdAsync(id);
        if (project == null)
        {
            return base.BadRequest($"Unable to load project with ID '{id}'.");
        }

        Project = project;

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
            return BadRequest($"Unable to load project with ID '{id}'.");
        }
        
        var user = await _userManager.GetUserAsync(User);
        if (user == null)
        {
            return RedirectToPage("/Account/Login", new { area = "Identity" });
        }
        
        var task = new TaskDefinition
        {
            Project = project,
            Assignee = user,
            Name = Input.Name,
            Description = "",
            TaskIdentifier = "task-123",
            CreatedDate = DateTime.UtcNow,
            UpdatedDate = DateTime.UtcNow,
            Status = Input.Status
        };
        
        await _taskService.CreateAsync(task);

        return RedirectToPage("/Projects/Details", new { id });
    }
}