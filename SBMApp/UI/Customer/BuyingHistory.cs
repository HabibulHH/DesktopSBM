using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;
using SBMApp.Context;

namespace SBMApp.UI.Customer
{
    public partial class BuyingHistory : MetroForm
    {
        public BuyingHistory()
        {
            InitializeComponent();
            Load();
        }

        private void Load()
        {
            CustomerContext db= new CustomerContext();
            buyingRecGrid.DataSource = db.BuyingRecords.ToList();
        }

        private void CustomerID_Click(object sender, EventArgs e)
        {

        }

        private void show_Click(object sender, EventArgs e)
        {
            DateTime sdate = startDate.Value;
            DateTime eDate = endDate.Value;
            string id = CustomerID.Text;
            CustomerContext db= new CustomerContext();
            var listOfCusBuying= db.BuyingRecords.Where(c => c.Date >= sdate && c.Date <= eDate && c.CustomerSL.Equals(id));
            buyingRecGrid.DataSource = listOfCusBuying.ToList();
            double total = 12.00;
            foreach (var item in listOfCusBuying)
            {
                total += item.Amount;
            }
            TotalTextBox.Text = total.ToString();
        }
    }
}
