using System;

namespace ToDoList.services.Exceptions
{
    public sealed class BadItemToUpdateException : Exception
    {
        private const string DomainMessage = "I could not update the task";

        public BadItemToUpdateException() : base(DomainMessage)
        {
        }
    }
}