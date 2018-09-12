using MongoDB.Driver;
using Microsoft.Extensions.Options;

namespace ToDoList.Database.Settings
{
    public class ConnectMongoDb : IConnectMongoDb
    {
        private readonly MongoSettings _settings;

        public ConnectMongoDb(IOptions<MongoSettings> settings)
        {
            _settings = settings.Value;
        }
        public MongoClient Connect()
        {
            var clientSettings = new MongoClientSettings();
            clientSettings.Server = new MongoServerAddress(_settings.ConnectionString, _settings.Port);
           return new MongoClient(clientSettings);
        }
    }
}