using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ProjectManagement.Models;
using ProjectManagement.Models.Views.Projects;
using ProjectManagement.Models.Views.Team;
using ProjectManagement.Services;

namespace ProjectManagement.Pages.Projects;

public class Index(IProjectService _projectService) : PageModel
{
    public PaginatedList<ProjectView> Projects { get; set; }
    
    public async Task<IActionResult> OnGetAsync(string searchString, int? pageIndex)
    {
        IEnumerable<ProjectView> projects = await _projectService.GetAll();
        
        ViewData["Keyword"] = searchString;
        
        projects = _projectService.Search(projects, searchString);

        Projects = PaginatedList<ProjectView>.Create(projects, pageIndex ?? 1, 5);
        
        return Page();
    }
}