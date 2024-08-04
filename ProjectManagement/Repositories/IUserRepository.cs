using ProjectManagement.Entities;

namespace ProjectManagement.Repositories;

public interface IUserRepository
{
    IEnumerable<User> GetAll();
    
    Task<User> GetByIdAsync(string id);
    
    Task<User> UpdateAsync(User user);
}