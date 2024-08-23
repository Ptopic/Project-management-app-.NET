using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
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
    
    public List<string> PropertyNames;

    public Index(IUserService userService)
    {
        _userService = userService;
    }
    
    public async Task<IActionResult> OnGetAsync(string searchString, string currentFilter, string sortOrder, int? pageIndex)
    {
        PropertyNames = _userService.GetFieldNames();
        
        var users = await _userService.GetAllAsync();
        
        ViewData["Keyword"] = searchString;
        users = _userService.Search(users, searchString);

        ViewData["CurrentFilter"] = currentFilter;
        users = _userService.Filter(users, currentFilter);
        
        ViewData["CurrentSort"] = sortOrder;
        users = _userService.Sort(users, sortOrder);

        Users = PaginatedList<UserView>.Create(users, pageIndex ?? 1, 5);
        
        return Page();
    }
}