using System.Collections;
using ProjectManagement.Entities;
using ProjectManagement.Models.Requests.Team;
using ProjectManagement.Models.Views.Team;

namespace ProjectManagement.Services;

public interface ITeamService
{
    List<string> GetFieldNames();
    
    Task<IEnumerable<TeamView>> GetAllAsync();

    IEnumerable<TeamView> Search(IEnumerable<TeamView> teams, string searchString);
    
    IEnumerable<TeamView> Sort(IEnumerable<TeamView> teams, string sortOrder);
    
    IEnumerable<User> SearchMembers(IEnumerable<User> teams, string searchString);
    
    Task<Team> GetByIdAsync(string id);
    
    Task<IEnumerable<TeamView>> GetByManagerIdAsync(string managerId);
    
    Task<Team> CreateAsync(CreateTeamRequest team, string userId);
    
    Task<Team> UpdateAsync(Team team);
    
    Task<IResult> DeleteAsync(Team team);
    
    Task<IEnumerable<TeamView>> GetAllWhereUserIsMember(string userId);
    
    Task<ICollection<User>?> GetMembersOfTeamAsync(string teamId);
    
    bool IsUserMemberOfTeam(string teamId, User user);
}