
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SBMApp.UI
{

    public partial class billUI : Form
    {
        
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
            
        }

        private bool CheckCustomerValidity()
        {
            return true;

        }

       
    }
}
