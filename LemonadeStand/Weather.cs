﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Weather
    {
        Random random;

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
            int weather = random.Next(daysWeather.Count-1);
            string currentWeather = daysWeather[weather];
            Console.WriteLine("Todays weather is " + currentWeather + ".");
            Console.ReadLine();
            return currentWeather;
            

        }

        public void runWeather()
        {
            getWeather();
        }
    }
}
