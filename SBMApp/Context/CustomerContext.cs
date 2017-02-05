using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SBMApp.MODELS;

namespace SBMApp.Context
{
    public class CustomerContext:DbContext
    {
        public DbSet<Customer> Customers { get; set; }
        public DbSet<CustomerPaymentModel> Payments { get; set; }
        public DbSet<SellsRecord> Records { get; set; }
        public DbSet<CustomerBuyingRec> BuyingRecords { get; set; }
    }
}
