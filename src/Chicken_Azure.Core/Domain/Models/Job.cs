namespace Chicken_Azure.Core.Domain.Models
{
    using Chicken_Azure.Common.Mongo.Models;
    using Chicken_Azure.Core.Domain.Enums;
    using MongoDB.Bson.Serialization.Attributes;
    using System.Collections.Generic;

    public class Job : BaseModel
    {
        [BsonElement("title")]
        public string Title { get; set; }

        [BsonElement("description")]
        public string Description { get; set; }

        [BsonElement("companyName")]
        public string CompanyName { get; set; }

        [BsonElement("address")]
        public Address Address { get; set; }

        [BsonElement("type")]
        public JobType Type { get; set; }

        [BsonElement("skills")]
        public IList<Skill> Skills { get; set; }
        
        [BsonElement("experiences")]
        public IList<Experience> Experiences { get; set; }
    }
}
