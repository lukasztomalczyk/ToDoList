using System;
using NHibernate;
using ToDoList.services.Models;

namespace ToDoList.services.Services
{
    public class ToDoListServices
    {
        private readonly ISession _session;

        public ToDoListServices(ISession session)
        {
            _session = session;
        }

        public TaskToDoItem GetById(int id)
        {
            if (id!=0)
            {
                throw new NotImplementedException();
            }
            else
            {
                throw new NotImplementedException();
            }
        }
    }
}