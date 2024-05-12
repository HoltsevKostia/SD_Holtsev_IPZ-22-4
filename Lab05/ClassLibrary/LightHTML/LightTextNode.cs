
using ClassLibrary.Visitor;

namespace ClassLibrary.LightHTML
{
    public class LightTextNode : LightNode, IVisitable
    {
        private string _text;

        public LightTextNode(string text)
        {
            _text = text;
        }

        public override string OuterHTML => _text;
        public override string InnerHTML => _text;

        public override string ToHTML()
        {
            return $"<p>{_text}</p>";
        }

        public override void OnCreated()
        {
            Console.WriteLine($"Element Node Created");
        }

        public override void OnInserted()
        {
            Console.WriteLine($"Element Node Created");
        }

        public override void OnRemoved()
        {
            Console.WriteLine($"Element Node Created");
        }

        public void Accept(IElementVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}
