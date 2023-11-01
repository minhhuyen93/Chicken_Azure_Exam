namespace Chicken_Azure.Common.Mongo
{
    using Chicken_Azure.Common.Mongo.Context;
    using Chicken_Azure.Common.Mongo.Factory;
    using Microsoft.Extensions.DependencyInjection;

    public static class RegistrationExtensions
    {
        public static IServiceCollection MongoRegistrations(this IServiceCollection services)
        {
            services
                .AddSingleton<IMongoContext, MongoContext>()
                .AddSingleton<IMongoFactory, MongoFactory>();
            return services;
        }
    }
}
