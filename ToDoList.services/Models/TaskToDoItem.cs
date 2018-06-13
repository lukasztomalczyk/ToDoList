namespace ToDoList.services.Models
{
    /// <summary>
    /// My entity, a task to do
    /// </summary>
    public class TaskToDoItem
    {
        public virtual int ID { get; set; }
        public virtual string Name { get; set; }
        public virtual string Description { get; set; }
        public virtual bool IsDone { get; set; }
    }
}