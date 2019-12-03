using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorPattern.Refactored
{
    public class Boeing737 : Aircraft
    {
        public Boeing737(string callSign, IAirTrafficControl atc) : base(callSign, atc)
        {
        }
    }
}
