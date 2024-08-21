using AutoMapper;
using ProjectManagement.Entities;
using ProjectManagement.Models.Requests.Task;
using ProjectManagement.Models.Views.Tasks;

namespace ProjectManagement.MappingProfiles;

public class TaskProfile : Profile
{
    public TaskProfile()
    {
        CreateMap<TaskDefinition, TaskView>();
        CreateMap<TaskView, TaskDefinition>();
        CreateMap<CreateTaskRequest, TaskDefinition>();
    }
}