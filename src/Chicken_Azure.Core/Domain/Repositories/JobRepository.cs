namespace Chicken_Azure.Core.Domain.Repositories
{
    using Chicken_Azure.Common.Mongo.Context;
    using Chicken_Azure.Common.Mongo.Repository;
    using Chicken_Azure.Core.Domain.Models;
    using MongoDB.Driver;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    public class JobRepository : BaseRespository<Job>, IJobRepository
    {
        private string CollectionName = "jobs";

        public JobRepository(IMongoContext mongoContext) : base(mongoContext) { }

        public async Task<IList<Job>> GetJobsAsync()
        {
            var filter = Builders<Job>.Filter.Empty;

            return await GetMultipleAsync(filter);
        }

        protected override string GetCollectionName()
        {
            return CollectionName;
        }
    }
}
