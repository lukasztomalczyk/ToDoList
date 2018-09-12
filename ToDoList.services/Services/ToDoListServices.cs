using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FluentValidation.Results;
using ToDoList.Database;
using ToDoList.Database.Models;
using ToDoList.Database.Repository;
using ToDoList.services.DTO;
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

        public ResultObject Create(TaskToDoItem item)
        {
            var validator = new TaskToDoItemValidator();
            ValidationResult result = validator.Validate(item);

            if (!result.IsValid)
            {
                var resultObject = new ResultObject();
                var error = result.Errors.First();
                resultObject.Errors = new [] 
                   { 
                       error.PropertyName, 
                       error.ErrorMessage, 
                   };
                resultObject.Item = item;
                resultObject.StatusCode = 201;

                return resultObject;
            }
            else
            {
                var resultObject = new ResultObject();
                
                resultObject.Item = item;
                resultObject.StatusCode = 200;

                return resultObject;
            }
          
        }

        public void Delete(TaskToDoItem item)
        {
            throw new System.NotImplementedException();
        }
    }
}