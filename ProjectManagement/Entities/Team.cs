namespace ProjectManagement.Entities;

public class Team : BaseEntity
{
    public string Name { get; set; } = null!;
    
    public string OwnerId { get; set; }
    public User Owner { get; set; } = null!;
 
    public ICollection<User> Members { get; set; } = new List<User>();
}