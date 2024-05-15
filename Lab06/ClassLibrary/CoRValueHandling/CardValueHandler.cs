
using ClassLibrary.Cards;

namespace ClassLibrary.CoRValueHandling
{
    public abstract class CardValueHandler : ICardValueHandler
    {
        private ICardValueHandler _nextHandler;

        public void SetNext(ICardValueHandler handler)
        {
            _nextHandler = handler;
        }

        public virtual int Handle(Card card, int currentTotal)
        {
            if (_nextHandler != null)
            {
                return _nextHandler.Handle(card, currentTotal);
            }
            else
            {
                throw new InvalidOperationException("No handler found for card.");
            }
        }
    }
}
