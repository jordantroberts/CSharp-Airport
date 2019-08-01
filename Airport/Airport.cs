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
            planes.ForEach(Console.WriteLine);
            return planes;
        }

        public void TakeOff(string plane)
        {
            planes.Remove(plane);
        }

    }
}