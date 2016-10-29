namespace SBMApp.UI
{
    partial class billUI
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
            this.label1 = new System.Windows.Forms.Label();
            this.productNameTextBox = new System.Windows.Forms.TextBox();
            this.productPriceTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.productQuantityTextBox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.priceRadioButton = new System.Windows.Forms.RadioButton();
            this.unitRadioButton = new System.Windows.Forms.RadioButton();
            this.addProductButton = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.billCreatingDateTime = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.customerMobileNumberTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.customerIdTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cashMemoDataGridView = new System.Windows.Forms.DataGridView();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.saveCashMemoData = new System.Windows.Forms.Button();
            this.SL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CashAmountTextBox = new System.Windows.Forms.TextBox();
            this.totalBillTextbox = new System.Windows.Forms.TextBox();
            this.dueAmountTextBox = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cashMemoDataGridView)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(191, 48);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "NAME";
            // 
            // productNameTextBox
            // 
            this.productNameTextBox.Location = new System.Drawing.Point(273, 48);
            this.productNameTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.productNameTextBox.Name = "productNameTextBox";
            this.productNameTextBox.Size = new System.Drawing.Size(132, 28);
            this.productNameTextBox.TabIndex = 2;
            // 
            // productPriceTextBox
            // 
            this.productPriceTextBox.Location = new System.Drawing.Point(273, 89);
            this.productPriceTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.productPriceTextBox.Name = "productPriceTextBox";
            this.productPriceTextBox.Size = new System.Drawing.Size(132, 28);
            this.productPriceTextBox.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(205, 90);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 23);
            this.label2.TabIndex = 4;
            this.label2.Text = "Price";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(175, 133);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 23);
            this.label3.TabIndex = 5;
            this.label3.Text = "Quantity";
            // 
            // productQuantityTextBox
            // 
            this.productQuantityTextBox.Location = new System.Drawing.Point(273, 128);
            this.productQuantityTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.productQuantityTextBox.Name = "productQuantityTextBox";
            this.productQuantityTextBox.Size = new System.Drawing.Size(132, 28);
            this.productQuantityTextBox.TabIndex = 6;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.priceRadioButton);
            this.groupBox1.Controls.Add(this.unitRadioButton);
            this.groupBox1.Controls.Add(this.addProductButton);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.productQuantityTextBox);
            this.groupBox1.Controls.Add(this.productNameTextBox);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.productPriceTextBox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(32, 15);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(432, 227);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add Product";
            // 
            // priceRadioButton
            // 
            this.priceRadioButton.AutoSize = true;
            this.priceRadioButton.Location = new System.Drawing.Point(337, 162);
            this.priceRadioButton.Name = "priceRadioButton";
            this.priceRadioButton.Size = new System.Drawing.Size(73, 24);
            this.priceRadioButton.TabIndex = 10;
            this.priceRadioButton.TabStop = true;
            this.priceRadioButton.Text = "PIECE";
            this.priceRadioButton.UseVisualStyleBackColor = true;
            // 
            // unitRadioButton
            // 
            this.unitRadioButton.AutoSize = true;
            this.unitRadioButton.Location = new System.Drawing.Point(282, 162);
            this.unitRadioButton.Name = "unitRadioButton";
            this.unitRadioButton.Size = new System.Drawing.Size(52, 24);
            this.unitRadioButton.TabIndex = 9;
            this.unitRadioButton.TabStop = true;
            this.unitRadioButton.Text = "KG";
            this.unitRadioButton.UseVisualStyleBackColor = true;
            // 
            // addProductButton
            // 
            this.addProductButton.BackColor = System.Drawing.Color.LimeGreen;
            this.addProductButton.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addProductButton.Location = new System.Drawing.Point(305, 190);
            this.addProductButton.Margin = new System.Windows.Forms.Padding(4);
            this.addProductButton.Name = "addProductButton";
            this.addProductButton.Size = new System.Drawing.Size(100, 32);
            this.addProductButton.TabIndex = 7;
            this.addProductButton.Text = "Add Product";
            this.addProductButton.UseVisualStyleBackColor = false;
            this.addProductButton.Click += new System.EventHandler(this.addProductButton_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.billCreatingDateTime);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.customerMobileNumberTextBox);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.customerIdTextBox);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(32, 296);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox3.Size = new System.Drawing.Size(432, 223);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Add Customer";
            // 
            // billCreatingDateTime
            // 
            this.billCreatingDateTime.Location = new System.Drawing.Point(149, 127);
            this.billCreatingDateTime.Margin = new System.Windows.Forms.Padding(4);
            this.billCreatingDateTime.Name = "billCreatingDateTime";
            this.billCreatingDateTime.Size = new System.Drawing.Size(265, 30);
            this.billCreatingDateTime.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(66, 134);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 23);
            this.label6.TabIndex = 4;
            this.label6.Text = "Date";
            // 
            // customerMobileNumberTextBox
            // 
            this.customerMobileNumberTextBox.Location = new System.Drawing.Point(149, 79);
            this.customerMobileNumberTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.customerMobileNumberTextBox.Name = "customerMobileNumberTextBox";
            this.customerMobileNumberTextBox.Size = new System.Drawing.Size(265, 30);
            this.customerMobileNumberTextBox.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(8, 82);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(130, 23);
            this.label5.TabIndex = 2;
            this.label5.Text = "Mobile Number";
            // 
            // customerIdTextBox
            // 
            this.customerIdTextBox.Location = new System.Drawing.Point(149, 37);
            this.customerIdTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.customerIdTextBox.Name = "customerIdTextBox";
            this.customerIdTextBox.Size = new System.Drawing.Size(265, 30);
            this.customerIdTextBox.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(83, 37);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 23);
            this.label4.TabIndex = 0;
            this.label4.Text = "ID";
            // 
            // cashMemoDataGridView
            // 
            this.cashMemoDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.cashMemoDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SL,
            this.ProductName,
            this.Quantity,
            this.Total});
            this.cashMemoDataGridView.Location = new System.Drawing.Point(287, 14);
            this.cashMemoDataGridView.Margin = new System.Windows.Forms.Padding(4);
            this.cashMemoDataGridView.Name = "cashMemoDataGridView";
            this.cashMemoDataGridView.Size = new System.Drawing.Size(448, 531);
            this.cashMemoDataGridView.TabIndex = 10;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(1428, 480);
            this.textBox6.Margin = new System.Windows.Forms.Padding(4);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(192, 22);
            this.textBox6.TabIndex = 12;
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(1428, 512);
            this.textBox7.Margin = new System.Windows.Forms.Padding(4);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(192, 22);
            this.textBox7.TabIndex = 13;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(1348, 550);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(27, 17);
            this.label9.TabIndex = 15;
            this.label9.Text = "AR";
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(1428, 544);
            this.textBox8.Margin = new System.Windows.Forms.Padding(4);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(192, 22);
            this.textBox8.TabIndex = 16;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.DarkOrange;
            this.button2.Location = new System.Drawing.Point(1521, 576);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 28);
            this.button2.TabIndex = 17;
            this.button2.Text = "Save";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(66, 136);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(41, 23);
            this.label10.TabIndex = 24;
            this.label10.Text = "Due";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(58, 89);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 23);
            this.label8.TabIndex = 23;
            this.label8.Text = "Cash";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(57, 56);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 23);
            this.label7.TabIndex = 22;
            this.label7.Text = "Total";
            // 
            // saveCashMemoData
            // 
            this.saveCashMemoData.BackColor = System.Drawing.Color.LimeGreen;
            this.saveCashMemoData.ForeColor = System.Drawing.SystemColors.ControlText;
            this.saveCashMemoData.Location = new System.Drawing.Point(188, 198);
            this.saveCashMemoData.Name = "saveCashMemoData";
            this.saveCashMemoData.Size = new System.Drawing.Size(75, 32);
            this.saveCashMemoData.TabIndex = 28;
            this.saveCashMemoData.Text = "SAVE ";
            this.saveCashMemoData.UseVisualStyleBackColor = false;
            this.saveCashMemoData.Click += new System.EventHandler(this.saveCashMemoData_Click);
            // 
            // SL
            // 
            this.SL.HeaderText = "SL";
            this.SL.Name = "SL";
            // 
            // ProductName
            // 
            this.ProductName.HeaderText = "Product Name";
            this.ProductName.Name = "ProductName";
            // 
            // Quantity
            // 
            this.Quantity.HeaderText = "Quantity";
            this.Quantity.Name = "Quantity";
            // 
            // Total
            // 
            this.Total.HeaderText = "Total";
            this.Total.Name = "Total";
            // 
            // CashAmountTextBox
            // 
            this.CashAmountTextBox.Location = new System.Drawing.Point(163, 89);
            this.CashAmountTextBox.Name = "CashAmountTextBox";
            this.CashAmountTextBox.Size = new System.Drawing.Size(100, 30);
            this.CashAmountTextBox.TabIndex = 29;
            // 
            // totalBillTextbox
            // 
            this.totalBillTextbox.Location = new System.Drawing.Point(163, 44);
            this.totalBillTextbox.Name = "totalBillTextbox";
            this.totalBillTextbox.Size = new System.Drawing.Size(100, 30);
            this.totalBillTextbox.TabIndex = 30;
            // 
            // dueAmountTextBox
            // 
            this.dueAmountTextBox.Location = new System.Drawing.Point(163, 128);
            this.dueAmountTextBox.Name = "dueAmountTextBox";
            this.dueAmountTextBox.ReadOnly = true;
            this.dueAmountTextBox.Size = new System.Drawing.Size(100, 30);
            this.dueAmountTextBox.TabIndex = 31;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Khaki;
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.dueAmountTextBox);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.totalBillTextbox);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.CashAmountTextBox);
            this.groupBox2.Controls.Add(this.saveCashMemoData);
            this.groupBox2.Controls.Add(this.cashMemoDataGridView);
            this.groupBox2.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(492, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(738, 508);
            this.groupBox2.TabIndex = 32;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Cash Memo";
            // 
            // billUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Khaki;
            this.ClientSize = new System.Drawing.Size(1370, 532);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBox8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "billUI";
            this.Text = "billUI";
            this.Load += new System.EventHandler(this.billUI_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cashMemoDataGridView)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox productNameTextBox;
        private System.Windows.Forms.TextBox productPriceTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox productQuantityTextBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button addProductButton;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox customerIdTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker billCreatingDateTime;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox customerMobileNumberTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView cashMemoDataGridView;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.RadioButton priceRadioButton;
        private System.Windows.Forms.RadioButton unitRadioButton;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button saveCashMemoData;
        private System.Windows.Forms.DataGridViewTextBoxColumn SL;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
        private System.Windows.Forms.TextBox CashAmountTextBox;
        private System.Windows.Forms.TextBox totalBillTextbox;
        private System.Windows.Forms.TextBox dueAmountTextBox;
        private System.Windows.Forms.GroupBox groupBox2;

    }
}