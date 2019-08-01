using System;
using System.Collections.Generic;

namespace Airport
{
    public class Airport
    {
        public List<Plane> planes;

        public Airport()
        {
            planes = new List<Plane>();
        }

        public List<Plane> Land(Plane plane)
        {
            planes.Add(plane);
            Console.WriteLine($"{ plane.Name } has landed");
            return planes;
        }

        public List<Plane> TakeOff(Plane plane)
        {
            planes.Remove(plane);
            Console.WriteLine($"{ plane.Name } has departed");
            return planes;
        }

        public int GetPlaneCount()
        {
            Console.WriteLine($"Planes in the airport: {planes.Count}");
            return planes.Count;
        }
    }
}

