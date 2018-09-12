using System;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using MongoDB.Driver;
using NHibernate.Event;
using ToDoList.Database;
using ToDoList.Database.Repository;
using ToDoList.Database.Settings;
using ToDoList.services.Services;
using ToDoList.services.Services.Abstract;

namespace ToDoList.services.DI
{
    public static class ServicesCollection
    {
        public static void AddCollection(this IServiceCollection services)
        {
            services.AddScoped<IMongoClient>(scop =>
            {
                var clientSettings = new MongoClientSettings();
                clientSettings.Server = new MongoServerAddress("localhost", 20217);
                return new MongoClient(clientSettings);
            });
            services.AddScoped<IRepository, Repository>();
            services.AddScoped<IToDoListServices, ToDoListServices>();
        }
    }
}