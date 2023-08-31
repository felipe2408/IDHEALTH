using MongoDB.Driver;

namespace IDHEALTH.Repositories
{
    public class MongoDB
    {
        public MongoClient client;

        public IMongoDatabase db;

        public MongoDB() { 
        
        
            client = new MongoClient("mongodb://idhealth:up4hDasboicGtKfXiNPrMcK4FP3dT47inIXTXQwGyTAtMbVfI8naWflbRWKHp91Yn87taXvLp7rvACDbToj9uA==@idhealth.mongo.cosmos.azure.com:10255/?ssl=true&replicaSet=globaldb&retrywrites=false&maxIdleTimeMS=120000&appName=@idhealth@");

            db = client.GetDatabase("IDHealth");


        
        }    
    }
}
