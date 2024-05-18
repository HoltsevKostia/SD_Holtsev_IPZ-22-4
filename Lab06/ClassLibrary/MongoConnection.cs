using MongoDB.Driver;

namespace ClassLibrary
{

    public sealed class MongoConnection
    {
        private static readonly object _lock = new object();
        private static MongoConnection _instance;
        private IMongoDatabase _database;

        private MongoConnection()
        {
            var client = new MongoClient("mongodb+srv://myAtlasDBUser:xGL80PP9mSzadmbn@myatlasclusteredu.epxxrw2.mongodb.net/?retryWrites=true&w=majority&appName=myAtlasClusterEDU");
            _database = client.GetDatabase("Blackjack");
        }

        public static MongoConnection Instance
        {
            get
            {
                lock (_lock)
                {
                    if (_instance == null)
                    {
                        _instance = new MongoConnection();
                    }
                    return _instance;
                }
            }
        }

        public IMongoCollection<T> GetCollection<T>(string name)
        {
            return _database.GetCollection<T>(name);
        }
    }
}
