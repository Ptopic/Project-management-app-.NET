using ProjectManagement.Entities;

namespace ProjectManagement.Repositories;

public interface ITeamRepository
{
    IQueryable<Team> GetAll();
}