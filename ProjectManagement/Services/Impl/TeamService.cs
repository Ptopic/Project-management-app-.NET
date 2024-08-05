using System.Collections;
using AutoMapper;
using DSMS.Application.Exceptions;
using Microsoft.EntityFrameworkCore;
using ProjectManagement.Entities;
using ProjectManagement.Models.Requests.Team;
using ProjectManagement.Models.Views.Team;
using ProjectManagement.Repositories;

namespace ProjectManagement.Services.Impl;

public class TeamService : ITeamService
{
    private readonly IMapper _mapper;
    private readonly ITeamRepository _teamRepository;
    private readonly IUserRepository _userRepository;
    
    public TeamService(IMapper mapper, ITeamRepository teamRepository, IUserRepository userRepository)
    {
        _mapper = mapper;
        _teamRepository = teamRepository;
        _userRepository = userRepository;
    }
    
    public async Task<IEnumerable<TeamView>> GetAllAsync()
    {
        var teams = await _teamRepository.GetAll().Include(x => x.Members).ToListAsync();

        return _mapper.Map<IEnumerable<TeamView>>(teams);
    }

    public IEnumerable<TeamView> Search(IEnumerable<TeamView> teams, string searchString)
    {
        IEnumerable<TeamView> searchedTeams = teams;
        
        if (!string.IsNullOrEmpty(searchString))
        {
            var searchStringTrim = searchString.ToLower().Trim();
            searchedTeams = searchedTeams.Where(t => t.Name.ToLower().Contains(searchStringTrim));
        }

        return searchedTeams;
    }

    public IEnumerable<User> SearchMembers(IEnumerable<User> members, string searchString)
    {
        IEnumerable<User> searchedMembers = members;
        
        if (!string.IsNullOrEmpty(searchString))
        {
            var searchStringTrim = searchString.ToLower().Trim();
            searchedMembers = searchedMembers.Where(t => t.FirstName.ToLower().Contains(searchStringTrim));
        }

        return searchedMembers;
    }

    public async Task<Team> GetByIdAsync(string id)
    {
        var team = await _teamRepository.GetAll().Include(x => x.Members).Where(x => x.Id.ToString() == id).FirstOrDefaultAsync();
        if (team == null)
        {
            throw new NotFoundException($"Team with ID '{id}' not found.");
        }

        return team;
    }

    public async Task<Team> CreateAsync(CreateTeamRequest team)
    {
        return await _teamRepository.AddAsync(_mapper.Map<Team>(team));
    }

    public async Task<Team> UpdateAsync(Team team)
    {
        return await _teamRepository.UpdateAsync(team);
    }

    public async Task<Team> DeleteAsync(Team team)
    {
        var users = _userRepository.GetAll().Where(u => u.Team == team).ToList();

        foreach (var user in users)
        {
            user.Team = null;
            await _userRepository.UpdateAsync(user);
        }
        
        return await _teamRepository.DeleteAsync(team);
    }
}