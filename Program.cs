using MongoDB.Bson;
using MongoDB.Driver;

namespace MongoDB_Test
{
    internal class Program
    {
        private static readonly string? connectionString = "The_Needed_Connection_String";

        private static readonly string? mongoDataBaseName = "The_Needed_Mongo_DB_Name";

        private readonly MongoDbMethods mongoDbMethods;

        public Program() => mongoDbMethods = new();

        private readonly MongoClient dbClient = new(connectionString);

        private static void Main()
        {
            Program mainProgram = new();
            List<BsonDocument> allMongoDbInAClient = mainProgram.mongoDbMethods.GetListOfAllMongoDbsInADbClient(mainProgram.dbClient);
            MongoDatabase mongoDatabase = mainProgram.mongoDbMethods.GetMongoDatabase(connectionString!, mongoDataBaseName!);
            BsonDocument element = mainProgram.mongoDbMethods.GetTheBsonDocumentValueUsingUniqueId(mongoDatabase, 31);
        }
    }
}