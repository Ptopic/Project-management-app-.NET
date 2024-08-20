using Microsoft.EntityFrameworkCore;
using ProjectManagement.Data;
using ProjectManagement.Entities;

namespace ProjectManagement.Repositories.Impl;

public class TeamRepository : BaseRepository<Team>, ITeamRepository
{
    private readonly DbSet<Team> _dbSet;

    public TeamRepository(AppDbContext context) : base(context)
    {
        _dbSet = context.Set<Team>();
    }
    
    public IQueryable<Team> GetAll()
    {
        return _dbSet.AsQueryable();
    }

    public async Task<Team> GetByIdAsync(Guid id)
    {
        return await _dbSet
            .FirstOrDefaultAsync(x => x.Id == id);
    }
}