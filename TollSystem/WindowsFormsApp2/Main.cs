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
    public partial class Main : Form
    {
        // Global variable to store selected language data across forms
        private static int selectedLang = 0;

        public Main()
        {
            InitializeComponent();
        }

        ///
        /// Creates a switch case on language selection and applies to selected language variable
        ///

        private void cbLanguage_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedIndex = cbLanguage.SelectedIndex;
            selectedLang = selectedIndex;

            // 0 (default) = Norwegian
            // 1 = German
            // 2 = English

            switch (selectedIndex)
            {
                case 0:
                    pbFlag.Image = Properties.Resources.norway;
                    lblWelcome.Text = Translations.WELCOME_NOR;
                    btnSignUp.Text = Translations.SIGNUP_NOR;
                    btnLogin.Text = Translations.LOGIN_NOR;
                    selectedLang = 0;
                    break;
                case 1:
                    pbFlag.Image = Properties.Resources.germany;
                    lblWelcome.Text = Translations.WELCOME_GER;
                    btnSignUp.Text = Translations.SIGNUP_GER;
                    btnLogin.Text = Translations.LOGIN_GER;
                    selectedLang = 1;
                    break;
                case 2:
                    pbFlag.Image = Properties.Resources.uk;
                    lblWelcome.Text = Translations.WELCOME_ENG;
                    btnSignUp.Text = Translations.SIGNUP_ENG;
                    btnLogin.Text = Translations.LOGIN_ENG;
                    selectedLang = 2;
                    break;
                default:
                    pbFlag.Image = Properties.Resources.norway;
                    lblWelcome.Text = Translations.WELCOME_NOR;
                    btnSignUp.Text = Translations.SIGNUP_NOR;
                    btnLogin.Text = Translations.LOGIN_NOR;
                    selectedLang = 0;
                    break;
            }
        }

        ///
        /// Creates instance of SignUp form and passes the selected language data
        ///

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            SignUp formSignUp = new SignUp();

            formSignUp.mainSelectedLang = selectedLang;
            formSignUp.ShowDialog();
        }

        ///
        /// Creates instance of Login form and passes all data from Main and SignUp forms
        ///

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Login formLogin = new Login();

            formLogin.mainSelectedLang = selectedLang;
            formLogin.firstName = SignUp.signUpFirstName;
            formLogin.lastName = SignUp.signUpLastName;
            formLogin.passportNum = SignUp.signUpPassportNum;
            
            formLogin.ShowDialog();
        }

        ///
        /// Exits the application (closes all forms) on exit button click
        ///

        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}