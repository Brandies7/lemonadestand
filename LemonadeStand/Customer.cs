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

        public void runCustomers()
        {
            getCustomers();
        }

    }
}
