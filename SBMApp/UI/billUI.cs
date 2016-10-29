using SBMApp.MODELS;
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

namespace SBMApp.UI
{

    public partial class billUI : Form
    {
        CashMemoManager aCashMemoManager = new CashMemoManager();
        long totalPrice=0;
        long toalQuantity;
        public billUI()
        {
            InitializeComponent();
            

        }

        private void billUI_Load(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {


        }

        private int ClculateTotalPriceFromDataGridView()
        {
            return 1;
        }

        private void addProductButton_Click(object sender, EventArgs e)
        {
            
            
            if (productPriceTextBox.Text != "" && productQuantityTextBox.Text != "" && productNameTextBox.Text != "")
            {
                Product aProduct = aCashMemoManager.GetProductByName("4 inch");
                if (aProduct != null)
                {
                    int n = cashMemoDataGridView.Rows.Add();
                    cashMemoDataGridView.Rows[n].Cells[0].Value = 1;
                    cashMemoDataGridView.Rows[n].Cells[1].Value = aProduct.Name;
                    cashMemoDataGridView.Rows[n].Cells[2].Value = productQuantityTextBox.Text;
                    cashMemoDataGridView.Rows[n].Cells[3].Value = (Convert.ToInt32(productPriceTextBox.Text) * Convert.ToSingle(productQuantityTextBox.Text)).ToString();
                    totalPrice = (long) Convert.ToSingle(cashMemoDataGridView.Rows[n].Cells[3].Value);
                }

               

            }
            else
            {
                MessageBox.Show("Please Fill Up All Information");
            }

        }

        private bool CheckCustomerValidity()
        {
            CustomerManager aCustomerManager= new CustomerManager();
            return aCustomerManager.IsCutomerExists(customerIdTextBox.Text);

        }

        private Customer GetCustomer(string id)
        { 
            CustomerManager aCustomerManager= new CustomerManager();
            Customer aCustomer = aCustomerManager.getCustomerById();
            return aCustomer;
        }

        private void saveCashMemoData_Click(object sender, EventArgs e)
        {
            
            string mobileNumber=customerMobileNumberTextBox.Text;
            
            Customer aCustomer = GetCustomer(customerIdTextBox.Text);
            if (aCustomer != null)
            {

            }
        }
    }
}
