
using ClassLibrary.Cards;

namespace ClassLibrary.CoRValueHandling
{
    public class FaceCardValueHandler : CardValueHandler
    {
        public override int Handle(Card card, int currentTotal)
        {
            return IsFaceCard(card) ? 10 : base.Handle(card, currentTotal);
        }

        private bool IsFaceCard(Card card)
        {
            return card.Rank == Rank.Jack || card.Rank == Rank.Queen || card.Rank == Rank.King;
        }
    }
}
