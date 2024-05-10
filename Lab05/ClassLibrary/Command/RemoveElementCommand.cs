
using ClassLibrary.Composite;

namespace ClassLibrary.Command
{
    public class RemoveElementCommand : ICommand
    {
        private readonly LightElementNode _parent;
        private readonly LightNode _element;

        public RemoveElementCommand(LightElementNode parent, LightNode element)
        {
            _parent = parent;
            _element = element;
        }

        public void Execute()
        {
            _parent.RemoveChild(_element);
        }
    }
}
