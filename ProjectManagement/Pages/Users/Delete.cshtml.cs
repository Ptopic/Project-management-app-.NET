using DSMS.Application.Exceptions;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ProjectManagement.Entities;
using ProjectManagement.Services;

namespace ProjectManagement.Pages.Users;

[Authorize(Roles = "Admin")]
public class Delete(UserManager<User> _userManager, ITaskService _taskService) : PageModel
{
    public string Username { get; set; }
    
    public async Task<IActionResult> OnGetAsync(string Id)
    {
        var user = await _userManager.FindByIdAsync(Id);
        if (user == null)
        {
            throw new NotFoundException("User not found");
        }

        var userName = await _userManager.GetUserNameAsync(user);
        Username = userName;

        return Page();
    }
    
    public async Task<IActionResult> OnPostAsync(string Id)
    {
        var user = await _userManager.FindByIdAsync(Id);
        if (user == null)
        {
            throw new NotFoundException("User not found");
        }
        
        var tasks = await _taskService.GetTasksByAssigneeIdAsync(user.Id);
        foreach (var task in tasks)
        {
            task.Assignee = null;
            await _taskService.UpdateAsync(task);
        }

        var result = await _userManager.DeleteAsync(user);
        if (!result.Succeeded)
        {
            throw new InvalidOperationException($"Unexpected error occurred deleting user.");
        }

        return Redirect("~/Users/Index");
    }
}