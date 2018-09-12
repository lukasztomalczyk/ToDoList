﻿using System.Collections.Generic;
using System.Threading.Tasks;
using ToDoList.Database;
using ToDoList.Database.Models;
using ToDoList.Database.Repository;
using ToDoList.services.Services.Abstract;
using ToDoList.services.Validator;

namespace ToDoList.services.Services
{
    public class ToDoListServices : IToDoListServices
    {
        private readonly IRepository _repository;

        public ToDoListServices(IRepository repository)
        {
            _repository = repository;
        }
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
            var validator = new TaskToDoItemValidator();
            validator.Validate(item);
            _repository.Create(item);
            return true;
        }

        public void Delete(TaskToDoItem item)
        {
            throw new System.NotImplementedException();
        }
    }
}