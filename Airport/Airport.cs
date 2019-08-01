using System;
using System.Collections.Generic;
using ClassNamePlane;
using ClassNameWeather;

namespace ClassNameAirport
{
    public class Airport
    {
        public string AirportName { get; set; }
        public List<Plane> planes;
        public Weather _weather; 

        public Airport(string airportName)
        {
            planes = new List<Plane>();
            AirportName = airportName;
            _weather = new Weather(); 
        }

        public void Land(Plane plane)
        {
            if (_weather.Forecast() != "stormy")
            {
                planes.Add(plane);
                Console.WriteLine($"{ plane.Name } has landed at {AirportName}");
            }
            else
            {
                throw new Exception("It's too stormy to land");
            }
        }

        public void TakeOff(Plane plane)
        {
            if (_weather.Forecast() != "stormy")
            {
                planes.Remove(plane);
                Console.WriteLine($"{ plane.Name } has departed from {AirportName}");
            }
            else
            {
                throw new Exception("It's too stormy to take off");
            }
            
        }

        public int GetPlaneCount()
        {
            Console.WriteLine($"Number of planes at {AirportName}: {planes.Count}");
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



