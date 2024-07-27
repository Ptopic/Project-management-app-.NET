using ProjectManagement.Entities;

namespace ProjectManagement.Models.Views.Team;

public class TeamView : BaseView
{
    public string Name { get; set; } = null!;
 
    public ICollection<User> Members { get; set; } = new List<User>();
}