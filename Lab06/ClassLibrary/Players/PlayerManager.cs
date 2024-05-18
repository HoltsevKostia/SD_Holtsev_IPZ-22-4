using MongoDB.Driver;

namespace ClassLibrary.Players
{
    public class PlayerManager
    {
        private readonly IMongoCollection<Player> playerCollection;

        public PlayerManager()
        {
            var mongoConnection = MongoConnection.Instance;
            playerCollection = mongoConnection.GetCollection<Player>("players");
        }

        public Player AuthenticatePlayer(string name, string password)
        {
            var filter = Builders<Player>.Filter.Eq(p => p.Name, name) & Builders<Player>.Filter.Eq(p => p.Password, password);
            return playerCollection.Find(filter).FirstOrDefault();
        }

        public void RegisterPlayer(string name, string password)
        {
            var player = new Player(name, password);
            playerCollection.InsertOne(player);
        }

        public Player FindPlayer(string name)
        {
            var filter = Builders<Player>.Filter.Eq(p => p.Name, name);
            return playerCollection.Find(filter).FirstOrDefault();
        }

        public void UpdatePlayerScore(Player player)
        {
            var filter = Builders<Player>.Filter.Eq(p => p.Name, player.Name);
            var update = Builders<Player>.Update.Set(p => p.Score, player.Score);
            playerCollection.UpdateOne(filter, update);
        }
    }
}
