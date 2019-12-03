﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorPattern.Refactored
{
    public class Airbus321 : Aircraft
    {
        public Airbus321(string callSign, IAirTrafficControl atc) : base(callSign, atc)
        {
        }
    }
}
