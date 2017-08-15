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
            Console.WriteLine("Welcome to The General Store, your one stop-shop. How can we help you today?" + Environment.NewLine +
                              "Please enter the amount of each item you would like to purchase." + Environment.NewLine +
                              "If you don't need an item just enter '0' or 'None" + Environment.NewLine +
                              "Thank you for choosing The General Store for your shopping needs" + Environment.NewLine +
                              "Please feel free to stop back if you run out of supplies.");
            Console.WriteLine();
            buyLemons();

        }

        public void buyLemons()
        {
            Console.Write("How many lemons would you like to purchase?: ");
            int lemons = int.Parse(Console.ReadLine());


            for (int i = 0; i <= lemons; i++)
            {

                player.inventory.playerLemons.Add(new Lemons());
            }

            player.CalculateCostOfLemons();
            Console.WriteLine();
            buySugar();
        }

        public void buySugar()
        {
            Console.Write("How much sugar would you like to purchase? (In Cups): ");
            int sugar = int.Parse(Console.ReadLine());


            for (int i = 0; i <= sugar; i++)
            {
                player.inventory.playerSugar.Add(new Sugar());
            }

            player.CalculateCostOfSugar();
            Console.WriteLine();
            buyIceCubes();
        }



        public void buyIceCubes()
        {
            Console.Write("How much ice would you like to purchase? (In Cubes): ");
            int ice = int.Parse(Console.ReadLine());

            List<IceCubes> myIce = new List<IceCubes>();
            for (int i = 0; i <= ice; i++)
            {
                myIce.Add(new IceCubes());
            }

            player.CalculateCostOfIce();
            Console.WriteLine();
            buyCups();
        }



        public void buyCups()
        {
            Console.Write("How many cups would you like to purchase?: ");
            int cups = int.Parse(Console.ReadLine());

            for (int i = 0; i <= cups; i++)
            {
                player.inventory.playerCups.Add(new Cups());
            }
            player.CalculateCostOfCups();
            Console.WriteLine();
            Console.ReadLine();
        }
    }
}

        

 

        
 





            


  


       

                
