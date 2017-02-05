using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Controls;
using MetroFramework.Forms;
using SBMApp.Context;
using SBMApp.MODELS;

namespace SBMApp.UI
{
    public partial class CustomersPayment : MetroForm
    {
        CustomerContext db= new CustomerContext();
        public CustomersPayment()
        {
            InitializeComponent();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (DialogResult.OK == MessageBox.Show("Confirm?","deleted",MessageBoxButtons.OKCancel))
            {
                DateTime date = paymentDate.Value;
                string CustomrId = CustomerSL.Text;
                float amountpaied = Convert.ToSingle(amount.Text);
                CustomerPaymentModel customerPayment = new CustomerPaymentModel()
                {
                    CustomerId = CustomrId,
                    Amount = amountpaied,
                    Date = date
                    
                };
                db.Payments.Add(customerPayment);
                var custoemrdb= db.Customers.FirstOrDefault(c=>c.CustomerId.Equals(customerPayment.CustomerId));
                if (custoemrdb == null)
                {
                    MessageBox.Show("No customer Found");
                }
                else
                { custoemrdb.AccountRecivable = custoemrdb.AccountRecivable - customerPayment.Amount; }
                db.SaveChanges();
                
                CustomerList aCustomerListfrolm = new CustomerList();
                this.Hide();
                




            }
        } 
    }
}
