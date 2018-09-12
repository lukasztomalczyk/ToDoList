using System.Collections.Generic;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Driver;
using ToDoList.Database.Settings;

namespace ToDoList.Database.Repository
{
    public class Repository<T> : IRepository<T> where T : class 
    {
        private readonly IMongoCollection<T> _mongoCollection;
        private const string NameDb ="ToDoList";

        public Repository(IConnectMongoDb mongoClient)
        {
            var mongo = mongoClient.Connect();
            _mongoCollection = mongo.GetDatabase(NameDb).GetCollection<T>("TaskToDo");
        }
        
        public Task<List<T>> LoadAll()
        {
             return _mongoCollection.Find(new BsonDocument()).ToListAsync();
        }

        public async void Create(T item)
        {
            await _mongoCollection.InsertOneAsync(item);
        }
    }
}