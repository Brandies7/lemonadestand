﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Sugar
    {
        public Sugar()
        {

        }

        public void BuySugar()
        {
            Console.WriteLine("How much sugar would you like to purchase? (In Cups)");
            int sugar = int.Parse(Console.ReadLine());

            List<Sugar> mySugar = new List<Sugar>();
            for (int i = 0; i <= sugar; i++)
            {
                mySugar.Add(new Sugar());
            }

        }
    }
}