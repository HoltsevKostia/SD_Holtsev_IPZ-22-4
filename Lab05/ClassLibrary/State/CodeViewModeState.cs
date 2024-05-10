
using ClassLibrary.Iterator;

namespace ClassLibrary.State
{
    public class CodeViewModeState : IViewModeState
    {
        public void Render(HTMLDocument document)
        {
            Console.WriteLine("Rendering HTML document as code:");
        }
    }
}
