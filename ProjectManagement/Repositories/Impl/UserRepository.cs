using System.Collections;
using Microsoft.EntityFrameworkCore;
using ProjectManagement.Data;
using ProjectManagement.Entities;

namespace ProjectManagement.Repositories.Impl;

public class UserRepository(AppDbContext context) : IUserRepository
{
    private readonly DbSet<User> _dbSet = context.Set<User>();
    
    public IQueryable<User> GetAll()
    {
        return _dbSet.AsQueryable();
    }

    IQueryable<User> IUserRepository.GetAll()
    {
        return GetAll();
    }

    public async Task<User> GetByIdAsync(string id)
    {
        return await _dbSet
            .Include(x => x.Teams)
            .FirstOrDefaultAsync(x => x.Id == id);
    }

    public async Task<User> UpdateAsync(User user)
    {
        var removedEntity = _dbSet.Remove(user).Entity;
        await context.SaveChangesAsync();

        return removedEntity;
    }

    public async Task<IEnumerable<User>> GetAllUsersWithoutTeam(Guid teamId)
    {
        return await _dbSet
            .Where(x => x.Teams.All(t => t.Id != teamId))
            .ToListAsync();
    }
}