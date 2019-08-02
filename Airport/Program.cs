using System;
using ClassNameAirport;
using ClassNamePlane;
using ClassNameWeather;

namespace ClassNameProgram
{
    class Program
    {
        static void Main()
        {
    
            var gatwick = new Airport("London Gatwick", new Weather(), 2); 
            var planeA = new Plane("Jordan's Private Jet");
            var planeB = new Plane("Amy's Private Jet");
            var planeC = new Plane("Steve's Helicopter");
            var planeD = new Plane("Tina's Private Jet");
            gatwick.Land(planeA);
            Console.WriteLine(gatwick.planes.Count);
            gatwick.Land(planeB);
            Console.WriteLine(gatwick.planes.Count);

            gatwick.Land(planeC);
            Console.WriteLine(gatwick.planes.Count);

            gatwick.Land(planeD);
            gatwick.TakeOff(planeB);
            gatwick.GetPlaneCount();
        }
    }
}


