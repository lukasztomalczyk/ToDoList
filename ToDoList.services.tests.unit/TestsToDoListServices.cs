using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Linq;
using FluentAssertions;
using Moq;
using NHibernate;
using NHibernate.Type;
using ToDoList.services.Models;
using NUnit;
using NUnit.Framework;
using NUnit.Framework.Internal;
using ToDoList.services.Services;
using ToDoList.services.Services.Abstract;

namespace ToDoList.services.tests.unit
{
    [TestFixture]
    public class TestsToDoListServices
    {
        private readonly List<TaskToDoItem> _fakeDataBase = new List<TaskToDoItem>()
            {
                new TaskToDoItem() { Id = 1, Name = "name_1", Description = "description_1", CreationDate = new DateTime(2018,01,10), DateOfCompletion = new DateTime(2018,02,10), IsDone = false },
                new TaskToDoItem() { Id = 2, Name = "name_2", Description = "description_2", CreationDate = new DateTime(2018,01,11), DateOfCompletion = new DateTime(2018,02,11), IsDone = false },
                new TaskToDoItem() { Id = 3, Name = "name_3", Description = "description_3", CreationDate = new DateTime(2018,01,12), DateOfCompletion = new DateTime(2018,03,12), IsDone = false },
            };
        

        [Test]
        public void GetAllTaskToDo_DownloadingTasks_SchouldReturnListOfAllTask()
        {
            // Arrange
            Mock<ISession> sessionMock = new Mock<ISession>();
            sessionMock.Setup(p => p.Query<TaskToDoItem>()).Returns(_fakeDataBase.AsQueryable);
            // Act
            var toDoService = new ToDoListServices(sessionMock.Object);
            var result = toDoService.GetAllTaskToDo();
            // Assert
            result.Should().Equal(_fakeDataBase);
        }

        [Test]
        public void GetById_RetrievesUserID_SchouldReturnTaskToDo()
        {
            // Arrange
            Mock<ISession> sessionMock = new Mock<ISession>();
            sessionMock.Setup(p => p.Get<TaskToDoItem>(1)).Returns(_fakeDataBase[1]);
            // Act
            var toDoService = new ToDoListServices(sessionMock.Object);
            var result = toDoService.GetById(1);
            // Assert
            result.Should().Be(_fakeDataBase[1]);
        }
     }
}