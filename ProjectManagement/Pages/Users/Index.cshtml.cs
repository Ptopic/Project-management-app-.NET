using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ProjectManagement.Entities.Enums;
using ProjectManagement.Models;
using ProjectManagement.Models.Views.Users;
using ProjectManagement.Services;

namespace ProjectManagement.Pages.Users;

[Authorize(Roles = "Admin")]
public class Index : PageModel
{
    private readonly IUserService _userService;

    public PaginatedList<UserView> Users { get; set; }

    public Index(IUserService userService)
    {
        _userService = userService;
    }
    
    public async Task<PageResult> OnGetAsync(string searchString, string currentFilter, int? pageIndex)
    {
        var users = await _userService.GetAllAsync();
        
        ViewData["Keyword"] = searchString;
        users = _userService.Search(users, searchString);

        ViewData["CurrentFilter"] = currentFilter;
        users = _userService.Filter(users, currentFilter);

        Users = PaginatedList<UserView>.Create(users, pageIndex ?? 1, 5);
        
        return Page();
    }
}