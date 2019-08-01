using System;
using System.Collections.Generic;
using ClassNamePlane;

namespace ClassNameAirport
{
    public class Airport
    {
        public string AirportName { get; set; }
        public List<Plane> planes;

        public Airport(string airportName)
        { 
            planes = new List<Plane>();
            AirportName = airportName;
        }

        public void Land(Plane plane)
        {
            planes.Add(plane);
            Console.WriteLine($"{ plane.Name } has landed at {AirportName}");
        }

        public void TakeOff(Plane plane)
        {
            planes.Remove(plane);
            Console.WriteLine($"{ plane.Name } has departed from {AirportName}");
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



