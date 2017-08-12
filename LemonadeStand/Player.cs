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

        public string Name
        {
            get
            {
                return name;
            }
        }

        public Player()
        {
            
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
    }
}

    

        



