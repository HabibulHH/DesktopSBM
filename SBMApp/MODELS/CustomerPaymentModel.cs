using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SBMApp.MODELS
{
    public class CustomerPaymentModel
    {
        public int Id { get; set; }
        public string CustomerId  { get; set; }
        public float Amount { get; set; }
        public DateTime Date { get; set; }
    }
}
