using Microsoft.EntityFrameworkCore;
using ProjectManagement.Data;
using ProjectManagement.Entities;

namespace ProjectManagement.Repositories.Impl;

public class ProjectRepository : BaseRepository<Project>, IProjectRepository
{
    private readonly DbSet<Project> _dbSet;

    public ProjectRepository(AppDbContext context) : base(context)
    {
        _dbSet = context.Set<Project>();
    }
}