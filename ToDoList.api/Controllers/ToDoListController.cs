using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis;
using ToDoList.services.DTO;
using ToDoList.services.Models;
using ToDoList.services.Services.Abstract;

namespace ToDoList.api.Controllers
{
    [Route("api/[controller]/[action]")]
    public class ToDoListController : Controller
    {
        private readonly IToDoListServices _toDoListServices;

        public ToDoListController(IToDoListServices toDoListServices)
        {
            _toDoListServices = toDoListServices;
        }

        [HttpPost]
        public ActionResult<Result<TaskToDoItem>> Create([FromBody] TaskToDoItem taskToDoItem)
        {
            if (ModelState.IsValid)
            {
                var validate = _toDoListServices.Validate(taskToDoItem.ToResult());
                var result = _toDoListServices.AddToDatabase(validate);
                
                return StatusCode((result.IsSuccess) ? 200 : 400, result);
            }
                return BadRequest(ModelState);
        }
        
    }
}
