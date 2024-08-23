using AutoMapper;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using ProjectManagement.Entities;
using ProjectManagement.Entities.Enums;
using ProjectManagement.Models.Views.Users;
using ProjectManagement.Repositories;

namespace ProjectManagement.Services.Impl;

public class UserService : IUserService
{
    private readonly IUserRepository _userRepository;
    private readonly IMapper _mapper;
    private readonly UserManager<User> _userManager;
    
    public UserService(IUserRepository userRepository, IMapper mapper, UserManager<User> userManager)
    {
        _userRepository = userRepository;
        _mapper = mapper;
        _userManager = userManager;
    }
    
    public List<string> GetFieldNames()
    { 
        User Patient = new User();
        return Patient.GetType().GetProperties().Where(x => x.Name == "FirstName" || x.Name == "LastName" || x.Name == "Email" || x.Name == "Role").Select(x => x.Name).ToList();
    }
    
    public async Task<IEnumerable<UserView>> GetAllAsync()
    {
        var data = _userRepository.GetAll().ToList();
        var users = new List<UserView>();

        foreach (var user in data)
        {
            var userDto = _mapper.Map<UserView>(user);
            
            try
            {
                var role = _userManager.GetRolesAsync(user).Result.First();
                userDto.Role = (Roles)Enum.Parse(typeof(Roles), role);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            
            users.Add(userDto);
        }
        
        return users;
    }
    
    public async Task<User> GetByIdAsync(string id)
    {
        return await _userRepository.GetByIdAsync(id);
    }

    public IEnumerable<UserView> Search(IEnumerable<UserView> users, string searchString)
    {
        IEnumerable<UserView> searchedUsers = users;

        if (!string.IsNullOrEmpty(searchString))
        {
            var searchStringTrim = searchString.ToLower().Trim();
            searchedUsers = users.Where(u =>
                u.FirstName.ToLower().Contains(searchStringTrim) ||
                u.LastName.ToLower().Contains(searchStringTrim));
        }

        return searchedUsers;
    }

    public IEnumerable<UserView> Filter(IEnumerable<UserView> users, string currentFilter)
    {
        IEnumerable<UserView> filteredUsers = users;

        if (!string.IsNullOrEmpty(currentFilter))
        {
            var currentFilterTrim = currentFilter.Trim();
            filteredUsers = users.Where(v => v.Role.ToString() == currentFilterTrim);
        }

        return filteredUsers;
    }

    public async Task<IEnumerable<User>> GetUsersWithoutTeam(Guid teamId)
    {
        return await _userRepository.GetAllUsersWithoutTeam(teamId);
    }

    public IEnumerable<UserView> Sort(IEnumerable<UserView> users, string sortOrder)
    {
        switch (sortOrder)
        {
            case "FirstName":
                return users.OrderBy(s => s.FirstName);
            case "FirstNameDesc":
                return users.OrderByDescending(s => s.FirstName);
            case "LastName":
                return users.OrderBy(s => s.LastName);
            case "LastNameDesc":
                return users.OrderByDescending(s => s.LastName);
            case "Email":
                return users.OrderBy(s => s.Email);
            case "EmailDesc":
                return users.OrderByDescending(s => s.Email);
            case "Role":
                return users.OrderBy(s => s.Role);
            case "RoleDesc":
                return users.OrderByDescending(s => s.Role);
            default:
                return users.OrderBy(s => s.FirstName);
        }
    }
}