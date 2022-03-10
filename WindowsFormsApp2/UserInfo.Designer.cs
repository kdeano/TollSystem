
namespace WindowsFormsApp2
{
    partial class UserInfo
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
            this.cbLanguage = new System.Windows.Forms.ComboBox();
            this.pbFlag = new System.Windows.Forms.PictureBox();
            this.txtCarModel = new System.Windows.Forms.TextBox();
            this.txtRegNum = new System.Windows.Forms.TextBox();
            this.btnSubmitCar = new System.Windows.Forms.Button();
            this.txtAccountName = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.txtCardNum = new System.Windows.Forms.TextBox();
            this.btnSubmitBank = new System.Windows.Forms.Button();
            this.cbExpiryMonth = new System.Windows.Forms.ComboBox();
            this.cbExpiryYear = new System.Windows.Forms.ComboBox();
            this.lblExpiryDate = new System.Windows.Forms.Label();
            this.txtSecurityCode = new System.Windows.Forms.TextBox();
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
            this.cbLanguage.Location = new System.Drawing.Point(418, 97);
            this.cbLanguage.Name = "cbLanguage";
            this.cbLanguage.Size = new System.Drawing.Size(166, 26);
            this.cbLanguage.TabIndex = 10;
            this.cbLanguage.Text = "Change language";
            this.cbLanguage.SelectedIndexChanged += new System.EventHandler(this.cbLanguage_SelectedIndexChanged);
            // 
            // pbFlag
            // 
            this.pbFlag.Image = global::WindowsFormsApp2.Properties.Resources.norway;
            this.pbFlag.Location = new System.Drawing.Point(418, 0);
            this.pbFlag.Name = "pbFlag";
            this.pbFlag.Size = new System.Drawing.Size(166, 91);
            this.pbFlag.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbFlag.TabIndex = 9;
            this.pbFlag.TabStop = false;
            // 
            // txtCarModel
            // 
            this.txtCarModel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtCarModel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCarModel.Font = new System.Drawing.Font("Calibri", 21.75F, System.Drawing.FontStyle.Bold);
            this.txtCarModel.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtCarModel.Location = new System.Drawing.Point(98, 231);
            this.txtCarModel.MaxLength = 50;
            this.txtCarModel.Name = "txtCarModel";
            this.txtCarModel.Size = new System.Drawing.Size(387, 43);
            this.txtCarModel.TabIndex = 12;
            this.txtCarModel.Text = "Bilmodell";
            this.txtCarModel.Click += new System.EventHandler(this.txtCarModel_Click);
            this.txtCarModel.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCarModel_KeyPress);
            // 
            // txtRegNum
            // 
            this.txtRegNum.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtRegNum.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRegNum.Font = new System.Drawing.Font("Calibri", 21.75F, System.Drawing.FontStyle.Bold);
            this.txtRegNum.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtRegNum.Location = new System.Drawing.Point(98, 299);
            this.txtRegNum.MaxLength = 50;
            this.txtRegNum.Name = "txtRegNum";
            this.txtRegNum.Size = new System.Drawing.Size(387, 43);
            this.txtRegNum.TabIndex = 13;
            this.txtRegNum.Text = "Registreringsnummer";
            this.txtRegNum.Click += new System.EventHandler(this.txtRegNum_Click);
            this.txtRegNum.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtRegNum_KeyPress);
            // 
            // btnSubmitCar
            // 
            this.btnSubmitCar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSubmitCar.Font = new System.Drawing.Font("Calibri", 21.75F, System.Drawing.FontStyle.Bold);
            this.btnSubmitCar.Location = new System.Drawing.Point(187, 452);
            this.btnSubmitCar.Name = "btnSubmitCar";
            this.btnSubmitCar.Size = new System.Drawing.Size(200, 50);
            this.btnSubmitCar.TabIndex = 15;
            this.btnSubmitCar.Text = "Sende inn";
            this.btnSubmitCar.UseVisualStyleBackColor = true;
            this.btnSubmitCar.Click += new System.EventHandler(this.btnSubmitCar_Click);
            // 
            // txtAccountName
            // 
            this.txtAccountName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtAccountName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAccountName.Font = new System.Drawing.Font("Calibri", 21.75F, System.Drawing.FontStyle.Bold);
            this.txtAccountName.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtAccountName.Location = new System.Drawing.Point(98, 164);
            this.txtAccountName.MaxLength = 50;
            this.txtAccountName.Name = "txtAccountName";
            this.txtAccountName.Size = new System.Drawing.Size(387, 43);
            this.txtAccountName.TabIndex = 16;
            this.txtAccountName.Text = "Brukernavn";
            this.txtAccountName.Visible = false;
            this.txtAccountName.Click += new System.EventHandler(this.txtAccountName_Click);
            this.txtAccountName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAccountName_KeyPress);
            // 
            // textBox2
            // 
            this.textBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox2.Font = new System.Drawing.Font("Calibri", 21.75F, System.Drawing.FontStyle.Bold);
            this.textBox2.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.textBox2.Location = new System.Drawing.Point(98, 367);
            this.textBox2.MaxLength = 50;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(387, 43);
            this.textBox2.TabIndex = 17;
            this.textBox2.Text = "Registreringsnummer";
            // 
            // txtCardNum
            // 
            this.txtCardNum.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtCardNum.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCardNum.Font = new System.Drawing.Font("Calibri", 21.75F, System.Drawing.FontStyle.Bold);
            this.txtCardNum.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtCardNum.Location = new System.Drawing.Point(98, 231);
            this.txtCardNum.MaxLength = 50;
            this.txtCardNum.Name = "txtCardNum";
            this.txtCardNum.Size = new System.Drawing.Size(387, 43);
            this.txtCardNum.TabIndex = 18;
            this.txtCardNum.Text = "Kortnummer";
            this.txtCardNum.Visible = false;
            this.txtCardNum.Click += new System.EventHandler(this.txtCardNum_Click);
            this.txtCardNum.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCardNum_KeyPress);
            // 
            // btnSubmitBank
            // 
            this.btnSubmitBank.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSubmitBank.Font = new System.Drawing.Font("Calibri", 21.75F, System.Drawing.FontStyle.Bold);
            this.btnSubmitBank.Location = new System.Drawing.Point(187, 452);
            this.btnSubmitBank.Name = "btnSubmitBank";
            this.btnSubmitBank.Size = new System.Drawing.Size(200, 50);
            this.btnSubmitBank.TabIndex = 20;
            this.btnSubmitBank.Text = "Sende inn";
            this.btnSubmitBank.UseVisualStyleBackColor = true;
            this.btnSubmitBank.Visible = false;
            this.btnSubmitBank.Click += new System.EventHandler(this.btnSubmitBank_Click);
            // 
            // cbExpiryMonth
            // 
            this.cbExpiryMonth.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbExpiryMonth.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbExpiryMonth.FormattingEnabled = true;
            this.cbExpiryMonth.Items.AddRange(new object[] {
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12"});
            this.cbExpiryMonth.Location = new System.Drawing.Point(98, 316);
            this.cbExpiryMonth.Name = "cbExpiryMonth";
            this.cbExpiryMonth.Size = new System.Drawing.Size(166, 26);
            this.cbExpiryMonth.TabIndex = 21;
            this.cbExpiryMonth.Text = "MM";
            this.cbExpiryMonth.Visible = false;
            // 
            // cbExpiryYear
            // 
            this.cbExpiryYear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbExpiryYear.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbExpiryYear.FormattingEnabled = true;
            this.cbExpiryYear.Items.AddRange(new object[] {
            "2022",
            "2023",
            "2024",
            "2025",
            "2026",
            "2027",
            "2028",
            "2029",
            "2030",
            "2031",
            "2032",
            "2033",
            "2034",
            "2035"});
            this.cbExpiryYear.Location = new System.Drawing.Point(319, 316);
            this.cbExpiryYear.Name = "cbExpiryYear";
            this.cbExpiryYear.Size = new System.Drawing.Size(166, 26);
            this.cbExpiryYear.TabIndex = 22;
            this.cbExpiryYear.Text = "YYYY";
            this.cbExpiryYear.Visible = false;
            // 
            // lblExpiryDate
            // 
            this.lblExpiryDate.AutoSize = true;
            this.lblExpiryDate.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExpiryDate.Location = new System.Drawing.Point(93, 287);
            this.lblExpiryDate.Name = "lblExpiryDate";
            this.lblExpiryDate.Size = new System.Drawing.Size(107, 26);
            this.lblExpiryDate.TabIndex = 23;
            this.lblExpiryDate.Text = "Utløpsdato";
            this.lblExpiryDate.Visible = false;
            // 
            // txtSecurityCode
            // 
            this.txtSecurityCode.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtSecurityCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSecurityCode.Font = new System.Drawing.Font("Calibri", 21.75F, System.Drawing.FontStyle.Bold);
            this.txtSecurityCode.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtSecurityCode.Location = new System.Drawing.Point(98, 367);
            this.txtSecurityCode.MaxLength = 50;
            this.txtSecurityCode.Name = "txtSecurityCode";
            this.txtSecurityCode.Size = new System.Drawing.Size(387, 43);
            this.txtSecurityCode.TabIndex = 24;
            this.txtSecurityCode.Text = "Kort sikkerhetskode";
            this.txtSecurityCode.Visible = false;
            this.txtSecurityCode.Click += new System.EventHandler(this.txtSecurityCode_Click);
            this.txtSecurityCode.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSecurityCode_KeyPress);
            // 
            // UserInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 561);
            this.Controls.Add(this.txtSecurityCode);
            this.Controls.Add(this.lblExpiryDate);
            this.Controls.Add(this.cbExpiryYear);
            this.Controls.Add(this.cbExpiryMonth);
            this.Controls.Add(this.btnSubmitBank);
            this.Controls.Add(this.txtCardNum);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.txtAccountName);
            this.Controls.Add(this.btnSubmitCar);
            this.Controls.Add(this.txtRegNum);
            this.Controls.Add(this.txtCarModel);
            this.Controls.Add(this.cbLanguage);
            this.Controls.Add(this.pbFlag);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "UserInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Toll System | User Information:";
            this.Load += new System.EventHandler(this.UserInformation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbFlag)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbLanguage;
        private System.Windows.Forms.PictureBox pbFlag;
        private System.Windows.Forms.TextBox txtCarModel;
        private System.Windows.Forms.TextBox txtRegNum;
        private System.Windows.Forms.Button btnSubmitCar;
        private System.Windows.Forms.TextBox txtAccountName;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox txtCardNum;
        private System.Windows.Forms.Button btnSubmitBank;
        private System.Windows.Forms.ComboBox cbExpiryMonth;
        private System.Windows.Forms.ComboBox cbExpiryYear;
        private System.Windows.Forms.Label lblExpiryDate;
        private System.Windows.Forms.TextBox txtSecurityCode;
    }
}