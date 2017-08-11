using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Day
    {
        Weather weather;
        
        public Day()
        {
            weather = new Weather();
        }

        private void myWeather()
        {
            weather.runWeather();
        }
        public void RunSevenDays()
        {

        }

        public void RunFourteenDays()
        {

        }

        public void RunTwentyOneDays()
        {

        }

        public void runDay()
        {
            myWeather();
        }
    }
}
