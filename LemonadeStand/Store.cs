using System;
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

        }

        public void getPurchase()
        {
            Console.WriteLine("Welcome to The General Store, your one stop-shop for all of your Lemonade Stand needs. How can we help you today?" + Environment.NewLine +
                              "Please choose what items you would like to purchase." + Environment.NewLine +
                              "Lemons: at 25 cents a piece" + Environment.NewLine +
                              "Sugar: at 50 cents a cup" + Environment.NewLine +
                              "IceCubes: at 10 cents a cube" + Environment.NewLine +
                              "Cups: at 25 cents a cup");
            string purchase = Console.ReadLine();
            switch (purchase)
            {
                case "Lemons":
                    lemons.BuyLemons();
                    break;
                case "Sugar":
                    sugar.BuySugar();
                    break;
                case "IceCubes":
                    ice.BuyIceCubes();
                    break;
                case "Cups":
                    cups.BuyCups();
                    break;
                default:
                    Console.WriteLine("Sorry, we don't carry that item. Please select another.");
                    getPurchase();
                    break;
            }
        }
    }
}
                
