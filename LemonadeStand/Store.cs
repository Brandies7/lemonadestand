using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Store
    {
        Player player;
        public Store(Player player)
        {
            this.player = player;

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
                    buySugar();
                    break;
                case "icecubes":
                    buyIceCubes();
                    break;
                case "cups":
                    buyCups();
                    break;
                default:
                    Console.WriteLine("Sorry, we don't carry that item. Please select another.");
                    getPurchase();
                    break;
            }
        }

        public void buyLemons()
        {
            Console.WriteLine("How many lemons would you like to purchase?");
            int lemons = int.Parse(Console.ReadLine());


            for (int i = 0; i <= lemons; i++)
            {

                player.inventory.playerLemons.Add(new Lemons());
            }

            calculateTotalLemons(lemons);
        }

        private void calculateTotalLemons(int lemons)
        {

            double total = lemons * 0.25;
            Console.WriteLine("Your total is $" + total + ". Thank you for your purchase.");
            KeepShopping();
        }

        public void buySugar()
        {
            Console.WriteLine("How much sugar would you like to purchase? (In Cups)");
            int sugar = int.Parse(Console.ReadLine());


            for (int i = 0; i <= sugar; i++)
            {
                player.inventory.playerSugar.Add(new Sugar());
            }

            calculateTotalSugar(sugar);
        }

        public void calculateTotalSugar(int sugar)
        {
            double total = sugar * 0.25;
            Console.WriteLine("Your total is $" + total + ". Thank you for your purchase.");
            KeepShopping();
        }

        public void buyIceCubes()
        {
            Console.WriteLine("How much ice would you like to purchase?");
            int ice = int.Parse(Console.ReadLine());

            List<IceCubes> myIce = new List<IceCubes>();
            for (int i = 0; i <= ice; i++)
            {
                myIce.Add(new IceCubes());
            }

            calculateTotalIce(ice);
        }

        public void calculateTotalIce(int ice)
        {

            double total = ice * 0.10;
            Console.WriteLine("Your total is $" + total + ". Thank you for your purchase.");
            KeepShopping();
        }

        public void buyCups()
        {
            Console.WriteLine("How much ice would you like to purchase?");
            int cups = int.Parse(Console.ReadLine());

            for (int i = 0; i <= cups; i++)
            {
                player.inventory.playerCups.Add(new Cups());
            }
            calculateTotalCups(cups);
        }

        public void calculateTotalCups(int cups)
        {
            double total = cups * 0.25;
            Console.WriteLine("Your total is $" + total + ". Thank you for your purchase.");
            KeepShopping();
        }

        private void KeepShopping()
        {
            Console.WriteLine("Would you like to continue shopping? 'Yes' or 'No'");
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


        
 





            


  


       

                
