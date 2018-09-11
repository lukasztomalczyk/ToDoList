using System;
using Microsoft.Extensions.DependencyInjection;
using MongoDB.Driver;
using NHibernate.Event;
using ToDoList.Database;

namespace ToDoList.services.DI
{
    public static class ServicesCollection
    {
        public static void AddCollection(this IServiceCollection services)
        {
            services.AddScoped<IMongoClient>(scop => new MongoClient("localhost"));
        }
    }
}