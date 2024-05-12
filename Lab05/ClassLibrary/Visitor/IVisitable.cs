
namespace ClassLibrary.Visitor
{
    public interface IVisitable
    {
        void Accept(IElementVisitor visitor);
    }
}
