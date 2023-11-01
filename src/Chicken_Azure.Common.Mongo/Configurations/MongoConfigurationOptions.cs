namespace Chicken_Azure.Common.Mongo.Configurations
{
    public class MongoConfigurationOptions
    {
        public static string DefaultConfiguration = "MongoConfiguration";
        public string Protocol { get; set; } = "mongodb";
        public string Hosts { get; set; } = "localhost";
        public string HostName { get; set; }
        public int Port { get; set; } = 27017;
        public string DatabaseName { get; set; }
        public string User { get; set; }
        public string Password { get; set; }
        public string ConnectionString { get; set; }
    }
}
