
using ClassLibrary.Cards;

namespace ClassLibrary.CoRValueHandling
{
    public interface ICardValueHandler
    {
        void SetNext(ICardValueHandler handler);
        int Handle(Card card, int currentTotal);
    }
}
