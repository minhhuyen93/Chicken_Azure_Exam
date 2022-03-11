namespace Chicken_Azure.Core.Application
{
    using Chicken_Azure.Core.Domain.Models;
    using Chicken_Azure.Core.Domain.Repositories;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    public class JobService : IJobService
    {
        private readonly IJobRepository _jobRepository;

        public JobService(IJobRepository jobRepository)
        {
            _jobRepository = jobRepository;
        }

        public Task<IList<Job>> GetJobsAsync()
        {
            return _jobRepository.GetJobsAsync();
        }
    }
}
