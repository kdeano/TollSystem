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
        // Declaring global variable to get and set selected language
        public int mainSelectedLang { get; set; }

        // Declaring global variables to pass text box data to Login form
        public static string signUpFirstName;
        public static string signUpLastName;
        public static int signUpPassportNum;

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
                    txtFirstName.Text = Translations.FIRST_NAME_NOR;
                    txtLastName.Text = Translations.LAST_NAME_NOR;
                    txtPassportNum.Text = Translations.PASSPORT_NUMBER_NOR;
                    btnSignUp.Text = Translations.SIGNUP_NOR;
                    mainSelectedLang = 0;
                    break;
                case 1:
                    pbFlag.Image = Properties.Resources.germany;
                    txtFirstName.Text = Translations.FIRST_NAME_GER;
                    txtLastName.Text = Translations.LAST_NAME_GER;
                    txtPassportNum.Text = Translations.PASSPORT_NUMBER_GER;
                    btnSignUp.Text = Translations.SIGNUP_GER;
                    mainSelectedLang = 1;
                    break;
                case 2:
                    pbFlag.Image = Properties.Resources.uk;
                    txtFirstName.Text = Translations.FIRST_NAME_ENG;
                    txtLastName.Text = Translations.LAST_NAME_ENG;
                    txtPassportNum.Text = Translations.PASSPORT_NUMBER_ENG;
                    btnSignUp.Text = Translations.SIGNUP_ENG;
                    mainSelectedLang = 2;
                    break;
                default:
                    pbFlag.Image = Properties.Resources.norway;
                    txtFirstName.Text = Translations.FIRST_NAME_NOR;
                    txtLastName.Text = Translations.LAST_NAME_NOR;
                    txtPassportNum.Text = Translations.PASSPORT_NUMBER_NOR;
                    btnSignUp.Text = Translations.SIGNUP_NOR;
                    mainSelectedLang = 0;
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
                    txtFirstName.Text = Translations.FIRST_NAME_NOR;
                    txtLastName.Text = Translations.LAST_NAME_NOR;
                    txtPassportNum.Text = Translations.PASSPORT_NUMBER_NOR;
                    btnSignUp.Text = Translations.SIGNUP_NOR;
                    mainSelectedLang = 0;
                    break;
                case 1:
                    pbFlag.Image = Properties.Resources.germany;
                    txtFirstName.Text = Translations.FIRST_NAME_GER;
                    txtLastName.Text = Translations.LAST_NAME_GER;
                    txtPassportNum.Text = Translations.PASSPORT_NUMBER_GER;
                    btnSignUp.Text = Translations.SIGNUP_GER;
                    mainSelectedLang = 1;
                    break;
                case 2:
                    pbFlag.Image = Properties.Resources.uk;
                    txtFirstName.Text = Translations.FIRST_NAME_ENG;
                    txtLastName.Text = Translations.LAST_NAME_ENG;
                    txtPassportNum.Text = Translations.PASSPORT_NUMBER_ENG;
                    btnSignUp.Text = Translations.SIGNUP_ENG;
                    mainSelectedLang = 2;
                    break;
                default:
                    pbFlag.Image = Properties.Resources.norway;
                    txtFirstName.Text = Translations.FIRST_NAME_NOR;
                    txtLastName.Text = Translations.LAST_NAME_NOR;
                    txtPassportNum.Text = Translations.PASSPORT_NUMBER_NOR;
                    btnSignUp.Text = Translations.SIGNUP_NOR;
                    mainSelectedLang = 0;
                    break;
            }
        }

        ///
        /// Added click events to text boxes so the default data clears for the user to start typing
        ///

        private void txtFirstName_Click(object sender, EventArgs e)
        {
            if (txtFirstName.Text.Length < 1 || 
                txtFirstName.Text == Translations.FIRST_NAME_NOR || 
                txtFirstName.Text == Translations.FIRST_NAME_GER || 
                txtFirstName.Text == Translations.FIRST_NAME_ENG)
            {
                txtFirstName.Clear();
            }
        }

        private void txtLastName_Click(object sender, EventArgs e)
        {
            if (txtLastName.Text.Length < 1 ||
                txtLastName.Text == Translations.LAST_NAME_NOR ||
                txtLastName.Text == Translations.LAST_NAME_GER ||
                txtLastName.Text == Translations.LAST_NAME_ENG)
            {
                txtLastName.Clear();
            }
        }

        private void txtPassportNum_Click(object sender, EventArgs e)
        {
            if (txtPassportNum.Text.Length < 1 ||
                txtPassportNum.Text == Translations.PASSPORT_NUMBER_NOR ||
                txtPassportNum.Text == Translations.PASSPORT_NUMBER_GER ||
                txtPassportNum.Text == Translations.PASSPORT_NUMBER_ENG)
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
                        MessageBox.Show(Translations.SUCCESS_SIGNUP_MSG_NOR);
                        break;
                    case 1:
                        MessageBox.Show(Translations.SUCCESS_SIGNUP_MSG_GER);
                        break;
                    case 2:
                        MessageBox.Show(Translations.SUCCESS_SIGNUP_MSG_ENG);
                        break;
                    default:
                        MessageBox.Show(Translations.SUCCESS_SIGNUP_MSG_NOR);
                        break;
                }

                this.Hide();
            } else
            {
                switch (mainSelectedLang)
                {
                    case 0:
                        MessageBox.Show(Translations.ERROR_EMPTY_MSG_NOR);
                        break;
                    case 1:
                        MessageBox.Show(Translations.ERROR_EMPTY_MSG_GER);
                        break;
                    case 2:
                        MessageBox.Show(Translations.ERROR_EMPTY_MSG_ENG);
                        break;
                    default:
                        MessageBox.Show(Translations.ERROR_EMPTY_MSG_NOR);
                        break;
                }
            }
        }

        ///
        /// Closes this form on exit click to release memory
        ///

        private void SignUp_FormClosed(object sender, FormClosedEventArgs e)
        {
            Close();
        }
    }
}
