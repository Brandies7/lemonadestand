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
            Console.WriteLine("Please Enter Your Name");
            name = Console.ReadLine();
            
        }

        public void runName(string name)
        {
            getName();
        }
    }
}

    

        



