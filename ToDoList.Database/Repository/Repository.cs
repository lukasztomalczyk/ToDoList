using System.Collections.Generic;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Driver;
using ToDoList.Database.Models;
using ToDoList.Database.Settings;

namespace ToDoList.Database.Repository
{
    public class Repository : IRepository
    {
        private readonly IMongoCollection<TaskToDoItem> _mongoCollection;
        private const string NameDb ="ToDoList";

        public Repository(IConnectMongoDb mongoClient)
        {
            var mongo = mongoClient.Connect();
            _mongoCollection = mongo.GetDatabase(NameDb).GetCollection<TaskToDoItem>("TaskToDo");
        }
        
        public Task<List<TaskToDoItem>> LoadAll()
        {
             return _mongoCollection.Find(new BsonDocument()).ToListAsync();
        }

        public async void Create(TaskToDoItem item)
        {
            await _mongoCollection.InsertOneAsync(item);
        }
    }
}