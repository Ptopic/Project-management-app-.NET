namespace ProjectManagement.Entities;

public class Project : BaseEntity
{
    public string Name { get; set; } = null!;
    
    public string Description { get; set; } = null!;
    
    public DateTime StartDate { get; set; }
    
    public DateTime EndDate { get; set; }
    
    public Guid ManagerId { get; set; }
    public User Manager { get; set; } = null!;
}