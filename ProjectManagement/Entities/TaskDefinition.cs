namespace ProjectManagement.Entities;

public class TaskDefinition : BaseEntity
{
    public Project Project { get; set; } = null!;
    
    public User Assignee { get; set; } = null!;
    
    public string Name { get; set; } = null!;
    
    public string Description { get; set; } = null!;
    
    public DateTime CreatedDate { get; set; }
    
    public DateTime DueDate { get; set; }
    
    public TaskStatus Status { get; set; }
}