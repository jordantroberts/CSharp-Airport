using System;
using ClassNameAirport;
using ClassNamePlane;

namespace ClassNameProgram
{
    class Program
    {
        static void Main()
        {
            var gatwick = new Airport("London Gatwick");
            var planeA = new Plane("Jordan's Private Jet");
            var planeB = new Plane("Amy's Private Jet");

            gatwick.Land(planeA);
            gatwick.Land(planeB);
            gatwick.TakeOff(planeB);
            gatwick.GetPlaneCount();

        }
    }
}


