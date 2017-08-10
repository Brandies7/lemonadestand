using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class IceCubes
    {
        public IceCubes()
        {

        }

        public void BuyIceCubes()
        {
            Console.WriteLine("How much ice would you like to purchase?");
            int ice = int.Parse(Console.ReadLine());

            List<IceCubes> myIce = new List<IceCubes>();
            for (int i = 0; i <= ice; i++)
            {
                myIce.Add(new IceCubes());
            }
            calculateTotal(ice);
        }

        public void calculateTotal(int ice)
        {

            double total = ice * 0.10;
            Console.WriteLine("Your total is $" + total + ". Thank you for your purchase.");
            Console.ReadLine();
        }
    }
}

