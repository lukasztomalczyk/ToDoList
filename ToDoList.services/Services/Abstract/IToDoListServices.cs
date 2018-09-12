using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ToDoList.services.DTO;
using ToDoList.services.Models;

namespace ToDoList.services.Services.Abstract
{
    public interface IToDoListServices
    {
        Result<TaskToDoItem> Validate(Result<TaskToDoItem> item);
        Result<TaskToDoItem> AddToDatabase(Result<TaskToDoItem> item);
    }
}