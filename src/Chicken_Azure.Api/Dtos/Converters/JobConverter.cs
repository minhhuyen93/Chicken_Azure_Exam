namespace Chicken_Azure.Api.Dtos.Converters
{
    using Chicken_Azure.Core.Domain.Models;
    using System.Collections.Generic;
    using System.Linq;

    public class JobConverter : IJobConverter
    {
        public IList<JobMetaDto> Converts(IList<Job> jobs)
        {
            if (jobs == null) { return new List<JobMetaDto>(); }

            return jobs.Select(Convert).ToList();
        }

        public JobMetaDto Convert(Job model)
        {
            return new JobMetaDto
            {
                Title = model.Title,
                CompanyName = model.CompanyName,
                Description = model.Description,
                Type = model.Type
            };
        }
    }
}
