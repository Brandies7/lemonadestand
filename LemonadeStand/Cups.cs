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

        }
    }
}
