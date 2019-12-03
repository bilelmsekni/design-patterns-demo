using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorPattern
{
    public class Airbus321 : Aircraft
    {
        public Airbus321(string callSign) : base(callSign)
        {
        }

        public override bool IsAltitudeAcceptable(int altitude)
        {
            foreach (var acknowledgedAircraft in _acknowledgedAircraft)
            {
                if (acknowledgedAircraft.GetType() == typeof(Boeing737))
                {
                    //logic to calculate distance between planes    
                }
                if (acknowledgedAircraft.GetType() == typeof(Embraer190))
                {
                    //logic to calculate distance between planes
                }
            }
            return false;
        }
    }
}
