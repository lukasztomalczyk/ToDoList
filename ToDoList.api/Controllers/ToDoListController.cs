using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using ToDoList.services.Interface;

namespace ToDoList.api.Controllers
{
    [Route("api/[controller]")]
    public class ToDoList : Controller
    {
        private readonly INHibernateSessionProvider _sessionProvider;

        public ToDoList(INHibernateSessionProvider sessionProvider, IConfiguration configuration)
        {
            _sessionProvider = sessionProvider;
            _sessionProvider.OpenSession(configuration);
        }

/*        public string GetAll()
        {
            _sessionProvider.Get
        }*/
    }
}
