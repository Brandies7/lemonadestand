using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class Player
    {

        private string name;
        public Inventory inventory;
        public double totalCostLemons; 

        public string Name
        {
            get
            {
                return name;
            }
        }

        public Player()
        {
            inventory = new Inventory();
        }

        public void getName()
        {
            Console.WriteLine("Hello New Player, Please Enter Your Name");
            name = Console.ReadLine();
        }

        private void cashTotal()
        {

        }

        public void CalculateCostOfLemons()
        {
            double totalCostLemons = 0;
            for (int i = 1; i < inventory.playerLemons.Count; i++)
            {
                totalCostLemons += inventory.playerLemons[i].price;
            }
            Console.WriteLine("Your total is " + totalCostLemons + ". Thank you for your purchase");
            Console.ReadLine();
        }

        public void CalculateCostOfSugar()
        {
            double totalCostSugar = 0;
            for (int i = 0; i < inventory.playerSugar.Count; i++)
            {
                totalCostSugar += inventory.playerSugar[i].price;    
            }
            Console.WriteLine("Your total is $" + totalCostSugar + ". Thank you for your purchase");
            Console.ReadLine();
        }

        public void CalculateCostOfCups()
        {
            double totalCostCups = 0;
            for (int i = 0; i < inventory.playerCups.Count; i++)
            {
                totalCostCups += inventory.playerCups[i].price;               
            }
            Console.WriteLine("Your total is $" + totalCostCups + ". Thank you for your purchase");
            Console.ReadLine();
        }

        public void CalculateCostOfIce()
        {
            double totalCostIce = 0;
            for (int i = 0; i < inventory.playerIceCubes.Count; i++)
            {
                totalCostIce += inventory.playerIceCubes[i].price;               
            }
            Console.WriteLine("Your total is $" + totalCostIce + ". Thank you for your purchase");
            Console.ReadLine();
        }
    }
}


   

    

        



