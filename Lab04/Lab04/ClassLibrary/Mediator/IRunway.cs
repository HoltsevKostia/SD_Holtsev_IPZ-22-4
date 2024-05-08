
namespace ClassLibrary.Mediator
{
    public interface IRunway
    {
        Guid Id { get; }
        bool IsBusy();
        void SetFree();
        void SetBusy();
    }
}
