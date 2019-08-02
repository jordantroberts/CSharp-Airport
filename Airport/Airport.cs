using System;
using System.Collections.Generic;
using ClassNamePlane;
using ClassNameWeather;

namespace ClassNameAirport
{
    public class Airport
    {
        private string _AirportName { get; set; }
        private int _Capacity { get; set; }
        public List<Plane> planes;
        public Weather weather;


        public Airport(string _airportName, Weather weather, int _capacity)
        {
            planes = new List<Plane>();
            _AirportName = _airportName;
            _Capacity = _capacity; 
            this.weather = weather;
        }

        public void Land(Plane plane)
        {
            if (weather.Forecast() == "stormy")
            {
                throw new Exception("It's too stormy to land");
            }
            if (planes.Count >= _Capacity)
            {
                throw new Exception("Airport is full");
            }
            planes.Add(plane);
            Console.WriteLine($"{ plane.Name } has landed at {_AirportName}");
        }

        public void TakeOff(Plane plane)
        {
            if (weather.Forecast() == "stormy")
            {
                throw new Exception("It's too stormy to take off");
            }
            if (planes.Contains(plane))
            {
                planes.Remove(plane);
                Console.WriteLine($"{ plane.Name } has departed from {_AirportName}");
            }
            else 
            {
                throw new Exception("Plane not in the airport");
            }
        }

        public int GetPlaneCount()
        {
            Console.WriteLine($"Number of planes at {_AirportName}: {planes.Count}");
            return planes.Count;
        }

        public void GetPlaneNames()
        {
            planes.ForEach(plane => Console.WriteLine((plane as Plane).Name));
        }

        public List<Plane> GetPlaneList()
        {
            return planes;
        }

    }
}



