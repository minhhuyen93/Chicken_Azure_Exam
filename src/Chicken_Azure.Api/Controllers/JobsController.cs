namespace Chicken_Azure.Api.Controllers
{
    using Chicken_Azure.Api.Dtos.Converters;
    using Chicken_Azure.Core.Application;
    using Microsoft.AspNetCore.Mvc;
    using System.Threading.Tasks;

    [Route("api/[controller]")]
    [ApiController]
    public class JobsController : ControllerBase
    {
        private readonly IJobService _jobService;
        private readonly IJobConverter _jobConverter;

        public JobsController(IJobService jobService,
            IJobConverter jobConverter)
        {
            _jobService = jobService;
            _jobConverter = jobConverter;
        }

        [HttpGet()]
        public async Task<IActionResult> GetJobs()
        {
            var models = await _jobService.GetJobsAsync();

            return Ok(_jobConverter.Converts(models));
        }
    }
}
