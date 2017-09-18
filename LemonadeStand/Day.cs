using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class Day
    {
        
        Weather weather;
        List<Customer> customers;
        public Day()
        {
            weather = new Weather();
            customers = new List<Customer>();
        }
        public void GetCustomers()
        {
            int i;
            for (i = 1; i <= 100; i++)
            {
                customers.Add(new Customer());
            }
        }
        public void GenerateCustomerOpinions()
        {
            for (int i = 0; i < customers.Count; i++)
            {
                customers[i].GetOpinions();
            }
        }
        public void GenerateCustomerPurchases()
        {
            for (int i = 0; i < customers.Count; i++)
            {
                customers[i].CheckIfBuy();
            }
        }
        public void RunDay()
        {
            weather.RunForecast();
            weather.RunWeather();
            GetCustomers();
            GenerateCustomerOpinions();
            GenerateCustomerPurchases();
        }
    }
}
        



        
 
