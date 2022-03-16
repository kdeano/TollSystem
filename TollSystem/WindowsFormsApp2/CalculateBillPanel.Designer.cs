namespace WindowsFormsApp2
{
    partial class CalculateBillPanel
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
            "Name",
            "Sarah Wilkes"}, -1);
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem(new string[] {
            "Reg No.",
            "DA 1234"}, -1);
            System.Windows.Forms.ListViewItem listViewItem3 = new System.Windows.Forms.ListViewItem(new string[] {
            "Reg No Country",
            "Norway"}, -1);
            System.Windows.Forms.ListViewItem listViewItem4 = new System.Windows.Forms.ListViewItem(new string[] {
            "Distance Travelled",
            "74 Miles"}, -1);
            System.Windows.Forms.ListViewItem listViewItem5 = new System.Windows.Forms.ListViewItem(new string[] {
            "Entrance",
            "Junction 07"}, -1);
            System.Windows.Forms.ListViewItem listViewItem6 = new System.Windows.Forms.ListViewItem(new string[] {
            "Exit",
            "Junction 12"}, -1);
            System.Windows.Forms.ListViewItem listViewItem7 = new System.Windows.Forms.ListViewItem(new string[] {
            "Navn",
            "Sarah Wilkes"}, -1);
            System.Windows.Forms.ListViewItem listViewItem8 = new System.Windows.Forms.ListViewItem(new string[] {
            "Reg No.",
            "DA 1234"}, -1);
            System.Windows.Forms.ListViewItem listViewItem9 = new System.Windows.Forms.ListViewItem(new string[] {
            "Reg No Land",
            "Norway"}, -1);
            System.Windows.Forms.ListViewItem listViewItem10 = new System.Windows.Forms.ListViewItem(new string[] {
            "Tilbakelagt avstand",
            "74 Miles"}, -1);
            System.Windows.Forms.ListViewItem listViewItem11 = new System.Windows.Forms.ListViewItem(new string[] {
            "Inngang",
            "Junction 07"}, -1);
            System.Windows.Forms.ListViewItem listViewItem12 = new System.Windows.Forms.ListViewItem(new string[] {
            "Exit",
            "Junction 12"}, -1);
            System.Windows.Forms.ListViewItem listViewItem13 = new System.Windows.Forms.ListViewItem(new string[] {
            "Name",
            "Sarah Wilkes"}, -1);
            System.Windows.Forms.ListViewItem listViewItem14 = new System.Windows.Forms.ListViewItem(new string[] {
            "Reg No.",
            "DA 1234"}, -1);
            System.Windows.Forms.ListViewItem listViewItem15 = new System.Windows.Forms.ListViewItem(new string[] {
            "Reg No Land",
            "Norway"}, -1);
            System.Windows.Forms.ListViewItem listViewItem16 = new System.Windows.Forms.ListViewItem(new string[] {
            "zurückgelegte Strecke",
            "74 Miles"}, -1);
            System.Windows.Forms.ListViewItem listViewItem17 = new System.Windows.Forms.ListViewItem(new string[] {
            "Eingang",
            "Junction 07"}, -1);
            System.Windows.Forms.ListViewItem listViewItem18 = new System.Windows.Forms.ListViewItem(new string[] {
            "Ausgang",
            "Junction 12"}, -1);
            this.lstUserDetails_Eng = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnCalculate = new System.Windows.Forms.Button();
            this.cbLanguage = new System.Windows.Forms.ComboBox();
            this.pbFlag = new System.Windows.Forms.PictureBox();
            this.lstUserDetails_Nor = new System.Windows.Forms.ListView();
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lstUserDetails_Ger = new System.Windows.Forms.ListView();
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            ((System.ComponentModel.ISupportInitialize)(this.pbFlag)).BeginInit();
            this.SuspendLayout();
            // 
            // lstUserDetails_Eng
            // 
            this.lstUserDetails_Eng.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.lstUserDetails_Eng.HideSelection = false;
            this.lstUserDetails_Eng.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2,
            listViewItem3,
            listViewItem4,
            listViewItem5,
            listViewItem6});
            this.lstUserDetails_Eng.Location = new System.Drawing.Point(65, 33);
            this.lstUserDetails_Eng.Name = "lstUserDetails_Eng";
            this.lstUserDetails_Eng.Size = new System.Drawing.Size(344, 303);
            this.lstUserDetails_Eng.TabIndex = 0;
            this.lstUserDetails_Eng.UseCompatibleStateImageBehavior = false;
            this.lstUserDetails_Eng.View = System.Windows.Forms.View.Details;
            this.lstUserDetails_Eng.Visible = false;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Driver Details";
            this.columnHeader1.Width = 130;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Details";
            this.columnHeader2.Width = 102;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(172, 354);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(119, 34);
            this.btnCalculate.TabIndex = 1;
            this.btnCalculate.Text = "Regne ut";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
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
            this.cbLanguage.Location = new System.Drawing.Point(429, 152);
            this.cbLanguage.Margin = new System.Windows.Forms.Padding(4);
            this.cbLanguage.Name = "cbLanguage";
            this.cbLanguage.Size = new System.Drawing.Size(220, 31);
            this.cbLanguage.TabIndex = 14;
            this.cbLanguage.Text = "Change language";
            this.cbLanguage.SelectedIndexChanged += new System.EventHandler(this.cbLanguage_SelectedIndexChanged);
            // 
            // pbFlag
            // 
            this.pbFlag.Image = global::WindowsFormsApp2.Properties.Resources.norway;
            this.pbFlag.Location = new System.Drawing.Point(429, 33);
            this.pbFlag.Margin = new System.Windows.Forms.Padding(4);
            this.pbFlag.Name = "pbFlag";
            this.pbFlag.Size = new System.Drawing.Size(221, 112);
            this.pbFlag.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbFlag.TabIndex = 13;
            this.pbFlag.TabStop = false;
            // 
            // lstUserDetails_Nor
            // 
            this.lstUserDetails_Nor.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader3,
            this.columnHeader4});
            this.lstUserDetails_Nor.HideSelection = false;
            this.lstUserDetails_Nor.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem7,
            listViewItem8,
            listViewItem9,
            listViewItem10,
            listViewItem11,
            listViewItem12});
            this.lstUserDetails_Nor.Location = new System.Drawing.Point(65, 33);
            this.lstUserDetails_Nor.Name = "lstUserDetails_Nor";
            this.lstUserDetails_Nor.Size = new System.Drawing.Size(344, 303);
            this.lstUserDetails_Nor.TabIndex = 15;
            this.lstUserDetails_Nor.UseCompatibleStateImageBehavior = false;
            this.lstUserDetails_Nor.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Driverdetaljer";
            this.columnHeader3.Width = 130;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Detaljer";
            this.columnHeader4.Width = 102;
            // 
            // lstUserDetails_Ger
            // 
            this.lstUserDetails_Ger.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader5,
            this.columnHeader6});
            this.lstUserDetails_Ger.HideSelection = false;
            this.lstUserDetails_Ger.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem13,
            listViewItem14,
            listViewItem15,
            listViewItem16,
            listViewItem17,
            listViewItem18});
            this.lstUserDetails_Ger.Location = new System.Drawing.Point(65, 33);
            this.lstUserDetails_Ger.Name = "lstUserDetails_Ger";
            this.lstUserDetails_Ger.Size = new System.Drawing.Size(344, 303);
            this.lstUserDetails_Ger.TabIndex = 16;
            this.lstUserDetails_Ger.UseCompatibleStateImageBehavior = false;
            this.lstUserDetails_Ger.View = System.Windows.Forms.View.Details;
            this.lstUserDetails_Ger.Visible = false;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Treiberdetails";
            this.columnHeader5.Width = 130;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Einzelheiten";
            this.columnHeader6.Width = 102;
            // 
            // CalculateBillPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(663, 450);
            this.Controls.Add(this.lstUserDetails_Ger);
            this.Controls.Add(this.lstUserDetails_Nor);
            this.Controls.Add(this.cbLanguage);
            this.Controls.Add(this.pbFlag);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.lstUserDetails_Eng);
            this.Name = "CalculateBillPanel";
            this.Text = "CalculateBill";
            ((System.ComponentModel.ISupportInitialize)(this.pbFlag)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lstUserDetails_Eng;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ComboBox cbLanguage;
        private System.Windows.Forms.PictureBox pbFlag;
        private System.Windows.Forms.ListView lstUserDetails_Nor;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ListView lstUserDetails_Ger;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
    }
}