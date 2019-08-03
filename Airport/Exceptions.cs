using System;
namespace AirportExceptions
{
    class StormyException : Exception
    {

        public StormyException(string message)
           : base(String.Format(message))
        {

        }

    }

    class CapacityException : Exception
    {

        public CapacityException(string message)
           : base(String.Format(message))
        {

        }

    }

    class PlaneNotInAirportException : Exception
    {
        public PlaneNotInAirportException(string message)
            : base(String.Format(message))
        {

        }

    }
}
