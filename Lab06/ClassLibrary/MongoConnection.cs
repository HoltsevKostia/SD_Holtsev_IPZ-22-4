using MongoDB.Driver;

namespace ClassLibrary
{

    public class MongoConnection
    {
        //private static readonly object _lock = new object();
        //private static MongoConnection _instance;
        //private IMongoDatabase _database;

        //private MongoConnection()
        //{
        //    var client = new MongoClient("your_mongo_connection_string");
        //    _database = client.GetDatabase("your_database_name");
        //}

        //public static MongoConnection Instance
        //{
        //    get
        //    {
        //        lock (_lock)
        //        {
        //            if (_instance == null)
        //            {
        //                _instance = new MongoConnection();
        //            }
        //            return _instance;
        //        }
        //    }
        //}

        //public IMongoCollection<T> GetCollection<T>(string name)
        //{
        //    return _database.GetCollection<T>(name);
        //}
    }
}
