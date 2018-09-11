using MongoDB.Driver;

namespace ToDoList.Database
{
    public static class ConnectMongoDb
    {
        public static MongoClient Connect()
        {
            var settings = new MongoClientSettings();
            settings.Server = new MongoServerAddress("localhost", 20217);
            return new MongoClient(settings);      
        }
    }
}