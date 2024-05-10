
using ClassLibrary.Iterator;

namespace ClassLibrary.State
{
    public class TreeViewModeState : IViewModeState
    {
        public void Render(HTMLDocument document)
        {
            Console.WriteLine("Rendering HTML document as a tree view:");
        }
    }
}
