using System;
using System.Collections.Generic;
using System.Linq;

namespace MediatorPattern
{
    public abstract class Aircraft
    {
        protected IList<Aircraft> _acknowledgedAircraft = new List<Aircraft>();
        protected Aircraft(string callSign)
        {
            CallSign = callSign;
        }

        public abstract bool IsAltitudeAcceptable(int altitude);

        public void Acknowledges(Aircraft aircraft)
        {
            _acknowledgedAircraft.Add(aircraft);
        }

        public void Climb(int altitude)
        {
            var canClimb = _acknowledgedAircraft.All(ac => ac.IsAltitudeAcceptable(altitude));
            if (canClimb)
            {
                Altitude += altitude;
            }
        }

        public string CallSign { get; private set; }
        public int Altitude { get; set; }
    }
}
