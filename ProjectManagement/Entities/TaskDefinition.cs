using TaskStatus = ProjectManagement.Entities.Enums.TaskStatus;

namespace ProjectManagement.Entities;

public class TaskDefinition : BaseEntity
{
    public Project Project { get; set; } = null!;
    
    public User? Assignee { get; set; } = null!;
    
    public string Name { get; set; } = null!;
    
    public string? Description { get; set; } = null!;
    
    public string TaskIdentifier { get; set; } = null!;
    
    public int TaskNumber { get; set; }
    
    public DateTime CreatedDate { get; set; }
    
    public DateTime UpdatedDate { get; set; }
    
    public TaskStatus Status { get; set; }
}