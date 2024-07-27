using Microsoft.EntityFrameworkCore;
using ProjectManagement.Data;
using ProjectManagement.Entities;

namespace ProjectManagement.Repositories.Impl;

public class TeamRepository(AppDbContext context) : ITeamRepository
{
    private readonly DbSet<Team> _dbSet = context.Set<Team>();
    
    public IQueryable<Team> GetAll()
    {
        return _dbSet.AsQueryable();
    }
}