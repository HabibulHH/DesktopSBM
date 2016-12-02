using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SBMApp.BLL;
using SBMApp.MODELS;

namespace SBMApp.UI
{
    public partial class CustomerRegistrationUI : Form
    {
        CustomerManager aCustomerManager = new CustomerManager();
        public CustomerRegistrationUI()
        {
            InitializeComponent();
        }

        private bool CheckInput()
        {
            if (CustoerBalanceTextBox.Text.Equals("") || CustomerNameTextBox.Text.Equals("")||MobileNumberTextBox.Text.Equals(""))
            {
                return true;
            }
            return false;
        }

        private void CustomerCreateButton_Click(object sender, EventArgs e)
        {
            if (this.CheckInput())
            {
                Customer aCustomer = new Customer();

                aCustomer.Name = CustomerNameTextBox.Text;
                aCustomer.Balance = Convert.ToSingle(CustoerBalanceTextBox.Text);
                aCustomer.Region = CustomerRegionComboBox.Text;
                aCustomer.OpeningDate = DateTime.Now;
                aCustomer.AccountReceivable = Convert.ToSingle(arTextBox.Text);
                aCustomer.TotalBuyingAmount = 0.00;
                aCustomer.MobileNumber = MobileNumberTextBox.Text;
                aCustomer.SL = customerSlText.Text;
                bool isSaved = aCustomerManager.AddCustomer(aCustomer);
                if (isSaved)
                    MessageBox.Show("Saved");
                else
                {
                    MessageBox.Show("Not saved");
                }
            }
           

        }
    }
}
