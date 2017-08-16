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
        public void getCustomers()
        {
            int i;
            for (i = 1; i <= 100; i++)
            {
                customers.Add(new Customer());
            }
        }

        private void myWeather()
        {
            weather.runWeather();
        }
        
        public void GenerateCustomerOpinions()
        {
            for (int i = 0; i < customers.Count; i++)
            {
                customers[i].getOpinions();
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
            getCustomers();
            myWeather();
            GenerateCustomerOpinions();
            GenerateCustomerPurchases();
        }
    }
}
        



        
 
