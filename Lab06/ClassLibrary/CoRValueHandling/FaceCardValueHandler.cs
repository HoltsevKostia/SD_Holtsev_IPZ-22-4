
using ClassLibrary.Cards;

namespace ClassLibrary.CoRValueHandling
{
    public class FaceCardValueHandler : CardValueHandler
    {
        public override int Handle(Card card, int currentTotal)
        {
            if (card.Rank == Rank.Jack || card.Rank == Rank.Queen || card.Rank == Rank.King)
            {
                return 10;
            }
            else
            {
                return base.Handle(card, currentTotal);
            }
        }
    }
}
