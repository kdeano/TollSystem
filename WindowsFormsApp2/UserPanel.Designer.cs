
namespace WindowsFormsApp2
{
    partial class UserPanel
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
            this.lblName = new System.Windows.Forms.Label();
            this.btnUserInfo = new System.Windows.Forms.Button();
            this.btnCarInfo = new System.Windows.Forms.Button();
            this.btnBankDetails = new System.Windows.Forms.Button();
            this.btnPaymentHistory = new System.Windows.Forms.Button();
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
            // lblName
            // 
            this.lblName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Calibri", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(134, 163);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(316, 36);
            this.lblName.TabIndex = 24;
            this.lblName.Text = "Driver name placeholder";
            this.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblName.Visible = false;
            // 
            // btnUserInfo
            // 
            this.btnUserInfo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnUserInfo.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUserInfo.Location = new System.Drawing.Point(79, 245);
            this.btnUserInfo.Name = "btnUserInfo";
            this.btnUserInfo.Size = new System.Drawing.Size(432, 65);
            this.btnUserInfo.TabIndex = 25;
            this.btnUserInfo.Text = "Personlig informasjon";
            this.btnUserInfo.UseVisualStyleBackColor = true;
            this.btnUserInfo.Visible = false;
            this.btnUserInfo.Click += new System.EventHandler(this.btnUserInfo_Click);
            // 
            // btnCarInfo
            // 
            this.btnCarInfo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCarInfo.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCarInfo.Location = new System.Drawing.Point(79, 333);
            this.btnCarInfo.Name = "btnCarInfo";
            this.btnCarInfo.Size = new System.Drawing.Size(432, 65);
            this.btnCarInfo.TabIndex = 26;
            this.btnCarInfo.Text = "Bilinformasjon";
            this.btnCarInfo.UseVisualStyleBackColor = true;
            this.btnCarInfo.Visible = false;
            this.btnCarInfo.Click += new System.EventHandler(this.btnCarInfo_Click);
            // 
            // btnBankDetails
            // 
            this.btnBankDetails.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnBankDetails.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBankDetails.Location = new System.Drawing.Point(79, 422);
            this.btnBankDetails.Name = "btnBankDetails";
            this.btnBankDetails.Size = new System.Drawing.Size(432, 65);
            this.btnBankDetails.TabIndex = 27;
            this.btnBankDetails.Text = "Bankinformasjon";
            this.btnBankDetails.UseVisualStyleBackColor = true;
            this.btnBankDetails.Visible = false;
            this.btnBankDetails.Click += new System.EventHandler(this.btnBankDetails_Click);
            // 
            // btnPaymentHistory
            // 
            this.btnPaymentHistory.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnPaymentHistory.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPaymentHistory.Location = new System.Drawing.Point(79, 511);
            this.btnPaymentHistory.Name = "btnPaymentHistory";
            this.btnPaymentHistory.Size = new System.Drawing.Size(432, 65);
            this.btnPaymentHistory.TabIndex = 28;
            this.btnPaymentHistory.Text = "Betalingshistorikk";
            this.btnPaymentHistory.UseVisualStyleBackColor = true;
            this.btnPaymentHistory.Visible = false;
            this.btnPaymentHistory.Click += new System.EventHandler(this.btnPaymentHistory_Click);
            // 
            // UserPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 641);
            this.Controls.Add(this.btnPaymentHistory);
            this.Controls.Add(this.btnBankDetails);
            this.Controls.Add(this.btnCarInfo);
            this.Controls.Add(this.btnUserInfo);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.cbLanguage);
            this.Controls.Add(this.pbFlag);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "UserPanel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Toll System | User:";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.UserPanel_FormClosing);
            this.Load += new System.EventHandler(this.UserPanel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbFlag)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbLanguage;
        private System.Windows.Forms.PictureBox pbFlag;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Button btnUserInfo;
        private System.Windows.Forms.Button btnCarInfo;
        private System.Windows.Forms.Button btnBankDetails;
        private System.Windows.Forms.Button btnPaymentHistory;
    }
}