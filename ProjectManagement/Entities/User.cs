using Microsoft.AspNetCore.Identity;
using ProjectManagement.Entities.Enums;

namespace ProjectManagement.Entities;

public class User : IdentityUser
{
    public string FirstName { get; set; } = null!;
    public string LastName { get; set; } = null!;
    
    public Roles? Role { get; set; }
    
    public ICollection<Team> Teams { get; set; } = new HashSet<Team>();
}