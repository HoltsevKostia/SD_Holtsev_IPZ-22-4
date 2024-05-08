
namespace ClassLibrary.Observer
{
    public class ClickEventListener : IEventListener
    {
        public void HandleEvent(string eventType)
        {
            if (eventType == "click")
            {
                Console.WriteLine("Click event handled");
            }
        }
    }
}
