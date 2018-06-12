using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using NHibernate;
using NHibernate.Tool.hbm2ddl;
using ToDoList.services.Models;

namespace ToDoList.services
{
    public static class NHibernateSessionProvider
    {
        public static ISession OpenSessionNHibernate()
        {
            ISessionFactory sessionFactory = Fluently.Configure()
                .Database(MsSqlConfiguration.MsSql2012
                    .ConnectionString("")
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