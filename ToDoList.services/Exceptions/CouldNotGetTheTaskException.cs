using System;

namespace ToDoList.services.Exceptions
{
    public sealed class CouldNotGetTheTaskException : Exception
    {
        private const string DomainMessage = "I could not get the task";
        
        public CouldNotGetTheTaskException() : base(DomainMessage)
        {
        }
    }
}