using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Player
    {
        public string name;
        public Player()
        {
           
        }

        private void GetName()
        {
            Console.WriteLine("Please Enter Your Name");
            name = Console.ReadLine();
        }

        private void ChooseRunTime()
        {
            Console.WriteLine("Please Choose How Many Days You Would Like Your Stand To Be Open For" + Environment.NewLine +
                              "Enter '1' For 7 Days" + Environment.NewLine +
                              "Enter '2' For "



        }
    }
}
