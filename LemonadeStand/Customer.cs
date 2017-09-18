using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class Customer
    {
        public string TodaysOpinion;
        public Customer()
        {

        }

        public void GetOpinions()
        {
            List<string> customerOpinions = new List<string>();
            customerOpinions.Add("I'm really thirsty, no matter what the weather today, I'm buying some lemonade.");
            customerOpinions.Add("I hope it's nice outside today so I can buy some lemonade.");
            customerOpinions.Add("I feel like some lemonade, but if it's raining, I won't even be able to stop to get some. I don't want to be stuck in the rain.");
            customerOpinions.Add("If it is hot out, I'm definitely stop and get some lemonade.");
            Random random = new Random();
            int opinion = random.Next(customerOpinions.Count);
            TodaysOpinion = customerOpinions[opinion];
        }
        public void CheckIfBuy()
        {

        }
    }
}
        


  
