using System.Collections.Generic;
using System.Threading.Tasks;
using ToDoList.services.Models;

namespace ToDoList.services.Services.Abstract
{
    public interface IToDoListServices
    {
        Task<TaskToDoItem> GetById(int id);
        List<TaskToDoItem> GetAllTaskToDo();
        void UpdateTask(TaskToDoItem item);
        bool CreateNewTaskToDo(TaskToDoItem item);
        void DeleteTask(TaskToDoItem item);
    }
}