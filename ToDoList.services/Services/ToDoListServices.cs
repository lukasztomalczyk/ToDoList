﻿using System.Collections.Generic;
using System.Threading.Tasks;
using ToDoList.Database.Models;
using ToDoList.services.Services.Abstract;

namespace ToDoList.services.Services
{
    public class ToDoListServices : IToDoListServices
    {
        public Task<TaskToDoItem> Get(int id)
        {
            throw new System.NotImplementedException();
        }

        public List<TaskToDoItem> GetAll()
        {
            throw new System.NotImplementedException();
        }

        public void Update(TaskToDoItem item)
        {
            throw new System.NotImplementedException();
        }

        public bool Create(TaskToDoItem item)
        {
            throw new System.NotImplementedException();
        }

        public void Delete(TaskToDoItem item)
        {
            throw new System.NotImplementedException();
        }
    }
}