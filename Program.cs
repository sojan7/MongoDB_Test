using MongoDB.Bson;
using MongoDB.Driver;

namespace MongoDB_Test
{
    internal class Program
    {
        private readonly MongoDbMethods mongoDbMethods;

        public Program() => mongoDbMethods = new();

        private MongoClient dbClient = new("mongodb://ss-stg-aira-quality:PLt0H9kVDtMTovX2@stgcluster01-shard-00-00.ddm82.azure.mongodb.net:27017,stgcluster01-shard-00-01.ddm82.azure.mongodb.net:27017,stgcluster01-shard-00-02.ddm82.azure.mongodb.net:27017/aira-quality?ssl=true&replicaSet=atlas-vo5aj6-shard-0&authSource=admin&retryWrites=true&w=majority");

        private static void Main()
        {
            Program mainProgram = new();
            List<BsonDocument> dataBases = mainProgram.mongoDbMethods.GetListOfAllMongoDbsInADbClient(mainProgram.dbClient);
        }
    }
}