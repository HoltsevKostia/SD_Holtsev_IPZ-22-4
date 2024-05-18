
using ClassLibrary.Players;

namespace ClassLibrary.GameStates
{
    public class LoginState : IGameState
    {
        private PlayerManager playerManager = new PlayerManager();

        public void Handle(GameContext context)
        {
            Console.Clear();
            Console.WriteLine("Login");
            Console.Write("Enter username: ");
            string username = Console.ReadLine();
            Console.Write("Enter password: ");
            string password = Console.ReadLine();

            Player player = playerManager.AuthenticatePlayer(username, password);

            if (player != null)
            {
                Console.WriteLine("Login successful. Welcome, " + player.Name + "!");
                context.CurrentPlayer = player;
                context.SetState(new MainMenuState());
            }
            else
            {
                Player existingPlayer = playerManager.FindPlayer(username);
                if (existingPlayer == null)
                {
                    Console.WriteLine("No such user found. Creating new user...");
                    playerManager.RegisterPlayer(username, password);
                    context.CurrentPlayer = playerManager.AuthenticatePlayer(username, password);
                    context.SetState(new MainMenuState());
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
