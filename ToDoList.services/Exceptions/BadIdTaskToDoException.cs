using System;

namespace ToDoList.services.Exceptions
{
    public sealed class BadIdTaskToDoException : Exception
    {
        private const string DomainMessage = "You have entered the wrong ID number";

        public BadIdTaskToDoException() : base (DomainMessage)
        {
        }
    }
}