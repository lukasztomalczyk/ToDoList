using FluentValidation;
using ToDoList.services.Models;

namespace ToDoList.services.Validator
{
    public class TaskToDoItemValidator : AbstractValidator<TaskToDoItem>
    {
        public TaskToDoItemValidator()
        {
            RuleFor(p => p.Id)
                .NotEmpty()
                .WithMessage("Bad ID");

            RuleFor(p => p.Name)
                .NotEmpty()
                .WithMessage("You must provide a name");
            RuleFor(p => p.Description)
                .NotNull()
                .WithMessage("You must provide a description");
        }
    }
}