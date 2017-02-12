using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;
using SBMApp.Context;

namespace SBMApp.UI.SellRecords
{
    public partial class SalesReport : MetroForm
    {
        public SalesReport()
        {
            InitializeComponent();
            Load();
        }

        private void Load()
        {
            CustomerContext db= new CustomerContext();
            var rec = db.Records.OrderByDescending(a=>a.Date.Day).ToList();
            salesRecordGrid.DataSource = rec;
        }

        private void monthlyReportButton_Click(object sender, EventArgs e)
        {
            DateTime date = DateTime.Now;
            int month = date.Month;
            CustomerContext db= new CustomerContext();
            var data = db.Records.Where(a => a.Date.Month.Equals(month)).ToList();
            salesRecordGrid.DataSource = data;
            float total=0;
            float totalonCash=0;
            float onDue=0;
            float collection=0;
            foreach (var itm in data)
            {
                total += itm.TotalSell;
                totalonCash += itm.SellOnCash;
                onDue += itm.SellsOnDue;
                collection += itm.Collection;
            }

            MessageBox.Show("Total: " + total.ToString() + "\nOn cash: " + totalonCash.ToString() + "\non Due: " +
                            onDue.ToString() + "\nCollection : " + collection.ToString());
            ;
        }

        private void yearlyReportButton_Click(object sender, EventArgs e)
        {

            CustomerContext db = new CustomerContext();

            var listOFrec = db.Records.GroupBy(a => a.Date.Year).Select(g => new
            {
                Year = g.Key,
                Total = g.Sum(i => i.TotalSell),
                OnCash = g.Sum(i => i.SellOnCash),
                OnDue = g.Sum(i => i.SellsOnDue),
                Collection=g.Sum(i=>i.Collection)

            }).ToList();

            salesRecordGrid.DataSource = listOFrec;
            //foreach (var item in listOFrec)
            //{
            //    saleChart.Series["TotalSale"].Points.AddXY(item.Year, item.Total);
            ////}
        }

        private void bymonthOftThisYear_Click(object sender, EventArgs e)
        {
            CustomerContext db = new CustomerContext();

            var listOFrec = db.Records.GroupBy(a => a.Date.Month).OrderByDescending(a=>a.Key).Select(g => new
            {
                Month = g.Key,
                Total = g.Sum(i => i.TotalSell),
                OnCash = g.Sum(i => i.SellOnCash),
                OnDue = g.Sum(i => i.SellsOnDue),
                Collection = g.Sum(i => i.Collection)

            }).ToList();

            salesRecordGrid.DataSource = listOFrec;
            var rec = db.Records.GroupBy(a => a.Date.Month).OrderByDescending(a => a.Key).Select(g => new
            {
                Month = g.Key,
                Total = g.Sum(i => i.TotalSell),
              

            }).ToList();
           // saleChart.DataSource = rec;
            //saleChart.Series["TotalSale"].XValueMember = "Month";
            //saleChart.Series["TotalSale"].XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int32;
            //saleChart.Series["TotalSale"].YValueMembers = "Sales";
            //saleChart.Series["TotalSale"].YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Single;
            foreach (var item in rec)
            {
                saleChart.Series["TotalSale"].Points.AddXY(item.Month, item.Total);
            }
            

        }
        
        
    }
}
