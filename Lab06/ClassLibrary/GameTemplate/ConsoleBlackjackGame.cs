
using ClassLibrary.CardDeck;
using ClassLibrary.Observer;
using ClassLibrary.PlayerHand;

namespace ClassLibrary.GameTemplate
{
    public class ConsoleBlackjackGame : BlackjackGame
    {
        private BlackjackObserver observer = new BlackjackObserver();
        protected override void InitializeGame()
        {
            deck = new Deck();
            playerHand = new Hand();
            dealerHand = new Hand();

            playerHand.AddObserver(observer);
            dealerHand.AddObserver(observer);
        }

        protected override void DealInitialCards()
        {
            playerHand.AddCard(deck.DrawCard());
            playerHand.AddCard(deck.DrawCard());
            dealerHand.AddCard(deck.DrawCard());
            dealerHand.AddCard(deck.DrawCard());

            // Перевірка, чи є Blackjack у гравця
            observer.Update(playerHand);

            if (observer.GameEnded)
            {
                DetermineWinner();
            }
        }

        protected override void PlayerTurn()
        {
            if (observer.GameEnded)
            {
                return;
            }

            bool playerContinues = true;
            while (playerContinues)
            {
                Console.WriteLine("Your hand: " + playerHand + "|| Score: " + playerHand.Score);
                Console.WriteLine("Dealer's visible card: " + dealerHand.GetFirstCard());
                Console.Write("Do you want to hit or stand? (h/s): ");
                // **Able to refactor** - потрібно додати обробку помилок, які можуть виникнути при "спілкуванні" з користувачем
                string input = Console.ReadLine();
                if (input.ToLower() == "h")
                {
                    playerHand.AddCard(deck.DrawCard());
                    observer.Update(playerHand);
                    if (playerHand.IsBusted())
                    {
                        Console.WriteLine("You busted!");
                        playerContinues = false;
                    }
                }
                else
                {
                    playerContinues = false;
                }
            }
        }

        protected override void DealerTurn()
        {
            if (observer.GameEnded)
            {
                return;
            }

            while (dealerHand.Score < 17)
            {
                dealerHand.AddCard(deck.DrawCard());
            }
        }

        protected override void DetermineWinner()
        {
            Console.WriteLine("Your hand: " + playerHand + "|| Score: " + playerHand.Score);
            Console.WriteLine("Dealer's hand: " + dealerHand + "|| Score: " + dealerHand.Score);

            if (playerHand.IsBusted())
            {
                Console.WriteLine("You lose!");
            }
            else if (dealerHand.IsBusted() || playerHand.Score > dealerHand.Score)
            {
                Console.WriteLine("You win!");
            }
            else if (playerHand.Score < dealerHand.Score)
            {
                Console.WriteLine("Dealer wins!");
            }
            else
            {
                Console.WriteLine("It's a tie!");
            }
        }
    }
}
