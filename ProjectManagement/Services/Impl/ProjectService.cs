using AutoMapper;
using DSMS.Application.Exceptions;
using Microsoft.EntityFrameworkCore;
using ProjectManagement.Entities;
using ProjectManagement.Models.Requests.Project;
using ProjectManagement.Models.Views.Projects;
using ProjectManagement.Repositories;

namespace ProjectManagement.Services.Impl;

public class ProjectService(IMapper _mapper, IProjectRepository _projectRepository, IUserRepository _userRepository, ITeamRepository _teamRepository) : IProjectService
{
    public async Task<IEnumerable<ProjectView>> GetAll()
    {
        var projects = await _projectRepository.GetAll().Include(x => x.Manager).Include(x => x.Team).ToListAsync();

        return _mapper.Map<IEnumerable<ProjectView>>(projects);
    }

    public async Task<Project> GetByIdAsync(string id)
    {
        var project = await _projectRepository.GetAll()
            .Include(x => x.Manager)
            .Include(x => x.Team)
            .Where(x => x.Id.ToString() == id)
            .FirstOrDefaultAsync();
        if (project == null)
        {
            throw new NotFoundException($"Project with ID '{id}' not found.");
        }

        return project;
    }

    public async Task<IEnumerable<ProjectView>> GetByManagerIdAsync(string managerId)
    {
        var projects = await _projectRepository.GetAll()
            .Include(x => x.Manager)
            .Include(x => x.Team)
            .Where(x => x.ManagerId == managerId)
            .ToListAsync();

        return _mapper.Map<IEnumerable<ProjectView>>(projects);
    }

    public async Task<IEnumerable<ProjectView>> GetAllByUserAsync(string userId)
    {
        var projects = await _projectRepository.GetAll()
            .Include(x => x.Manager)
            .Include(x => x.Team)
            .ThenInclude(t => t.Members)
            .Where(x => x.Team.Members.Any(m => m.Id == userId))
            .ToListAsync();

        return _mapper.Map<IEnumerable<ProjectView>>(projects);
    }

    public IEnumerable<ProjectView> Search(IEnumerable<ProjectView> projects, string searchString)
    {
        IEnumerable<ProjectView> searchedProjects = projects;
        
        if (!string.IsNullOrEmpty(searchString))
        {
            var searchStringTrim = searchString.ToLower().Trim();
            searchedProjects = searchedProjects.Where(p => p.Name.ToLower().Contains(searchStringTrim));
        }

        return searchedProjects;
    }

    public async Task<Project> CreateAsync(CreateProjectRequest project)
    {
        var manager = await _userRepository.GetByIdAsync(project.ManagerId);
        
        if (manager == null)
        {
            throw new NotFoundException("Manager not found");
        }
        
        var team = await _teamRepository.GetByIdAsync(new Guid(project.TeamId));
        
        if (team == null)
        {
            throw new NotFoundException("Team not found");
        }
        
        var newProject = new Project()
        {
            Name = project.Name,
            Description = project.Description ?? string.Empty,
            StartDate = DateTime.SpecifyKind(project.StartDate, DateTimeKind.Utc),
            EndDate = DateTime.SpecifyKind(project.EndDate, DateTimeKind.Utc),
            ManagerId = project.ManagerId,
            Manager = manager,
            Team = team,
        };
        
        return await _projectRepository.AddAsync(newProject);
    }

    public async Task<Project> UpdateAsync(Project project)
    {
        project.StartDate = DateTime.SpecifyKind(project.StartDate, DateTimeKind.Utc);
        project.EndDate = DateTime.SpecifyKind(project.EndDate, DateTimeKind.Utc);
        
        return await _projectRepository.UpdateAsync(project);
    }

    public async Task<IResult> DeleteAsync(Project project)
    {
        project.Manager = null;
        project.Team = null;
        
        await _projectRepository.DeleteAsync(project);

        return Results.Ok();
    }
}