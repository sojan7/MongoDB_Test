using MongoDB.Bson;
using MongoDB.Driver;
using MongoDB.Driver.Builders;

namespace MongoDB_Test
{
    internal class MongoDbMethods
    {
        public List<BsonDocument> GetListOfAllMongoDbsInADbClient(MongoClient dbClient) => dbClient.ListDatabases().ToList();

        public BsonDocument GetTheBsonDocumentValueUsingUniqueId(MongoDatabase mongoDatabase, int Unique_Id)
        {
            IMongoQuery query = Query.EQ("Node_Name", Unique_Id);
            BsonDocument bsonDocument = mongoDatabase.GetCollection("Collection_Name").FindOne(query);
            return bsonDocument;
        }

        public MongoDatabase GetMongoDatabase(string connectionString, string databaseName)
        {
            MongoClient client = new(connectionString);
            return client.GetServer().GetDatabase(databaseName);
        }
    }
}