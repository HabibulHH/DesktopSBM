using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SBMApp.MODELS
{
    public  class CashMemo
    {
        public Customer ACustomer { get; set; }
        public List<Product> Products { get; set; }
        public DateTime Date { get; set; }
        public long OnCash { get; set; }
        public long OnDue { get; set; }


    }
}
