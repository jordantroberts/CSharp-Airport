using System;
namespace ClassNameWeather
{
    public class Weather
    {
        public Weather()
        {

        }

        public string Forecast()
        {
            Random random = new Random();
            var weather = random.Next(1, 11);
            if (weather == 1 || weather == 2)
            {
                return "stormy";
            }
            else
            {
                return "sunny";
            }
        }
    }
}
