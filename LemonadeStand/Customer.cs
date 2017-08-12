using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Customer
    {

        public Customer()
        {

        }

        private void getCustomers()
        {
            int i;
            List<Customer> dailyCustomers = new List<Customer>();
            for (i = 0; i <= 50; i++)
            {
                dailyCustomers.Add(new Customer());
                dailyCustomers.ToString();
            }
        }

        private string getOpinions()
        {
            List<string> customerOpinions = new List<string>();
            customerOpinions.Add("I'm really thirsty, no matter what the weather today, I'm buying some lemonade.");
            customerOpinions.Add("I hope it's nice outside today so I can buy some lemonade.");
            customerOpinions.Add("I feel like some lemonade, but if it's raining, I won't even be able to stop to get some. I don't want to be stuck in the rain.");
            customerOpinions.Add("If it is hot out, I'm definitely stop and get some lemonade.");
            Random random = new Random();
            int opinion = random.Next(customerOpinions.Count);
            string todaysOpinion = customerOpinions[opinion];
            return todaysOpinion;
        }

        private void mergeLists()
        {

        }

        public void runCustomers()
        {
            getCustomers();
            getOpinions();
        }
    }
}

  
