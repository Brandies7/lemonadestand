using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Game
    {
        Player player;
        private Game()
        {

        }

        private void DisplayRules()
        {
            Console.WriteLine("Welocme " + player.name + ". Congratulations on your new buisness venture. Lets go over the rules and where to begin" + Environment.NewLine +
                              "First, you'll need to go to the store and pick up your products. Then you're going to have to decide how to make your lemonade" + Environment.NewLine +
                              "(How much of each ingredient to add). Things you need to keep in mind: The weather will affect your sales. Price will also" + Environment.NewLine +
                              "affect your sales. The taste of your lemonade will affect customer satisfaction. Customer satisfaction will affect your stands" + Environment.NewLine +
                              "popularity. Well, that pretty much covers it. Good luck" + player.name + "and may your stand turn a nice profit.");
         }
    }
}
