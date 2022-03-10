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
    public partial class UserInfo : Form
    {
        public int mainSelectedLang { get; set; }
        public string firstName { get; set; }
        public static string carModel = "";
        public static string regNum = "";

        public UserInfo()
        {
            InitializeComponent();

            firstName = SignUp.signUpFirstName;
            this.Text = "Toll System | User Information:" + " " + firstName;
        }

        private void UserInformation_Load(object sender, EventArgs e)
        {
            switch (mainSelectedLang)
            {
                case 0:
                    pbFlag.Image = Properties.Resources.norway;
                    txtCarModel.Text = Translations.CAR_MODEL_NOR;
                    txtRegNum.Text = Translations.CAR_REG_NUMBER_NOR;
                    btnSubmitCar.Text = Translations.SUBMIT_NOR;
                    mainSelectedLang = 0;
                    break;
                case 1:
                    pbFlag.Image = Properties.Resources.germany;
                    txtCarModel.Text = Translations.CAR_MODEL_GER;
                    txtRegNum.Text = Translations.CAR_REG_NUMBER_GER;
                    btnSubmitCar.Text = Translations.SUBMIT_GER;
                    mainSelectedLang = 1;
                    break;
                case 2:
                    pbFlag.Image = Properties.Resources.uk;
                    txtCarModel.Text = Translations.CAR_MODEL_ENG;
                    txtRegNum.Text = Translations.CAR_REG_NUMBER_ENG;
                    btnSubmitCar.Text = Translations.SUBMIT_ENG;
                    mainSelectedLang = 2;
                    break;
                default:
                    pbFlag.Image = Properties.Resources.norway;
                    txtCarModel.Text = Translations.CAR_MODEL_NOR;
                    txtRegNum.Text = Translations.CAR_REG_NUMBER_NOR;
                    btnSubmitCar.Text = Translations.SUBMIT_NOR;
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
                    txtCarModel.Text = Translations.CAR_MODEL_NOR;
                    txtRegNum.Text = Translations.CAR_REG_NUMBER_NOR;
                    btnSubmitCar.Text = Translations.SUBMIT_NOR;
                    txtAccountName.Text = Translations.ACCOUNT_NAME_NOR;
                    txtCardNum.Text = Translations.CARD_NUMBER_NOR;
                    lblExpiryDate.Text = Translations.EXPIRY_DATE_NOR;
                    txtSecurityCode.Text = Translations.CARD_SECURITY_CODE_NOR;
                    btnSubmitBank.Text = Translations.SUBMIT_NOR;
                    mainSelectedLang = 0;
                    break;
                case 1:
                    pbFlag.Image = Properties.Resources.germany;
                    txtCarModel.Text = Translations.CAR_MODEL_GER;
                    txtRegNum.Text = Translations.CAR_REG_NUMBER_GER;
                    btnSubmitCar.Text = Translations.SUBMIT_GER;
                    txtAccountName.Text = Translations.ACCOUNT_NAME_GER;
                    txtCardNum.Text = Translations.CARD_NUMBER_GER;
                    lblExpiryDate.Text = Translations.EXPIRY_DATE_GER;
                    txtSecurityCode.Text = Translations.CARD_SECURITY_CODE_GER;
                    btnSubmitBank.Text = Translations.SUBMIT_GER;
                    mainSelectedLang = 1;
                    break;
                case 2:
                    pbFlag.Image = Properties.Resources.uk;
                    txtCarModel.Text = Translations.CAR_MODEL_ENG;
                    txtRegNum.Text = Translations.CAR_REG_NUMBER_ENG;
                    btnSubmitCar.Text = Translations.SUBMIT_ENG;
                    txtAccountName.Text = Translations.ACCOUNT_NAME_ENG;
                    txtCardNum.Text = Translations.CARD_NUMBER_ENG;
                    lblExpiryDate.Text = Translations.EXPIRY_DATE_ENG;
                    txtSecurityCode.Text = Translations.CARD_SECURITY_CODE_ENG;
                    btnSubmitBank.Text = Translations.SUBMIT_ENG;
                    mainSelectedLang = 2;
                    break;
                default:
                    pbFlag.Image = Properties.Resources.norway;
                    txtCarModel.Text = Translations.CAR_MODEL_NOR;
                    txtRegNum.Text = Translations.CAR_REG_NUMBER_NOR;
                    btnSubmitCar.Text = Translations.SUBMIT_NOR;
                    txtAccountName.Text = Translations.ACCOUNT_NAME_NOR;
                    txtCardNum.Text = Translations.CARD_NUMBER_NOR;
                    lblExpiryDate.Text = Translations.EXPIRY_DATE_NOR;
                    txtSecurityCode.Text = Translations.CARD_SECURITY_CODE_NOR;
                    btnSubmitBank.Text = Translations.SUBMIT_NOR;
                    mainSelectedLang = 0;
                    break;
            }
        }

        ///
        /// Added click events to text boxes so the default data clears for the user to start typing
        ///

        private void txtCarModel_Click(object sender, EventArgs e)
        {
            if (txtCarModel.Text.Length < 1 ||
                txtCarModel.Text == Translations.CAR_MODEL_NOR ||
                txtCarModel.Text == Translations.CAR_MODEL_GER ||
                txtCarModel.Text == Translations.CAR_MODEL_ENG)
            {
                txtCarModel.Clear();
            }
        }

        private void txtRegNum_Click(object sender, EventArgs e)
        {
            if (txtRegNum.Text.Length < 1 ||
                txtRegNum.Text == Translations.CAR_REG_NUMBER_NOR ||
                txtRegNum.Text == Translations.CAR_REG_NUMBER_GER ||
                txtRegNum.Text == Translations.CAR_REG_NUMBER_ENG)
            {
                txtRegNum.Clear();
            }
        }

        private void txtAccountName_Click(object sender, EventArgs e)
        {
            if (txtAccountName.Text.Length < 1 ||
                txtAccountName.Text == Translations.ACCOUNT_NAME_NOR ||
                txtAccountName.Text == Translations.ACCOUNT_NAME_GER ||
                txtAccountName.Text == Translations.ACCOUNT_NAME_ENG)
            {
                txtAccountName.Clear();
            }
        }

        private void txtCardNum_Click(object sender, EventArgs e)
        {
            if (txtCardNum.Text.Length < 1 ||
                txtCardNum.Text == Translations.CARD_NUMBER_NOR ||
                txtCardNum.Text == Translations.CARD_NUMBER_GER ||
                txtCardNum.Text == Translations.CARD_NUMBER_ENG)
            {
                txtCardNum.Clear();
            }
        }

        private void txtSecurityCode_Click(object sender, EventArgs e)
        {
            if (txtSecurityCode.Text.Length < 1 ||
                txtSecurityCode.Text == Translations.CARD_SECURITY_CODE_NOR ||
                txtSecurityCode.Text == Translations.CARD_SECURITY_CODE_GER ||
                txtSecurityCode.Text == Translations.CARD_SECURITY_CODE_ENG)
            {
                txtSecurityCode.Clear();
            }
        }

        ///
        /// Added KeyPress events to text boxes to change colour to black
        /// Prevents grey text when user uses TAB instead of mouse click to navigate
        ///

        private void txtCarModel_KeyPress(object sender, KeyPressEventArgs e)
        {
            txtCarModel.ForeColor = System.Drawing.Color.Black;
        }

        private void txtRegNum_KeyPress(object sender, KeyPressEventArgs e)
        {
            txtRegNum.ForeColor = System.Drawing.Color.Black;
        }

        private void txtAccountName_KeyPress(object sender, KeyPressEventArgs e)
        {
            txtAccountName.ForeColor = System.Drawing.Color.Black;
        }

        private void txtCardNum_KeyPress(object sender, KeyPressEventArgs e)
        {
            txtCardNum.ForeColor = System.Drawing.Color.Black;
        }

        private void txtSecurityCode_KeyPress(object sender, KeyPressEventArgs e)
        {
            txtSecurityCode.ForeColor = System.Drawing.Color.Black;
        }

        ///
        /// TODO: Comment for submit car button
        ///

        private void btnSubmitCar_Click(object sender, EventArgs e)
        {
            if (txtCarModel.Text.Length > 1 &&
                txtRegNum.Text.Length > 1 &&
                txtCarModel.Text != "" &&
                txtRegNum.Text != "")
            {
                switch (mainSelectedLang)
                {
                    case 0:
                        MessageBox.Show(Translations.SUCCESS_CAR_MSG_NOR);
                        txtAccountName.Text = Translations.ACCOUNT_NAME_NOR;
                        txtCardNum.Text = Translations.CARD_NUMBER_NOR;
                        lblExpiryDate.Text = Translations.EXPIRY_DATE_NOR;
                        txtSecurityCode.Text = Translations.CARD_SECURITY_CODE_NOR;
                        btnSubmitBank.Text = Translations.SUBMIT_NOR;
                        break;
                    case 1:
                        MessageBox.Show(Translations.SUCCESS_CAR_MSG_GER);
                        txtAccountName.Text = Translations.ACCOUNT_NAME_GER;
                        txtCardNum.Text = Translations.CARD_NUMBER_GER;
                        lblExpiryDate.Text = Translations.EXPIRY_DATE_GER;
                        txtSecurityCode.Text = Translations.CARD_SECURITY_CODE_GER;
                        btnSubmitBank.Text = Translations.SUBMIT_GER;
                        break;
                    case 2:
                        MessageBox.Show(Translations.SUCCESS_CAR_MSG_ENG);
                        txtAccountName.Text = Translations.ACCOUNT_NAME_ENG;
                        txtCardNum.Text = Translations.CARD_NUMBER_ENG;
                        lblExpiryDate.Text = Translations.EXPIRY_DATE_ENG;
                        txtSecurityCode.Text = Translations.CARD_SECURITY_CODE_ENG;
                        btnSubmitBank.Text = Translations.SUBMIT_ENG;
                        break;
                    default:
                        MessageBox.Show(Translations.SUCCESS_CAR_MSG_NOR);
                        txtAccountName.Text = Translations.ACCOUNT_NAME_NOR;
                        txtCardNum.Text = Translations.CARD_NUMBER_NOR;
                        lblExpiryDate.Text = Translations.EXPIRY_DATE_NOR;
                        txtSecurityCode.Text = Translations.CARD_SECURITY_CODE_NOR;
                        btnSubmitBank.Text = Translations.SUBMIT_NOR;
                        break;
                }

                txtCarModel.Visible = false;
                txtRegNum.Visible = false;
                btnSubmitCar.Visible = false;

                txtAccountName.Visible = true;
                txtCardNum.Visible = true;
                lblExpiryDate.Visible = true;
                cbExpiryMonth.Visible = true;
                cbExpiryYear.Visible = true;
                txtSecurityCode.Visible = true;
                btnSubmitBank.Visible = true;
            } else if (txtCarModel.Text.Length < 1 ||
                txtRegNum.Text.Length < 1 ||
                txtCarModel.Text == "" ||
                txtRegNum.Text == "")
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
            } else
            {
                switch (mainSelectedLang)
                {
                    case 0:
                        MessageBox.Show(Translations.ERROR_OTHER_MSG_NOR);
                        break;
                    case 1:
                        MessageBox.Show(Translations.ERROR_OTHER_MSG_GER);
                        break;
                    case 2:
                        MessageBox.Show(Translations.ERROR_OTHER_MSG_ENG);
                        break;
                    default:
                        MessageBox.Show(Translations.ERROR_OTHER_MSG_NOR);
                        break;
                }
            }
        }

        ///
        /// TODO: Comment on submit bank button
        ///

        private void btnSubmitBank_Click(object sender, EventArgs e)
        {
            // TODO: Add logic for submit bank details button
        }

        ///
        /// Closes this form on exit click to release memory
        ///

        private void UserInfo_FormClosed(object sender, FormClosedEventArgs e)
        {
            Close();
        }
    }
}
