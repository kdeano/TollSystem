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
        // 0 = Norwegian by default
        private static int selectedLang = 0;

        // Global objects for the Sign Up & Login forms
        //public static SignUp formSignUp = new SignUp(selectedLang);

        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            
        }

        private void cbLanguage_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedIndex = cbLanguage.SelectedIndex;
            selectedLang = selectedIndex;
            //Object selectedItem = cbLanguage.SelectedItem;

            // 0 = Norwegian
            // 1 = German
            // 2 = English

            //MessageBox.Show("Selected item text: " + selectedItem.ToString() + "\n" + "Index: " + selectedIndex.ToString());

            switch (selectedIndex)
            {
                case 0:
                    //MessageBox.Show("Norway");
                    pbFlag.Image = Properties.Resources.norway;
                    lblWelcome.Text = "Velkommen!";
                    btnSignUp.Text = "Melde deg på";
                    btnLogin.Text = "Logg Inn";
                    selectedLang = 0;
                    break;
                case 1:
                    //MessageBox.Show("Germany");
                    pbFlag.Image = Properties.Resources.germany;
                    lblWelcome.Text = "Willkommen!";
                    btnSignUp.Text = "Anmelden";
                    btnLogin.Text = "Einloggen";
                    selectedLang = 1;
                    break;
                case 2:
                    //MessageBox.Show("United Kingdom");
                    pbFlag.Image = Properties.Resources.uk;
                    lblWelcome.Text = "Welcome!";
                    btnSignUp.Text = "Sign up";
                    btnLogin.Text = "Log in";
                    selectedLang = 2;
                    break;
                default:
                    //MessageBox.Show("Norway");
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