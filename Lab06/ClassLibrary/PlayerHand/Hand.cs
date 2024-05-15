using ClassLibrary.Cards;


namespace ClassLibrary.PlayerHand
{
    public class Hand
    {
        private List<Card> cards;
        private HandValueCalculator calculator;
        public event Action<Hand> BlackjackAchieved;

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

        public void IsBlackjack()
        {
            int totalValue = calculator.CalculateTotalValue(cards);

                if (totalValue == 21 && cards.Count == 2)
                {
                    BlackjackAchieved?.Invoke(this);
                }         
        }
    }
}
