
using ClassLibrary.Extensions;
using ClassLibrary.Players;

namespace ClassLibrary.GameStates
{
    public class LoginState : IGameState
    {
        private PlayerManager playerManager = new PlayerManager();

        public void Handle(GameContext context)
        {
            Console.WriteLine("Login");
            Console.Write("Enter username: ");
            string username = Console.ReadLine();
            Console.Write("Enter password: ");
            string password = Console.ReadLine();

            Player player = playerManager.AuthenticatePlayer(username, password);

            if (player != null)
            {
                Console.Write("Login successful. ");
                string message = "Welcome, " + player.Name + "!";
                message.ConsoleWriteLineSlowly();
                context.CurrentPlayer = player;
                context.SetState(new GameMenuState());
            }
            else
            {
                Player existingPlayer = playerManager.FindPlayer(username);
                if (existingPlayer == null)
                {
                    string message = "No such user found. Creating new user...";
                    message.ConsoleWriteLineSlowly();
                    playerManager.RegisterPlayer(username, password);
                    context.CurrentPlayer = playerManager.AuthenticatePlayer(username, password);
                    context.SetState(new GameMenuState());
                }
                else
                {
                    Console.WriteLine("Incorrect password. Try again.");
                    context.SetState(new LoginState());
                }
            }
        }
    }
}
