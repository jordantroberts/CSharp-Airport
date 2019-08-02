using NUnit.Framework;
using ClassNameAirport;
using ClassNamePlane;
using ClassNameWeather;
using Moq;
using System;

namespace AirportTest
{
   
    public class AirportTest
    {
        
        Plane plane = new Plane("TestPlane");
        
        [Test]
       
        public void PlaneCanLandIfSunny()
        {
            var weather = new Mock<Weather>();
            weather.Setup(x => x.Forecast()).Returns("sunny");
            var airport = new Airport("TestAirport", weather.Object);

            airport.Land(plane);
            Assert.IsTrue(airport.planes.Contains(plane));
        }

        [Test]

        public void PlaneWontLandIfStormy()
        {
            var weather = new Mock<Weather>();
            weather.Setup(x => x.Forecast()).Returns("stormy");
            var airport = new Airport("TestAirport", weather.Object);
            var exception = Assert.Throws<Exception>(() => airport.Land(plane));
            Assert.AreEqual(exception.Message, "It's too stormy to land");
        }

        //public void PlaneCanTakeOff()
        //{
        //    airport.Land(plane);
        //    airport.TakeOff(plane);
        //    Assert.IsFalse(airport.planes.Contains(plane));
        //}
    }
}

