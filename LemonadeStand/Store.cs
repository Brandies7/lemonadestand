﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Store
    {
        
        Lemons lemons;
        Sugar sugar;
        IceCubes ice;
        Cups cups;
        public Store()
        {
            lemons = new Lemons();
            sugar = new Sugar();
            ice = new IceCubes();
            cups = new Cups();
        }

        private void getPurchase()
        {
            Console.WriteLine("Welcome to The General Store, your one stop-shop for all of your Lemonade Stand needs. How can we help you today?" + Environment.NewLine +
                              "Please choose what items you would like to purchase." + Environment.NewLine +
                              "Lemons: at 25 cents a piece" + Environment.NewLine +
                              "Sugar: at 50 cents a cup" + Environment.NewLine +
                              "IceCubes: at 10 cents a cube" + Environment.NewLine +
                              "Cups: at 25 cents a cup");
            string purchase = Console.ReadLine().ToLower();
            switch (purchase)
            {
                case "lemons":
                    lemons.runLemons();
                    break;
                case "sugar":
                    sugar.BuySugar();
                    break;
                case "icecubes":
                    ice.BuyIceCubes();
                    break;
                case "cups":
                    cups.BuyCups();
                    break;
                default:
                    Console.WriteLine("Sorry, we don't carry that item. Please select another.");
                    getPurchase();
                    break;
            }
        }

        public void runStore()
        {
            getPurchase();
        }
        
    }
}
                
