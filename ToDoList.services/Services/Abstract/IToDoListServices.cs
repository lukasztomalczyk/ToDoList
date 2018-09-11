using System.Collections.Generic;
using System.Threading.Tasks;
using ToDoList.Database.Models;

namespace ToDoList.services.Services.Abstract
{
    public interface IToDoListServices
    {
        Task<TaskToDoItem> Get(int id);
        List<TaskToDoItem> GetAll();
        void Update(TaskToDoItem item);
        bool Create(TaskToDoItem item);
        void Delete(TaskToDoItem item);
    }
}