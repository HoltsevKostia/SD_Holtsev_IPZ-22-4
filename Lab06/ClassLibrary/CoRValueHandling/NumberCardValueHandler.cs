
using ClassLibrary.Cards;

namespace ClassLibrary.CoRValueHandling
{
    public class NumberCardValueHandler : CardValueHandler
    {
        public override int Handle(Card card, int currentTotal)
        {
            if (card.Rank >= Rank.Two && card.Rank <= Rank.Ten)
            {
                return (int)card.Rank;
            }
            else
            {
                return base.Handle(card, currentTotal);
            }
        }
    }
}
