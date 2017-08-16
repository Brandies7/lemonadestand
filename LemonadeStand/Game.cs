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
        Day day;
        public Game()
        {
            
            ui = new UserInterface();
            day = new Day();
        }
        public void runGame()
        {
            ui.runUserInterface();
            
            day.RunDay();
        }
    }
}
            
            
        

        
   
            

     