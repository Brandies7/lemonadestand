using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Program
    {

        Lemons lemons;

        public Program()
        {
            lemons = new Lemons();
        }
        static void Main(string[] args)
        {
            Game game = new Game();
            game.runGame();
            

        }

        
        
        
        
    }
}
