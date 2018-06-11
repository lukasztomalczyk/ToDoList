namespace ToDoList.services.Models
{
    public class TaskToDoItem
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public bool IsDone { get; set; }
    }
}