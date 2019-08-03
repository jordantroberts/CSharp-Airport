using System;
using System.Collections.Generic;
using ClassNamePlane;
using ClassNameWeather;
using AirportExceptions;

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

        public List<Plane> Land(Plane plane)
        {
            {
                if (weather.Forecast() == "stormy")
                {
                    Console.WriteLine("It's too stormy to land");
                    return planes;
                }
                if (planes.Count >= _Capacity)
                {
                    Console.WriteLine("Airport is full");
                    return planes;
                }
                else
                {
                    planes.Add(plane);
                    Console.WriteLine($"{ plane.Name } has landed at {_AirportName}");
                    return planes; 
                }
            }
        }

        public List<Plane> TakeOff(Plane plane)
        {
            if (weather.Forecast() == "stormy")
            {
                Console.WriteLine("It's too stormy to take off");
                return planes; 
            }
            if (planes.Contains(plane))
            {
                planes.Remove(plane);
                Console.WriteLine($"{ plane.Name } has departed from {_AirportName}");
                return planes; 
            }
            else
            {
                Console.WriteLine("Plane not in the airport");
                return planes; 
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



