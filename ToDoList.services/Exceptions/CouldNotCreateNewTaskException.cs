using System;

namespace ToDoList.services.Exceptions
{
    public sealed class CouldNotCreateNewTaskException : Exception
    {
        private const string DomainMessage = "An error occurred when trying to create a new task";

        public CouldNotCreateNewTaskException() : base(DomainMessage)
        {
        }
    }
}