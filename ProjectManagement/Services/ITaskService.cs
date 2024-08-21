using ProjectManagement.Entities;
using ProjectManagement.Models.Views.Tasks;

namespace ProjectManagement.Services;

public interface ITaskService
{
    Task<TaskDefinition> CreateAsync(TaskDefinition task);
    
    Task<IEnumerable<TaskView>> GetByProjectIdAsync(string projectId);
    
    Task<TaskView> GetLatestTaskByProjectIdAsync(string projectId);
}