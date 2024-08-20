using ProjectManagement.Models.Views.Projects;

namespace ProjectManagement.Services;

public interface IProjectService
{
    Task<IEnumerable<ProjectView>> GetAll();
    
    Task<IEnumerable<ProjectView>> GetByManagerIdAsync(string managerId);
    
    Task<IEnumerable<ProjectView>> GetAllByUserAsync(string userId);
    
    IEnumerable<ProjectView> Search(IEnumerable<ProjectView> projects, string searchString);
}