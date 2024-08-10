using AutoMapper;
using Microsoft.EntityFrameworkCore;
using ProjectManagement.Models.Views.Projects;
using ProjectManagement.Repositories;

namespace ProjectManagement.Services.Impl;

public class ProjectService(IMapper _mapper, IProjectRepository _projectRepository) : IProjectService
{
    public async Task<IEnumerable<ProjectView>> GetAll()
    {
        var projects = await _projectRepository.GetAll().ToListAsync();

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
}