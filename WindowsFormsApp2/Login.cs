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

        // Declaring global consts for error (wrong credentials) messages for all languages
        private const string ERROR_CREDS_MSG_NOR = "Feil: Kontroller at legitimasjonen din er riktig.";
        private const string ERROR_CREDS_MSG_GER = "Fehler: Bitte stellen Sie sicher, dass Ihre Anmeldeinformationen korrekt sind.";
        private const string ERROR_CREDS_MSG_ENG = "Error: Please make sure your credentials are correct.";

        // Declaring global consts for error (empty strings) messages for all languages
        private const string ERROR_EMPTY_MSG_NOR = "Feil: Sørg for at alle tekstbokser er fylt ut.";
        private const string ERROR_EMPTY_MSG_GER = "Fehler: Bitte stellen Sie sicher, dass alle Textfelder ausgefüllt sind.";
        private const string ERROR_EMPTY_MSG_ENG = "Error: Please make sure all text boxes are filled.";

        // Declaring global consts for success messages for all languages
        private const string SUCCESS_MSG_NOR = "Suksess: Du har blitt logget inn.\n\nDu vil nå bli omdirigert for å legge til kjøretøy- og bankinformasjon.";
        private const string SUCCESS_MSG_GER = "Erfolg: Sie wurden angemeldet.\n\nSie werden nun weitergeleitet, um Fahrzeug- und Bankinformationen hinzuzufügen.";
        private const string SUCCESS_MSG_ENG = "Success: You have been logged in.\n\nYou will now be redirected to add vehicle & bank information.";

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
            }
        }

        ///
        /// Added KeyPress events to text boxes to change colour to black
        /// Prevents grey text when user uses TAB instead of mouse click to navigate
        ///

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

        ///
        /// Added logic when login button is clicked to display success or error messages to user depending on logic path
        /// Added a for loop to close any form that is not the UserPanel after successful login
        ///

        private void btnLogin_Click(object sender, EventArgs e)
        {
            // TODO: Add logic for Toll Operator login

            // User login logic
            if (txtFirstName.Text == firstName &&
                txtLastName.Text == lastName &&
                Convert.ToInt32(txtPassportNum.Text) == passportNum)
            {
                switch (mainSelectedLang)
                {
                    case 0:
                        MessageBox.Show(SUCCESS_MSG_NOR);
                        break;
                    case 1:
                        MessageBox.Show(SUCCESS_MSG_GER);
                        break;
                    case 2:
                        MessageBox.Show(SUCCESS_MSG_ENG);
                        break;
                    default:
                        MessageBox.Show(SUCCESS_MSG_NOR);
                        break;
                }

                UserPanel formUserPanel = new UserPanel();
                UserInfo formUserInfo = new UserInfo();

                formUserPanel.Show();

                for (int i = Application.OpenForms.Count - 1; i >= 0; i--)
                {
                    if (Application.OpenForms[i].Name != "UserPanel")
                    {
                        Application.OpenForms[i].Hide();
                    }
                }

                formUserInfo.mainSelectedLang = mainSelectedLang;
                formUserInfo.ShowDialog();
            } else if (txtFirstName.Text.Length < 1 ||
                txtLastName.Text.Length < 1 ||
                txtPassportNum.Text.Length < 1 ||
                txtFirstName.Text == "" ||
                txtLastName.Text == "" ||
                txtPassportNum.Text == "")
            {
                switch (mainSelectedLang)
                {
                    case 0:
                        MessageBox.Show(ERROR_EMPTY_MSG_NOR);
                        break;
                    case 1:
                        MessageBox.Show(ERROR_EMPTY_MSG_GER);
                        break;
                    case 2:
                        MessageBox.Show(ERROR_EMPTY_MSG_ENG);
                        break;
                    default:
                        MessageBox.Show(ERROR_EMPTY_MSG_NOR);
                        break;
                }
            } else
            {
                switch (mainSelectedLang)
                {
                    case 0:
                        MessageBox.Show(ERROR_CREDS_MSG_NOR);
                        break;
                    case 1:
                        MessageBox.Show(ERROR_CREDS_MSG_GER);
                        break;
                    case 2:
                        MessageBox.Show(ERROR_CREDS_MSG_ENG);
                        break;
                    default:
                        MessageBox.Show(ERROR_CREDS_MSG_NOR);
                        break;
                }
            }
        }

        ///
        /// Closes this form on exit click to release memory
        ///

        private void Login_FormClosed(object sender, FormClosedEventArgs e)
        {
            Close();
        }
    }
}
