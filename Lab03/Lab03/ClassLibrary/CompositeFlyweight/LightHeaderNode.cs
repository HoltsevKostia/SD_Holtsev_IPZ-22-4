
using ClassLibrary.Composite;

namespace ClassLibrary.CompositeFlyweight
{
    public class LightHeaderNode : LightNode
    {
        private string _text;
        private int _level;

        public LightHeaderNode(string text, int level)
        {
            _text = text;
            _level = level;
        }

        public override string OuterHTML => throw new NotImplementedException();

        public override string InnerHTML => throw new NotImplementedException();

        public override string ToHTML()
        {
            return $"<h{_level}>{_text}</h{_level}>";
        }
    }
}
