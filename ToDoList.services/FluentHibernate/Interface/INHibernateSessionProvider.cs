using Microsoft.Extensions.Configuration;
using NHibernate;

namespace ToDoList.services.Interface
{
    public interface INHibernateSessionProvider
    {
        ISession OpenSession(IConfiguration configuration);
    }
}