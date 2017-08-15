using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class UserInterface
    {
        Player player;
        Store store;
        Customer customer;
        
        public UserInterface()
        {
            
            player = new Player();
            store = new Store(player);
            customer = new Customer();

        }

        private void displayRules()
        {

            Console.WriteLine("Welocme " + player.Name + ". Congratulations on your new buisness venture. Lets go over the rules and where to begin" + Environment.NewLine +
                              "First, you'll need to go to the store and pick up your products. Then you're going to have to decide how to make your lemonade" + Environment.NewLine +
                              "(How much of each ingredient to add). Things you need to keep in mind: The weather will affect your sales. Price will also" + Environment.NewLine +
                              "affect your sales. The taste of your lemonade will affect customer satisfaction. Customer satisfaction will affect your stands" + Environment.NewLine +
                              "popularity. Well, that pretty much covers it. Good luck " + player.Name + " and may your stand turn a nice profit." + Environment.NewLine);
        }

        private void goShopping()
        {
            Console.WriteLine("Goodmornig " + player.Name + ", would you like to go shopping today? 'Yes' or 'No'" + Environment.NewLine);
            string choice = Console.ReadLine().ToLower();
            Console.WriteLine();
            switch (choice)
            {
                case "yes":
                    store.getPurchase();
                    break;
                case "no":
                    Console.WriteLine("Ok, well come back if you need anything.");
                    Console.ReadLine();
                    Console.Clear();
                    break;
                default:
                    Console.WriteLine("I'm sorry, but that was invalid choice. Please select another.");
                    goShopping();
                    break;
            }
        }

        public void runUserInterface()
        {
            player.getName();
            Console.WriteLine();
            displayRules();
            Console.WriteLine();
            goShopping();
            Console.WriteLine();
        }
    }
}
