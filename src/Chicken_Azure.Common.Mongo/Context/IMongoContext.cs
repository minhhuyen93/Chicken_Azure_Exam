using MongoDB.Driver;

namespace Chicken_Azure.Common.Mongo.Context
{
    public interface IMongoContext
    {
        IMongoCollection<T> GetMongoCollection<T>(string collectionName = null);
        IMongoDatabase GetDatabase();
    }
}
