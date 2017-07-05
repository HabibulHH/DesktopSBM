namespace SBMApp.UI
{
    partial class HOME
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
            this.CustomerControlButton = new MetroFramework.Controls.MetroButton();
            this.recordControlButton = new MetroFramework.Controls.MetroButton();
            this.salesReport = new MetroFramework.Controls.MetroButton();
            this.ExpenseEntry = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // CustomerControlButton
            // 
            this.CustomerControlButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.CustomerControlButton.Location = new System.Drawing.Point(101, 114);
            this.CustomerControlButton.Name = "CustomerControlButton";
            this.CustomerControlButton.Size = new System.Drawing.Size(155, 103);
            this.CustomerControlButton.TabIndex = 0;
            this.CustomerControlButton.Text = "Customer Control";
            this.CustomerControlButton.UseSelectable = true;
            this.CustomerControlButton.Click += new System.EventHandler(this.CustomerControlButton_Click);
            // 
            // recordControlButton
            // 
            this.recordControlButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.recordControlButton.Location = new System.Drawing.Point(306, 114);
            this.recordControlButton.Name = "recordControlButton";
            this.recordControlButton.Size = new System.Drawing.Size(155, 103);
            this.recordControlButton.TabIndex = 1;
            this.recordControlButton.Text = "Sales Rec";
            this.recordControlButton.UseSelectable = true;
            this.recordControlButton.Click += new System.EventHandler(this.recordControlButton_Click);
            // 
            // salesReport
            // 
            this.salesReport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.salesReport.Location = new System.Drawing.Point(508, 114);
            this.salesReport.Name = "salesReport";
            this.salesReport.Size = new System.Drawing.Size(155, 103);
            this.salesReport.TabIndex = 2;
            this.salesReport.Text = "Sales Report";
            this.salesReport.UseSelectable = true;
            this.salesReport.Click += new System.EventHandler(this.salesReport_Click);
            // 
            // ExpenseEntry
            // 
            this.ExpenseEntry.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ExpenseEntry.Location = new System.Drawing.Point(101, 254);
            this.ExpenseEntry.Name = "ExpenseEntry";
            this.ExpenseEntry.Size = new System.Drawing.Size(155, 103);
            this.ExpenseEntry.TabIndex = 3;
            this.ExpenseEntry.Text = "Expense Entry";
            this.ExpenseEntry.UseSelectable = true;
            // 
            // HOME
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(768, 389);
            this.Controls.Add(this.ExpenseEntry);
            this.Controls.Add(this.salesReport);
            this.Controls.Add(this.recordControlButton);
            this.Controls.Add(this.CustomerControlButton);
            this.Name = "HOME";
            this.Text = "HOME";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroButton CustomerControlButton;
        private MetroFramework.Controls.MetroButton recordControlButton;
        private MetroFramework.Controls.MetroButton salesReport;
        private MetroFramework.Controls.MetroButton ExpenseEntry;
    }
}