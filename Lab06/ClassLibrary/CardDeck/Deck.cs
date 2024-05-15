
using ClassLibrary.Cards;
using ClassLibrary.CardsFactory;
using ClassLibrary.Extensions;

namespace ClassLibrary.CardDeck
{
    public class Deck
    {
        private List<Card> cards;

        public Deck()
        {
            cards = new List<Card>();
            InitializeDeck();
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
