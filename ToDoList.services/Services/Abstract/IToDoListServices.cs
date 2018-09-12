using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ToDoList.Database.Models;
using ToDoList.services.DTO;

namespace ToDoList.services.Services.Abstract
{
    public interface IToDoListServices
    {
        Task<TaskToDoItem> Get(int id);
        List<TaskToDoItem> GetAll();
        void Update(TaskToDoItem item);
        ResultObject Create(TaskToDoItem item);
        void Delete(TaskToDoItem item);
    }
}