namespace Chicken_Azure.Core.Domain.Models
{
    using MongoDB.Bson.Serialization.Attributes;

    public class Skill
    {
        [BsonElement("title")]
        public string Title { get; set; }
        
        [BsonElement("language")]
        public string Language { get; set; }

        [BsonElement("description")]
        public string Description { get; set; }
    }
}
