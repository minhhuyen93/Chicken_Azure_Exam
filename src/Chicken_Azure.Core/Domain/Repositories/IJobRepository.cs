namespace Chicken_Azure.Core.Domain.Repositories
{
    using Chicken_Azure.Core.Domain.Models;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    public interface IJobRepository
    {
        Task<IList<Job>> GetJobsAsync();
    }
}
