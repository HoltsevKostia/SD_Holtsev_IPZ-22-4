using ClassLibrary.Cards;
using ClassLibrary.CoRValueHandling;

namespace ClassLibrary.PlayerHand
{
    public class Hand
    {
        private List<Card> cards;
        public int Score { get; private set; }

        public Hand()
        {
            cards = new List<Card>();
        }

        public void AddCard(Card card)
        {
            cards.Add(card);
            CalculateScore();
        }

        public Card GetFirstCard()
        {
            return cards.FirstOrDefault();          
        }

        private void CalculateScore()
        {
            int aceCount = cards.Count(card => card.Rank == Rank.Ace);
            Score = cards.Sum(card => (int)card.Rank);

            while (Score > 21 && aceCount > 0)
            {
                Score -= 10;
                aceCount--;
            }
        }

        public override string ToString()
        {
            return string.Join(", ", cards);
        }

        public bool IsBusted()
        {
            return Score > 21;
        }
    }
}
