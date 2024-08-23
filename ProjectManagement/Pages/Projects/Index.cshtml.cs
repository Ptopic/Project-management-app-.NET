using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ProjectManagement.Entities;
using ProjectManagement.Entities.Enums;
using ProjectManagement.Models;
using ProjectManagement.Models.Views.Projects;
using ProjectManagement.Models.Views.Team;
using ProjectManagement.Services;

namespace ProjectManagement.Pages.Projects;

[Authorize]
public class Index(IProjectService _projectService, UserManager<User> _userManager) : PageModel
{
    public PaginatedList<ProjectView> Projects { get; set; }

    public User CurrentUser { get; set; }
    
    public List<string> PropertyNames;
    
    public async Task<IActionResult> OnGetAsync(string searchString, string sortOrder, int? pageIndex)
    {
        PropertyNames = _projectService.GetFieldNames();
        
        var user = await _userManager.GetUserAsync(User);
        if (user == null)
        {
            return RedirectToPage("/Account/Login", new { area = "Identity" });
        }
        
        CurrentUser = user;
        
        var roles = await _userManager.GetRolesAsync(user);

        IEnumerable<ProjectView> projects;
        
        if (roles.Contains(Roles.Admin.ToString()))
        {
            projects = await _projectService.GetAll();
        }
        else if(roles.Contains(Roles.Manager.ToString()))
        {
            projects = await _projectService.GetByManagerIdAsync(user.Id);
            var projectsWhereManagerIsMember = await _projectService.GetAllByUserAsync(user.Id);
            projects = projects.Concat(projectsWhereManagerIsMember);
        }
        else
        {
            projects = await _projectService.GetAllByUserAsync(user.Id);
        }
        
        if (projects == null)
        {
            return RedirectToPage("/Index");
        }
        
        ViewData["Keyword"] = searchString;
        
        projects = _projectService.Search(projects, searchString);
        
        ViewData["CurrentSort"] = sortOrder;
        projects = _projectService.Sort(projects, sortOrder);

        Projects = PaginatedList<ProjectView>.Create(projects, pageIndex ?? 1, 5);
        
        return Page();
    }
}