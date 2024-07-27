using ProjectManagement.Models.Views.Team;

namespace ProjectManagement.Services;

public interface ITeamService
{
    Task<IEnumerable<TeamView>> GetAllAsync();
    
    IEnumerable<TeamView> Search(IEnumerable<TeamView> teams, string searchString);
}