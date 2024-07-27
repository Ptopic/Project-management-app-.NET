using AutoMapper;
using ProjectManagement.Entities;
using ProjectManagement.Models.Views.Team;

namespace ProjectManagement.MappingProfiles;

public class TeamProfile: Profile
{
    public TeamProfile()
    {
        CreateMap<Team, TeamView>();
    }
}