using NUnit.Framework;
using ClassNameAirport;
using ClassNamePlane;

namespace AirportTest
{
    public class AirportTest
    {

        [Test]
        public void PlaneCanLand()
        {
            // moq these later
            Airport airport = new Airport("TestAirport");
            Plane plane = new Plane("TestPlane");
            // moq these later
            airport.Land(plane);
            Assert.IsTrue(airport.planes.Contains(plane));
        }
    }
}

