using ClassLibrary.Cards;

namespace ClassLibrary.CoRValueHandling
{
    public class HandValueCalculator
    {
        private ICardValueHandler handlerChain;

        public HandValueCalculator()
        {
            // Побудуємо ланцюжок обробників
            handlerChain = BuildHandlerChain();
        }

        private ICardValueHandler BuildHandlerChain()
        {
            var numberHandler = new NumberCardValueHandler();
            var faceHandler = new FaceCardValueHandler();
            var aceHandler = new AceCardValueHandler();

            numberHandler.SetNext(faceHandler);
            faceHandler.SetNext(aceHandler);

            return numberHandler;
        }

        public int CalculateTotalValue(List<Card> cards)
        {
            int total = 0;
            foreach (var card in cards)
            {
                total += handlerChain.Handle(card, total);
            }

            // Додаткова логіка для коригування значення туза
            int aceCount = cards.Count(c => c.Rank == Rank.Ace);
            while (total > 21 && aceCount > 0)
            {
                total -= 10;
                aceCount--;
            }

            return total;
        }
    }
}
