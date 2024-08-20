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
    
    public async Task<IActionResult> OnGetAsync(string Id)
    {
        var user = await _userManager.GetUserAsync(User);
        if (user == null)
        {
            return RedirectToPage("/Account/Login", new { area = "Identity" });
        }
        
        var project = await _projectService.GetByIdAsync(Id);
        if (project == null)
        {
            return base.BadRequest($"Unable to load project with ID '{Id}'.");
        }

        Name = project.Name; 

        return Page();
    }
    
    public async Task<IActionResult> OnPostAsync(string Id)
    {
        var project = await _projectService.GetByIdAsync(Id);
        if (project == null)
        {
            return base.BadRequest($"Unable to load project with ID '{Id}'.");
        }

        await _projectService.DeleteAsync(project);

        return Redirect("~/Projects/Index");
    }
}