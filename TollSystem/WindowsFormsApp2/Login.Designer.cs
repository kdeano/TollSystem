
namespace WindowsFormsApp2
{
    partial class Login
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
            this.btnLogin = new System.Windows.Forms.Button();
            this.txtPassportNum = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.btnOperator = new System.Windows.Forms.Button();
            this.txtOpPass = new System.Windows.Forms.TextBox();
            this.btnTransDept = new System.Windows.Forms.Button();
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
            this.cbLanguage.Location = new System.Drawing.Point(557, 119);
            this.cbLanguage.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbLanguage.Name = "cbLanguage";
            this.cbLanguage.Size = new System.Drawing.Size(220, 31);
            this.cbLanguage.TabIndex = 8;
            this.cbLanguage.Text = "Change language";
            this.cbLanguage.SelectedIndexChanged += new System.EventHandler(this.cbLanguage_SelectedIndexChanged);
            // 
            // btnLogin
            // 
            this.btnLogin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnLogin.Font = new System.Drawing.Font("Calibri", 21.75F, System.Drawing.FontStyle.Bold);
            this.btnLogin.Location = new System.Drawing.Point(249, 553);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(267, 62);
            this.btnLogin.TabIndex = 14;
            this.btnLogin.Text = "Logg Inn";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // txtPassportNum
            // 
            this.txtPassportNum.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPassportNum.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPassportNum.Font = new System.Drawing.Font("Calibri", 21.75F, System.Drawing.FontStyle.Bold);
            this.txtPassportNum.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtPassportNum.Location = new System.Drawing.Point(133, 426);
            this.txtPassportNum.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPassportNum.MaxLength = 50;
            this.txtPassportNum.Name = "txtPassportNum";
            this.txtPassportNum.Size = new System.Drawing.Size(515, 52);
            this.txtPassportNum.TabIndex = 13;
            this.txtPassportNum.Text = "Passnummer";
            this.txtPassportNum.Click += new System.EventHandler(this.txtPassportNum_Click);
            this.txtPassportNum.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPassportNum_KeyPress);
            // 
            // txtLastName
            // 
            this.txtLastName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtLastName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtLastName.Font = new System.Drawing.Font("Calibri", 21.75F, System.Drawing.FontStyle.Bold);
            this.txtLastName.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtLastName.Location = new System.Drawing.Point(133, 334);
            this.txtLastName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtLastName.MaxLength = 50;
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(515, 52);
            this.txtLastName.TabIndex = 12;
            this.txtLastName.Text = "Etternavn";
            this.txtLastName.Click += new System.EventHandler(this.txtLastName_Click);
            this.txtLastName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtLastName_KeyPress);
            // 
            // txtFirstName
            // 
            this.txtFirstName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtFirstName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFirstName.Font = new System.Drawing.Font("Calibri", 21.75F, System.Drawing.FontStyle.Bold);
            this.txtFirstName.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtFirstName.Location = new System.Drawing.Point(133, 241);
            this.txtFirstName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtFirstName.MaxLength = 50;
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(515, 52);
            this.txtFirstName.TabIndex = 11;
            this.txtFirstName.Text = "Fornavn";
            this.txtFirstName.Click += new System.EventHandler(this.txtFirstName_Click);
            this.txtFirstName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFirstName_KeyPress);
            // 
            // btnOperator
            // 
            this.btnOperator.Location = new System.Drawing.Point(26, 12);
            this.btnOperator.Name = "btnOperator";
            this.btnOperator.Size = new System.Drawing.Size(153, 47);
            this.btnOperator.TabIndex = 15;
            this.btnOperator.Text = "Toll Operator Login";
            this.btnOperator.UseVisualStyleBackColor = true;
            this.btnOperator.Click += new System.EventHandler(this.opLoginBTN_Click);
            // 
            // txtOpPass
            // 
            this.txtOpPass.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtOpPass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtOpPass.Font = new System.Drawing.Font("Calibri", 21.75F, System.Drawing.FontStyle.Bold);
            this.txtOpPass.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtOpPass.Location = new System.Drawing.Point(133, 426);
            this.txtOpPass.Margin = new System.Windows.Forms.Padding(4);
            this.txtOpPass.MaxLength = 50;
            this.txtOpPass.Name = "txtOpPass";
            this.txtOpPass.Size = new System.Drawing.Size(515, 52);
            this.txtOpPass.TabIndex = 16;
            this.txtOpPass.Text = "Password";
            this.txtOpPass.Visible = false;
            // 
            // btnTransDept
            // 
            this.btnTransDept.Location = new System.Drawing.Point(26, 65);
            this.btnTransDept.Name = "btnTransDept";
            this.btnTransDept.Size = new System.Drawing.Size(153, 47);
            this.btnTransDept.TabIndex = 17;
            this.btnTransDept.Text = "Transport Dept Login";
            this.btnTransDept.UseVisualStyleBackColor = true;
            this.btnTransDept.Click += new System.EventHandler(this.btnTransDept_Click);
            // 
            // pbFlag
            // 
            this.pbFlag.Image = global::WindowsFormsApp2.Properties.Resources.norway;
            this.pbFlag.Location = new System.Drawing.Point(557, 0);
            this.pbFlag.Margin = new System.Windows.Forms.Padding(4);
            this.pbFlag.Name = "pbFlag";
            this.pbFlag.Size = new System.Drawing.Size(221, 112);
            this.pbFlag.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbFlag.TabIndex = 7;
            this.pbFlag.TabStop = false;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(779, 690);
            this.Controls.Add(this.btnTransDept);
            this.Controls.Add(this.txtOpPass);
            this.Controls.Add(this.btnOperator);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.txtPassportNum);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.cbLanguage);
            this.Controls.Add(this.pbFlag);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Toll System | Login";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Login_FormClosed);
            this.Load += new System.EventHandler(this.Login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbFlag)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbLanguage;
        private System.Windows.Forms.PictureBox pbFlag;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.TextBox txtPassportNum;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Button btnOperator;
        private System.Windows.Forms.TextBox txtOpPass;
        private System.Windows.Forms.Button btnTransDept;
    }
}