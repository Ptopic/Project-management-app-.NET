using System.Collections;
using ProjectManagement.Entities;
using ProjectManagement.Entities.Enums;

namespace ProjectManagement.Repositories;

public interface IUserRepository
{
    IQueryable<User> GetAll();
    
    Task<User> GetByIdAsync(string id);
    
    Task<User> UpdateAsync(User user);
    
    Task<IEnumerable<User>> GetAllUsersWithoutTeam(Guid teamId);
}