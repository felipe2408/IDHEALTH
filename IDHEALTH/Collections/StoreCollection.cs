using IDHEALTH.Interface;
using IDHEALTH.Models;
using IDHEALTH.Repositories;
using MongoDB.Bson;
using MongoDB.Driver;

namespace IDHEALTH.Collections
{
    public class StoreCollection : IStore
    {
        private MongoData _repository = new MongoData();

        private IMongoCollection<Store> Collection;



        public StoreCollection()
        {
            Collection = _repository.db.GetCollection<Store>("Store");
        }

        public async Task<List<Store>> GetAllStore()
        {
            return await Collection.FindAsync(new BsonDocument()).Result.ToListAsync();
        }

        public  async Task InsertStore(Store store)
        {
            await Collection.InsertOneAsync(store);
        }

        public async Task UpdateStore(Store store)
        {
            var filter = Builders<Store>.Filter.Eq(x => x.StoreID, store.StoreID);

            await Collection.ReplaceOneAsync(filter, store);
        }
    }
}
