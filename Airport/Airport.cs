using System;
using System.Collections.Generic;
using ClassNamePlane;
using ClassNameWeather;

namespace ClassNameAirport
{
    public class Airport
    {
        private string _AirportName { get; set; }
        public List<Plane> planes;
        public Weather weather; 

        public Airport(string _airportName, Weather weather)
        {
            planes = new List<Plane>();
            _AirportName = _airportName;
            this.weather = weather;
      
        }

        public void Land(Plane plane)
        {
            if (weather.Forecast() != "stormy")
            {
                planes.Add(plane);
                Console.WriteLine($"{ plane.Name } has landed at {_AirportName}");
            }
            else
            {
                throw new Exception("It's too stormy to land");
            }
        }

        public void TakeOff(Plane plane)
        {
            if (weather.Forecast() != "stormy")
            {
                planes.Remove(plane);
                Console.WriteLine($"{ plane.Name } has departed from {_AirportName}");
            }
            else
            {
                throw new Exception("It's too stormy to take off");
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



