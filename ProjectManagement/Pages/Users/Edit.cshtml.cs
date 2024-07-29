using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ProjectManagement.Entities;
using ProjectManagement.Models.Requests.User;

namespace ProjectManagement.Pages.Users;

[Authorize(Roles = ("Admin"))]
public class Edit : PageModel
{
    private readonly UserManager<User> _userManager;

    public Edit(UserManager<User> userManager)
    {
        _userManager = userManager;
    }
    
    [TempData]
    public string StatusMessage { get; set; }
    
    [BindProperty]
    public CreateUserRequest Input { get; set; }
    
    private async Task LoadAsync(User user)
    {
        var firstName = user.FirstName;
        var lastName = user.LastName;
        var username = user.UserName;
        var email = user.Email;

        var roles = await _userManager.GetRolesAsync(user);
        var role = roles.First().ToString();

        Input = new CreateUserRequest
        {
            FirstName = firstName,
            LastName = lastName,
            UserName = username,
            Email = email,
            Role = role
        };
    }
    
    public async Task<IActionResult> OnGetAsync(string Id)
    {
        var user = await _userManager.FindByIdAsync(Id);
        if (user == null)
        {
            return base.BadRequest($"Unable to load user with ID '{Id}'.");
        }

        await LoadAsync(user);
        return Page();
    }

    public async Task<IActionResult> OnPostAsync(string Id)
    {
        var user = await _userManager.FindByIdAsync(Id);
        if (user == null)
        {
            return base.BadRequest($"Unable to load user with ID '{Id}'.");
        }

        if (!ModelState.IsValid)
        {
            await LoadAsync(user);
            return Page();
        }
        
        var firstName = user.FirstName;
        if (Input.FirstName != firstName)
        {
            user.FirstName = Input.FirstName;
        }

        var lastName = user.LastName;
        if (Input.LastName != lastName)
        {
            user.LastName = Input.LastName;
        }
        
        var username = user.UserName;
        if (Input.UserName != username)
        {
            user.UserName = Input.UserName;
        }
        
        var email = user.Email;
        if (Input.Email != email)
        {
            user.Email = Input.Email;
        }
        
        var role = _userManager.GetRolesAsync(user).Result.First();
        if (Input.Role != role)
        {
            await _userManager.RemoveFromRoleAsync(user, role);
            await _userManager.AddToRoleAsync(user, Input.Role);
        }

        await _userManager.UpdateAsync(user);
        
        StatusMessage = "User details have been updated";
        return Page();
    }
}