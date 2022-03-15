namespace WindowsFormsApp2
{
    partial class OperatorPanel
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
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem(new string[] {
            "Sarah Wilkes",
            "Car",
            "Manual",
            "Needs Actioning",
            "Awaiting Payment"}, -1);
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem(new string[] {
            "Soren Osted",
            "Van",
            "Monthly",
            "35",
            "15/02/2022"}, -1);
            System.Windows.Forms.ListViewItem listViewItem3 = new System.Windows.Forms.ListViewItem(new string[] {
            "Mikail Bridges",
            "Lorry",
            "Monthly",
            "15",
            "03/03/2022"}, -1);
            System.Windows.Forms.ListViewItem listViewItem4 = new System.Windows.Forms.ListViewItem(new string[] {
            "Anne Effe",
            "Car",
            "Manual",
            "55",
            "27/02/2022"}, -1);
            System.Windows.Forms.ListViewItem listViewItem5 = new System.Windows.Forms.ListViewItem(new string[] {
            "Mikail Bridges",
            "Lorry",
            "Monthly",
            "15",
            "03/03/2022"}, -1);
            System.Windows.Forms.ListViewItem listViewItem6 = new System.Windows.Forms.ListViewItem(new string[] {
            "Soren Osted",
            "Van",
            "Monthly",
            "35",
            "15/02/2022"}, -1);
            System.Windows.Forms.ListViewItem listViewItem7 = new System.Windows.Forms.ListViewItem(new System.Windows.Forms.ListViewItem.ListViewSubItem[] {
            new System.Windows.Forms.ListViewItem.ListViewSubItem(null, "Sarah Wilkes"),
            new System.Windows.Forms.ListViewItem.ListViewSubItem(null, "Car"),
            new System.Windows.Forms.ListViewItem.ListViewSubItem(null, "Manual"),
            new System.Windows.Forms.ListViewItem.ListViewSubItem(null, "Needs Actioning"),
            new System.Windows.Forms.ListViewItem.ListViewSubItem(null, "Awaiting Payment", System.Drawing.SystemColors.WindowText, System.Drawing.SystemColors.Window, new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0))))}, -1);
            System.Windows.Forms.ListViewItem listViewItem8 = new System.Windows.Forms.ListViewItem(new string[] {
            "Anne Effe",
            "Car",
            "Manual",
            "55",
            "27/02/2022"}, -1);
            System.Windows.Forms.ListViewItem listViewItem9 = new System.Windows.Forms.ListViewItem(new string[] {
            "Oleg Menst",
            "Van",
            "Monthly",
            "22",
            "19/02/2022"}, -1);
            this.cbLanguage = new System.Windows.Forms.ComboBox();
            this.listUsersExit12 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.listExits = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.listUsersExit13 = new System.Windows.Forms.ListView();
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnCalculateBill = new System.Windows.Forms.Button();
            this.pbFlag = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbFlag)).BeginInit();
            this.SuspendLayout();
            // 
            // cbLanguage
            // 
            this.cbLanguage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbLanguage.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbLanguage.FormattingEnabled = true;
            this.cbLanguage.Items.AddRange(new object[] {
            "Norweigen",
            "German",
            "English"});
            this.cbLanguage.Location = new System.Drawing.Point(718, 132);
            this.cbLanguage.Margin = new System.Windows.Forms.Padding(4);
            this.cbLanguage.Name = "cbLanguage";
            this.cbLanguage.Size = new System.Drawing.Size(220, 31);
            this.cbLanguage.TabIndex = 12;
            this.cbLanguage.Text = "Change language";
            // 
            // listUsersExit12
            // 
            this.listUsersExit12.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader5,
            this.columnHeader3,
            this.columnHeader4});
            this.listUsersExit12.HideSelection = false;
            this.listUsersExit12.ImeMode = System.Windows.Forms.ImeMode.Disable;
            listViewItem4.Checked = true;
            listViewItem4.StateImageIndex = 1;
            this.listUsersExit12.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2,
            listViewItem3,
            listViewItem4});
            this.listUsersExit12.Location = new System.Drawing.Point(148, 66);
            this.listUsersExit12.Name = "listUsersExit12";
            this.listUsersExit12.Size = new System.Drawing.Size(538, 365);
            this.listUsersExit12.TabIndex = 13;
            this.listUsersExit12.UseCompatibleStateImageBehavior = false;
            this.listUsersExit12.View = System.Windows.Forms.View.Details;
            this.listUsersExit12.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Name";
            this.columnHeader1.Width = 105;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Vehicle";
            this.columnHeader2.Width = 66;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Bill Type";
            this.columnHeader5.Width = 74;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Amount (EUR)";
            this.columnHeader3.Width = 123;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Date Paid";
            this.columnHeader4.Width = 120;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(243, 20);
            this.label1.TabIndex = 14;
            this.label1.Text = "Billing and Payment History";
            // 
            // listExits
            // 
            this.listExits.FormattingEnabled = true;
            this.listExits.ItemHeight = 16;
            this.listExits.Items.AddRange(new object[] {
            "Junction 12",
            "Junction 13",
            "Junction 14",
            "Junction 15"});
            this.listExits.Location = new System.Drawing.Point(12, 66);
            this.listExits.Name = "listExits";
            this.listExits.Size = new System.Drawing.Size(120, 84);
            this.listExits.TabIndex = 15;
            this.listExits.SelectedIndexChanged += new System.EventHandler(this.listExits_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 17);
            this.label2.TabIndex = 16;
            this.label2.Text = "Select Exit:";
            // 
            // listUsersExit13
            // 
            this.listUsersExit13.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader9,
            this.columnHeader10});
            this.listUsersExit13.HideSelection = false;
            this.listUsersExit13.ImeMode = System.Windows.Forms.ImeMode.Disable;
            listViewItem8.Checked = true;
            listViewItem8.StateImageIndex = 1;
            this.listUsersExit13.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem5,
            listViewItem6,
            listViewItem7,
            listViewItem8,
            listViewItem9});
            this.listUsersExit13.LabelEdit = true;
            this.listUsersExit13.Location = new System.Drawing.Point(148, 66);
            this.listUsersExit13.Name = "listUsersExit13";
            this.listUsersExit13.Size = new System.Drawing.Size(538, 365);
            this.listUsersExit13.TabIndex = 17;
            this.listUsersExit13.UseCompatibleStateImageBehavior = false;
            this.listUsersExit13.View = System.Windows.Forms.View.Details;
            this.listUsersExit13.Visible = false;
            this.listUsersExit13.SelectedIndexChanged += new System.EventHandler(this.listUsersExit13_SelectedIndexChanged);
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Name";
            this.columnHeader6.Width = 105;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Vehicle";
            this.columnHeader7.Width = 66;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Bill Type";
            this.columnHeader8.Width = 74;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Amount (EUR)";
            this.columnHeader9.Width = 122;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "Date Paid";
            this.columnHeader10.Width = 125;
            // 
            // btnCalculateBill
            // 
            this.btnCalculateBill.Location = new System.Drawing.Point(339, 457);
            this.btnCalculateBill.Name = "btnCalculateBill";
            this.btnCalculateBill.Size = new System.Drawing.Size(109, 33);
            this.btnCalculateBill.TabIndex = 18;
            this.btnCalculateBill.Text = "Process Bill";
            this.btnCalculateBill.UseVisualStyleBackColor = true;
            this.btnCalculateBill.Click += new System.EventHandler(this.btnCalculateBill_Click);
            // 
            // pbFlag
            // 
            this.pbFlag.Image = global::WindowsFormsApp2.Properties.Resources.norway;
            this.pbFlag.Location = new System.Drawing.Point(718, 13);
            this.pbFlag.Margin = new System.Windows.Forms.Padding(4);
            this.pbFlag.Name = "pbFlag";
            this.pbFlag.Size = new System.Drawing.Size(221, 112);
            this.pbFlag.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbFlag.TabIndex = 11;
            this.pbFlag.TabStop = false;
            // 
            // OperatorPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(952, 548);
            this.Controls.Add(this.btnCalculateBill);
            this.Controls.Add(this.listUsersExit13);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listExits);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listUsersExit12);
            this.Controls.Add(this.cbLanguage);
            this.Controls.Add(this.pbFlag);
            this.Name = "OperatorPanel";
            this.Text = "OperatorPanel";
            ((System.ComponentModel.ISupportInitialize)(this.pbFlag)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbLanguage;
        private System.Windows.Forms.PictureBox pbFlag;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ListBox listExits;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.Button btnCalculateBill;
        public System.Windows.Forms.ListView listUsersExit13;
        public System.Windows.Forms.ListView listUsersExit12;
    }
}