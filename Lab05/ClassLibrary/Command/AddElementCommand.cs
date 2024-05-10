using ClassLibrary.LightHTML;
using ClassLibrary.Iterator;

namespace ClassLibrary.Command
{
    public class AddElementCommand : ICommand
    {
        private readonly LightElementNode _parent;
        private readonly LightNode _element;

        public AddElementCommand(LightElementNode parent, LightNode element)
        {
            _parent = parent;
            _element = element;
        }

        public void Execute()
        {
            _parent.AddChild(_element);
        }
    }
}
