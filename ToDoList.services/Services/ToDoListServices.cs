using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FluentValidation.Results;
using ToDoList.Database;
using ToDoList.Database.Repository;
using ToDoList.services.DTO;
using ToDoList.services.Models;
using ToDoList.services.Services.Abstract;
using ToDoList.services.Validator;

namespace ToDoList.services.Services
{
    public class ToDoListServices : IToDoListServices
    {
        private readonly IRepository<TaskToDoItem> _repository;

        public ToDoListServices(IRepository<TaskToDoItem> repository)
        {
            _repository = repository;
        }


        public Result<TaskToDoItem> Validate(Result<TaskToDoItem> item)
        {
            var validator = new TaskToDoItemValidator();
            ValidationResult result = validator.Validate(item.Value);


            if (result.IsValid)
            {
                return Result<TaskToDoItem>.Success(item.Value);
            }
                return Result<TaskToDoItem>.Fail(result.Errors.ToArray());
 
        }

        public Result<TaskToDoItem> AddToDatabase(Result<TaskToDoItem> item)
        {
            if (item.IsSuccess)
            {
                _repository.Create(item.Value);
                return Result<TaskToDoItem>.Success(item.Value);
            }
                return Result<TaskToDoItem>.Fail(item.Errors);
        }
    }
}