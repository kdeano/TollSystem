using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class SignUp : Form
    {
        private static string firstName;
        private static string lastName;
        private static string passportNum;

        public int mainSelectedLang { get; set; }
        public static Main formMain = new Main();

        public SignUp()
        {
            InitializeComponent();
        }

        private void SignUp_Load(object sender, EventArgs e)
        {
            switch (mainSelectedLang)
            {
                case 0:
                    pbFlag.Image = Properties.Resources.norway;
                    mainSelectedLang = 0;
                    txtFirstName.Text = "Fornavn";
                    break;
                case 1:
                    pbFlag.Image = Properties.Resources.germany;
                    mainSelectedLang = 1;
                    txtFirstName.Text = "Vorname";
                    break;
                case 2:
                    pbFlag.Image = Properties.Resources.uk;
                    mainSelectedLang = 2;
                    txtFirstName.Text = "First name";
                    break;
                default:
                    pbFlag.Image = Properties.Resources.norway;
                    mainSelectedLang = 0;
                    txtFirstName.Text = "Fornavn";
                    break;
            }
        }

        private void txtFirstName_Click(object sender, EventArgs e)
        {
            if (txtFirstName.Text.Length < 1 || 
                txtFirstName.Text == "Fornavn" || 
                txtFirstName.Text == "Vorname" || 
                txtFirstName.Text == "First name")
            {
                txtFirstName.Clear();
            }
        }

        private void cbLanguage_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedIndex = cbLanguage.SelectedIndex;
            mainSelectedLang = selectedIndex;

            switch (selectedIndex)
            {
                case 0:
                    pbFlag.Image = Properties.Resources.norway;
                    mainSelectedLang = 0;
                    txtFirstName.Text = "Fornavn";
                    txtLastName.Text = "Etternavn";
                    txtPassportNum.Text = "Passnummer";
                    break;
                case 1:
                    pbFlag.Image = Properties.Resources.germany;
                    mainSelectedLang = 1;
                    txtFirstName.Text = "Vorname";
                    txtLastName.Text = "Nachname";
                    txtPassportNum.Text = "Ausweisnummer";
                    break;
                case 2:
                    pbFlag.Image = Properties.Resources.uk;
                    mainSelectedLang = 2;
                    txtFirstName.Text = "First name";
                    txtLastName.Text = "Last name";
                    txtPassportNum.Text = "Passport number";
                    break;
                default:
                    pbFlag.Image = Properties.Resources.norway;
                    mainSelectedLang = 0;
                    txtFirstName.Text = "Fornavn";
                    txtLastName.Text = "Etternavn";
                    txtPassportNum.Text = "Passnummer";
                    break;
            }
        }

        private void txtFirstName_KeyPress(object sender, KeyPressEventArgs e)
        {
            txtFirstName.ForeColor = System.Drawing.Color.Black;
        }

        private void txtLastName_KeyPress(object sender, KeyPressEventArgs e)
        {
            txtLastName.ForeColor = System.Drawing.Color.Black;
        }

        private void txtPassportNum_KeyPress(object sender, KeyPressEventArgs e)
        {
            txtPassportNum.ForeColor = System.Drawing.Color.Black;
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            firstName = txtFirstName.Text;
            lastName = txtLastName.Text;
            passportNum = txtPassportNum.Text;

            this.Hide();
            //formMain.Show();
        }

        private void SignUp_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            //formMain.Show();
        }
    }
}
