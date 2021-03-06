﻿using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis;
using ToDoList.services.Models;
using ToDoList.services.Services.Abstract;

namespace ToDoList.api.Controllers
{
    [Route("api/[controller]")]
    public class ToDoListController : Controller
    {
        private readonly IToDoListServices _toDoListServices;

        public ToDoListController(IToDoListServices toDoListServices)
        {
            _toDoListServices = toDoListServices;
        }
        // ToDo Command–query separation


        [HttpGet("GetById/{id}")]
        public async Task<TaskToDoItem> GetById(int id)
        {
            return await _toDoListServices.GetById(id);
        }

        [HttpGet("GetAll")]
        public IEnumerable<TaskToDoItem> GetAll()
        {
            return _toDoListServices.GetAllTaskToDo();
        }

        [HttpPost]
        [ProducesResponseType(200, Type = typeof(TaskToDoItem))]
        [ProducesResponseType(400)]
        [ValidateAntiForgeryToken]
        public IActionResult Create([FromBody] TaskToDoItem taskToDoItem)
        {
            if (ModelState.IsValid)
            {
                _toDoListServices.CreateNewTaskToDo(taskToDoItem);
                return Ok(taskToDoItem);
            }
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
                _toDoListServices.DeleteTask(taskToDoItem);
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
                _toDoListServices.UpdateTask(taskToDoItem);
                return Ok(taskToDoItem);
            }
            else
            {
                return BadRequest(ModelState);
            }
        }
        
    }
}
