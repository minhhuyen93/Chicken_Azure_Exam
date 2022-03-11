namespace Chicken_Azure.Core.Domain.Models
{
    using MongoDB.Bson.Serialization.Attributes;

    public class Experience
    {
        [BsonElement("projectName")]
        public string ProjectName { get; set; }

        [BsonElement("duration")]
        public string Duration { get; set; }

        [BsonElement("description")]
        public string Description { get; set; }

        [BsonElement("responsibility")]
        public string Responsibility { get; set; }
    }
}
