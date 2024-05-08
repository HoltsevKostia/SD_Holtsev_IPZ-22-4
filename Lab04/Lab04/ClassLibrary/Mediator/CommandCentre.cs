
namespace ClassLibrary.Mediator
{
    public class CommandCentre
    {
        private List<IRunway> _runways = new List<IRunway>();
        private List<IAircraft> _aircrafts = new List<IAircraft>();

        public void RegisterRunway(IRunway runway)
        {
            _runways.Add(runway);
        }

        public void RegisterAircraft(IAircraft aircraft)
        {
            _aircrafts.Add(aircraft);
        }

        public void NotifyRunwayLanding(IAircraft aircraft)
        {
            foreach (var runway in _runways)
            {
                if (!runway.IsBusy())
                {
                    Console.WriteLine($"Aircraft {aircraft.Name} is landing.");
                    Console.WriteLine($"Checking runway {runway.Id}.");
                    runway.SetBusy();
                    return;
                }
            }
            Console.WriteLine($"Could not land, all runways are busy.");
        }

        public void NotifyRunwayTakeoff(IAircraft aircraft)
        {
            foreach (var runway in _runways)
            {
                if (runway.IsBusy())
                {
                    runway.SetFree();
                    Console.WriteLine($"Aircraft {aircraft.Name} has taken off from runway {runway.Id}.");
                    return;
                }
            }
            Console.WriteLine($"Aircraft {aircraft.Name} is not currently on any runway.");
        }
    }
}
