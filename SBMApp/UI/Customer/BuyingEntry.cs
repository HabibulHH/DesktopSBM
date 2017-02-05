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
using SBMApp.MODELS;

namespace SBMApp.UI.Customer
{
    public partial class BuyingEntry : MetroForm
    {
        public BuyingEntry()
        {
            InitializeComponent();
        }

        private void BuyingRecEntryButton_Click(object sender, EventArgs e)
        {
            if (DialogResult.OK == MessageBox.Show("Confirm Entry..?", "SAVE", MessageBoxButtons.OKCancel))
            {
                CustomerContext db= new CustomerContext();
                var customerdb = db.Customers.FirstOrDefault(c => c.CustomerId.Equals(CustomerID.Text));
                if (customerdb==null)
                {
                    MessageBox.Show("Customer does not exists..");
                }
                else
                {
                    var entry = new CustomerBuyingRec()
                    {
                        CustomerSL = CustomerID.Text,
                        Amount = Convert.ToSingle(amount.Text),
                        Date = buyingDateTime.Value

                    };

                    db.BuyingRecords.Add(entry);
                    MessageBox.Show(db.SaveChanges() > 0 ? "Saved" : "Not Saved");
                    this.Hide();
                }
               

            }
        }
    }
}
