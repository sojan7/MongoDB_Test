using MongoDB.Bson;
using MongoDB.Driver;

namespace MongoDB_Test
{
    internal class MongoDbMethods
    {
        public List<BsonDocument> GetListOfAllMongoDbsInADbClient(MongoClient dbClient)
        {
            return dbClient.ListDatabases().ToList();
        }
    }
}