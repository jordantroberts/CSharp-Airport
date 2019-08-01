using NUnit.Framework;
using ClassNameAirport;
using ClassNamePlane;

namespace AirportTest
{
    public class AirportTest
    {
        Airport airport = new Airport("TestAirport");
        Plane plane = new Plane("TestPlane");

        [Test]
       
        public void PlaneCanLand()
        {
            airport.Land(plane);
            Assert.IsTrue(airport.planes.Contains(plane));
        }

        public void PlaneCanTakeOff()
        {
            airport.Land(plane);
            airport.TakeOff(plane);
            Assert.IsFalse(airport.planes.Contains(plane));
        }
    }
}

