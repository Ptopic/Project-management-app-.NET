using AutoMapper;
using DSMS.Application.Exceptions;
using Microsoft.EntityFrameworkCore;
using ProjectManagement.Entities;
using ProjectManagement.Models.Views.Team;
using ProjectManagement.Repositories;

namespace ProjectManagement.Services.Impl;

public class TeamService : ITeamService
{
    private readonly IMapper _mapper;
    private readonly ITeamRepository _teamRepository;
    
    public TeamService(IMapper mapper, ITeamRepository teamRepository)
    {
        _mapper = mapper;
        _teamRepository = teamRepository;
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

    public async Task<Team> GetByIdAsync(string id)
    {
        var team = (await _teamRepository.GetAllAsync(a => a.Id.ToString() == id)).FirstOrDefault();
        if (team == null)
        {
            throw new NotFoundException($"Team with ID '{id}' not found.");
        }
        return team;
    }

    public async Task<Team> UpdateAsync(Team team)
    {
        return await _teamRepository.UpdateAsync(team);
    }
}