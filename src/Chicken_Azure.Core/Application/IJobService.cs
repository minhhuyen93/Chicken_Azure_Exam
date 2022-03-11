namespace Chicken_Azure.Core.Application
{
    using Chicken_Azure.Core.Domain.Models;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    public interface IJobService
    {
        Task<IList<Job>> GetJobsAsync();
    }
}
