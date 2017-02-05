using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SBMApp.MODELS
{
    public class Customer
    {
        public double Id { set; get; }
        public double Balance { set; get; }
        public string Name { set; get; }
        public string MobileNumber { set; get; }
        public string Region { set; get; }
        public DateTime OpeningDate { set; get; }
        public double CurrentMonthBuyingAmount { set; get; }
        public double TotalBuyingAmount { set; get; }
        public double AccountReceivable { get; set; }
        public string SL { get; set; }

    }
}
