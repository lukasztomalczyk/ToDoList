using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using NHibernate;
using ToDoList.services.Models;

namespace ToDoList.api.Controllers
{
    [Route("api/[controller]")]
    public class ToDoList : Controller
    {
        private readonly ISession _dataBase;

        public ToDoList(NHibernate.ISession dataBase)
        {
            _dataBase = dataBase;
        }
        // ToDo Command–query separation
        [HttpGet]
        public List<TaskToDoItem> Get()
        {
            return _dataBase.Query<TaskToDoItem>().ToList();
        }
    }
}
