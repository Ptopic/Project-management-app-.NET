using Microsoft.AspNetCore.Identity;

namespace ProjectManagement.Entities;

public class User : IdentityUser
{
    public string FirstName { get; set; } = null!;
    public string LastName { get; set; } = null!;
    
    public Guid? TeamId { get; set; }
    public Team? Team { get; set; }
}