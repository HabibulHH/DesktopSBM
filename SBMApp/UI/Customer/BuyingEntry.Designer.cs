namespace SBMApp.UI.Customer
{
    partial class BuyingEntry
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
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.CustomerID = new MetroFramework.Controls.MetroTextBox();
            this.amount = new MetroFramework.Controls.MetroTextBox();
            this.buyingDateTime = new MetroFramework.Controls.MetroDateTime();
            this.BuyingRecEntryButton = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(94, 88);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(86, 20);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "Customer ID";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(122, 118);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(58, 20);
            this.metroLabel2.TabIndex = 1;
            this.metroLabel2.Text = "Amount";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(142, 157);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(38, 20);
            this.metroLabel3.TabIndex = 2;
            this.metroLabel3.Text = "Date";
            // 
            // CustomerID
            // 
            // 
            // 
            // 
            this.CustomerID.CustomButton.Image = null;
            this.CustomerID.CustomButton.Location = new System.Drawing.Point(178, 1);
            this.CustomerID.CustomButton.Name = "";
            this.CustomerID.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.CustomerID.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.CustomerID.CustomButton.TabIndex = 1;
            this.CustomerID.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.CustomerID.CustomButton.UseSelectable = true;
            this.CustomerID.CustomButton.Visible = false;
            this.CustomerID.Lines = new string[0];
            this.CustomerID.Location = new System.Drawing.Point(239, 84);
            this.CustomerID.MaxLength = 32767;
            this.CustomerID.Name = "CustomerID";
            this.CustomerID.PasswordChar = '\0';
            this.CustomerID.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.CustomerID.SelectedText = "";
            this.CustomerID.SelectionLength = 0;
            this.CustomerID.SelectionStart = 0;
            this.CustomerID.ShortcutsEnabled = true;
            this.CustomerID.Size = new System.Drawing.Size(200, 23);
            this.CustomerID.TabIndex = 3;
            this.CustomerID.UseSelectable = true;
            this.CustomerID.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.CustomerID.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // amount
            // 
            // 
            // 
            // 
            this.amount.CustomButton.Image = null;
            this.amount.CustomButton.Location = new System.Drawing.Point(178, 1);
            this.amount.CustomButton.Name = "";
            this.amount.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.amount.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.amount.CustomButton.TabIndex = 1;
            this.amount.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.amount.CustomButton.UseSelectable = true;
            this.amount.CustomButton.Visible = false;
            this.amount.Lines = new string[0];
            this.amount.Location = new System.Drawing.Point(239, 118);
            this.amount.MaxLength = 32767;
            this.amount.Name = "amount";
            this.amount.PasswordChar = '\0';
            this.amount.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.amount.SelectedText = "";
            this.amount.SelectionLength = 0;
            this.amount.SelectionStart = 0;
            this.amount.ShortcutsEnabled = true;
            this.amount.Size = new System.Drawing.Size(200, 23);
            this.amount.TabIndex = 4;
            this.amount.UseSelectable = true;
            this.amount.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.amount.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // buyingDateTime
            // 
            this.buyingDateTime.Location = new System.Drawing.Point(239, 154);
            this.buyingDateTime.MinimumSize = new System.Drawing.Size(0, 30);
            this.buyingDateTime.Name = "buyingDateTime";
            this.buyingDateTime.Size = new System.Drawing.Size(200, 30);
            this.buyingDateTime.TabIndex = 5;
            // 
            // BuyingRecEntryButton
            // 
            this.BuyingRecEntryButton.Location = new System.Drawing.Point(364, 202);
            this.BuyingRecEntryButton.Name = "BuyingRecEntryButton";
            this.BuyingRecEntryButton.Size = new System.Drawing.Size(75, 23);
            this.BuyingRecEntryButton.TabIndex = 6;
            this.BuyingRecEntryButton.Text = "SAVE";
            this.BuyingRecEntryButton.UseSelectable = true;
            this.BuyingRecEntryButton.Click += new System.EventHandler(this.BuyingRecEntryButton_Click);
            // 
            // BuyingEntry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(552, 300);
            this.Controls.Add(this.BuyingRecEntryButton);
            this.Controls.Add(this.buyingDateTime);
            this.Controls.Add(this.amount);
            this.Controls.Add(this.CustomerID);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Name = "BuyingEntry";
            this.Text = "BuyingEntry";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroTextBox CustomerID;
        private MetroFramework.Controls.MetroTextBox amount;
        private MetroFramework.Controls.MetroDateTime buyingDateTime;
        private MetroFramework.Controls.MetroButton BuyingRecEntryButton;
    }
}