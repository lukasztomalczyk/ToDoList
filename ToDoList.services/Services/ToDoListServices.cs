using System;
using System.Collections.Generic;
using System.Linq;
using NHibernate;
using ToDoList.services.Exceptions;
using ToDoList.services.Models;
using ToDoList.services.Services.Abstract;

namespace ToDoList.services.Services
{
    public class ToDoListServices : IToDoListServices
    {
        private readonly ISession _session;

        public ToDoListServices(ISession session)
        {
            _session = session;
        }

        public TaskToDoItem GetById(int id)
        {
            if (id!=0)
            {
                try
                {
                    return _session.Get<TaskToDoItem>(id);
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

        public IEnumerable<TaskToDoItem> GetAllTaskToDo()
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

        public void CreateNewTaskToDo(TaskToDoItem item)
        {
            if (item != null)
            {
                _session.BeginTransaction();
                _session.Save(item);
                _session.Transaction.Commit();
            }
            else
            {
                throw new CouldNotCreateNewTaskException();
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