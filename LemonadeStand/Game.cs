using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace LemonadeStand
{
    public class Game
    {
        UserInterface ui;
        Day days;

        public Game()
        {
            ui = new UserInterface();
        }
        public void runGame()
        {
            ui.runUserInterface();
            
            
        }

        
    }
}
            

     