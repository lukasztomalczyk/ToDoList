using FluentNHibernate.Mapping;
using NHibernate.Mapping;
using ToDoList.services.Models;

namespace ToDoList.services.Mappings
{
    /// <summary>
    ///  Here's the mapping class, mapping TaskToDoItem
    /// </summary>
    public class TaskToDoItemMap : ClassMap<TaskToDoItem>
    {
        public TaskToDoItemMap()
        {
//            Table("TaskToDoItem");
                
            Id(x => x.Id)
                .GeneratedBy
                .Increment();;
            Map(x => x.Name)
                .Not.Nullable();
            Map(x => x.Description)
                .Nullable();
            Map(x => x.CreationDate)
                .Not.Nullable();
            Map(x => x.DateOfCompletion)
                .Not.Nullable();
            Map(x => x.IsDone);   
        }
    }
}