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
            lemons = new Lemons();
            sugar = new Sugar();
            ice = new IceCubes();
            cups = new Cups();
        }

        public void getPurchase()
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
                    buyLemons();
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

        private void buyLemons()
        {
            Console.WriteLine("How many lemons would you like to purchase?");
            int lemons = int.Parse(Console.ReadLine());

            List<Lemons> mylemons = new List<Lemons>();
            for (int i = 0; i <= lemons; i++)
            {
                mylemons.Add(new Lemons());
            }

            calculateTotal(lemons);
        }

        private void calculateTotal(int lemons)
        {

            double total = lemons * 0.25;
            Console.WriteLine("Your total is $" + total + ". Thank you for your purchase. Would you like to continue shopping? 'Yes' or 'No'");
            string continueShopping = Console.ReadLine().ToLower();
            switch (continueShopping)
            {
                case "yes":
                    getPurchase();
                    break;
                case "no":
                    Console.WriteLine("Ok, well you have a good day, and goodluck on your sales. Hope to see you soon.");
                    break;
                default:
                    Console.WriteLine("Sorry but that was not a valid entry. Please try again.");
                    break;
            }
        }
    }
}



        
 





            


  


       

                
