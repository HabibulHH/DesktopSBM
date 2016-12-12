namespace SBMApp.UI
{
    partial class AddProduct
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
            this.amountTextBox = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.addProductButton = new MetroFramework.Controls.MetroButton();
            this.ProductNameComboBox = new MetroFramework.Controls.MetroComboBox();
            this.KgRadioButton = new MetroFramework.Controls.MetroRadioButton();
            this.PiceRadioButton = new MetroFramework.Controls.MetroRadioButton();
            this.feetRadioButton = new MetroFramework.Controls.MetroRadioButton();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.totalPriceTextBox = new MetroFramework.Controls.MetroTextBox();
            this.buyingPrice = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.SuspendLayout();
            // 
            // amountTextBox
            // 
            // 
            // 
            // 
            this.amountTextBox.CustomButton.Image = null;
            this.amountTextBox.CustomButton.Location = new System.Drawing.Point(113, 1);
            this.amountTextBox.CustomButton.Name = "";
            this.amountTextBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.amountTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.amountTextBox.CustomButton.TabIndex = 1;
            this.amountTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.amountTextBox.CustomButton.UseSelectable = true;
            this.amountTextBox.CustomButton.Visible = false;
            this.amountTextBox.Lines = new string[0];
            this.amountTextBox.Location = new System.Drawing.Point(358, 134);
            this.amountTextBox.MaxLength = 32767;
            this.amountTextBox.Name = "amountTextBox";
            this.amountTextBox.PasswordChar = '\0';
            this.amountTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.amountTextBox.SelectedText = "";
            this.amountTextBox.SelectionLength = 0;
            this.amountTextBox.SelectionStart = 0;
            this.amountTextBox.ShortcutsEnabled = true;
            this.amountTextBox.Size = new System.Drawing.Size(135, 23);
            this.amountTextBox.TabIndex = 2;
            this.amountTextBox.UseSelectable = true;
            this.amountTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.amountTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(240, 134);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(58, 20);
            this.metroLabel1.TabIndex = 3;
            this.metroLabel1.Text = "Amount";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(199, 88);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(99, 20);
            this.metroLabel2.TabIndex = 4;
            this.metroLabel2.Text = "Product Name";
            // 
            // addProductButton
            // 
            this.addProductButton.BackColor = System.Drawing.Color.LimeGreen;
            this.addProductButton.Location = new System.Drawing.Point(418, 293);
            this.addProductButton.Name = "addProductButton";
            this.addProductButton.Size = new System.Drawing.Size(75, 31);
            this.addProductButton.TabIndex = 5;
            this.addProductButton.Text = "SAVE";
            this.addProductButton.UseSelectable = true;
            this.addProductButton.Click += new System.EventHandler(this.addProductButton_Click);
            // 
            // ProductNameComboBox
            // 
            this.ProductNameComboBox.FormattingEnabled = true;
            this.ProductNameComboBox.ItemHeight = 24;
            this.ProductNameComboBox.Items.AddRange(new object[] {
            "Item 1",
            "Item 2",
            "Item 3"});
            this.ProductNameComboBox.Location = new System.Drawing.Point(358, 88);
            this.ProductNameComboBox.Name = "ProductNameComboBox";
            this.ProductNameComboBox.Size = new System.Drawing.Size(135, 30);
            this.ProductNameComboBox.TabIndex = 6;
            this.ProductNameComboBox.UseSelectable = true;
            // 
            // KgRadioButton
            // 
            this.KgRadioButton.AutoSize = true;
            this.KgRadioButton.Location = new System.Drawing.Point(300, 178);
            this.KgRadioButton.Name = "KgRadioButton";
            this.KgRadioButton.Size = new System.Drawing.Size(41, 17);
            this.KgRadioButton.TabIndex = 7;
            this.KgRadioButton.Text = "KG";
            this.KgRadioButton.UseSelectable = true;
            // 
            // PiceRadioButton
            // 
            this.PiceRadioButton.AutoSize = true;
            this.PiceRadioButton.Location = new System.Drawing.Point(364, 178);
            this.PiceRadioButton.Name = "PiceRadioButton";
            this.PiceRadioButton.Size = new System.Drawing.Size(49, 17);
            this.PiceRadioButton.TabIndex = 8;
            this.PiceRadioButton.Text = "PICE";
            this.PiceRadioButton.UseSelectable = true;
            // 
            // feetRadioButton
            // 
            this.feetRadioButton.AutoSize = true;
            this.feetRadioButton.Location = new System.Drawing.Point(442, 178);
            this.feetRadioButton.Name = "feetRadioButton";
            this.feetRadioButton.Size = new System.Drawing.Size(51, 17);
            this.feetRadioButton.TabIndex = 9;
            this.feetRadioButton.Text = "FEET";
            this.feetRadioButton.UseSelectable = true;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(256, 220);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(74, 20);
            this.metroLabel3.TabIndex = 10;
            this.metroLabel3.Text = "Total Price";
            // 
            // totalPriceTextBox
            // 
            // 
            // 
            // 
            this.totalPriceTextBox.CustomButton.Image = null;
            this.totalPriceTextBox.CustomButton.Location = new System.Drawing.Point(113, 1);
            this.totalPriceTextBox.CustomButton.Name = "";
            this.totalPriceTextBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.totalPriceTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.totalPriceTextBox.CustomButton.TabIndex = 1;
            this.totalPriceTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.totalPriceTextBox.CustomButton.UseSelectable = true;
            this.totalPriceTextBox.CustomButton.Visible = false;
            this.totalPriceTextBox.Lines = new string[0];
            this.totalPriceTextBox.Location = new System.Drawing.Point(358, 216);
            this.totalPriceTextBox.MaxLength = 32767;
            this.totalPriceTextBox.Name = "totalPriceTextBox";
            this.totalPriceTextBox.PasswordChar = '\0';
            this.totalPriceTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.totalPriceTextBox.SelectedText = "";
            this.totalPriceTextBox.SelectionLength = 0;
            this.totalPriceTextBox.SelectionStart = 0;
            this.totalPriceTextBox.ShortcutsEnabled = true;
            this.totalPriceTextBox.Size = new System.Drawing.Size(135, 23);
            this.totalPriceTextBox.TabIndex = 11;
            this.totalPriceTextBox.UseSelectable = true;
            this.totalPriceTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.totalPriceTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // buyingPrice
            // 
            // 
            // 
            // 
            this.buyingPrice.CustomButton.Image = null;
            this.buyingPrice.CustomButton.Location = new System.Drawing.Point(113, 1);
            this.buyingPrice.CustomButton.Name = "";
            this.buyingPrice.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.buyingPrice.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.buyingPrice.CustomButton.TabIndex = 1;
            this.buyingPrice.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.buyingPrice.CustomButton.UseSelectable = true;
            this.buyingPrice.CustomButton.Visible = false;
            this.buyingPrice.Lines = new string[0];
            this.buyingPrice.Location = new System.Drawing.Point(358, 254);
            this.buyingPrice.MaxLength = 32767;
            this.buyingPrice.Name = "buyingPrice";
            this.buyingPrice.PasswordChar = '\0';
            this.buyingPrice.ReadOnly = true;
            this.buyingPrice.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.buyingPrice.SelectedText = "";
            this.buyingPrice.SelectionLength = 0;
            this.buyingPrice.SelectionStart = 0;
            this.buyingPrice.ShortcutsEnabled = true;
            this.buyingPrice.Size = new System.Drawing.Size(135, 23);
            this.buyingPrice.TabIndex = 13;
            this.buyingPrice.UseSelectable = true;
            this.buyingPrice.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.buyingPrice.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(256, 258);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(86, 20);
            this.metroLabel4.TabIndex = 12;
            this.metroLabel4.Text = "Buying Price";
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(520, 258);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(77, 20);
            this.metroLabel5.TabIndex = 14;
            this.metroLabel5.Text = "TK per unit";
            // 
            // AddProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(805, 365);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.buyingPrice);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.totalPriceTextBox);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.feetRadioButton);
            this.Controls.Add(this.PiceRadioButton);
            this.Controls.Add(this.KgRadioButton);
            this.Controls.Add(this.ProductNameComboBox);
            this.Controls.Add(this.addProductButton);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.amountTextBox);
            this.Name = "AddProduct";
            this.Text = "AddProduct";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTextBox amountTextBox;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroButton addProductButton;
        private MetroFramework.Controls.MetroComboBox ProductNameComboBox;
        private MetroFramework.Controls.MetroRadioButton KgRadioButton;
        private MetroFramework.Controls.MetroRadioButton PiceRadioButton;
        private MetroFramework.Controls.MetroRadioButton feetRadioButton;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroTextBox totalPriceTextBox;
        private MetroFramework.Controls.MetroTextBox buyingPrice;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel5;

    }
}