using ClassLibrary.Cards;
using ClassLibrary.CoRValueHandling;

namespace ClassLibrary.PlayerHand
{
    public class Hand
    {
        private List<Card> cards;
        private HandValueCalculator calculator;

        public Hand()
        {
            cards = new List<Card>();
            calculator = new HandValueCalculator();
        }

        public void AddCard(Card card)
        {
            cards.Add(card);
        }

        public Card GetFirstCard()
        {
            return cards.FirstOrDefault();          
        }

        public int CalculateTotalValue()
        {
            return calculator.CalculateTotalValue(cards);
        }

        public override string ToString()
        {
            return string.Join(", ", cards);
        }

        public bool IsBusted()
        {
            return calculator.CalculateTotalValue(cards) > 21;
        }
    }
}
