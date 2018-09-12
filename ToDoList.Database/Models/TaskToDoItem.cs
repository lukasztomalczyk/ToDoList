using System;
using System.ComponentModel.DataAnnotations;

namespace ToDoList.Database.Models
{
    /// <summary>
    /// My entity, a task to do
    /// </summary>
    public class TaskToDoItem
    {
       // [Required(ErrorMessage = "When creating a new ID record is required")]
        public virtual int Id { get; set; }
        
       // [Required(ErrorMessage = "The name of the task is required")]
        public virtual string Name { get; set; }
        
        public virtual string Description { get; set; }
        
        public virtual DateTime CreationDate { get; set; }
        
      //  [Required(ErrorMessage = "You must specify when to do the task")]
        public virtual DateTime DateOfCompletion { get; set; }
        
        public virtual bool IsDone { get; set; }
    }
}