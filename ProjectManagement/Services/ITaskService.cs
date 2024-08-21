using ProjectManagement.Entities;

namespace ProjectManagement.Services;

public interface ITaskService
{
    Task<TaskDefinition> CreateAsync(TaskDefinition task);
}