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
        public partial class OperatorPanel : Form
        {
        // Declaring global variables to get and set selected language information
        public int mainSelectedLang { get; set; }
 
        public OperatorPanel()
            {
                InitializeComponent();
            }

            private void listView1_SelectedIndexChanged(object sender, EventArgs e)
            {

            }

            private void listExits_SelectedIndexChanged(object sender, EventArgs e)
            {
                //View different payment history when different exit is selected
                if (listUsersExit12_Eng.Visible == true)
                {
                    listUsersExit12_Eng.Hide();
                    listUsersExit13_Eng.Show();
                }
                else
                {
                    listUsersExit13_Eng.Hide();
                    listUsersExit12_Eng.Show();
                }
            }

            private void btnCalculateBill_Click(object sender, EventArgs e)
            {
                //Open new window to calculate bill
                CalculateBillPanel formBillPanel = new CalculateBillPanel();

                formBillPanel.Show();

                //If a form does not have the name of the operator panel hide it
                for (int i = Application.OpenForms.Count - 1; i >= 0; i--)
                {
                    if (Application.OpenForms[i].Name != "CalculateBillPanel")
                    {
                        Application.OpenForms[i].Hide();
                    }
                }
            }

            public void listUsersExit13_SelectedIndexChanged(object sender, EventArgs e)
            {

            }

            private void cbLanguage_SelectedIndexChanged(object sender, EventArgs e)
            {
                int selectedIndex = cbLanguage.SelectedIndex;

                switch (selectedIndex)
                {
                    case 0:
                        pbFlag.Image = Properties.Resources.norway;
                        txtBillTitle.Text = Translations.OPERATOR_PANEL_TITLE_NOR;
                        txtSelectExit.Text = Translations.SELECT_EXIT_TITLE_NOR;
                        btnCalculateBill.Text = Translations.PROCESS_BUTTON_TEXT_NOR;
                        mainSelectedLang = 0;
                        listUsersExit13_Nor.Show();
                        listUsersExit12_Eng.Hide();
                        listUsersExit12_Ger.Hide();
                        listUsersExit13_Eng.Hide();
                        break;
                    case 1:
                        pbFlag.Image = Properties.Resources.germany;
                        txtBillTitle.Text = Translations.OPERATOR_PANEL_TITLE_GER;
                        txtSelectExit.Text = Translations.SELECT_EXIT_TITLE_GER;
                        btnCalculateBill.Text = Translations.PROCESS_BUTTON_TEXT_GER;
                        mainSelectedLang = 1;
                        listUsersExit13_Nor.Hide();
                        listUsersExit12_Eng.Hide();
                        listUsersExit12_Ger.Show();
                        listUsersExit13_Eng.Hide();
                        break;
                    case 2:
                        pbFlag.Image = Properties.Resources.uk;
                        txtBillTitle.Text = Translations.OPERATOR_PANEL_TITLE_ENG;
                        txtSelectExit.Text = Translations.SELECT_EXIT_TITLE_ENG;
                        btnCalculateBill.Text = Translations.PROCESS_BUTTON_TEXT_ENG;
                        mainSelectedLang = 2;
                        listUsersExit13_Nor.Hide();
                        listUsersExit12_Eng.Hide();
                        listUsersExit12_Ger.Hide();
                        listUsersExit13_Eng.Show();
                        break;
                    default:
                        pbFlag.Image = Properties.Resources.norway;
                        txtBillTitle.Text = Translations.OPERATOR_PANEL_TITLE_NOR;
                        txtSelectExit.Text = Translations.SELECT_EXIT_TITLE_NOR;
                        btnCalculateBill.Text = Translations.PROCESS_BUTTON_TEXT_NOR;
                        mainSelectedLang = 0;
                        listUsersExit13_Nor.Show();
                        listUsersExit12_Eng.Hide();
                        listUsersExit12_Ger.Hide();
                        listUsersExit13_Eng.Hide();
                        break;
                }
            }

        private void OperatorPanel_Load(object sender, EventArgs e)
        {

        }
    }
    }
}
