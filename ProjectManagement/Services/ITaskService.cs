using ProjectManagement.Entities;
using ProjectManagement.Models.Views.Tasks;

namespace ProjectManagement.Services;

public interface ITaskService
{
    Task<TaskDefinition> CreateAsync(TaskDefinition task);
    
    Task<TaskDefinition> UpdateAsync(TaskDefinition team);
    
    Task<TaskDefinition> GetByIdAsync(string id);
    
    Task<IEnumerable<TaskView>> GetByProjectIdAsync(string projectId);
    
    Task<TaskView> GetLatestTaskByProjectIdAsync(string projectId);
    
    IEnumerable<TaskView> Search(IEnumerable<TaskView> tasks, string searchString);
    
    IEnumerable<TaskView> Filter(IEnumerable<TaskView> tasks, string currentFilter);
    
    Task<IResult> DeleteAsync(TaskDefinition task);
}