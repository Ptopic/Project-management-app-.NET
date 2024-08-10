using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;
using ProjectManagement.Data;
using ProjectManagement.Entities;

namespace ProjectManagement.Repositories.Impl;

public class TaskRepository : BaseRepository<TaskDefinition>, ITaskRepository
{
    private readonly DbSet<TaskDefinition> _dbSet;

    public TaskRepository(AppDbContext context) : base(context)
    {
        _dbSet = context.Set<TaskDefinition>();
    }
}