using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using Microsoft.Extensions.Configuration;
using NHibernate;
using NHibernate.Tool.hbm2ddl;
using ToDoList.services.Interface;
using ToDoList.services.Models;

namespace ToDoList.services.FluentHibernate
{
    public class NHibernateSessionProvider : INHibernateSessionProvider
    {
        public NHibernateSessionProvider()
        {
            
        }
        public ISession OpenSession(IConfiguration configuration)
        {          
            ISessionFactory sessionFactory = Fluently.Configure()
                .Database(MsSqlConfiguration.MsSql2012
                    .ConnectionString(configuration.GetConnectionString("connectionString"))
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