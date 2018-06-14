using System.ComponentModel.DataAnnotations;
using System.ServiceModel.Channels;

namespace ToDoList.services.Models
{
    /// <summary>
    /// My entity, a task to do
    /// </summary>
    public class TaskToDoItem
    {
        [Required(ErrorMessage = "When creating a new ID record is required")]
        public virtual int ID { get; set; }
        [Required(ErrorMessage = "The name of the task is required")]
        public virtual string Name { get; set; }
        public virtual string Description { get; set; }
        public virtual bool IsDone { get; set; }
    }
}