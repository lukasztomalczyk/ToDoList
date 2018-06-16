using System;

namespace ToDoList.services.Exceptions
{
    public sealed class ThereIsNoSuchTaskException : Exception
    {
        private const string DomainMessage = "I could not find such a task in the database";

        public ThereIsNoSuchTaskException() : base(DomainMessage)
        {
        }
    }
}