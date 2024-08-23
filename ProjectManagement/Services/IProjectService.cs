using ProjectManagement.Entities;
using ProjectManagement.Models.Requests.Project;
using ProjectManagement.Models.Views.Projects;

namespace ProjectManagement.Services;

public interface IProjectService
{
    List<string> GetFieldNames();
    
    Task<IEnumerable<ProjectView>> GetAll();
    
    Task<Project> GetByIdAsync(string id);
    
    Task<IEnumerable<ProjectView>> GetByManagerIdAsync(string managerId);
    
    Task<IEnumerable<ProjectView>> GetAllByUserAsync(string userId);
    
    IEnumerable<ProjectView> Search(IEnumerable<ProjectView> projects, string searchString);
    
    IEnumerable<ProjectView> Sort(IEnumerable<ProjectView> projects, string sortOrder);
    
    Task<Project> CreateAsync(CreateProjectRequest project);
    
    Task<Project> UpdateAsync(Project project);
    
    Task<IResult> DeleteAsync(Project project);
}