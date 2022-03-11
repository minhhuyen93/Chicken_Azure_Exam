namespace Chicken_Azure.Common.Mongo.Factory
{
    using Chicken_Azure.Common.Mongo.Configurations;
    using MongoDB.Driver;
    using System.Text;

    public class MongoFactory : IMongoFactory
    {
        public IMongoClient CreateClient(MongoConfigurationOptions options)
        {
            return CreateClient(CreateConnectionString(options));
        }

        public IMongoClient CreateClient(string connectionString)
        {
            var url = new MongoUrl(connectionString);

            var clientSetting = MongoClientSettings.FromUrl(url);

            return new MongoClient(clientSetting);
        }

        public string CreateConnectionString(MongoConfigurationOptions options)
        {
            var builder = new StringBuilder();
            builder.Append($"{options.Protocol}://");

            var host = $"{options.HostName}:{options.Port}";
            builder.Append($"{host}/");

            if (!string.IsNullOrEmpty(options.DatabaseName))
            {
                builder.Append(options.DatabaseName);
            }

            return builder.ToString();
        }
    }
}
