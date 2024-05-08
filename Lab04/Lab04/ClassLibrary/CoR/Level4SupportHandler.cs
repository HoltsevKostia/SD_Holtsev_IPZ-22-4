
namespace ClassLibrary.CoR
{
    public class Level4SupportHandler : SupportHandler
    {
        public override void HandleRequest(int level)
        {
            base.HandleRequest(level);
            if (level == 4)
            {
                Console.WriteLine("Level 4 Support: How can I assist you?");
            }
            else if (_nextHandler != null)
            {
                _nextHandler.HandleRequest(level);
            }
        }
    }
}
