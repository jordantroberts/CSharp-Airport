using NUnit.Framework;
using ClassNameAirport;
using ClassNamePlane;
using ClassNameWeather;
using Moq;


namespace AirportTest
{
   
    public class AirportTest
    {
        
        Plane plane = new Plane("TestPlane");
        
        [Test]
       
        public void PlaneCanLand()
        {
            var weather = new Mock<Weather>();
            weather.Setup(x => x.Forecast()).Returns("sunny");
            var airport = new Airport("TestAirport", weather.Object);

            airport.Land(plane);
            Assert.IsTrue(airport.planes.Contains(plane));
        }

        //public void PlaneCanTakeOff()
        //{
        //    airport.Land(plane);
        //    airport.TakeOff(plane);
        //    Assert.IsFalse(airport.planes.Contains(plane));
        //}
    }
}

