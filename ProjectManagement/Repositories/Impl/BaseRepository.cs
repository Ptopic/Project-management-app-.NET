using System.Linq.Expressions;
using DSMS.Application.Exceptions;
using Microsoft.EntityFrameworkCore;
using ProjectManagement.Data;
using ProjectManagement.Entities;

namespace ProjectManagement.Repositories.Impl;

public class BaseRepository<TEntity> : IBaseRepository<TEntity> where TEntity : BaseEntity
{
    protected readonly AppDbContext Context;
    protected readonly DbSet<TEntity> DbSet;

    protected BaseRepository(AppDbContext context)
    {
        Context = context;
        DbSet = context.Set<TEntity>();
    }
    
    public async Task<TEntity> AddAsync(TEntity entity)
    {
        var addedEntity = (await DbSet.AddAsync(entity)).Entity;
        await Context.SaveChangesAsync();

        return addedEntity;
    }

    public async Task<TEntity> DeleteAsync(TEntity entity)
    {
        var removedEntity = DbSet.Remove(entity).Entity;
        await Context.SaveChangesAsync();

        return removedEntity;
    }

    public async Task<List<TEntity>> GetAllAsync(Expression<Func<TEntity, bool>> predicate)
    {
        return await DbSet.Where(predicate).ToListAsync();
    }

    public async Task<TEntity> GetFirstAsync(Expression<Func<TEntity, bool>> predicate)
    {
        var entity = await DbSet.Where(predicate).FirstOrDefaultAsync();

        if (entity == null) throw new NotFoundException("Not found");

        return await DbSet.Where(predicate).FirstOrDefaultAsync();
    }

    public async Task<TEntity> UpdateAsync(TEntity entity)
    {
        DbSet.Update(entity);
        await Context.SaveChangesAsync();

        return entity;
    }
}