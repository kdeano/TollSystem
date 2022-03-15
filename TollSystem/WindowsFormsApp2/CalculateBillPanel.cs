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
        public CalculateBillPanel()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            //calculate and display bill of user selected
            OperatorPanel formOperatorPanel = new OperatorPanel();

            formOperatorPanel.listUsersExit13.Items[2].SubItems[3].Text = "36";
            formOperatorPanel.listUsersExit12.Items[0].SubItems[3].Text = "36";
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
    }
}
