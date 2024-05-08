
namespace ClassLibrary.Observer
{
    public class MouseoverEventListener : IEventListener
    {
        public void HandleEvent(string eventType)
        {
            if (eventType == "click")
            {
                Console.WriteLine("Mouseover event handled");
            }
        }
    }
}
