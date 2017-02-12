namespace SBMApp.UI.SellRecords
{
    partial class SalesReport
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.salesRecordGrid = new MetroFramework.Controls.MetroGrid();
            this.monthlyReportButton = new MetroFramework.Controls.MetroButton();
            this.yearlyReportButton = new MetroFramework.Controls.MetroButton();
            this.bymonthOftThisYear = new MetroFramework.Controls.MetroButton();
            this.saleChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.salesRecordGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.saleChart)).BeginInit();
            this.SuspendLayout();
            // 
            // salesRecordGrid
            // 
            this.salesRecordGrid.AllowUserToResizeRows = false;
            this.salesRecordGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.salesRecordGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.salesRecordGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.salesRecordGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.salesRecordGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.salesRecordGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.salesRecordGrid.DefaultCellStyle = dataGridViewCellStyle2;
            this.salesRecordGrid.EnableHeadersVisualStyles = false;
            this.salesRecordGrid.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.salesRecordGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.salesRecordGrid.Location = new System.Drawing.Point(41, 106);
            this.salesRecordGrid.Name = "salesRecordGrid";
            this.salesRecordGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.salesRecordGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.salesRecordGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.salesRecordGrid.RowTemplate.Height = 24;
            this.salesRecordGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.salesRecordGrid.Size = new System.Drawing.Size(656, 183);
            this.salesRecordGrid.TabIndex = 0;
            // 
            // monthlyReportButton
            // 
            this.monthlyReportButton.Location = new System.Drawing.Point(183, 30);
            this.monthlyReportButton.Name = "monthlyReportButton";
            this.monthlyReportButton.Size = new System.Drawing.Size(91, 23);
            this.monthlyReportButton.TabIndex = 1;
            this.monthlyReportButton.Text = "By this month";
            this.monthlyReportButton.UseSelectable = true;
            this.monthlyReportButton.Click += new System.EventHandler(this.monthlyReportButton_Click);
            // 
            // yearlyReportButton
            // 
            this.yearlyReportButton.Location = new System.Drawing.Point(304, 30);
            this.yearlyReportButton.Name = "yearlyReportButton";
            this.yearlyReportButton.Size = new System.Drawing.Size(93, 23);
            this.yearlyReportButton.TabIndex = 2;
            this.yearlyReportButton.Text = "By Year";
            this.yearlyReportButton.UseSelectable = true;
            this.yearlyReportButton.Click += new System.EventHandler(this.yearlyReportButton_Click);
            // 
            // bymonthOftThisYear
            // 
            this.bymonthOftThisYear.Location = new System.Drawing.Point(444, 30);
            this.bymonthOftThisYear.Name = "bymonthOftThisYear";
            this.bymonthOftThisYear.Size = new System.Drawing.Size(149, 23);
            this.bymonthOftThisYear.TabIndex = 3;
            this.bymonthOftThisYear.Text = "By  month of this year";
            this.bymonthOftThisYear.UseSelectable = true;
            this.bymonthOftThisYear.Click += new System.EventHandler(this.bymonthOftThisYear_Click);
            // 
            // saleChart
            // 
            chartArea1.Name = "ChartArea1";
            this.saleChart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.saleChart.Legends.Add(legend1);
            this.saleChart.Location = new System.Drawing.Point(599, 5);
            this.saleChart.Name = "saleChart";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "TotalSale";
            this.saleChart.Series.Add(series1);
            this.saleChart.Size = new System.Drawing.Size(350, 322);
            this.saleChart.TabIndex = 4;
            this.saleChart.Text = "Sales Chart";
            // 
            // SalesReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1069, 350);
            this.Controls.Add(this.saleChart);
            this.Controls.Add(this.bymonthOftThisYear);
            this.Controls.Add(this.yearlyReportButton);
            this.Controls.Add(this.monthlyReportButton);
            this.Controls.Add(this.salesRecordGrid);
            this.Name = "SalesReport";
            this.Text = "Sales Report";
            ((System.ComponentModel.ISupportInitialize)(this.salesRecordGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.saleChart)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroGrid salesRecordGrid;
        private MetroFramework.Controls.MetroButton monthlyReportButton;
        private MetroFramework.Controls.MetroButton yearlyReportButton;
        private MetroFramework.Controls.MetroButton bymonthOftThisYear;
        private System.Windows.Forms.DataVisualization.Charting.Chart saleChart;
    }
}