using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace LemonadeStand
{
    class Game
    {
        UserInterface ui;
        Customer customer;
        Day days;

        public Game()
        {
            ui = new UserInterface();
            customer = new Customer();
            days = new Day();
        }
        public void runGame()
        {
            ui.runUserInterface();
            days.runDay();
            customer.runCustomers();
        }
    }
}
            

     