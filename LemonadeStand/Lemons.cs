using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Lemons : Store
    {
        
        public Lemons(int price, int total)
        {
            this.price = price;
            this.total = total;
        }

        public void BuyLemons(int price, int )
        {
            Console.WriteLine("How many lemons would you like to purchase?");
            int lemons = int.Parse(Console.ReadLine());

            List<Lemons> mylemons = new List<Lemons>();
            for (int i = 0; i <= lemons; i++)
            {
                mylemons.Add(new Lemons(int price, int total));
            }

        }
    }
}

        
        
 
