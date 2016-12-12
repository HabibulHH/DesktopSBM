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
        public float SellingPrice { get; set; }
        public float BuyingPrice { get; set; }
        public float  Quantity { get; set; } // can be KG or picess
        public string Unit { get; set; }
        public long CurrentStock { get; set; }

    }
}
