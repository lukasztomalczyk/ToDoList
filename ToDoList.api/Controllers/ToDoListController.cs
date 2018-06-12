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
        public ToDoList(INHibernateSessionProvider nHibernateSessionProvider, IConfiguration configuration)
        {
            nHibernateSessionProvider.OpenSession(configuration);
        }
    }
}
