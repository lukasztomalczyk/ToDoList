using System.Configuration.Internal;
using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using Microsoft.Extensions.Configuration;
using NHibernate;
using NHibernate.Tool.hbm2ddl;
using ToDoList.services.Models;

namespace ToDoList.services
{
    public static class NHibernateSessionProvider
    {
        public static ISession OpenSessionNHibernate(IConfiguration configuration)
        {
            var connectionString = "172.17.0.2;Database=ToDoList;Trusted_Connection=True;";
            ISessionFactory sessionFactory = Fluently.Configure()
                .Database(MsSqlConfiguration.MsSql2012
                    .ConnectionString(c=>c.Server("172.17.0.2")
                        .Database("ToDoList")
                        .Username("SA")
                        .Password("Kleopatra2017@@"))
                    .ShowSql())

                // Mapping our entity
                .Mappings(m => m.FluentMappings
                    .AddFromAssemblyOf<TaskToDoItem>())
                
                // Create your schema at runtime.
                .ExposeConfiguration(cfg => new SchemaExport(cfg)
                    .Create(false, false))
                .BuildSessionFactory();

            return sessionFactory.OpenSession();

        }
    }
}