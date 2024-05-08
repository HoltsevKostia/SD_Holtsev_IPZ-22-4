
namespace ClassLibrary.CoR
{
    public abstract class SupportHandler
    {
        protected SupportHandler _nextHandler;

        public void SetNextHandler(SupportHandler handler)
        {
            _nextHandler = handler;
        }

        public virtual void HandleRequest(int level) {
            Console.WriteLine($"Moving to next hendler");
        }
    }
}
