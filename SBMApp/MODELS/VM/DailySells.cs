using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SBMApp.MODELS.VM
{
    public class DailySells
    {
        public long Id { get; set; }
        public DateTime SellsDate { get; set; }
        public double TotalSells { get; set; } // from each CashMemo
        public double OndueSells { get; set; }
        public double OnCashSells { get; set; }


    }
}
