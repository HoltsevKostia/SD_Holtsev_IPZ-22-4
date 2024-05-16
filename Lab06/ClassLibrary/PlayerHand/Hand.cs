using ClassLibrary.Cards;
using ClassLibrary.Observer;

namespace ClassLibrary.PlayerHand 
{
    public class Hand : IObservable
    {
        private List<Card> cards;
        public int Score { get; private set; }
        private List<IObserver> observers = new List<IObserver>();

        public Hand()
        {
            cards = new List<Card>();
        }

        public void AddObserver(IObserver observer)
        {
            observers.Add(observer);
        }

        public void RemoveObserver(IObserver observer)
        {
            observers.Remove(observer);
        }

        public void NotifyObservers()
        {
            foreach (var observer in observers)
            {
                observer.Update(this);
            }
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
