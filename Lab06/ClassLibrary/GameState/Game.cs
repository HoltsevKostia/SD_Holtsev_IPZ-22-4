
using ClassLibrary.CardDeck;
using ClassLibrary.PlayerHand;

namespace ClassLibrary.GameState
{
    public class Game
    {
        private GameState currentState;
        private readonly Hand playerHand;
        private readonly Hand dealerHand;
        private readonly Deck deck;

        public Game()
        {
            playerHand = new Hand();
            dealerHand = new Hand();
            deck = new Deck();
            currentState = new StartState(this);
        }

        public Hand PlayerHand => playerHand;
        public Hand DealerHand => dealerHand;
        public Deck Deck => deck;

        public void SetState(GameState state)
        {
            currentState = state;
        }

        public void StartGame()
        {
            currentState.StartGame();
        }

        public void DealCards()
        {
            currentState.GiveCard();
        }

        public void PlayerTurn()
        {
            currentState.PlayerTurn();
        }

        public void DealerTurn()
        {
            currentState.DealerTurn();
        }

        public void EndGame()
        {
            currentState.EndGame();
        }
    }
}
