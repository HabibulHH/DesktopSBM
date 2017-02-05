using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SBMApp.MODELS
{
    public class Customer
    {
       
        public int Id { get; set; }
        public string CustomernName { get; set; }

        public string CustomerId { get; set; }
        public float AccountRecivable { get; set; }
       
        public string MobileNumber { get; set; }

        public string Region { get; set; }
    }
}
