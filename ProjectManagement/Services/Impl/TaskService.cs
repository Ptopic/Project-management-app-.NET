using AutoMapper;
using DSMS.Application.Exceptions;
using Microsoft.EntityFrameworkCore;
using ProjectManagement.Entities;
using ProjectManagement.Models.Views.Tasks;
using ProjectManagement.Repositories;

namespace ProjectManagement.Services.Impl;

public class TaskService : ITaskService
{
    private readonly IMapper _mapper;
    private readonly ITaskRepository _taskRepository;
    
    public TaskService(IMapper mapper, ITaskRepository taskRepository)
    {
        _mapper = mapper;
        _taskRepository = taskRepository;
    }

    public async Task<TaskDefinition> CreateAsync(TaskDefinition task)
    {
        return await _taskRepository.AddAsync(task);
    }

    public async Task<TaskDefinition> UpdateAsync(TaskDefinition team)
    {
        return await _taskRepository.UpdateAsync(team);
    }

    public async Task<TaskDefinition> GetByIdAsync(string id)
    {
        var task = await _taskRepository.GetAll().Include(x => x.Assignee).Where(x => x.Id.ToString() == id).FirstOrDefaultAsync();
        
        return task;
    }

    public async Task<IEnumerable<TaskView>> GetByProjectIdAsync(string projectId)
    {
        var tasks = await _taskRepository.GetAll()
            .Include(x => x.Assignee)
            .Where(x => x.Project.Id.ToString() == projectId)
            .OrderBy(x => x.CreatedDate)
            .ToListAsync();

        return _mapper.Map<IEnumerable<TaskView>>(tasks);
    }

    public async Task<TaskView> GetLatestTaskByProjectIdAsync(string projectId)
    {
        var task = await _taskRepository.GetAll()
            .Include(x => x.Assignee)
            .Where(x => x.Project.Id.ToString() == projectId)
            .OrderByDescending(x => x.CreatedDate)
            .FirstOrDefaultAsync();

        Console.WriteLine(task);
        return _mapper.Map<TaskView>(task);
    }

    public IEnumerable<TaskView> Search(IEnumerable<TaskView> tasks, string searchString)
    {
        IEnumerable<TaskView> searchedTasks = tasks;
        
        if (!string.IsNullOrEmpty(searchString))
        {
            var searchStringTrim = searchString.ToLower().Trim();
            searchedTasks = searchedTasks.Where(t => t.Name.ToLower().Contains(searchStringTrim));
        }

        return searchedTasks;
    }

    public IEnumerable<TaskView> Filter(IEnumerable<TaskView> tasks, string currentFilter)
    {
        IEnumerable<TaskView> filteredTasks = tasks;
        
        if (!string.IsNullOrEmpty(currentFilter))
        {
            var currentFilterTrim = currentFilter.Trim();
            
            if (currentFilter == "unassigned")
            {
                filteredTasks = tasks.Where(t => t.Assignee == null);
            }
            else
            {
                filteredTasks = tasks.Where(t => t.Assignee != null && t.Assignee.Id.ToString() == currentFilterTrim);
            }
        }

        return filteredTasks;
    }

    public async Task<IResult> DeleteAsync(TaskDefinition task)
    {
        task.Assignee = null;
        
        await _taskRepository.DeleteAsync(task);

        return Results.Ok();
    }

    public async Task<IEnumerable<TaskDefinition>> GetTasksByAssigneeIdAsync(string userId)
    {
        var tasks = await _taskRepository.GetAll()
            .Include(x => x.Assignee)
            .Where(x => x.Assignee.Id == userId)
            .ToListAsync();

        return tasks;
    }
}