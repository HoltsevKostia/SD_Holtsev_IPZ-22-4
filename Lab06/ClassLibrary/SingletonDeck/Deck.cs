
using ClassLibrary.Cards;
using ClassLibrary.CardsFactory;
using ClassLibrary.Extensions;

namespace ClassLibrary.SingletonDeck
{
    public class Deck
    {
        private static Deck instance;
        private static readonly object lockObject = new object();
        private List<Card> cards;
        private Random rng;

        private Deck()
        {
            cards = new List<Card>();
            rng = new Random();
            InitializeDeck();
        }

        public static Deck Instance
        {
            get
            {
                lock (lockObject)
                {
                    if (instance == null)
                    {
                        instance = new Deck();
                    }
                    return instance;
                }
            }
        }

        private void InitializeDeck()
        {
            foreach (Suit suit in Enum.GetValues(typeof(Suit)))
            {
                foreach (Rank rank in Enum.GetValues(typeof(Rank)))
                {
                    cards.Add(CardFactory.CreateCard(rank, suit));
                }
            }
            cards.Shuffle();
        }      

        public Card DrawCard()
        {
            lock (lockObject)
            {
                if (cards.Count == 0)
                {
                    throw new InvalidOperationException("No cards left in the deck.");
                }

                Card card = cards[0];
                cards.RemoveAt(0);
                return card;
            }
        }
    }
}
