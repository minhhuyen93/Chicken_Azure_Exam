namespace Chicken_Azure.Api.Dtos
{
    using Chicken_Azure.Core.Domain.Enums;

    public class JobMetaDto
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string CompanyName { get; set; }
        //public AddressDto Address { get; set; }
        public JobType Type { get; set; }
    }
}
