using IDHEALTH.Interface;
using IDHEALTH.Models;
using IDHEALTH.Repositories;
using MongoDB.Bson;
using MongoDB.Driver;
using System;

namespace IDHEALTH.Collections
{
    public class CategoryCollection : ICategory
    {
        private MongoData _repository = new MongoData();

        private IMongoCollection<Category> Collection;


        public CategoryCollection()
        {
            Collection = _repository.db.GetCollection<Category>("Category");
        }

        public async Task<List<Category>> GetAllCategories()
        {
            return await Collection.FindAsync(new BsonDocument()).Result.ToListAsync();
        }

        public async Task InsertCategory(Category category)
        {
            await Collection.InsertOneAsync(category);
        }

        public async Task UpdateCategory(Category category)
        {
            var filter = Builders<Category>.Filter.Eq(x => x.CategoryID, category.CategoryID);

            await Collection.ReplaceOneAsync(filter, category);
        }
    }
}
