using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorPattern.Refactored
{
    public interface IAirTrafficControl
    {
        bool IsAltitudeAcceptable(Aircraft reportingAircraft, int altitude);
        void Acknowledges(Aircraft aircraft);
    }
}
