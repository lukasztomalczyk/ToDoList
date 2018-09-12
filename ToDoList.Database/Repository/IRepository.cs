using System.Collections.Generic;
using System.Threading.Tasks;

namespace ToDoList.Database.Repository
{
    public interface IRepository<T> where T : class
    {
        Task<List<T>> LoadAll();
        void Create(T item);
    }
}