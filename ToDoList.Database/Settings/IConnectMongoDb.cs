using MongoDB.Driver;

namespace ToDoList.Database.Settings
{
    public interface IConnectMongoDb
    {
        MongoClient Connect();
    }
}