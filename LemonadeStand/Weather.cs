using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class Weather
    {

        public int temp;

        public Weather()
        {

        }

        public string GetWeather()
        {
            List<string> daysWeather = new List<string>();
            daysWeather.Add("sunny");
            daysWeather.Add("cloudy");
            daysWeather.Add("rainy");
            daysWeather.Add("cloudy and rainy");
            Random random = new Random();
            int weather = random.Next(daysWeather.Count);
            string currentWeather = daysWeather[weather];
            return currentWeather;
        }

        public int GetTemp()
        {
            Random random = new Random();
            temp = random.Next(50, 100);
            return temp;
        }

        public string GetForecast()
        {
            List<string> daysForecast = new List<string>();
            daysForecast.Add("sunny");
            daysForecast.Add("cloudy");
            daysForecast.Add("rainy");
            daysForecast.Add("cloudy and rainy");
            Random random = new Random();
            int forecast = random.Next(daysForecast.Count);
            string currentForecast = daysForecast[forecast];
            return currentForecast;
        }

        private int GetForecastTemp()
        {
            if (temp > 50 && temp < 65)
            {
                Random random = new Random();
                int forecastTemp = random.Next(50, 65);
                return forecastTemp;
            }
            else if (temp > 65 && temp < 80)
            {
                Random random = new Random();
                int forecastTemp = random.Next(65, 80);
                return forecastTemp;
            }
            else
            {
                Random random = new Random();
                int forecastTemp = random.Next(80, 100);
                return forecastTemp;
            }
        }

        public void RunForecast()
        {
            Console.WriteLine("Todays forecast is " + GetForecast() + " and " + GetTemp() + " degrees.");
            Console.ReadLine();
            
        }

        public void RunWeather()
        {
            Console.WriteLine("Todays weather is " + GetWeather() + " and " + GetForecastTemp() + " degrees.");
            Console.ReadLine();
        }
    }
}
            
 