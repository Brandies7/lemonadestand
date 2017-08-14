using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class UserInterface
    {
        Player player;
        Day days;
        Store store;
        Customer customer;
        public UserInterface()
        {
            player = new Player();
            days = new Day();
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
                    break;
                default:
                    Console.WriteLine("I'm sorry, but that was invalid choice. Please select another.");
                    goShopping();
                    break;
            }
        }

        private void ChooseRunTime()
        {
            Console.WriteLine("Please Choose How Many Days You Would Like Your Stand To Be Open For" + Environment.NewLine +
                              "Enter '1' For 7 Days" + Environment.NewLine +
                              "Enter '2' For 14 Days" + Environment.NewLine +
                              "Enter '3' For 21 Days" + Environment.NewLine);
            string runtime = Console.ReadLine();
            switch (runtime)
            {
                case "1":
                    days.RunSevenDays();
                    break;
                case "2":
                    days.RunFourteenDays();
                    break;
                case "3":
                    days.RunTwentyOneDays();
                    break;
                default:
                    Console.WriteLine("Sorry, That Was An Invalid Response. Please Choose One Of The Options Given");
                    ChooseRunTime();
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
