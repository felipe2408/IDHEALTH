using IDHEALTH.Interface;
using IDHEALTH.Models;
using IDHEALTH.Repositories;
using MongoDB.Bson;
using MongoDB.Driver;

namespace IDHEALTH.Collections
{
    public class PersonCollection : IPersonCollection
    {
        private  MongoData _repository = new MongoData();

        private IMongoCollection<Person> Collection;

        public PersonCollection()
        {
            Collection = _repository.db.GetCollection<Person>("Person");
        }

        public async Task<List<Person>> GetAllPeople()
        {

            return await Collection.FindAsync(new BsonDocument()).Result.ToListAsync();
        }

        public async Task InsertPeople(Person person)
        {
            await Collection.InsertOneAsync(person);
        }

        public async Task UpdatePeople(Person person)
        {
            var filter = Builders<Person>.Filter.Eq(x => x.PersonID, person.PersonID);

            await Collection.ReplaceOneAsync(filter, person);


        }
    }
}
