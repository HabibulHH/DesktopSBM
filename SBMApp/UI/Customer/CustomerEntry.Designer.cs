namespace SBMApp.UI
{
    partial class CustomerEntry
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
            this.name = new MetroFramework.Controls.MetroTextBox();
            this.mobile = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.area = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.uniqid = new MetroFramework.Controls.MetroTextBox();
            this.customerEntryButton = new MetroFramework.Controls.MetroButton();
            this.dueads = new MetroFramework.Controls.MetroLabel();
            this.due = new MetroFramework.Controls.MetroTextBox();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(164, 89);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(47, 20);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "Name";
            // 
            // name
            // 
            // 
            // 
            // 
            this.name.CustomButton.Image = null;
            this.name.CustomButton.Location = new System.Drawing.Point(145, 1);
            this.name.CustomButton.Name = "";
            this.name.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.name.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.name.CustomButton.TabIndex = 1;
            this.name.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.name.CustomButton.UseSelectable = true;
            this.name.CustomButton.Visible = false;
            this.name.Lines = new string[0];
            this.name.Location = new System.Drawing.Point(296, 85);
            this.name.MaxLength = 32767;
            this.name.Name = "name";
            this.name.PasswordChar = '\0';
            this.name.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.name.SelectedText = "";
            this.name.SelectionLength = 0;
            this.name.SelectionStart = 0;
            this.name.ShortcutsEnabled = true;
            this.name.Size = new System.Drawing.Size(167, 23);
            this.name.TabIndex = 1;
            this.name.UseSelectable = true;
            this.name.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.name.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // mobile
            // 
            // 
            // 
            // 
            this.mobile.CustomButton.Image = null;
            this.mobile.CustomButton.Location = new System.Drawing.Point(145, 1);
            this.mobile.CustomButton.Name = "";
            this.mobile.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.mobile.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mobile.CustomButton.TabIndex = 1;
            this.mobile.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mobile.CustomButton.UseSelectable = true;
            this.mobile.CustomButton.Visible = false;
            this.mobile.Lines = new string[0];
            this.mobile.Location = new System.Drawing.Point(296, 137);
            this.mobile.MaxLength = 32767;
            this.mobile.Name = "mobile";
            this.mobile.PasswordChar = '\0';
            this.mobile.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mobile.SelectedText = "";
            this.mobile.SelectionLength = 0;
            this.mobile.SelectionStart = 0;
            this.mobile.ShortcutsEnabled = true;
            this.mobile.Size = new System.Drawing.Size(167, 23);
            this.mobile.TabIndex = 3;
            this.mobile.UseSelectable = true;
            this.mobile.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mobile.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(164, 141);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(107, 20);
            this.metroLabel2.TabIndex = 2;
            this.metroLabel2.Text = "Mobile Number";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(164, 187);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(38, 20);
            this.metroLabel3.TabIndex = 4;
            this.metroLabel3.Text = "Area";
            // 
            // area
            // 
            this.area.FormattingEnabled = true;
            this.area.ItemHeight = 24;
            this.area.Items.AddRange(new object[] {
            "Rowmari",
            "Dantvanga",
            "Rajibpur",
            "Kartimari",
            "Char shol mari",
            "Boraikandi"});
            this.area.Location = new System.Drawing.Point(296, 187);
            this.area.Name = "area";
            this.area.Size = new System.Drawing.Size(167, 30);
            this.area.TabIndex = 5;
            this.area.UseSelectable = true;
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(164, 234);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(61, 20);
            this.metroLabel4.TabIndex = 6;
            this.metroLabel4.Text = "UNIQ ID";
            // 
            // uniqid
            // 
            // 
            // 
            // 
            this.uniqid.CustomButton.Image = null;
            this.uniqid.CustomButton.Location = new System.Drawing.Point(145, 1);
            this.uniqid.CustomButton.Name = "";
            this.uniqid.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.uniqid.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.uniqid.CustomButton.TabIndex = 1;
            this.uniqid.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.uniqid.CustomButton.UseSelectable = true;
            this.uniqid.CustomButton.Visible = false;
            this.uniqid.Lines = new string[0];
            this.uniqid.Location = new System.Drawing.Point(296, 234);
            this.uniqid.MaxLength = 32767;
            this.uniqid.Name = "uniqid";
            this.uniqid.PasswordChar = '\0';
            this.uniqid.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.uniqid.SelectedText = "";
            this.uniqid.SelectionLength = 0;
            this.uniqid.SelectionStart = 0;
            this.uniqid.ShortcutsEnabled = true;
            this.uniqid.Size = new System.Drawing.Size(167, 23);
            this.uniqid.TabIndex = 7;
            this.uniqid.UseSelectable = true;
            this.uniqid.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.uniqid.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // customerEntryButton
            // 
            this.customerEntryButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.customerEntryButton.Location = new System.Drawing.Point(388, 313);
            this.customerEntryButton.Name = "customerEntryButton";
            this.customerEntryButton.Size = new System.Drawing.Size(75, 37);
            this.customerEntryButton.TabIndex = 8;
            this.customerEntryButton.Text = "CREATE";
            this.customerEntryButton.UseSelectable = true;
            this.customerEntryButton.Click += new System.EventHandler(this.customerEntryButton_Click);
            // 
            // dueads
            // 
            this.dueads.AutoSize = true;
            this.dueads.Location = new System.Drawing.Point(164, 275);
            this.dueads.Name = "dueads";
            this.dueads.Size = new System.Drawing.Size(35, 20);
            this.dueads.TabIndex = 9;
            this.dueads.Text = "Due";
            // 
            // due
            // 
            // 
            // 
            // 
            this.due.CustomButton.Image = null;
            this.due.CustomButton.Location = new System.Drawing.Point(145, 1);
            this.due.CustomButton.Name = "";
            this.due.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.due.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.due.CustomButton.TabIndex = 1;
            this.due.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.due.CustomButton.UseSelectable = true;
            this.due.CustomButton.Visible = false;
            this.due.Lines = new string[0];
            this.due.Location = new System.Drawing.Point(296, 275);
            this.due.MaxLength = 32767;
            this.due.Name = "due";
            this.due.PasswordChar = '\0';
            this.due.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.due.SelectedText = "";
            this.due.SelectionLength = 0;
            this.due.SelectionStart = 0;
            this.due.ShortcutsEnabled = true;
            this.due.Size = new System.Drawing.Size(167, 23);
            this.due.TabIndex = 10;
            this.due.UseSelectable = true;
            this.due.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.due.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // CustomerEntry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(858, 373);
            this.Controls.Add(this.due);
            this.Controls.Add(this.dueads);
            this.Controls.Add(this.customerEntryButton);
            this.Controls.Add(this.uniqid);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.area);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.mobile);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.name);
            this.Controls.Add(this.metroLabel1);
            this.ForeColor = System.Drawing.Color.OrangeRed;
            this.Name = "CustomerEntry";
            this.Text = "CustomerEntry";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox name;
        private MetroFramework.Controls.MetroTextBox mobile;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroComboBox area;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroTextBox uniqid;
        private MetroFramework.Controls.MetroButton customerEntryButton;
        private MetroFramework.Controls.MetroLabel dueads;
        private MetroFramework.Controls.MetroTextBox due;
    }
}