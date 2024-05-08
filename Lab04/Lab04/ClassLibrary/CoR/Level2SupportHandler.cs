
namespace ClassLibrary.CoR
{
    public class Level2SupportHandler : SupportHandler
    {
        public override void HandleRequest(int level)
        {
            base.HandleRequest(level);
            if (level == 2)
            {
                Console.WriteLine("Level 2 Support: How can I assist you?");
            }
            else if (_nextHandler != null)
            {
                _nextHandler.HandleRequest(level);
            }
        }
    }
}
