using AutoMapper;
using ProjectManagement.Entities;
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
}