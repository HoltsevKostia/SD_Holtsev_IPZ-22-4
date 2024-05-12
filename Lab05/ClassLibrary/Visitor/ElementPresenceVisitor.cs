
using ClassLibrary.LightHTML;

namespace ClassLibrary.Visitor
{
    public class ElementPresenceVisitor : IElementVisitor
    {
        private string _tagName;
        private bool _isPresent;

        public ElementPresenceVisitor(string tagName)
        {
            _tagName = tagName;
            _isPresent = false;
        }

        public bool IsElementPresent()
        {
            return _isPresent;
        }

        public void Visit(LightElementNode element)
        {
            if (element.TagName == _tagName)
            {
                _isPresent = true;
            }
        }

        public void Visit(LightTextNode element)
        {
            // Не перевіряємо текстові вузли
        }
    }
}
