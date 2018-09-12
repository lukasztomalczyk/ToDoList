using FluentValidation;
using ToDoList.Database.Models;

namespace ToDoList.services.Validator
{
    public class TaskToDoItemValidator : AbstractValidator<TaskToDoItem>
    {
        public TaskToDoItemValidator()
        {
            RuleFor(p => p.Id)
                .NotEmpty();

            RuleFor(p => p.Name)
                .NotEmpty();
        }
    }
}