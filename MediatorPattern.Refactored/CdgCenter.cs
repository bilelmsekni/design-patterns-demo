using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorPattern.Refactored
{
    public class CdgCenter : IAirTrafficControl
    {
        private readonly IList<Aircraft> _aircraftUnderGuidance = new List<Aircraft>();

        public bool IsAltitudeAcceptable(Aircraft reportingAircraft, int altitude)
        {
            var otherAircrafts = _aircraftUnderGuidance.Where(x => x != reportingAircraft);
            foreach (var currentAircraftUnderGuidance in otherAircrafts)
            {
                if (Math.Abs(currentAircraftUnderGuidance.Altitude - altitude) < 1000)
                {
                    return false;
                }
            }
            return true;
        }

        public void Acknowledges(Aircraft aircraft)
        {
            if (!_aircraftUnderGuidance.Contains(aircraft))
            {
                _aircraftUnderGuidance.Add(aircraft);
            }
        }
    }
}
