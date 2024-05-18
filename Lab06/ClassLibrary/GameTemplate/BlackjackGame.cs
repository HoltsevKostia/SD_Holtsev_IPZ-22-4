
using ClassLibrary.CardDeck;
using ClassLibrary.PlayerHand;

namespace ClassLibrary.GameTemplate
{
    public abstract class BlackjackGame
    {
        protected Deck deck;
        protected Hand playerHand;
        protected Hand dealerHand;

        public void Play()
        {
            InitializeGame();
            DealInitialCards();
            PlayerTurn();
            DealerTurn();
            DetermineWinner();
        }

        protected abstract void InitializeGame();
        protected abstract void DealInitialCards();
        protected abstract void PlayerTurn();
        protected abstract void DealerTurn();
        protected abstract void DetermineWinner();
    }
}
