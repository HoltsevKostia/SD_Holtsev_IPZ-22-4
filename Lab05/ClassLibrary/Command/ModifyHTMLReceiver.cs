
using ClassLibrary.Composite;

namespace ClassLibrary.Command
{
    public class ModifyHTMLReceiver
    {
        private readonly HTMLDocument _document;

        public ModifyHTMLReceiver(HTMLDocument document)
        {
            _document = document;
        }

        public void AddElement(LightElementNode parent, LightNode element)
        {
            parent.AddChild(element);
        }

        public void RemoveElement(LightElementNode parent, LightNode element)
        {
            parent.RemoveChild(element);
        }
    }
}
