using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using Microsoft.Extensions.Configuration;
using NHibernate;
using NHibernate.Tool.hbm2ddl;
using ToDoList.services.Models;

namespace ToDoList.services.FluentHibernate
{
    public static class NHibernateSessionProvider
    {
        public static ISessionFactory NHibernateSessionFactory(IConfiguration configuration)
        {          
            return Fluently.Configure()
                .Database(MsSqlConfiguration.MsSql2012
                    .ConnectionString(configuration.GetConnectionString("connectionString"))
                    .ShowSql())


                // Mapping our entity
                .Mappings(m => m.FluentMappings
                    .AddFromAssemblyOf<TaskToDoItem>())
                
                // Create your schema at runtime.
                .ExposeConfiguration(cfg => new SchemaExport(cfg)
                    .Create(true, true))
                .BuildConfiguration()
                .BuildSessionFactory();
        }
    }
}