using Microsoft.Build.Framework;
using ProjectManagement.Entities;
using TaskStatus = ProjectManagement.Entities.Enums.TaskStatus;

namespace ProjectManagement.Models.Requests.Task;

public class UpdateTaskRequest: BaseRequest
{
    [Required]
    public string Name { get; set; }
    
    public string? Description { get; set; }
    
    public string? AssigneeId { get; set; }
    
    public TaskStatus? Status { get; set; }
}