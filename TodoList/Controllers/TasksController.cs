using Microsoft.AspNetCore.Mvc;
using TodoList.Contracts.TodoList;

namespace TodoList.Controllers;

[ApiController]
[Route("[controller]")]
public class TasksController : ControllerBase
{
    [HttpPost]
    public IActionResult CreateTask(CreateTaskRequest request)
    {
        return Ok();
    }
    
    [HttpGet("{id:guid}")]
    public IActionResult GetTask(Guid id)
    {
        return Ok();
    }
    
    [HttpPut("{id:guid}")]
    public IActionResult PutTask(Guid id, UpsertTaskRequest request)
    {
        return Ok();
    }
    
    [HttpDelete("{id:guid}")]
    public IActionResult DeleteTask(Guid id)
    {
        return Ok();
    }
}