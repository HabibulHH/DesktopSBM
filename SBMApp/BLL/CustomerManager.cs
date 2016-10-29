using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SBMApp.MODELS;

namespace SBMApp.BLL
{
    public class CustomerManager
    {

        public bool IsCutomerExists(string id)
        {
            return true;
        }

        public Customer getCustomerById()
        {
            Customer aCustomer = new Customer()
            {
                Name = "Habibul Hasan",
                Region = "DantVanga",
                AccountReceivable = 5466.00,
            };
            return aCustomer;
        }
    }
}
