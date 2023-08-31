using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace IDHEALTH.Models
{
    public class Person
    {

        [BsonId]
        public ObjectId PersonID { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string IdentificationNumber { get; set; }

        public string Email { get; set; }

        public string Password { get; set; }

        public bool IsActive { get; set; }


    }
}
