using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SBMApp.MODELS;

namespace SBMApp.UI
{
    public partial class AddProduct : MetroFramework.Forms.MetroForm
    {
        public AddProduct()
        {
            InitializeComponent();
        }

        public string SelectedRadioButton()
        {
            if (KgRadioButton.Checked) return "KG";
            if (PiceRadioButton.Checked) return "PICE";
            if (feetRadioButton.Checked) return "FEET";
            else
            {
                return "no";
            }
        }

        private void addProductButton_Click(object sender, EventArgs e)
        {
           Product aProduct= new Product();
            aProduct.Name = ProductNameComboBox.SelectedValue.ToString();
            if (SelectedRadioButton().Equals("no"))
            {
                MessageBox.Show("Please select UNIT..!!");
            }
            else
            {
                aProduct.Unit = SelectedRadioButton();

            }
            aProduct.Quantity = Convert.ToSingle(amountTextBox.Text);
            aProduct.BuyingPrice =
                
            //float  = Convert.ToSingle(totalPriceTextBox.Text);
            
                buyingPrice.Text = (aProduct.Quantity/);

        }
    }
}
