using System;
using System.Collections.Generic;
using System.Linq;

namespace Airport
{
    public class Airport
    {
        public List<object> planes;

        public Airport()
        {
            planes = new List<object>();
        }

        public List<object> Land(object plane)
        {
            planes.Add(plane);
            Console.WriteLine("Currently in the airport:");
            planes.ForEach(Console.WriteLine);
            return planes;
        }

        public List<object> TakeOff(object plane)
        {
            planes.Remove(plane);
            Console.WriteLine("Currently in the airport:");
            planes.ForEach(Console.WriteLine);
            return planes;
        }

        public int GetPlaneCount()
        {
            Console.WriteLine(planes.Count);
            return planes.Count();
        }
    }
}

