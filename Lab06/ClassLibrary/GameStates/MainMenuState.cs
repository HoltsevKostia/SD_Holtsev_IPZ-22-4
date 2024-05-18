
namespace ClassLibrary.GameStates
{
    public class MainMenuState : IGameState
    {
        public void Handle(GameContext context)
        {
            Console.Clear();
            Console.WriteLine("1. Start Game");
            Console.WriteLine("2. Show High Scores");
            Console.WriteLine("3. Exit");
            Console.Write("Select an option: ");

            string input = Console.ReadLine();
            switch (input)
            {
                case "1":
                    context.SetState(new PlayGameState(context.CurrentPlayer, context.PlayerManager));
                    break;
                case "2":
                    context.SetState(new HighScoreState());
                    break;
                case "3":
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Invalid option. Try again.");
                    break;
            }
        }
    }
}
