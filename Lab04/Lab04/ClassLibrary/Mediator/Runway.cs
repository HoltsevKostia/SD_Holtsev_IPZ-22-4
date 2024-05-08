
namespace ClassLibrary.Mediator
{
    public class Runway : IRunway
    {
        public Guid Id { get; }
        private bool _isBusy;

        public Runway()
        {
            Id = Guid.NewGuid();
        }

        public bool IsBusy()
        {
            return _isBusy;
        }

        public void SetBusy()
        {
            _isBusy = true;
            Console.WriteLine($"Runway {Id} is now busy.");
        }

        public void SetFree()
        {
            _isBusy = false;
            Console.WriteLine($"Runway {Id} is now free.");
        }
    }
}
