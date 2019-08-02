using System;
namespace ClassNameWeather
{

    public interface IWeather
    {
        string Forecast();
    }

    public class Weather
    {
        public virtual string Forecast()
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
