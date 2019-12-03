using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorPattern
{
    public class Boeing737 : Aircraft
    {
        public Boeing737(string callSign) : base(callSign)
        {
        }

        public override bool IsAltitudeAcceptable(int altitude)
        {
            throw new NotImplementedException();
        }
    }
}
