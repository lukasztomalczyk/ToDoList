using System;

namespace ToDoList.services.Exceptions
{
    public sealed class CouldNotDeleteTaskException : Exception
    {
        private const string DomainMessage = "An error occurred while trying to delete the task";

        public CouldNotDeleteTaskException() : base(DomainMessage)
        {
        }
    }
}