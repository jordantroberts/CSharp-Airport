using System;
using System.Collections.Generic;

namespace Airport
{
    public class Airport
    {
        public List<string> planes;

        public Airport()
        {
            planes = new List<string>();
        }

        public List<string> Land(string plane)
        {
            planes.Add(plane);
            Console.WriteLine("Currently in the airport:");
            planes.ForEach(Console.WriteLine);
            return planes;
        }

        public List<string> TakeOff(string plane)
        {
            planes.Remove(plane);
            Console.WriteLine("Currently in the airport:");
            planes.ForEach(Console.WriteLine);
            return planes;
        }

    }
}