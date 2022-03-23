
using AspnetCoreSqliteApi.Models;
using AspnetCoreSqliteApi.Services;
using Microsoft.AspNetCore.Mvc;

namespace AspnetCoreSqliteApi.Controllers;

[ApiController]
[Route("api/[controller]/[action]/{id?}")]
public class TaskController : ControllerBase
{
    ITaskService _taskService;

    public TaskController(ITaskService taskService)
    {
        _taskService = taskService;
    }

    [HttpGet(Name = "GetTasks")]
    public ServiceResponse<IEnumerable<TaskModel>> GetTasks() {
        return _taskService.GetTasks();
    }

    [HttpGet(Name = "GetTask")]
    public ServiceResponse<TaskModel> GetTask(int id) {
        return _taskService.GetTask(id);
    }

    [HttpPost(Name = "AddTask")]
    public ServiceResponse<int> AddTask(TaskModel task) {
        return  _taskService.AddTask(task);
    }

    [HttpPost(Name = "UpdateTask")]
    public ServiceResponse<int> UpdateTask(TaskModel task) {
        return _taskService.UpdateTask(task);
    }

    [HttpPost(Name = "DeleteTask")]
    public ServiceResponse<int> DeleteTask(TaskModel task) {
        return _taskService.DeleteTask(task);
    }
}