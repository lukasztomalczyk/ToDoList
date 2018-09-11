using System.Collections.Generic;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Driver;
using ToDoList.Database.Models;

namespace ToDoList.Database
{
    public class Repository : IRepository
    {
        private readonly IMongoCollection<TaskToDoItem> _mongoCollection;
        private const string NameDb ="ToDoList";

        public Repository(IMongoClient mongoClient)
        {
            var mongo = mongoClient.GetDatabase(NameDb);
            _mongoCollection = mongo.GetCollection<TaskToDoItem>(NameDb);
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