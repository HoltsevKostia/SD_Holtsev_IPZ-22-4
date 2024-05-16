
using ClassLibrary.PlayerHand;

namespace ClassLibrary.Observer
{
    public class BlackjackObserver : IObserver
    {
        private bool gameEnded;

        public bool GameEnded => gameEnded;

        public void Update(Hand hand)
        {
            if (hand.Score == 21)
            {
                Console.WriteLine("Blackjack!");
                gameEnded = true;
            }
            else if (hand.IsBusted())
            {
                Console.WriteLine("Bust!");
                gameEnded = true;
            }
        }
    }
}
