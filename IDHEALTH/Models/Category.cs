using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace IDHEALTH.Models
{
    public class Category
    {
        [BsonId]
        public ObjectId CategoryID { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

    
    }
}
