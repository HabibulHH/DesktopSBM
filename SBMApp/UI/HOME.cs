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
using SBMApp.UI.SellRecords;

namespace SBMApp.UI
{
    public partial class HOME : MetroForm
    {
        public HOME()
        {
            InitializeComponent();
        }

        private void recordControlButton_Click(object sender, EventArgs e)
        {
            DailySalesRec salesRec = new DailySalesRec();
            salesRec.Show();
        }

        private void CustomerControlButton_Click(object sender, EventArgs e)
        {
            CustomerList aCustomerList= new CustomerList();
            aCustomerList.Show();
        }

        private void salesReport_Click(object sender, EventArgs e)
        {
            SalesReport aneSalesReport = new SalesReport();
            aneSalesReport.Show();
        }
    }
}
