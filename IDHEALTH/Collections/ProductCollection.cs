using IDHEALTH.Interface;
using IDHEALTH.Models;
using IDHEALTH.Repositories;
using MongoDB.Bson;
using MongoDB.Driver;

namespace IDHEALTH.Collections
{
    public class ProductCollection : IProduct
    {
        private MongoData _repository = new MongoData();

        private IMongoCollection<Product> Collection;


        public ProductCollection()
        {
            Collection = _repository.db.GetCollection<Product>("Product");
        }

        public async Task<List<Product>> GetAllProduct()
        {
            return await Collection.FindAsync(new BsonDocument()).Result.ToListAsync();
        }

        public async Task InsertProduct(Product product)
        {
            await Collection.InsertOneAsync(product);
        }

        public async Task UpdateProduct(Product product)
        {
            var filter = Builders<Product>.Filter.Eq(x => x.ProductID, product.ProductID);

            await Collection.ReplaceOneAsync(filter, product);
        }


    }
}
