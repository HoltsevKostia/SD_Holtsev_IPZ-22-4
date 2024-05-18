using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace ClassLibrary.Players
{

    public class Player
    {
        [BsonId]
        public ObjectId Id { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
        public int Score { get; set; }

        public Player(string name, string password)
        {
            Name = name;
            Password = password;
            Score = 0;
        }
    }
}
