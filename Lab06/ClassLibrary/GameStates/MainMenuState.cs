
using ClassLibrary.Players;

namespace ClassLibrary.GameStates
{
    public class MainMenuState : IGameState
    {
        public void Handle(GameContext context)
        {
            Console.Clear();
            Console.WriteLine("Welcome to Blackjack!");
            Console.WriteLine("1. Play with login and leaderboard");
            Console.WriteLine("2. Play without login");
            Console.WriteLine("3. Exit");
            Console.Write("Choose an option: ");

            string choice = Console.ReadLine();
            switch (choice)
            {
                case "1":
                    context.SetState(new LoginState());
                    break;
                case "2":
                    context.SetState(new GameMenuState());
                    break;
                case "3":
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Invalid choice. Try again.");
                    context.SetState(new MainMenuState());
                    break;
            }
        }
    }
}
