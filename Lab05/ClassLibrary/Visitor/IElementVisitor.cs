
using ClassLibrary.LightHTML;

namespace ClassLibrary.Visitor
{
    public interface IElementVisitor
    {
        void Visit(LightElementNode element);
        void Visit(LightTextNode element);
    }
}
