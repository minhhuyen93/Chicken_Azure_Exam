namespace Chicken_Azure.Common.Mongo.Repository
{
    using Chicken_Azure.Common.Mongo.Context;
    using Chicken_Azure.Common.Mongo.Models;
    using MongoDB.Driver;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    public abstract class BaseRespository<T> where T : BaseModel
    {
        private readonly IMongoContext _mongoContext;
        private static string CollectionName = "";

        public BaseRespository(IMongoContext mongoContext)
        {
            _mongoContext = mongoContext;
        }

        public async Task<IList<T>> GetMultipleAsync(FilterDefinition<T> filter)
        {
            var collection = _mongoContext.GetMongoCollection<T>(GetCollectionName());

            var results = await collection.FindAsync(filter);

            return results.ToList();
        }

        protected abstract string GetCollectionName();
    }
}
