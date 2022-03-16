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

        public partial class CalculateBillPanel : Form
    {
        // Declaring global variables to get and set selected language information
        public int mainSelectedLang { get; set; }

        public CalculateBillPanel()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            //calculate and display bill of user selected
            OperatorPanel formOperatorPanel = new OperatorPanel();

            formOperatorPanel.listUsersExit13_Eng.Items[2].SubItems[3].Text = "36";
            formOperatorPanel.listUsersExit12_Eng.Items[0].SubItems[3].Text = "36";
            formOperatorPanel.Show();

            //If a form does not have the name of the operator panel hide it
            for (int i = Application.OpenForms.Count - 1; i >= 0; i--)
            {
                if (Application.OpenForms[i].Name != "OperatorPanel")
                {
                    Application.OpenForms[i].Hide();
                }
            }
        }

        private void cbLanguage_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedIndex = cbLanguage.SelectedIndex;

            switch (selectedIndex)
            {
                case 0:
                    pbFlag.Image = Properties.Resources.norway;
                    btnCalculate.Text = Translations.CALCULATE_BUTTON_TEXT_NOR;
                    lstUserDetails_Eng.Hide();
                    lstUserDetails_Ger.Hide();
                    lstUserDetails_Nor.Show();
                    mainSelectedLang = 0;
                    break;
                case 1:
                    pbFlag.Image = Properties.Resources.germany;
                    btnCalculate.Text = Translations.CALCULATE_BUTTON_TEXT_GER;
                    lstUserDetails_Eng.Hide();
                    lstUserDetails_Ger.Show();
                    lstUserDetails_Nor.Hide();
                    mainSelectedLang = 1;
                    break;
                case 2:
                    pbFlag.Image = Properties.Resources.uk;
                    btnCalculate.Text = Translations.CALCULATE_BUTTON_TEXT_ENG;
                    lstUserDetails_Eng.Show();
                    lstUserDetails_Ger.Hide();
                    lstUserDetails_Nor.Hide();
                    mainSelectedLang = 2;
                    break;
                default:
                    pbFlag.Image = Properties.Resources.norway;
                    btnCalculate.Text = Translations.CALCULATE_BUTTON_TEXT_NOR;
                    lstUserDetails_Eng.Hide();
                    lstUserDetails_Ger.Hide();
                    lstUserDetails_Nor.Show();
                    mainSelectedLang = 0;
                    break;
            }


    }
}
