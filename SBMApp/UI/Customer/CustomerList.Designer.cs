namespace SBMApp.UI
{
    partial class CustomerList
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
            this.metroGrid1 = new MetroFramework.Controls.MetroGrid();
            this.Column1 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Payment = new MetroFramework.Controls.MetroButton();
            this.refreshButton = new MetroFramework.Controls.MetroButton();
            this.custometEntryButton = new MetroFramework.Controls.MetroButton();
            this.PaymentHistory = new MetroFramework.Controls.MetroButton();
            this.customerBuyingEntry = new MetroFramework.Controls.MetroButton();
            this.buyinHistoryButton = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid1)).BeginInit();
            this.SuspendLayout();
            // 
            // metroGrid1
            // 
            this.metroGrid1.AllowUserToResizeRows = false;
            this.metroGrid1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGrid1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.metroGrid1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.metroGrid1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGrid1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.metroGrid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.metroGrid1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.metroGrid1.DefaultCellStyle = dataGridViewCellStyle2;
            this.metroGrid1.EnableHeadersVisualStyles = false;
            this.metroGrid1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.metroGrid1.GridColor = System.Drawing.Color.LimeGreen;
            this.metroGrid1.Location = new System.Drawing.Point(23, 83);
            this.metroGrid1.Name = "metroGrid1";
            this.metroGrid1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGrid1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.metroGrid1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.metroGrid1.RowTemplate.Height = 24;
            this.metroGrid1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.metroGrid1.Size = new System.Drawing.Size(827, 331);
            this.metroGrid1.TabIndex = 0;
            this.metroGrid1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.metroGrid1_CellContentClick);
            this.metroGrid1.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.metroGrid1_CellFormatting);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "remove";
            this.Column1.Name = "Column1";
            // 
            // Payment
            // 
            this.Payment.Location = new System.Drawing.Point(335, 18);
            this.Payment.Name = "Payment";
            this.Payment.Size = new System.Drawing.Size(120, 23);
            this.Payment.TabIndex = 1;
            this.Payment.Text = "Payment";
            this.Payment.UseSelectable = true;
            this.Payment.Click += new System.EventHandler(this.Payment_Click);
            // 
            // refreshButton
            // 
            this.refreshButton.Location = new System.Drawing.Point(202, 18);
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.Size = new System.Drawing.Size(120, 23);
            this.refreshButton.TabIndex = 2;
            this.refreshButton.Text = "refresh";
            this.refreshButton.UseSelectable = true;
            this.refreshButton.Click += new System.EventHandler(this.refreshButton_Click);
            // 
            // custometEntryButton
            // 
            this.custometEntryButton.Location = new System.Drawing.Point(202, 47);
            this.custometEntryButton.Name = "custometEntryButton";
            this.custometEntryButton.Size = new System.Drawing.Size(120, 23);
            this.custometEntryButton.TabIndex = 3;
            this.custometEntryButton.Text = "Customer Entry";
            this.custometEntryButton.UseSelectable = true;
            this.custometEntryButton.Click += new System.EventHandler(this.custometEntryButton_Click);
            // 
            // PaymentHistory
            // 
            this.PaymentHistory.Location = new System.Drawing.Point(335, 47);
            this.PaymentHistory.Name = "PaymentHistory";
            this.PaymentHistory.Size = new System.Drawing.Size(120, 23);
            this.PaymentHistory.TabIndex = 4;
            this.PaymentHistory.Text = "Payment History";
            this.PaymentHistory.UseSelectable = true;
            this.PaymentHistory.Click += new System.EventHandler(this.PaymentHistory_Click);
            // 
            // customerBuyingEntry
            // 
            this.customerBuyingEntry.Location = new System.Drawing.Point(510, 18);
            this.customerBuyingEntry.Name = "customerBuyingEntry";
            this.customerBuyingEntry.Size = new System.Drawing.Size(109, 23);
            this.customerBuyingEntry.TabIndex = 5;
            this.customerBuyingEntry.Text = "Buying Entry";
            this.customerBuyingEntry.UseSelectable = true;
            this.customerBuyingEntry.Click += new System.EventHandler(this.customerBuyingEntry_Click);
            // 
            // buyinHistoryButton
            // 
            this.buyinHistoryButton.Location = new System.Drawing.Point(510, 46);
            this.buyinHistoryButton.Name = "buyinHistoryButton";
            this.buyinHistoryButton.Size = new System.Drawing.Size(109, 23);
            this.buyinHistoryButton.TabIndex = 6;
            this.buyinHistoryButton.Text = "Buying History";
            this.buyinHistoryButton.UseSelectable = true;
            this.buyinHistoryButton.Click += new System.EventHandler(this.buyinHistoryButton_Click);
            // 
            // CustomerList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(944, 377);
            this.Controls.Add(this.buyinHistoryButton);
            this.Controls.Add(this.customerBuyingEntry);
            this.Controls.Add(this.PaymentHistory);
            this.Controls.Add(this.custometEntryButton);
            this.Controls.Add(this.refreshButton);
            this.Controls.Add(this.Payment);
            this.Controls.Add(this.metroGrid1);
            this.Name = "CustomerList";
            this.Text = "CustomerList";
            this.Load += new System.EventHandler(this.CustomerList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroGrid metroGrid1;
        private System.Windows.Forms.DataGridViewButtonColumn Column1;
        private MetroFramework.Controls.MetroButton Payment;
        private MetroFramework.Controls.MetroButton refreshButton;
        private MetroFramework.Controls.MetroButton custometEntryButton;
        private MetroFramework.Controls.MetroButton PaymentHistory;
        private MetroFramework.Controls.MetroButton customerBuyingEntry;
        private MetroFramework.Controls.MetroButton buyinHistoryButton;
    }
}