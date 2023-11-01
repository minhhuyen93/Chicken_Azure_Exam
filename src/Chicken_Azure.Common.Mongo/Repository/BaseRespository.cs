namespace Chicken_Azure.Common.Mongo.Repository
{
    using Chicken_Azure.Common.Mongo.Context;
    using Chicken_Azure.Common.Mongo.Models;
    using MongoDB.Driver;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    public abstract class BaseRespository<T> where T : BaseModel
    {
        private readonly IMongoContext _mongoContext;
        private readonly IMongoCollection<T> _collection;

        public BaseRespository(IMongoContext mongoContext)
        {
            _mongoContext = mongoContext;
            _collection = _mongoContext.GetMongoCollection<T>(GetCollectionName());
        }

        public async Task<IList<T>> GetMultipleAsync(FilterDefinition<T> filter)
        {
            var results = await _collection.FindAsync(filter);

            return results.ToList();
        }

        protected abstract string GetCollectionName();
    }
}
