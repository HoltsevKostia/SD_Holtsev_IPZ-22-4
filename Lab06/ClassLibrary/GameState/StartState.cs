
using ClassLibrary.Extensions;

namespace ClassLibrary.GameState
{
    public class StartState : GameState
    {
        private readonly Game game;

        public StartState(Game game)
        {
            this.game = game;
        }

        public override void StartGame()
        {
            //string starting_message = "Starting the game...";
            //starting_message.ConsoleWriteLineSlowly();

            game.PlayerHand.AddCard(game.Deck.DrawCard());
            game.PlayerHand.AddCard(game.Deck.DrawCard());

            game.DealerHand.AddCard(game.Deck.DrawCard());
            game.DealerHand.AddCard(game.Deck.DrawCard());

            Console.WriteLine("Player's cards: " + game.PlayerHand.ToString() + " - Total Value: " + game.PlayerHand.CalculateTotalValue());
            Console.WriteLine("Dealer's cards: " + game.DealerHand.GetFirstCard() + ", [Hidden]");
            game.PlayerHand.IsBlackjack();
        }
    }
}
