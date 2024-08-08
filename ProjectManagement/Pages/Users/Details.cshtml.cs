using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ProjectManagement.Entities;
using ProjectManagement.Services;
using ProjectManagement.Services.Impl;

namespace ProjectManagement.Pages.Users;

[Authorize(Roles = "Admin")]
public class Details : PageModel
{
    private readonly UserManager<User> _userManager;
    private readonly IUserService _userService;
    
    public Details(UserManager<User> userManager, IUserService userService)
    {
        _userManager = userManager;
        _userService = userService;
    }
    
    public User UserData { get; private set; }
    
    public string UserRole { get; private set; }

    private async Task LoadAsync(User user)
    {
        UserData = user;

        var roles = await _userManager.GetRolesAsync(user);

        UserRole = roles.First();
    }

    public async Task<IActionResult> OnGetAsync(string id)
    {
        var user = await _userService.GetByIdAsync(id);
        if (user == null)
        {
            return base.BadRequest($"Unable to load user with ID '{id}'.");
        }

        await LoadAsync(user);

        return Page();
    }
}