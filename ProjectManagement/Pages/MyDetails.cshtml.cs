using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ProjectManagement.Entities;

namespace ProjectManagement.Pages;

[Authorize]
public class MyDetails(UserManager<User> userManager) : PageModel
{
    public User? user;

    public void OnGet()
    {
        var task = userManager.GetUserAsync(User);
        task.Wait();
        user = task.Result;
    }
}