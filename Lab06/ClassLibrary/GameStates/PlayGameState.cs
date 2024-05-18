using ClassLibrary.GameTemplate;
using ClassLibrary.Players;

namespace ClassLibrary.GameStates
{
    public class PlayGameState : IGameState
    {
        private Player currentPlayer;
        private PlayerManager playerManager;
        private BlackjackGame game;


        public PlayGameState(Player player, PlayerManager manager)
        {
            currentPlayer = player;
            playerManager = manager;
            game = new ConsoleBlackjackGame(player, playerManager);
        }

        public void Handle(GameContext context)
        {
            Console.Clear();
            game = new ConsoleBlackjackGame(currentPlayer, playerManager);
            game.Play();

            context.SetState(new GameMenuState());
        }
    }
}
