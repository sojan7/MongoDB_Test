using MongoDB.Bson;
using MongoDB.Driver;

namespace MongoDB_Test
{
    internal class Program
    {
        private readonly MongoDbMethods mongoDbMethods;

        public Program() => mongoDbMethods = new();

        private static readonly string? connectionString = "mongodb://ss-stg-aira-quality:PLt0H9kVDtMTovX2@stgcluster01-shard-00-00.ddm82.azure.mongodb.net:27017,stgcluster01-shard-00-01.ddm82.azure.mongodb.net:27017,stgcluster01-shard-00-02.ddm82.azure.mongodb.net:27017/aira-quality?ssl=true&replicaSet=atlas-vo5aj6-shard-0&authSource=admin&retryWrites=true&w=majority";

        private MongoClient dbClient = new(connectionString);

        private static void Main()
        {
            Program mainProgram = new();
            MongoDatabase mongoDatabase = mainProgram.mongoDbMethods.GetMongo(connectionString!, "aira-quality");
            BsonDocument element = mainProgram.mongoDbMethods.GetTheBsonDocumentValueUsingTriggerId(mongoDatabase, 31);
        }
    }
}