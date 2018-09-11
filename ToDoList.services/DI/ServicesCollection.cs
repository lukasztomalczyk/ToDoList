using Microsoft.Extensions.DependencyInjection;
using ToDoList.services.FluentHibernate;

namespace ToDoList.services.DI
{
    public static class ServicesCollection
    {
        public static void AddCollection(this IServiceCollection services)
        {
/*
            var builder = new ContainerBuilder();
            builder.RegisterType<NHibernateSessionProvider>();
            var container = builder.Build();

            var scope = container.BeginLifetimeScope();
            scope.Resolve<NHibernateSessionProvider>();
            */

        }
    }
}