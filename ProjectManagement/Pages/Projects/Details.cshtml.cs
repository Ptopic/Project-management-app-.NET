using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ProjectManagement.Entities;
using ProjectManagement.Models.Requests.Task;
using ProjectManagement.Models.Views.Tasks;
using ProjectManagement.Services;
using TaskStatus = ProjectManagement.Entities.Enums.TaskStatus;

namespace ProjectManagement.Pages.Projects;

[Authorize]
public class Details(IProjectService _projectService, UserManager<User> _userManager, ITaskService _taskService, IUserService _userService, ITeamService _teamService) : PageModel
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
            return base.BadRequest($"Unable to load project with ID '{id}'.");
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
            return BadRequest($"Unable to load project with ID '{id}'.");
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
            return NotFound();
        }

        task.Assignee = null;
        
        await _taskService.DeleteAsync(task);

        return RedirectToPage("Details", new { id = projectId });
    }
}