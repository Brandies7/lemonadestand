using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Lemons
    {

        List<Lemons> mylemons = new List<Lemons>();

        public Lemons()
        {

        }

        private void buyLemons()
        {
            Console.WriteLine("How many lemons would you like to purchase?");
            int lemons = int.Parse(Console.ReadLine());
            
            List<Lemons> mylemons= new List<Lemons>();
            for (int i = 0; i <= lemons; i++)
            {
                mylemons.Add(new Lemons());
            }

            calculateTotal(lemons);
        }

        private void calculateTotal(int lemons)
        {
            
            double total = lemons * 0.25;
            Console.WriteLine("Your total is $" + total + ". Thank you for your purchase.");
            Console.ReadLine();
        }

        public void runLemons()
        {
            buyLemons();
            

        }
    }
}

  
        
        
 
