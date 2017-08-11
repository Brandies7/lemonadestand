using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Weather
    {

        public int temp;
        
        public Weather()
        {
           // Weather weather = new Weather();
        }

        private string getWeather()
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

        private int getTemp()
        {
            Random random = new Random();
            temp = random.Next(50, 100);
            return temp;
        }

        private string getForecast()
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

        private int getForecastTemp()
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





        public void runWeather()
        {
            //getTemp();
            //getForecast();
            Console.WriteLine("Todays forecast is " + getForecast() + " and " + getTemp() + " degrees.");
            Console.ReadLine();
            Console.WriteLine("Todays weather is " + getWeather() + " and " + getForecastTemp() + " degrees.");
            Console.ReadLine();
            
        }
    }
}
