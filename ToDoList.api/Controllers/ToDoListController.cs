using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis;
using ToDoList.Database.Models;
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


        [HttpGet("{id:int}")]
        public string GetById(int id)
        {
            return id.ToString();
        }

        [HttpGet]
        public string GetAll()
        {
            return "get all";
        }

        [HttpPost]
        public IActionResult Create([FromBody] TaskToDoItem taskToDoItem)
        {
            if (ModelState.IsValid)
            {
                _toDoListServices.Create(taskToDoItem);
                return Ok(taskToDoItem);}
            else
            {
                return BadRequest(ModelState);
            }
        }

        [HttpDelete]
        [ProducesResponseType(200, Type = typeof(TaskToDoItem))]
        [ProducesResponseType(400)]
        public IActionResult Delete([FromBody] TaskToDoItem taskToDoItem)
        {
            if (ModelState.IsValid)
            {
                _toDoListServices.Delete(taskToDoItem);
                return Ok(taskToDoItem);
            }
            else
            {
                return BadRequest(ModelState);
            }
        }
        
        [HttpPut]
        [ProducesResponseType(200, Type = typeof(TaskToDoItem))]
        [ProducesResponseType(400)]
        public IActionResult Update([FromBody] TaskToDoItem taskToDoItem)
        {
            if (ModelState.IsValid)
            {
                _toDoListServices.Update(taskToDoItem);
                return Ok(taskToDoItem);
            }
            else
            {
                return BadRequest(ModelState);
            }
        }
        
    }
}
