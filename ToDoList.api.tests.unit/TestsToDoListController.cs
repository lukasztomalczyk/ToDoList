using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using FluentAssertions;
using FluentAssertions.Common;
using Moq;
using NHibernate.Criterion;
using NUnit.Framework;
using ToDoList.services.Services.Abstract;
using ToDoList.api.Controllers;
using ToDoList.Database.Models;
using ToDoList.services.Exceptions;

namespace ToDoList.api.tests.unit
{
    [TestFixture]
    public class TestsToDoListController
    {
//        private List<TaskToDoItem> GetTestDataBase()
//        {
//            var sessions = new List<TaskToDoItem>()
//            {
//                new TaskToDoItem() { Id = 1, Name = "name_1", Description = "description_1", CreationDate = new DateTime(2018,01,10), DateOfCompletion = new DateTime(2018,02,10), IsDone = false },
//                new TaskToDoItem() { Id = 2, Name = "name_2", Description = "description_2", CreationDate = new DateTime(2018,01,11), DateOfCompletion = new DateTime(2018,02,11), IsDone = false },
//                new TaskToDoItem() { Id = 3, Name = "name_3", Description = "description_3", CreationDate = new DateTime(2018,01,12), DateOfCompletion = new DateTime(2018,03,12), IsDone = false },
//
//            };
//
//            return sessions;
//        }
        
        private readonly List<TaskToDoItem> _fakeDataBase = new List<TaskToDoItem>()
        {
            new TaskToDoItem() { Id = 1, Name = "name_1", Description = "description_1", CreationDate = new DateTime(2018,01,10), DateOfCompletion = new DateTime(2018,02,10), IsDone = false },
            new TaskToDoItem() { Id = 2, Name = "name_2", Description = "description_2", CreationDate = new DateTime(2018,01,11), DateOfCompletion = new DateTime(2018,02,11), IsDone = false },
            new TaskToDoItem() { Id = 3, Name = "name_3", Description = "description_3", CreationDate = new DateTime(2018,01,12), DateOfCompletion = new DateTime(2018,03,12), IsDone = false },
        };

/*        [Test]
        public async Task GetById_RequestTaskToDoById_ShouldReturnTaskToDoItem()
        {
            Mock<IToDoListServices> toDoServices = new Mock<IToDoListServices>();
            toDoServices.Setup(p => p.Get(1)).Returns(Task.FromResult(_fakeDataBase[1]));
            var controller = new ToDoListController(toDoServices.Object);

            var result = await controller.GetById(1);
            result.Should().BeOfType(typeof(TaskToDoItem));
            result.Should().BeSameAs(_fakeDataBase[1]);
        }*/
    }
}