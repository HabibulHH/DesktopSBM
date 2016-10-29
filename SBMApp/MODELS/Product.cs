using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SBMApp.MODELS
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }//Should be unique and readable string 
        public long SellingPrice { get; set; }
        public long BuyingPrice { get; set; }
        public long  Quantity { get; set; } // can be KG or picess
        public string Unit { get; set; }

    }
}
