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
            var airport = new Airport("TestAirport", weather.Object, 10);
            airport.Land(plane);
            Assert.IsTrue(airport.planes.Contains(plane));
        }

        [Test]
        
        public void PlaneWontLandIfStormy()
        {
            var weather = new Mock<Weather>();
            weather.Setup(x => x.Forecast()).Returns("stormy");
            var airport = new Airport("TestAirport", weather.Object, 10);
            var exception = Assert.Throws<Exception>(() => airport.Land(plane));
            Assert.AreEqual(exception.Message, "It's too stormy to land");
        }

        //[Test]
        //public void PlaneCanTakeOffIfSunny()
        //{
        //    var weather = new Mock<Weather>();
        //    weather.Setup(x => x.Forecast()).Returns("sunny");
        //    var airport = new Airport("TestAirport", weather.Object, 10);
        //    airport.Land(plane);
        //    airport.TakeOff(plane);
        //    Assert.IsFalse(airport.planes.Contains(plane));
        //}

        //[Test]
        //public void PlaneWontTakeOffIfStormy()
        //{
        //    var weather = new Mock<Weather>();
        //    weather.Setup(x => x.Forecast()).Returns("sunny");
        //    var airport = new Airport("TestAirport", weather.Object, 10);
        //    airport.Land(plane);
        //    var weather2 = new Mock<Weather>();
        //    weather2.Setup(x => x.Forecast()).Returns("stormy");
        //    var airport2 = new Airport("TestAirport", weather2.Object, 10);
        //    var exception = Assert.Throws<Exception>(() => airport2.TakeOff(plane));
        //    Assert.AreEqual(exception.Message, "It's too stormy to take off");
        //}

        //[Test]
        //public void PlaneWontLandIfNoSpace()
        //{
        //    var weather = new Mock<Weather>();
        //    weather.Setup(x => x.Forecast()).Returns("sunny");
        //    var airport = new Airport("TestAirport", weather.Object, 0);
        //    var exception = Assert.Throws<Exception>(() => airport.Land(plane));
        //    Assert.AreEqual(exception.Message, "Airport is full");
        //}

        //[Test]
        //public void PlaneCantTakeOffIfNotAtAirport()
        //{
        //    var weather = new Mock<Weather>();
        //    weather.Setup(x => x.Forecast()).Returns("sunny");
        //    var airport = new Airport("TestAirport", weather.Object, 10);
        //    var exception = Assert.Throws<Exception>(() => airport.TakeOff(plane));
        //    Assert.AreEqual(exception.Message, "Plane not in the airport");
        //}
    }
}

