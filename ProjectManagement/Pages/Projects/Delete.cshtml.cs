using DSMS.Application.Exceptions;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ProjectManagement.Entities;
using ProjectManagement.Entities.Enums;
using ProjectManagement.Services;

namespace ProjectManagement.Pages.Projects;

[Authorize(Roles = "Admin,Manager")]
public class Delete(UserManager<User> _userManager, IProjectService _projectService) : PageModel
{
    public string Name { get; set; }
    
    public async Task<IActionResult> OnGetAsync(string id)
    {
        var user = await _userManager.GetUserAsync(User);
        if (user == null)
        {
            return RedirectToPage("/Account/Login", new { area = "Identity" });
        }
        
        var project = await _projectService.GetByIdAsync(id);
        if (project == null)
        {
            throw new NotFoundException("Project not found");
        }

        Name = project.Name; 

        return Page();
    }
    
    public async Task<IActionResult> OnPostAsync(string id)
    {
        var project = await _projectService.GetByIdAsync(id);
        if (project == null)
        {
            throw new NotFoundException("Project not found");
        }

        await _projectService.DeleteAsync(project);

        return Redirect("~/Projects/Index");
    }
}