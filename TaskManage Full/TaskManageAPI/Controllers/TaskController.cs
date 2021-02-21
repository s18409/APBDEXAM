using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TaskManageAPI.DTOs;
using TaskManageAPI.Services;

namespace TaskManageAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TaskController : ControllerBase
    {
        private readonly ITaskService _taskService;

        public TaskController(ITaskService taskService)
        {
            _taskService = taskService;
        }
        [HttpGet]
        public IActionResult GetTasks(int? Id)
        {
            var data = _taskService.GetTasks(Id);
            return Ok(data);
        }
        [HttpPost("AddNewTask")]
        public IActionResult AddNewTask(AddTaskDTO model)
        {
            if (ModelState.IsValid)
            {
                var data = _taskService.AddTask(model);
                return Ok("New Task Created Successfuly with Id = " + data);
            }
            return BadRequest(ModelState);
            
        }
    }
}
