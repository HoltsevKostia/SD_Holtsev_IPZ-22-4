
namespace ClassLibrary.Mediator
{
    public interface IAircraft
    {
        string Name { get; }
        void Land();
        void TakeOff();
    }
}
