using System.ComponentModel.DataAnnotations;
using TaskStatus = ProjectManagement.Entities.Enums.TaskStatus;

namespace ProjectManagement.Models.Requests.Task;

public class CreateTaskRequest : BaseRequest
{
    [Required]
    public string Name { get; set; }
    
    [Required]
    public TaskStatus Status { get; set; }
}