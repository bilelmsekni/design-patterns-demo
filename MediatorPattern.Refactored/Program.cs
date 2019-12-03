using System;

namespace MediatorPattern.Refactored
{
    class Program
    {
        static void Main(string[] args)
        {
            var yytCenter = new CdgCenter();

            var flight1 = new Airbus321("AC159", yytCenter);
            var flight2 = new Boeing737("WS203", yytCenter);
            var flight3 = new Embraer190("AC602", yytCenter);

            flight1.Climb(1000);
        }
    }
}
