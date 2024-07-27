using ProjectManagement.Entities;

namespace ProjectManagement.Repositories;

public interface IUserRepository
{
    IQueryable<User> GetAll();
    
    Task<User> GetByIdAsync(string id);
}