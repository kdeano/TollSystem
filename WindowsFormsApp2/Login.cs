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
    public partial class Login : Form
    {
        // Declaring global variables to get and set selected language & login information
        public int mainSelectedLang { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public int passportNum { get; set; }

        public Login()
        {
            InitializeComponent();
        }

        ///
        /// Selected language data is passed to this form from Main upon Load event with updated components
        ///

        private void Login_Load(object sender, EventArgs e)
        {
            switch (mainSelectedLang)
            {
                case 0:
                    pbFlag.Image = Properties.Resources.norway;
                    mainSelectedLang = 0;
                    txtFirstName.Text = "Fornavn";
                    txtLastName.Text = "Etternavn";
                    txtPassportNum.Text = "Passnummer";
                    btnLogin.Text = "Logg Inn";
                    break;
                case 1:
                    pbFlag.Image = Properties.Resources.germany;
                    mainSelectedLang = 1;
                    txtFirstName.Text = "Vorname";
                    txtLastName.Text = "Nachname";
                    txtPassportNum.Text = "Ausweisnummer";
                    btnLogin.Text = "Anmeldung";
                    break;
                case 2:
                    pbFlag.Image = Properties.Resources.uk;
                    mainSelectedLang = 2;
                    txtFirstName.Text = "First name";
                    txtLastName.Text = "Last name";
                    txtPassportNum.Text = "Passport number";
                    btnLogin.Text = "Login";
                    break;
                default:
                    pbFlag.Image = Properties.Resources.norway;
                    mainSelectedLang = 0;
                    txtFirstName.Text = "Fornavn";
                    txtLastName.Text = "Etternavn";
                    txtPassportNum.Text = "Passnummer";
                    btnLogin.Text = "Logg Inn";
                    break;
            }
        }

        ///
        /// Copying the combo box language selection method from Main form with updated components
        ///

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
                    btnLogin.Text = "Logg Inn";
                    break;
                case 1:
                    pbFlag.Image = Properties.Resources.germany;
                    mainSelectedLang = 1;
                    txtFirstName.Text = "Vorname";
                    txtLastName.Text = "Nachname";
                    txtPassportNum.Text = "Ausweisnummer";
                    btnLogin.Text = "Anmeldung";
                    break;
                case 2:
                    pbFlag.Image = Properties.Resources.uk;
                    mainSelectedLang = 2;
                    txtFirstName.Text = "First name";
                    txtLastName.Text = "Last name";
                    txtPassportNum.Text = "Passport number";
                    btnLogin.Text = "Login";
                    break;
                default:
                    pbFlag.Image = Properties.Resources.norway;
                    mainSelectedLang = 0;
                    txtFirstName.Text = "Fornavn";
                    txtLastName.Text = "Etternavn";
                    txtPassportNum.Text = "Passnummer";
                    btnLogin.Text = "Logg Inn";
                    break;
            }
        }

        ///
        /// Added click events to text boxes so the default data clears for the user to start typing
        ///

        private void txtFirstName_Click(object sender, EventArgs e)
        {
            if (txtFirstName.Text.Length < 1 ||
                txtFirstName.Text == "Fornavn" ||
                txtFirstName.Text == "Vorname" ||
                txtFirstName.Text == "First name")
            {
                txtFirstName.Clear();
                txtFirstName.ForeColor = System.Drawing.Color.Black;
            }
        }

        private void txtLastName_Click(object sender, EventArgs e)
        {
            if (txtLastName.Text.Length < 1 ||
                txtLastName.Text == "Etternavn" ||
                txtLastName.Text == "Nachname" ||
                txtLastName.Text == "Last name")
            {
                txtLastName.Clear();
                txtLastName.ForeColor = System.Drawing.Color.Black;
            }
        }

        private void txtPassportNum_Click(object sender, EventArgs e)
        {
            if (txtPassportNum.Text.Length < 1 ||
                txtPassportNum.Text == "Passnummer" ||
                txtPassportNum.Text == "Ausweisnummer" ||
                txtPassportNum.Text == "Passport number")
            {
                txtPassportNum.Clear();
                txtPassportNum.ForeColor = System.Drawing.Color.Black;
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            MessageBox.Show(firstName + lastName + passportNum);
        }
    }
}
