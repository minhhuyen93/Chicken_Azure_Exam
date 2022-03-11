namespace Chicken_Azure.Api.Dtos.Converters
{
    using Chicken_Azure.Core.Domain.Models;
    using System.Collections.Generic;

    public interface IJobConverter
    {
        IList<JobMetaDto> Converts(IList<Job> jobs);
    }
}
