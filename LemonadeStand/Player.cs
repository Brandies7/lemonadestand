using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Player
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

        private void getName()
        {
            Console.WriteLine("Hello New Player, Please Enter Your Name");
            name = Console.ReadLine();
        }
            
        private void cashTotal()
        {

        }

        public void runName(string name)
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
    }
}

    

        



