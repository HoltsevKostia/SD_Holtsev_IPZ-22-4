using ClassLibrary.Players;

namespace ClassLibrary.GameStates
{
    public class HighScoreState : IGameState
    {
        public void Handle(GameContext context)
        {
            Console.Clear();
            Console.WriteLine("High Scores\n");

            var playerManager = new PlayerManager();
            var topPlayers = playerManager.GetTopPlayers();

            Console.WriteLine("{0,-20} {1,10}", "Player Name", "Score");
            Console.WriteLine(new string('-', 31));

            foreach (var player in topPlayers)
            {
                Console.WriteLine("{0,-20} {1,10}", player.Name, player.Score);
            }

            Console.WriteLine("\nPress any key to return to the main menu...");
            Console.ReadKey();

            context.SetState(new GameMenuState());
        }
    }
}
