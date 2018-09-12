using System.Collections.Generic;
using System.Threading.Tasks;
using ToDoList.Database.Models;

namespace ToDoList.Database.Repository
{
    public interface IRepository
    {
        Task<List<TaskToDoItem>> LoadAll();
        void Create(TaskToDoItem item);
    }
}