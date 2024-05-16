
using ClassLibrary.PlayerHand;

namespace ClassLibrary.Observer
{
    public class BlackjackObserver : IObserver
    {
        private bool gameСontinue = true;

        public bool СontinueGame => gameСontinue;

        public void Update(Hand hand)
        {
            if (hand.Score == 21)
            {
                Console.WriteLine("Blackjack!");
                gameСontinue = false;
            }
            else if (hand.IsBusted())
            {
                Console.WriteLine("Bust!");
                gameСontinue = false;
            }
            else gameСontinue = true;
        }
    }
}
