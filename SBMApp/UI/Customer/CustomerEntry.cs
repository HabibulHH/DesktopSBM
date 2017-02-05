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

namespace SBMApp.UI
{
    public partial class CustomerEntry : MetroForm
    {
        public CustomerEntry()
        {
            InitializeComponent();
        }

        private void customerEntryButton_Click(object sender, EventArgs e)
        {
            MODELS.Customer customer = new MODELS.Customer()
            {
                CustomernName = name.Text,
                CustomerId = uniqid.Text,
                AccountRecivable = Convert.ToSingle(due.Text),
                Region = area.Text,
                MobileNumber = mobile.Text


            };
            // Avoid duplication error

            #region saveCustomer
            CustomerContext db = new CustomerContext();

            var customerDb = db.Customers.ToList();
            bool isUnique = true;
            foreach (var cus in customerDb)
            {
                if (cus.CustomerId.Equals(customer.CustomerId))
                {

                    isUnique = false;
                    MessageBox.Show("Please change UNIQ ID and Mobile number");
                    break;
                }
               

            }

            if (isUnique)
            {
                db.Customers.Add(customer);
                int rowAffected = db.SaveChanges();
                if (rowAffected == 1)
                {
                    MessageBox.Show("Customer Saved.....");
                }
                this.Hide();
            }
           

            

            #endregion


        }
    }
}
