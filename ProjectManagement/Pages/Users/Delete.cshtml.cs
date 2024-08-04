using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ProjectManagement.Entities;

namespace ProjectManagement.Pages.Users;

[Authorize(Roles = ("Admin"))]
public class Delete(UserManager<User> _userManager) : PageModel
{
    public string Username { get; set; }
    
    public async Task<IActionResult> OnGet(string Id)
    {
        var user = await _userManager.FindByIdAsync(Id);
        if (user == null)
        {
            return base.BadRequest($"Unable to load user with ID '{Id}'.");
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
            return base.BadRequest($"Unable to load user with ID '{Id}'.");
        }

        var result = await _userManager.DeleteAsync(user);
        if (!result.Succeeded)
        {
            throw new InvalidOperationException($"Unexpected error occurred deleting user.");
        }

        return Redirect("~/Users/Index");
    }
}