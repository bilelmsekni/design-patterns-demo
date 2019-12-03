using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorPattern.Refactored
{
    public abstract class Aircraft
    {
        private readonly IAirTrafficControl _atc;

        protected Aircraft(string callSign, IAirTrafficControl atc)
        {
            _atc = atc;
            CallSign = callSign;
            _atc.Acknowledges(this);
        }

        public void Climb(int altitude)
        {
           var canClimb = _atc.IsAltitudeAcceptable(this, altitude);
            if (canClimb)
            {
                Altitude += altitude;
            }
        }

        public string CallSign { get; private set; }
        public int Altitude { get; set; }

    }
}
