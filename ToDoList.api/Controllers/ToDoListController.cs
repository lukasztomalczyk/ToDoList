using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using NHibernate;
using ToDoList.services.Models;
using ToDoList.services.Services;
using ToDoList.services.Services.Abstract;

namespace ToDoList.api.Controllers
{
    [Route("api/[controller]")]
    public class ToDoList : Controller
    {
        private readonly IToDoListServices _toDoListServices;

        public ToDoList(IToDoListServices toDoListServices)
        {
            _toDoListServices = toDoListServices;
        }
        // ToDo Command–query separation


        [HttpGet("GetById/{id}")]
        public TaskToDoItem GetById(int id)
        {
            return _toDoListServices.GetById(id);
        }
        
        
    }
}
