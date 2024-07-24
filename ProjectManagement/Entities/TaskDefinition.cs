namespace ProjectManagement.Entities;

public class TaskDefinition : BaseEntity
{
    public Guid ProjectId { get; set; }
    public Project Project { get; set; } = null!;
    
    public Guid AssigneeId { get; set; }
    public User Assignee { get; set; } = null!;
    
    public string Name { get; set; } = null!;
    
    public string Description { get; set; } = null!;
    
    public DateTime CreatedDate { get; set; }
    
    public DateTime DueDate { get; set; }
    
    public TaskStatus Status { get; set; }
}