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
            //this.mainSelectedLang = selectedLang;
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

        private void SignUp_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            formMain.Show();
        }

        private void SignUp_Click(object sender, EventArgs e)
        {
            /*if ((txtFirstName.Text.Length >= 0) || 
                txtFirstName.Text.ToLower() == "Fornavn" || // Norwegian
                txtFirstName.Text.ToLower() == "Vorname" || // German
                txtFirstName.Text.ToLower() == "First name") // English
            {
                txtFirstName.Clear();
            }*/

            //txtFirstName.Clear();
        }

        private void txtFirstName_KeyPress(object sender, KeyPressEventArgs e)
        {
            txtFirstName.ForeColor = System.Drawing.Color.Black;
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
    }
}
