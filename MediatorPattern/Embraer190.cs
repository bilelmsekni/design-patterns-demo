using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorPattern
{
    public class Embraer190 : Aircraft
    {
        public Embraer190(string callSign) : base(callSign)
        {
        }

        public override bool IsAltitudeAcceptable(int altitude)
        {
            throw new NotImplementedException();
        }
    }
}
