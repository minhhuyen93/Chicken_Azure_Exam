namespace Chicken_Azure.Common.Mongo.Context
{
    using Chicken_Azure.Common.Mongo.Configurations;
    using Chicken_Azure.Common.Mongo.Factory;
    using Microsoft.Extensions.Options;
    using MongoDB.Driver;

    public class MongoContext : IMongoContext
    {
        private IMongoDatabase _database;
        private IMongoClient _client;
        private readonly IMongoFactory _mongoFactory;
        private MongoConfigurationOptions _options;

        public MongoContext(IMongoFactory mongoFactory,
            IOptions<MongoConfigurationOptions> options)
        {
            _mongoFactory = mongoFactory;
            _options = options.Value;
        }

        public IMongoClient GetClient()
        {
            if (_client != null) { return _client; }

            _client = _mongoFactory.CreateClient(_options);
            return _client;
        }

        public IMongoDatabase GetDatabase()
        {
            if (_database != null) { return _database; }
            var client = GetClient();
            _database = client.GetDatabase(_options.DatabaseName);

            return _database;
        }

        public IMongoCollection<T> GetMongoCollection<T>(string collectionName = null)
        {
            var db = GetDatabase();

            return db.GetCollection<T>(collectionName);
        }
    }
}
