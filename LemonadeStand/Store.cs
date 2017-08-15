﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class Store
    {
        Player player;
        Lemons lemons;
        Sugar sugar;
        IceCubes ice;
        Cups cups;
        
        

        

        public Store(Player player)
        {

            
            this.player = player;
            lemons = new Lemons();
            sugar = new Sugar();
            ice = new IceCubes();
            cups = new Cups();
            
        }

        public void getPurchase()
        {
            Console.WriteLine("Welcome to The General Store, your one stop-shop. How can we help you today?" + Environment.NewLine +
                              "Please enter the amount of each item you would like to purchase." + Environment.NewLine +
                              "If you don't need an item just enter '0' or 'None" + Environment.NewLine +
                              "Thank you for choosing The General Store for your shopping needs" + Environment.NewLine +
                              "Please feel free to stop back if you run out of supplies.");
            Console.WriteLine();
            BuyIngredients();

        }
        public void BuyIngredients()
        {
            buyLemons();
            buySugar();
            buyIceCubes();
            buyCups();
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
            
        }



        public void buyIceCubes()
        {
            Console.Write("How much ice would you like to purchase? (In Cubes): ");
            int ice = int.Parse(Console.ReadLine());

            List<IceCubes> myIce = new List<IceCubes>();
            for (int i = 0; i <= ice; i++)
            {
                player.inventory.playerIceCubes.Add(new IceCubes());
            }

            player.CalculateCostOfIce();
            Console.WriteLine();
            
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

        public void DisplayDaysPurchases()
        {
            Console.WriteLine("You purchased " + lemons + " lemons, for " + player.totalCostLemons + Environment.NewLine +
                              sugar + " cups of sugar, for " + player.totalCostSugar + Environment.NewLine +
                              ice + " cubes of ice, for " + player.totalCostIce + Environment.NewLine +
                              "and " + cups + " cups, for " + player.totalCostIce + Environment.NewLine + 
                              "for a grand total of " + (player.totalCostLemons + player.totalCostSugar + player.totalCostIce + player.totalCostCups) + "." + Environment.NewLine +
                              "Thank you for shopping with us today. hope to see you again");
            Console.ReadLine();

        }

        
    }

    
}

        

 

        
 





            


  


       

                
