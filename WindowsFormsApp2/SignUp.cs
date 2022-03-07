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
        // Declaring global variables to pass text box data to Login form
        public static string signUpFirstName;
        public static string signUpLastName;
        public static int signUpPassportNum;

        // Dcelaring global variables for error messages for all languages
        private static string errorMsgNor = "Feil: Sørg for at alle tekstbokser er fylt ut.";
        private static string errorMsgGer = "Fehler: Bitte stellen Sie sicher, dass alle Textfelder ausgefüllt sind.";
        private static string errorMsgEng = "Error: Please make sure all text boxes are filled.";

        // Declaring global variables for success messages for all languages
        private static string successMsgNor = "Suksess: Fortsett for å logge på.";
        private static string successMsgGer = "Erfolgreich: Bitte melden Sie sich an.";
        private static string successMsgEng = "Success: Please proceed to log in.";

        // Declaring global variable to get and set selected language
        public int mainSelectedLang { get; set; }

        public SignUp()
        {
            InitializeComponent();
        }

        ///
        /// Selected language data is passed to this form from Main upon Load event with updated components
        ///

        private void SignUp_Load(object sender, EventArgs e)
        {
            switch (mainSelectedLang)
            {
                case 0:
                    pbFlag.Image = Properties.Resources.norway;
                    mainSelectedLang = 0;
                    txtFirstName.Text = "Fornavn";
                    txtLastName.Text = "Etternavn";
                    txtPassportNum.Text = "Passnummer";
                    btnSignUp.Text = "Melde deg på";
                    break;
                case 1:
                    pbFlag.Image = Properties.Resources.germany;
                    mainSelectedLang = 1;
                    txtFirstName.Text = "Vorname";
                    txtLastName.Text = "Nachname";
                    txtPassportNum.Text = "Ausweisnummer";
                    btnSignUp.Text = "Anmelden";
                    break;
                case 2:
                    pbFlag.Image = Properties.Resources.uk;
                    mainSelectedLang = 2;
                    txtFirstName.Text = "First name";
                    txtLastName.Text = "Last name";
                    txtPassportNum.Text = "Passport number";
                    btnSignUp.Text = "Sign up";
                    break;
                default:
                    pbFlag.Image = Properties.Resources.norway;
                    mainSelectedLang = 0;
                    txtFirstName.Text = "Fornavn";
                    txtLastName.Text = "Etternavn";
                    txtPassportNum.Text = "Passnummer";
                    btnSignUp.Text = "Melde deg på";
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
                    btnSignUp.Text = "Melde deg på";
                    break;
                case 1:
                    pbFlag.Image = Properties.Resources.germany;
                    mainSelectedLang = 1;
                    txtFirstName.Text = "Vorname";
                    txtLastName.Text = "Nachname";
                    txtPassportNum.Text = "Ausweisnummer";
                    btnSignUp.Text = "Anmelden";
                    break;
                case 2:
                    pbFlag.Image = Properties.Resources.uk;
                    mainSelectedLang = 2;
                    txtFirstName.Text = "First name";
                    txtLastName.Text = "Last name";
                    txtPassportNum.Text = "Passport number";
                    btnSignUp.Text = "Sign up";
                    break;
                default:
                    pbFlag.Image = Properties.Resources.norway;
                    mainSelectedLang = 0;
                    txtFirstName.Text = "Fornavn";
                    txtLastName.Text = "Etternavn";
                    txtPassportNum.Text = "Passnummer";
                    btnSignUp.Text = "Melde deg på";
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
        /// Assigned global variable values to text box string values on Sign up button click
        ///

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            if (txtFirstName.Text.Length > 1 && 
                txtLastName.Text.Length > 1 && 
                txtPassportNum.Text.Length > 1 &&
                txtFirstName.Text != "" &&
                txtLastName.Text != "" &&
                txtPassportNum.Text != "")
            {
                SignUp.signUpFirstName = txtFirstName.Text;
                SignUp.signUpLastName = txtLastName.Text;
                SignUp.signUpPassportNum = Convert.ToInt32(txtPassportNum.Text);

                switch (mainSelectedLang)
                {
                    case 0:
                        MessageBox.Show(successMsgNor);
                        break;
                    case 1:
                        MessageBox.Show(successMsgGer);
                        break;
                    case 2:
                        MessageBox.Show(successMsgEng);
                        break;
                    default:
                        MessageBox.Show(successMsgNor);
                        break;
                }

                this.Hide();
            } else
            {
                switch (mainSelectedLang)
                {
                    case 0:
                        MessageBox.Show(errorMsgNor);
                        break;
                    case 1:
                        MessageBox.Show(errorMsgGer);
                        break;
                    case 2:
                        MessageBox.Show(errorMsgEng);
                        break;
                    default:
                        MessageBox.Show(errorMsgNor);
                        break;
                }
            }
        }

        ///
        /// Hides this form on exit click (closing causes stack overflow errors)
        ///

        private void SignUp_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
        }
    }
}
