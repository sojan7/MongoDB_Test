using MongoDB.Bson;
using MongoDB.Driver;
using MongoDB.Driver.Builders;

namespace MongoDB_Test
{
    internal class MongoDbMethods
    {
        public List<BsonDocument> GetListOfAllMongoDbsInADbClient(MongoClient dbClient) => dbClient.ListDatabases().ToList();

        public BsonDocument GetTheBsonDocumentValueUsingTriggerId(MongoDatabase mongoDatabase, int triggerId)
        {
            IMongoQuery query = Query.EQ("trigger.id", Convert.ToInt32(triggerId));
            BsonDocument bsonDocument = mongoDatabase.GetCollection("report").FindOne(query);
            return bsonDocument;
        }

        public MongoDatabase GetMongo(string connectionString, string databaseName)
        {
            MongoClient client = new(connectionString);
            return client.GetServer().GetDatabase(databaseName);
        }
    }
}