
using ClassLibrary.Extensions;

namespace ClassLibrary.GameState
{
    public class PlayerTurnState : GameState
    {
        private readonly Game game;

        public PlayerTurnState(Game game)
        {
            this.game = game;
        }

        public override void PlayerTurn()
        {
            string message = "Your turn to choose";
            Console.ReadLine();
            message.ConsoleWriteLineSlowly();
        }
    }
}
