﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorPattern
{
    public class Program
    {
        static void Main(string[] args)
        {
            var flight1 = new Airbus321("AC159");
            var flight2 = new Boeing737("WS203");
            flight2.Acknowledges(flight1);
            flight1.Acknowledges(flight2);

            var flight3 = new Embraer190("AC602");
            flight3.Acknowledges(flight1);
            flight1.Acknowledges(flight3);
            flight3.Acknowledges(flight2);
            flight2.Acknowledges(flight3);

            flight1.Climb(5000);
        }
    }
}
