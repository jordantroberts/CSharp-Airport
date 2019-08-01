using System;
using System.Collections.Generic;

namespace Airport
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

        public List<Plane> Land(Plane plane)
        {
            planes.Add(plane);
            Console.WriteLine($"{ plane.Name } has landed at {AirportName}");
            return planes;
        }

        public List<Plane> TakeOff(Plane plane)
        {
            planes.Remove(plane);
            Console.WriteLine($"{ plane.Name } has departed from {AirportName}");
            return planes;
        }

        public int GetPlaneCount()
        {
            Console.WriteLine($"Number of planes at {AirportName}: {planes.Count}");
            //planes.ForEach(a => Console.WriteLine((a as Plane).Name));
            return planes.Count;
        }
    }
}

