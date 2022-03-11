namespace Chicken_Azure.Common.Mongo.Models
{
    using MongoDB.Bson.Serialization.Attributes;

    public class BaseModel
    {
        [BsonElement("_id")]
        [BsonRepresentation(MongoDB.Bson.BsonType.ObjectId)]
        public string Id { get; set; }
    }
}
