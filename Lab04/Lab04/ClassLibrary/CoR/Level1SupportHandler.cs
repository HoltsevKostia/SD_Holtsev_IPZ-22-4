
namespace ClassLibrary.CoR
{
    public class Level1SupportHandler : SupportHandler
    {
        public override void HandleRequest(int level)
        {
            base.HandleRequest(level);
            if (level == 1)
            {
                Console.WriteLine("Level 1 Support: How can I assist you?");
            }
            else if (_nextHandler != null)
            {
                _nextHandler.HandleRequest(level);
            }
        }
    }
}
