using ProjectManagement.Entities;
using ProjectManagement.Entities.Enums;
using ProjectManagement.Models.Views.Users;

namespace ProjectManagement.Services;

public interface IUserService
{
    Task<IEnumerable<UserView>> GetAllAsync();
    
    Task<User> GetByIdAsync(string id);
    
    IEnumerable<UserView> Search(IEnumerable<UserView> users, string searchString);

    IEnumerable<UserView> Filter(IEnumerable<UserView> users, string currentFilter);
    
    Task<IList<User>> GetUsersWithoutTeam(Guid teamId);
}