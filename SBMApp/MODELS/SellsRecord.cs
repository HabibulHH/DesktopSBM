using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SBMApp.MODELS
{
    public class SellsRecord
    {
       
        public int Id { get; set; }

        
        public DateTime Date { get; set; }

      
        public float TotalSell { get; set; }
      
        public float SellOnCash { get; set; }

        public float SellsOnDue { get; set; }
      
        public float Collection { get; set; }

     
       
    }
}
