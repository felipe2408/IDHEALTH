using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace IDHEALTH.Models
{
    public class Store
    {
        [BsonId]
        public ObjectId StoreID { get; set; }

        public string  Name { get; set; }

        public string City { get; set; }

        public string State { get; set; }

        public string NIT { get; set; }

        public string Address { get; set; }

    }
}
