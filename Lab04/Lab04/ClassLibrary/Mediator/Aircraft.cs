
namespace ClassLibrary.Mediator
{
    public class Aircraft : IAircraft
    {
        public string Name { get; }
        private CommandCentre _mediator;

        public Aircraft(string name, CommandCentre mediator)
        {
            Name = name;
            _mediator = mediator;
        }

        public void Land()
        {
            _mediator.NotifyRunwayLanding(this);
        }

        public void TakeOff()
        {
            _mediator.NotifyRunwayTakeoff(this);
        }
    }
}
