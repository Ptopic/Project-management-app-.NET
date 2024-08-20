using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ProjectManagement.Entities;
using ProjectManagement.Services;

namespace ProjectManagement.Pages.Projects;

public class Details(IProjectService _projectService) : PageModel
{
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
}