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
            if (listUsersExit12.Visible == true)
            {
                listUsersExit12.Hide();
                listUsersExit13.Show();
            }
            else
            {
                listUsersExit13.Hide();
                listUsersExit12.Show();
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
    }
}
