using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using NHibernate;

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
        public ToDoList Get()
        {
            return _dataBase.Get<ToDoList>(1);
        }
    }
}
