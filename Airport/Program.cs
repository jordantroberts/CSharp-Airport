using System;

namespace Airport
{
    class Program
    {
        static void Main(string[] args)
        {
            Airport airport = new Airport();
            Plane plane = new Plane("Jordan's Private Jet");
            Plane plane2 = new Plane("Amy's Private Jet");
            airport.Land(plane);
            airport.Land(plane2);
            airport.TakeOff(plane);
            airport.GetPlaneCount();
        }
    }
}


