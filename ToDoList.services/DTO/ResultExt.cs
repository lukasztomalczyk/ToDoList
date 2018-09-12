
using System.Linq;
using System.Threading.Tasks;
using FluentValidation.Results;
using MongoDB.Driver;
using ToDoList.Database.Repository;
using ToDoList.Database.Settings;
using ToDoList.services.Models;
using ToDoList.services.Validator;

namespace ToDoList.services.DTO
{
    public static class ResultExt
    {
        public static Result<TaskToDoItem> ToResult(this TaskToDoItem item)
        {
            return Result<TaskToDoItem>.Success(item);
        }
    }
}