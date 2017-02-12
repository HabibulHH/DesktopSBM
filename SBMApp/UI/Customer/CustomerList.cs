using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;
using MetroFramework.Forms;
using SBMApp.Context;
using SBMApp.MODELS;
using SBMApp.UI.Customer;

namespace SBMApp.UI
{
    public partial class CustomerList : MetroForm
    {
        CustomerContext db = new CustomerContext();
        public CustomerList()
        {
            InitializeComponent();
            loadGrid();
        }

        public void loadGrid()
        {
            CustomerContext database = new CustomerContext();
            var customers = database.Customers.ToList();
            metroGrid1.DataSource = customers;
        }
        private void metroGrid1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            metroGrid1.Rows[e.RowIndex].Cells[0].Value = "remove";
        }

        private void metroGrid1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (DialogResult.OK == MessageBox.Show("Confirm Delete..?", "Delete", MessageBoxButtons.OKCancel))
            {
                if (e.ColumnIndex == 0)
                {
                    DataGridViewRow row = this.metroGrid1.SelectedRows[0];
                    var id = row.Cells["Id"].Value;
                    var cus = db.Customers.Find(id);
                    db.Customers.Remove(cus);
                    db.SaveChanges();

                    metroGrid1.DataSource = db.Customers.ToList();
                }
            }
            
        }

        private void Payment_Click(object sender, EventArgs e)
        {
            var  payment=new CustomersPayment();
            payment.Show();
        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            this.loadGrid();
        }

        private void custometEntryButton_Click(object sender, EventArgs e)
        {
            var entry = new CustomerEntry();
            entry.Show();
        }

        private void PaymentHistory_Click(object sender, EventArgs e)
        {
            var history =  new PaymentHistory();
            history.Show();
        }

        private void customerBuyingEntry_Click(object sender, EventArgs e)
        {
            var entry= new BuyingEntry();
            entry.Show();
        }

        private void buyinHistoryButton_Click(object sender, EventArgs e)
        {
            var history= new BuyingHistory();
            history.Show();
        }

        private void CustomerList_Load(object sender, EventArgs e)
        {

        }
    }
}
