using System.Collections.Generic;
using ToDoList.services.Models;

namespace ToDoList.services.Services.Abstract
{
    public interface IToDoListServices
    {
        TaskToDoItem GetById(int id);
        IEnumerable<TaskToDoItem> GetAllTaskToDo();
        void UpdateTask(TaskToDoItem item);
        void CreateNewTaskToDo(TaskToDoItem item);
        void DeleteTask(TaskToDoItem item);
    }
}