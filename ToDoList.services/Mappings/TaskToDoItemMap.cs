﻿using FluentNHibernate.Mapping;
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
                
            Id(x => x.ID)
                .GeneratedBy
                .Increment();;
            Map(x => x.Name)
                .Not.Nullable();
            Map(x => x.Description)
                .Nullable();
            Map(x => x.IsDone);   
        }
    }
}