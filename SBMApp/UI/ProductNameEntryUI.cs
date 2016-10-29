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
    public partial class ProductNameEntryUI : Form
    {
        public ProductNameEntryUI()
        {
            InitializeComponent();
        }

        private string getRadioButton()
        {
            string nameOfRadio = string.Empty;
            if (feetRadioButton.Checked) nameOfRadio = "FEET";
            else if (piceRadioButton.Checked) nameOfRadio = "PICE";
            else if (kgRadioButton.Checked) nameOfRadio = "KG";
            else
            {
                return "Please select A UNIT";
            }
            return nameOfRadio;
        }

        private void productSavebutton_Click(object sender, EventArgs e)
        {
            ProductEntryManager entryManager= new ProductEntryManager();
            string productName = productNameTextBox.Text;
            string unit = getRadioButton();
            if (unit.Equals("Please select A UNIT"))
            {
                MessageBox.Show("Please select A UNIT");
            }
            else
            {
                if (entryManager.AddProduct(productName,unit))
                {
                    MessageBox.Show("Added sussefully");
                }
            }
         
        }
    }
}
