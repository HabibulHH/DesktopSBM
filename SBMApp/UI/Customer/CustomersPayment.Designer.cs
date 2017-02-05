namespace SBMApp.UI
{
    partial class CustomersPayment
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
            this.CustomerSL = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.amount = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.paymentDate = new MetroFramework.Controls.MetroDateTime();
            this.saveButton = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(104, 111);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(87, 20);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "Customer SL";
            // 
            // CustomerSL
            // 
            // 
            // 
            // 
            this.CustomerSL.CustomButton.Image = null;
            this.CustomerSL.CustomButton.Location = new System.Drawing.Point(178, 1);
            this.CustomerSL.CustomButton.Name = "";
            this.CustomerSL.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.CustomerSL.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.CustomerSL.CustomButton.TabIndex = 1;
            this.CustomerSL.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.CustomerSL.CustomButton.UseSelectable = true;
            this.CustomerSL.CustomButton.Visible = false;
            this.CustomerSL.Lines = new string[0];
            this.CustomerSL.Location = new System.Drawing.Point(231, 108);
            this.CustomerSL.MaxLength = 32767;
            this.CustomerSL.Name = "CustomerSL";
            this.CustomerSL.PasswordChar = '\0';
            this.CustomerSL.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.CustomerSL.SelectedText = "";
            this.CustomerSL.SelectionLength = 0;
            this.CustomerSL.SelectionStart = 0;
            this.CustomerSL.ShortcutsEnabled = true;
            this.CustomerSL.Size = new System.Drawing.Size(200, 23);
            this.CustomerSL.TabIndex = 1;
            this.CustomerSL.UseSelectable = true;
            this.CustomerSL.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.CustomerSL.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(133, 147);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(58, 20);
            this.metroLabel2.TabIndex = 2;
            this.metroLabel2.Text = "Amount";
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
            this.amount.Location = new System.Drawing.Point(231, 141);
            this.amount.MaxLength = 32767;
            this.amount.Name = "amount";
            this.amount.PasswordChar = '\0';
            this.amount.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.amount.SelectedText = "";
            this.amount.SelectionLength = 0;
            this.amount.SelectionStart = 0;
            this.amount.ShortcutsEnabled = true;
            this.amount.Size = new System.Drawing.Size(200, 23);
            this.amount.TabIndex = 3;
            this.amount.UseSelectable = true;
            this.amount.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.amount.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(153, 195);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(38, 20);
            this.metroLabel3.TabIndex = 4;
            this.metroLabel3.Text = "Date";
            // 
            // paymentDate
            // 
            this.paymentDate.Location = new System.Drawing.Point(231, 182);
            this.paymentDate.MinimumSize = new System.Drawing.Size(0, 30);
            this.paymentDate.Name = "paymentDate";
            this.paymentDate.Size = new System.Drawing.Size(200, 30);
            this.paymentDate.TabIndex = 5;
            // 
            // saveButton
            // 
            this.saveButton.BackColor = System.Drawing.Color.Red;
            this.saveButton.ForeColor = System.Drawing.Color.Coral;
            this.saveButton.Location = new System.Drawing.Point(355, 243);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 6;
            this.saveButton.Text = "Save";
            this.saveButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.saveButton.UseSelectable = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // CustomersPayment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(720, 372);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.paymentDate);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.amount);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.CustomerSL);
            this.Controls.Add(this.metroLabel1);
            this.Name = "CustomersPayment";
            this.Text = "CustomersPayment";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox CustomerSL;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox amount;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroDateTime paymentDate;
        private MetroFramework.Controls.MetroButton saveButton;
    }
}