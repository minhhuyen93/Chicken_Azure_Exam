namespace Chicken_Azure.Common.Mongo.Factory
{
    using Chicken_Azure.Common.Mongo.Configurations;
    using MongoDB.Driver;

    public interface IMongoFactory
    {
        IMongoClient CreateClient(MongoConfigurationOptions options);

        IMongoClient CreateClient(string connectionString);
    }
}
