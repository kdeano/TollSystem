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
        // 0 (default) = Norwegian
        private static int selectedLang = 0;

        public Main()
        {
            InitializeComponent();
        }

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
                    lblWelcome.Text = "Velkommen!";
                    btnSignUp.Text = "Melde deg på";
                    btnLogin.Text = "Logg Inn";
                    selectedLang = 0;
                    break;
                case 1:
                    pbFlag.Image = Properties.Resources.germany;
                    lblWelcome.Text = "Willkommen!";
                    btnSignUp.Text = "Anmelden";
                    btnLogin.Text = "Einloggen";
                    selectedLang = 1;
                    break;
                case 2:
                    pbFlag.Image = Properties.Resources.uk;
                    lblWelcome.Text = "Welcome!";
                    btnSignUp.Text = "Sign up";
                    btnLogin.Text = "Log in";
                    selectedLang = 2;
                    break;
                default:
                    pbFlag.Image = Properties.Resources.norway;
                    lblWelcome.Text = "Velkommen!";
                    btnSignUp.Text = "Melde deg på";
                    btnLogin.Text = "Logg Inn";
                    selectedLang = 0;
                    break;
            }
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            SignUp formSignUp = new SignUp();

            formSignUp.mainSelectedLang = selectedLang;
            formSignUp.ShowDialog();
        }

        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}