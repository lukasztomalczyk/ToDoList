using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FluentNHibernate.Conventions;
using NHibernate;
using ToDoList.services.Exceptions;
using ToDoList.services.Models;
using ToDoList.services.Services.Abstract;

namespace ToDoList.services.Services
{
    public class ToDoListServices : IToDoListServices
    {
        private readonly ISession _session;
        private ITransaction _transaction; 

        public ToDoListServices(ISession session)
        {
            _session = session;
        }

        public async Task<TaskToDoItem> GetById(int id)
        {
            if (id != 0)
            {
                try
                {
                    return await _session.GetAsync<TaskToDoItem>(id);
                }
                catch (Exception)
                {
                    throw new CouldNotGetTheTaskException();
                }
            }
            else
            {
                throw new BadIdTaskToDoException();
            }
        }

        public List<TaskToDoItem> GetAllTaskToDo()
        {
            return _session.Query<TaskToDoItem>().ToList();
        }

        public void UpdateTask(TaskToDoItem item)
        {
            if (item != null)
            {
                _session.BeginTransaction();
                _session.Update(item);
                _session.Transaction.Commit();
            }
            else
            {
                throw new BadItemToUpdateException();
            }
        }

        public bool CreateNewTaskToDo(TaskToDoItem item)
        {
            if (item != null)
            {
                try
                {
                    _transaction = _session.BeginTransaction();
                    _session.Save(item);
                    _transaction.Commit();
                    return true;
                }
                catch
                {
                    _transaction?.Rollback();
                    throw new CouldNotCreateNewTaskException();
                }
            }
            else
            {
                return false;
            }
        }

        public void DeleteTask(TaskToDoItem item)
        {
            if (item != null)
            {
                _session.BeginTransaction();
                _session.Delete(item);
                _session.Transaction.Commit();
            }
            else
            {
                throw new CouldNotDeleteTaskException();
            }
        }

        // ToDo co zwraca ta metoda
        public IEnumerable<TaskToDoItem> Find(int id)
        {
            return _session.Query<TaskToDoItem>().Where(x => x.Id == id);
        }
        
    }
}