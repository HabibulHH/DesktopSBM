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

namespace SBMApp.UI.SellRecords
{
    public partial class DailySalesRec : MetroForm
    {
        public DailySalesRec()
        {
            InitializeComponent();
        }

        private void saveRec_Click(object sender, EventArgs e)
        {
            if (recDate.Value.Equals(null) || totalSales.Text.Equals(" ") ||
                onCashSale.Text.Equals(" ") && ondDueSale.Text.Equals(" "))
            {
                MessageBox.Show("Please Fill all input box");
            }
            else
            {
                SellsRecord aSellsRecord= new SellsRecord()
                {
                     Date = recDate.Value,
                     TotalSell = Convert.ToSingle(totalSales.Text),
                     SellOnCash = Convert.ToSingle(onCashSale.Text),
                     SellsOnDue = Convert.ToSingle(ondDueSale.Text),
                     Collection = Convert.ToSingle(collection.Text)

                };
                if (aSellsRecord.TotalSell == aSellsRecord.SellOnCash + aSellsRecord.SellsOnDue)
                {
                    CustomerContext db = new CustomerContext();
                    db.Records.Add(aSellsRecord);
                    int rowAffected = db.SaveChanges();
                    if (rowAffected > 0)
                    {
                        MessageBox.Show("Saved...");
                        onCashSale.Text = ondDueSale.Text = collection.Text = totalSales.Text = String.Empty;
                    }
                    else
                    {
                        MessageBox.Show("Save failed");
                    }
                }
                else
                {
                    MessageBox.Show("Please check calculation ");
                }

            }

        }
    }
}
