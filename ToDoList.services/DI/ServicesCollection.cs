using System;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using MongoDB.Driver;
using NHibernate.Event;
using ToDoList.Database;
using ToDoList.Database.Repository;
using ToDoList.Database.Settings;
using ToDoList.services.Models;
using ToDoList.services.Services;
using ToDoList.services.Services.Abstract;

namespace ToDoList.services.DI
{
    public static class ServicesCollection
    {
        public static void AddCollection(this IServiceCollection services)
        {
            services.AddScoped<IConnectMongoDb, ConnectMongoDb>();
            services.AddScoped<IRepository<TaskToDoItem>, Repository<TaskToDoItem>>();
            services.AddScoped<IToDoListServices, ToDoListServices>();
        }
    }
}