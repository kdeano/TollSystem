
namespace WindowsFormsApp2
{
    partial class SignUp
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
            this.pbFlag = new System.Windows.Forms.PictureBox();
            this.cbLanguage = new System.Windows.Forms.ComboBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtPassportNum = new System.Windows.Forms.TextBox();
            this.btnSignUp = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbFlag)).BeginInit();
            this.SuspendLayout();
            // 
            // pbFlag
            // 
            this.pbFlag.Image = global::WindowsFormsApp2.Properties.Resources.norway;
            this.pbFlag.Location = new System.Drawing.Point(418, 1);
            this.pbFlag.Name = "pbFlag";
            this.pbFlag.Size = new System.Drawing.Size(166, 91);
            this.pbFlag.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbFlag.TabIndex = 5;
            this.pbFlag.TabStop = false;
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
            this.cbLanguage.Location = new System.Drawing.Point(418, 98);
            this.cbLanguage.Name = "cbLanguage";
            this.cbLanguage.Size = new System.Drawing.Size(166, 26);
            this.cbLanguage.TabIndex = 6;
            this.cbLanguage.Text = "Change language";
            this.cbLanguage.SelectedIndexChanged += new System.EventHandler(this.cbLanguage_SelectedIndexChanged);
            // 
            // txtFirstName
            // 
            this.txtFirstName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtFirstName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFirstName.Font = new System.Drawing.Font("Calibri", 21.75F, System.Drawing.FontStyle.Bold);
            this.txtFirstName.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtFirstName.Location = new System.Drawing.Point(86, 193);
            this.txtFirstName.MaxLength = 50;
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(387, 43);
            this.txtFirstName.TabIndex = 7;
            this.txtFirstName.Text = "Fornavn";
            this.txtFirstName.Click += new System.EventHandler(this.txtFirstName_Click);
            this.txtFirstName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFirstName_KeyPress);
            // 
            // txtLastName
            // 
            this.txtLastName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtLastName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtLastName.Font = new System.Drawing.Font("Calibri", 21.75F, System.Drawing.FontStyle.Bold);
            this.txtLastName.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtLastName.Location = new System.Drawing.Point(86, 268);
            this.txtLastName.MaxLength = 50;
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(387, 43);
            this.txtLastName.TabIndex = 8;
            this.txtLastName.Text = "Etternavn";
            this.txtLastName.Click += new System.EventHandler(this.txtLastName_Click);
            this.txtLastName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtLastName_KeyPress);
            // 
            // txtPassportNum
            // 
            this.txtPassportNum.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPassportNum.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPassportNum.Font = new System.Drawing.Font("Calibri", 21.75F, System.Drawing.FontStyle.Bold);
            this.txtPassportNum.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtPassportNum.Location = new System.Drawing.Point(86, 343);
            this.txtPassportNum.MaxLength = 50;
            this.txtPassportNum.Name = "txtPassportNum";
            this.txtPassportNum.Size = new System.Drawing.Size(387, 43);
            this.txtPassportNum.TabIndex = 9;
            this.txtPassportNum.Text = "Passnummer";
            this.txtPassportNum.Click += new System.EventHandler(this.txtPassportNum_Click);
            this.txtPassportNum.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPassportNum_KeyPress);
            // 
            // btnSignUp
            // 
            this.btnSignUp.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSignUp.Font = new System.Drawing.Font("Calibri", 21.75F, System.Drawing.FontStyle.Bold);
            this.btnSignUp.Location = new System.Drawing.Point(173, 446);
            this.btnSignUp.Name = "btnSignUp";
            this.btnSignUp.Size = new System.Drawing.Size(200, 50);
            this.btnSignUp.TabIndex = 10;
            this.btnSignUp.Text = "Melde deg på";
            this.btnSignUp.UseVisualStyleBackColor = true;
            this.btnSignUp.Click += new System.EventHandler(this.btnSignUp_Click);
            // 
            // SignUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 561);
            this.Controls.Add(this.btnSignUp);
            this.Controls.Add(this.txtPassportNum);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.cbLanguage);
            this.Controls.Add(this.pbFlag);
            this.Name = "SignUp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Toll System | Sign up";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SignUp_FormClosing);
            this.Load += new System.EventHandler(this.SignUp_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbFlag)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbFlag;
        private System.Windows.Forms.ComboBox cbLanguage;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtPassportNum;
        private System.Windows.Forms.Button btnSignUp;
    }
}