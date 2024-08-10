using ProjectManagement.Models.Views.Projects;

namespace ProjectManagement.Services;

public interface IProjectService
{
    Task<IEnumerable<ProjectView>> GetAll();
    
    IEnumerable<ProjectView> Search(IEnumerable<ProjectView> projects, string searchString);
}