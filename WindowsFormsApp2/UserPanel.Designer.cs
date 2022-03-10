
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
            this.cbLanguage.Location = new System.Drawing.Point(638, 97);
            this.cbLanguage.Name = "cbLanguage";
            this.cbLanguage.Size = new System.Drawing.Size(166, 26);
            this.cbLanguage.TabIndex = 10;
            this.cbLanguage.Text = "Change language";
            // 
            // pbFlag
            // 
            this.pbFlag.Image = global::WindowsFormsApp2.Properties.Resources.norway;
            this.pbFlag.Location = new System.Drawing.Point(638, 0);
            this.pbFlag.Name = "pbFlag";
            this.pbFlag.Size = new System.Drawing.Size(166, 91);
            this.pbFlag.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbFlag.TabIndex = 9;
            this.pbFlag.TabStop = false;
            // 
            // UserPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 481);
            this.Controls.Add(this.cbLanguage);
            this.Controls.Add(this.pbFlag);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "UserPanel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Toll System | User:";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.UserPanel_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.pbFlag)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cbLanguage;
        private System.Windows.Forms.PictureBox pbFlag;
    }
}