using Microsoft.EntityFrameworkCore;
using ProjectManagement.Data;
using ProjectManagement.Entities;

namespace ProjectManagement.Repositories.Impl;

public class UserRepository : IUserRepository
{
    private readonly AppDbContext _context;
    private readonly DbSet<User> _DbSet;
    
    public UserRepository(AppDbContext context)
    {
        _context = context ?? throw new ArgumentNullException(nameof(context));
        _DbSet = context.Set<User>();
    }
    
    public IQueryable<User> GetAll()
    {
        return _DbSet.AsQueryable();
    }

    public async Task<User> GetByIdAsync(string id)
    {
        return await _DbSet
            .Include(x => x.Team)
            .FirstOrDefaultAsync(x => x.Id == id);
    }
}