using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using NHibernate;
using ToDoList.services.Models;
using ToDoList.services.Services;

namespace ToDoList.api.Controllers
{
    [Route("api/[controller]")]
    public class ToDoList : Controller
    {
        private readonly ToDoListServices _dataBase;

        public ToDoList(ToDoListServices dataBase)
        {
            _dataBase = dataBase;
        }
        // ToDo Command–query separation
//        [HttpGet("GetAll")]
//        public List<TaskToDoItem> GetAll()
//        {
//            return _dataBase.Query<TaskToDoItem>().ToList();
//        }

        [HttpGet("GetById/{id}")]
        public TaskToDoItem GetById(int id)
        {
            return _dataBase.GetById(id);
        }
    }
}
