using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ProjectManagement.Entities.Enums;
using ProjectManagement.Models.Views.Users;
using ProjectManagement.Services;

namespace ProjectManagement.Pages.Users;

[Authorize(Roles = "Admin")]
public class Index : PageModel
{
    private readonly IUserService _userService;

    public IEnumerable<UserView> Users { get; private set; } = new List<UserView>();

    public Index(IUserService userService)
    {
        _userService = userService;
    }
    
    public async Task<PageResult> OnGetAsync(string searchString, string currentFilter)
    {
        Users = await _userService.GetAllAsync();
        
        ViewData["Keyword"] = searchString;
        Users = _userService.Search(Users, searchString);

        ViewData["CurrentFilter"] = currentFilter;
        Users = _userService.Filter(Users, currentFilter);

        return Page();
    }
}