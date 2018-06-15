using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data;
using NHibernate.Type;
using ToDoList.services.Models;
using NUnit;
using NUnit.Framework;

namespace ToDoList.services.tests.unit
{
    [TestFixture]
    public class TestsToDoListServices
    {
        private readonly IEnumerable<TaskToDoItem> _fakeDataBase = new List<TaskToDoItem>()
            {
                new TaskToDoItem() { Id = 1, Name = "name_1", Description = "description_1", CreationDate = new DateTime(2018,01,10), DateOfCompletion = new DateTime(2018,02,10), IsDone = false },
                new TaskToDoItem() { Id = 2, Name = "name_2", Description = "description_2", CreationDate = new DateTime(2018,01,11), DateOfCompletion = new DateTime(2018,02,11), IsDone = false },
            };
        

        [Test]
        public void GetById_RetrievesUserID_SchouldReturnInt()
        {
            // Arrange
            
            // Act
            
            // Assert
        }
    }
}