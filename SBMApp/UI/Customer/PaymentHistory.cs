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

namespace SBMApp.UI
{
    public partial class PaymentHistory : MetroForm
    {
        public PaymentHistory()
        {
            InitializeComponent();
            loadPayment();
        }

        private void  loadPayment()
        {
            CustomerContext db= new CustomerContext();
            var payments= db.Payments.ToList();
            paymentHistoryGrid.DataSource = payments;
        }
    }
}
