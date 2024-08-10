using AutoMapper;
using ProjectManagement.Entities;
using ProjectManagement.Models.Views.Projects;

namespace ProjectManagement.MappingProfiles;

public class ProjectProfile: Profile
{
    public ProjectProfile()
    {
        CreateMap<Project, ProjectView>();
    }
}