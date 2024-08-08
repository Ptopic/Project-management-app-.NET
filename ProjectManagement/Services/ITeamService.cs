using System.Collections;
using ProjectManagement.Entities;
using ProjectManagement.Models.Requests.Team;
using ProjectManagement.Models.Views.Team;

namespace ProjectManagement.Services;

public interface ITeamService
{
    Task<IEnumerable<TeamView>> GetAllAsync();

    IEnumerable<TeamView> Search(IEnumerable<TeamView> teams, string searchString);
    
    IEnumerable<User> SearchMembers(IEnumerable<User> teams, string searchString);
    
    Task<Team> GetByIdAsync(string id);
    
    Task<IEnumerable<TeamView>> GetByManagerIdAsync(string managerId);
    
    Task<Team> CreateAsync(CreateTeamRequest team, string userId);
    
    Task<Team> UpdateAsync(Team team);
    
    Task<IResult> DeleteAsync(Team feedback);
}