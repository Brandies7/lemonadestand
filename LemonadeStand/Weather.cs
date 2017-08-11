using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Weather
    {
        

        public Weather()
        {

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
            int temp = random.Next(50, 100);
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
            Random random = new Random();
            int temp = random.Next(65, 85);
            return temp;
        }





        public void runWeather()
        {
            Console.WriteLine("Todays forecast is " + getForecast() + " and " + getForecastTemp() + " degrees.");
            Console.ReadLine();
            Console.WriteLine("Todays weather is " + getWeather() + " and " + getTemp() + " degrees.");
            Console.ReadLine();
            
        }
    }
}
