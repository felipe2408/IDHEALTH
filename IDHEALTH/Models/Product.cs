using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace IDHEALTH.Models
{
    public class Product
    {
        [BsonId]
        public ObjectId ProductID { get; set; }


        public string Brand { get; set; }

        public string Name { get; set; }

        public string Category { get; set; }

        public decimal Price { get; set; }

        public DateTime ExpiryDate { get; set; }

        public string MadeBy { get; set; }

        public string Description { get; set; }

    }
}
