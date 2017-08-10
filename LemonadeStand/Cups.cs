using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Cups
    {
        public Cups()
        {

        }

        public void BuyCups()
        {
            Console.WriteLine("How many cups would you like to purchase?");
            int cups = int.Parse(Console.ReadLine());

            List<Cups> myCups = new List<Cups>();
            for (int i = 0; i <= cups; i++)
            {
                myCups.Add(new Cups());
            }
            calculateTotal(cups);
        }

        public void calculateTotal(int cups)
        {

            double total = cups * 0.25;
            Console.WriteLine("Your total is $" + total + ". Thank you for your purchase.");
            Console.ReadLine();
        }
    }
}
    

