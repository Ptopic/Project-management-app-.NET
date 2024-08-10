using ProjectManagement.Entities;

namespace ProjectManagement.Models.Views.Projects;

public class ProjectView : BaseView
{
    public string Name { get; set; } = null!;
    
    public string Description { get; set; } = null!;
    
    public DateTime StartDate { get; set; }
    
    public DateTime EndDate { get; set; }
    
    public User Manager { get; set; } = null!;
}