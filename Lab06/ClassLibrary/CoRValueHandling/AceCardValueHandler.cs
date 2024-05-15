using ClassLibrary.Cards;

namespace ClassLibrary.CoRValueHandling
{
    public class AceCardValueHandler : CardValueHandler
    {
        public override int Handle(Card card, int currentTotal)
        {
            if (card.Rank == Rank.Ace)
            {
                // Туз може бути оцінений як 11 або 1 в залежності від поточного значення
                return currentTotal + 11 > 21 ? 1 : 11;
            }
            else
            {
                return base.Handle(card, currentTotal);
            }
        }
    }
}
