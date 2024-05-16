
using ClassLibrary.CardDeck;
using ClassLibrary.PlayerHand;

namespace ClassLibrary.GameTemplate
{
    public class ConsoleBlackjackGame : BlackjackGame
    {
        protected override void InitializeGame()
        {
            deck = new Deck();
            playerHand = new Hand();
            dealerHand = new Hand();
        }

        protected override void DealInitialCards()
        {
            playerHand.AddCard(deck.DrawCard());
            playerHand.AddCard(deck.DrawCard());
            dealerHand.AddCard(deck.DrawCard());
            dealerHand.AddCard(deck.DrawCard());
        }

        protected override void PlayerTurn()
        {
            bool playerContinues = true;
            while (playerContinues)
            {
                Console.WriteLine("Your hand: " + playerHand);
                Console.WriteLine("Dealer's visible card: " + dealerHand.GetFirstCard());
                Console.Write("Do you want to hit or stand? (h/s): ");
                string input = Console.ReadLine();
                if (input.ToLower() == "h")
                {
                    playerHand.AddCard(deck.DrawCard());
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
            while (dealerHand.CalculateTotalValue() < 17)
            {
                dealerHand.AddCard(deck.DrawCard());
            }
        }

        protected override void DetermineWinner()
        {
            Console.WriteLine("Your hand: " + playerHand);
            Console.WriteLine("Dealer's hand: " + dealerHand);

            if (playerHand.IsBusted())
            {
                Console.WriteLine("You lose!");
            }
            else if (dealerHand.IsBusted() || playerHand.CalculateTotalValue() > dealerHand.CalculateTotalValue())
            {
                Console.WriteLine("You win!");
            }
            else if (playerHand.CalculateTotalValue() < dealerHand.CalculateTotalValue())
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
