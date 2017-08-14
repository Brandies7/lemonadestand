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

        public void runName()
        {
            getName();
        }
        public void CalculateCostOfLemons()
        {
            double totalCostLemons = 0;
            for(int i = 0; i < inventory.playerLemons.Count; i++)
            {
                totalCostLemons += inventory.playerLemons[i].price;
            }
        }

        public void CalculateCostOfSugar()
        {
            double totalCostSugar = 0;
            for (int i = 0; i < inventory.playerSugar.Count; i++)
            {
                totalCostSugar += inventory.playerSugar[i].price;
            }
        }

        public void CalculateCostOfCups()
        {
            double totalCostCups = 0;
            for (int i = 0; i < inventory.playerCups.Count; i++)
            {
                totalCostCups += inventory.playerCups[i].price;
            }
        }

        public void CalculateCostOfIce()
        {
            double totalCostIce = 0;
            for (int i = 0; i < inventory.playerIceCubes.Count; i++)
            {
                totalCostIce += inventory.playerIceCubes[i].price;
            }
        }


    }
}

    

        



