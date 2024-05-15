
using ClassLibrary.Cards;

namespace ClassLibrary.CardsFactory
{
    public static class CardFactory
    {
        public static Card CreateCard(Rank rank, Suit suit)
        {
            return new Card(rank, suit);
        }
    }
}
