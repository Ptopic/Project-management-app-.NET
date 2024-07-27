using AutoMapper;
using ProjectManagement.Entities;
using ProjectManagement.Models.Views.Users;

namespace ProjectManagement.MappingProfiles;

public class UserProfile : Profile
{
    public UserProfile()
    {
        CreateMap<User, UserView>();
    }
}