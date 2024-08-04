using ProjectManagement.Entities;

namespace ProjectManagement.Repositories;

public interface ITeamRepository : IBaseRepository<Team>
{
    IQueryable<Team> GetAll();
}