
namespace ClassLibrary.CoR
{
    public class Level3SupportHandler : SupportHandler
    {
        public override void HandleRequest(int level)
        {
            base.HandleRequest(level);
            if (level == 3)
            {
                Console.WriteLine("Level 3 Support: How can I assist you?");
            }
            else if (_nextHandler != null)
            {
                _nextHandler.HandleRequest(level);
            }
        }
    }
}
