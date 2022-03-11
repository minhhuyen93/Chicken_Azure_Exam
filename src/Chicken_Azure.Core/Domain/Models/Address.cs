namespace Chicken_Azure.Core.Domain.Models
{
    using MongoDB.Bson.Serialization.Attributes;

    public class Address
    {
        [BsonElement("city")]
        public string City { get; set; }

        [BsonElement("countryCode")]
        public string CountryCode { get; set; }

        [BsonElement("postalCode")]
        public string PostalCode { get; set; }

        [BsonElement("addressLine1")]
        public string AddressLine1 { get; set; }

        [BsonElement("addressLine2")]
        public string AddressLine2 { get; set; }
    }
}
