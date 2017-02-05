namespace SBMApp.UI.Customer
{
    partial class BuyingHistory
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.buyingRecGrid = new MetroFramework.Controls.MetroGrid();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.startDate = new MetroFramework.Controls.MetroDateTime();
            this.endDate = new MetroFramework.Controls.MetroDateTime();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.CustomerID = new MetroFramework.Controls.MetroTextBox();
            this.TotalTextBox = new MetroFramework.Controls.MetroLabel();
            this.show = new MetroFramework.Controls.MetroButton();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            ((System.ComponentModel.ISupportInitialize)(this.buyingRecGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // buyingRecGrid
            // 
            this.buyingRecGrid.AllowUserToResizeRows = false;
            this.buyingRecGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.buyingRecGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.buyingRecGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.buyingRecGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.buyingRecGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.buyingRecGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.buyingRecGrid.DefaultCellStyle = dataGridViewCellStyle5;
            this.buyingRecGrid.EnableHeadersVisualStyles = false;
            this.buyingRecGrid.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.buyingRecGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.buyingRecGrid.Location = new System.Drawing.Point(47, 98);
            this.buyingRecGrid.Name = "buyingRecGrid";
            this.buyingRecGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.buyingRecGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.buyingRecGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.buyingRecGrid.RowTemplate.Height = 24;
            this.buyingRecGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.buyingRecGrid.Size = new System.Drawing.Size(684, 241);
            this.buyingRecGrid.TabIndex = 0;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(211, 29);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(66, 20);
            this.metroLabel1.TabIndex = 1;
            this.metroLabel1.Text = "start date";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(389, 29);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(64, 20);
            this.metroLabel2.TabIndex = 2;
            this.metroLabel2.Text = "end date";
            // 
            // startDate
            // 
            this.startDate.Location = new System.Drawing.Point(211, 52);
            this.startDate.MinimumSize = new System.Drawing.Size(0, 30);
            this.startDate.Name = "startDate";
            this.startDate.Size = new System.Drawing.Size(127, 30);
            this.startDate.TabIndex = 3;
            // 
            // endDate
            // 
            this.endDate.Location = new System.Drawing.Point(389, 52);
            this.endDate.MinimumSize = new System.Drawing.Size(0, 30);
            this.endDate.Name = "endDate";
            this.endDate.Size = new System.Drawing.Size(127, 30);
            this.endDate.TabIndex = 4;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(558, 29);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(84, 20);
            this.metroLabel3.TabIndex = 5;
            this.metroLabel3.Text = "Customer Id";
            // 
            // CustomerID
            // 
            // 
            // 
            // 
            this.CustomerID.CustomButton.Image = null;
            this.CustomerID.CustomButton.Location = new System.Drawing.Point(96, 1);
            this.CustomerID.CustomButton.Name = "";
            this.CustomerID.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.CustomerID.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.CustomerID.CustomButton.TabIndex = 1;
            this.CustomerID.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.CustomerID.CustomButton.UseSelectable = true;
            this.CustomerID.CustomButton.Visible = false;
            this.CustomerID.Lines = new string[0];
            this.CustomerID.Location = new System.Drawing.Point(549, 59);
            this.CustomerID.MaxLength = 32767;
            this.CustomerID.Name = "CustomerID";
            this.CustomerID.PasswordChar = '\0';
            this.CustomerID.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.CustomerID.SelectedText = "";
            this.CustomerID.SelectionLength = 0;
            this.CustomerID.SelectionStart = 0;
            this.CustomerID.ShortcutsEnabled = true;
            this.CustomerID.Size = new System.Drawing.Size(118, 23);
            this.CustomerID.TabIndex = 6;
            this.CustomerID.UseSelectable = true;
            this.CustomerID.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.CustomerID.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.CustomerID.Click += new System.EventHandler(this.CustomerID_Click);
            // 
            // TotalTextBox
            // 
            this.TotalTextBox.AutoSize = true;
            this.TotalTextBox.Location = new System.Drawing.Point(345, 354);
            this.TotalTextBox.Name = "TotalTextBox";
            this.TotalTextBox.Size = new System.Drawing.Size(52, 20);
            this.TotalTextBox.TabIndex = 7;
            this.TotalTextBox.Text = "TOTAL";
            // 
            // show
            // 
            this.show.Location = new System.Drawing.Point(683, 58);
            this.show.Name = "show";
            this.show.Size = new System.Drawing.Size(66, 23);
            this.show.TabIndex = 8;
            this.show.Text = "show";
            this.show.UseSelectable = true;
            this.show.Click += new System.EventHandler(this.show_Click);
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(224, 354);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(86, 20);
            this.metroLabel4.TabIndex = 9;
            this.metroLabel4.Text = "total amount";
            // 
            // BuyingHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(772, 394);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.show);
            this.Controls.Add(this.TotalTextBox);
            this.Controls.Add(this.CustomerID);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.endDate);
            this.Controls.Add(this.startDate);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.buyingRecGrid);
            this.Name = "BuyingHistory";
            this.Text = "BuyingHistory";
            ((System.ComponentModel.ISupportInitialize)(this.buyingRecGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroGrid buyingRecGrid;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroDateTime startDate;
        private MetroFramework.Controls.MetroDateTime endDate;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroTextBox CustomerID;
        private MetroFramework.Controls.MetroLabel TotalTextBox;
        private MetroFramework.Controls.MetroButton show;
        private MetroFramework.Controls.MetroLabel metroLabel4;
    }
}