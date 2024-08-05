using Microsoft.AspNetCore.Identity;

namespace ProjectManagement.Entities;

public class User : IdentityUser
{
    public string FirstName { get; set; } = null!;
    public string LastName { get; set; } = null!;
    
    public ICollection<Team> Teams { get; set; } = new HashSet<Team>(); // Many-to-many relationship
}