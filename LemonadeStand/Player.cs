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
        public double totalCostSugar;
        public double totalCostIce;
        public double totalCostCups;

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

        public void GetName()
        {
            Console.WriteLine("Hello New Player, Please Enter Your Name");
            name = Console.ReadLine();
        }

        private void CashTotal()
        {

        }

        public void CalculateCostOfLemons()
        {
            
            for (int i = 1; i < inventory.playerLemons.Count; i++)
            {
                totalCostLemons += inventory.playerLemons[i].price;
            }
            Console.WriteLine("Your total is $" + totalCostLemons + ".");
            Console.WriteLine();
        }

        public void CalculateCostOfSugar()
        {
            
            for (int i = 1; i < inventory.playerSugar.Count; i++)
            {
                totalCostSugar += inventory.playerSugar[i].price;    
            }
            Console.WriteLine("Your total is $" + totalCostSugar + ".");
            Console.WriteLine();
        }

        public void CalculateCostOfCups()
        {
            
            for (int i = 1; i < inventory.playerCups.Count; i++)
            {
                totalCostCups += inventory.playerCups[i].price;               
            }
            Console.WriteLine("Your total is $" + totalCostCups + ".");
            Console.WriteLine();
        }

        public void CalculateCostOfIce()
        {
           
            for (int i = 1; i < inventory.playerIceCubes.Count; i++)
            {
                totalCostIce += inventory.playerIceCubes[i].price;               
            }
            Console.WriteLine("Your total is $" + totalCostIce + ".");
            Console.WriteLine();
        }

        
    }
}


   

    

        



