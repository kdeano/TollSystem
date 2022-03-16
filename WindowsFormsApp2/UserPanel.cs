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
    public partial class UserPanel : Form
    {
        // Including getters and setters for all user information needed from other forms
        public int mainSelectedLang { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public int passportNum { get; set; }

        public string carModel { get; set; }
        public string carRegNumber { get; set; }
        public string bankAccountName { get; set; }
        public int bankCardNumber { get; set; }
        public int bankSecurityCode { get; set; }
        public int bankCardExpiryMonth { get; set; }
        public int bankCardExpiryYear { get; set; }

        public UserPanel()
        {
            InitializeComponent();
        }

        ///
        /// Loading data to the form on load
        ///

        private void UserPanel_Load(object sender, EventArgs e)
        {
            firstName = SignUp.signUpFirstName;
            this.Text = "Toll System | User Panel: " + firstName;
            this.lblName.Text = firstName + " " + lastName;
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
                    btnUserInfo.Text = Translations.USER_INFO_NOR;
                    btnCarInfo.Text = Translations.CAR_INFO_NOR;
                    btnBankDetails.Text = Translations.BANK_DETAILS_NOR;
                    btnPaymentHistory.Text = Translations.PAYMENT_HISTORY_NOR;
                    mainSelectedLang = 0;
                    break;
                case 1:
                    pbFlag.Image = Properties.Resources.germany;
                    btnUserInfo.Text = Translations.USER_INFO_GER;
                    btnCarInfo.Text = Translations.CAR_INFO_GER;
                    btnBankDetails.Text = Translations.BANK_DETAILS_GER;
                    btnPaymentHistory.Text = Translations.PAYMENT_HISTORY_GER;
                    mainSelectedLang = 1;
                    break;
                case 2:
                    pbFlag.Image = Properties.Resources.uk;
                    btnUserInfo.Text = Translations.USER_INFO_ENG;
                    btnCarInfo.Text = Translations.CAR_INFO_ENG;
                    btnBankDetails.Text = Translations.BANK_DETAILS_ENG;
                    btnPaymentHistory.Text = Translations.PAYMENT_HISTORY_ENG;
                    mainSelectedLang = 2;
                    break;
                default:
                    pbFlag.Image = Properties.Resources.norway;
                    btnUserInfo.Text = Translations.USER_INFO_NOR;
                    btnCarInfo.Text = Translations.CAR_INFO_NOR;
                    btnBankDetails.Text = Translations.BANK_DETAILS_NOR;
                    btnPaymentHistory.Text = Translations.PAYMENT_HISTORY_NOR;
                    mainSelectedLang = 0;
                    break;
            }
        }

        ///
        /// Added click events to each button to show message boxes with the information stated 
        ///

        private void btnUserInfo_Click(object sender, EventArgs e)
        {
            switch (mainSelectedLang)
            {
                case 0:
                    MessageBox.Show(Translations.USER_INFO_NOR + ":\n\n" +
                                    Translations.FIRST_NAME_NOR + ":\t" +
                                    firstName + "\n" +
                                    Translations.LAST_NAME_NOR + ":\t" +
                                    lastName + "\n" +
                                    Translations.PASSPORT_NUMBER_NOR + ":\t" +
                                    passportNum);
                    break;
                case 1:
                    MessageBox.Show(Translations.USER_INFO_GER + ":\n\n" +
                                    Translations.FIRST_NAME_GER + ":\t" +
                                    firstName + "\n" +
                                    Translations.LAST_NAME_GER + ":\t" +
                                    lastName + "\n" +
                                    Translations.PASSPORT_NUMBER_GER + ":\t" +
                                    passportNum);
                    break;
                case 2:
                    MessageBox.Show(Translations.USER_INFO_ENG + ":\n\n" +
                                    Translations.FIRST_NAME_ENG + ":\t" +
                                    firstName + "\n" +
                                    Translations.LAST_NAME_ENG + ":\t" +
                                    lastName + "\n" +
                                    Translations.PASSPORT_NUMBER_ENG + ":\t" +
                                    passportNum);
                    break;
                default:
                    MessageBox.Show(Translations.USER_INFO_NOR + ":\n\n" +
                                    Translations.FIRST_NAME_NOR + ":\t" +
                                    firstName + "\n" +
                                    Translations.LAST_NAME_NOR + ":\t" +
                                    lastName + "\n" +
                                    Translations.PASSPORT_NUMBER_NOR + ":\t" +
                                    passportNum);
                    break;
            }
        }

        private void btnCarInfo_Click(object sender, EventArgs e)
        {
            switch (mainSelectedLang)
            {
                case 0:
                    MessageBox.Show(Translations.CAR_INFO_NOR + ":\n\n" +
                                    Translations.CAR_MODEL_NOR + ":\t" +
                                    carModel + "\n" +
                                    Translations.CAR_REG_NUMBER_NOR + ":\t" +
                                    carRegNumber);
                    break;
                case 1:
                    MessageBox.Show(Translations.CAR_INFO_GER + ":\n\n" +
                                    Translations.CAR_MODEL_GER + ":\t" +
                                    carModel + "\n" +
                                    Translations.CAR_REG_NUMBER_GER + ":\t" +
                                    carRegNumber);
                    break;
                case 2:
                    MessageBox.Show(Translations.CAR_INFO_ENG + ":\n\n" +
                                    Translations.CAR_MODEL_ENG + ":\t" +
                                    carModel + "\n" +
                                    Translations.CAR_REG_NUMBER_ENG + ":\t" +
                                    carRegNumber);
                    break;
                default:
                    MessageBox.Show(Translations.CAR_INFO_NOR + ":\n\n" +
                                    Translations.CAR_MODEL_NOR + ":\t" +
                                    carModel + "\n" +
                                    Translations.CAR_REG_NUMBER_NOR + ":\t" +
                                    carRegNumber);
                    break;
            }
        }

        private void btnBankDetails_Click(object sender, EventArgs e)
        {
            switch (mainSelectedLang)
            {
                case 0:
                    MessageBox.Show(Translations.BANK_DETAILS_NOR + ":\n\n" +
                                    Translations.ACCOUNT_NAME_NOR + ":\t" +
                                    bankAccountName + "\n" +
                                    Translations.CARD_NUMBER_NOR + ":\t" +
                                    bankCardNumber + "\n" +
                                    Translations.EXPIRY_DATE_NOR + ":\t" +
                                    bankCardExpiryMonth + "/" + bankCardExpiryYear + "\n" +
                                    Translations.CARD_SECURITY_CODE_NOR + ":\t" +
                                    bankSecurityCode);
                    break;
                case 1:
                    MessageBox.Show(Translations.BANK_DETAILS_GER + ":\n\n" +
                                    Translations.ACCOUNT_NAME_GER + ":\t" +
                                    bankAccountName + "\n" +
                                    Translations.CARD_NUMBER_GER + ":\t" +
                                    bankCardNumber + "\n" +
                                    Translations.EXPIRY_DATE_GER + ":\t" +
                                    bankCardExpiryMonth + "/" + bankCardExpiryYear + "\n" +
                                    Translations.CARD_SECURITY_CODE_GER + ":\t" +
                                    bankSecurityCode);
                    break;
                case 2:
                    MessageBox.Show(Translations.BANK_DETAILS_ENG + ":\n\n" +
                                    Translations.ACCOUNT_NAME_ENG + ":\t" +
                                    bankAccountName + "\n" +
                                    Translations.CARD_NUMBER_ENG + ":\t" +
                                    bankCardNumber + "\n" +
                                    Translations.EXPIRY_DATE_ENG + ":\t" +
                                    bankCardExpiryMonth + "/" + bankCardExpiryYear + "\n" +
                                    Translations.CARD_SECURITY_CODE_ENG + ":\t" +
                                    bankSecurityCode);
                    break;
                default:
                    MessageBox.Show(Translations.BANK_DETAILS_NOR + ":\n\n" +
                                    Translations.ACCOUNT_NAME_NOR + ":\t" +
                                    bankAccountName + "\n" +
                                    Translations.CARD_NUMBER_NOR + ":\t" +
                                    bankCardNumber + "\n" +
                                    Translations.EXPIRY_DATE_NOR + ":\t" +
                                    bankCardExpiryMonth + "/" + bankCardExpiryYear + "\n" +
                                    Translations.CARD_SECURITY_CODE_NOR + ":\t" +
                                    bankSecurityCode);
                    break;
            }
        }

        private void btnPaymentHistory_Click(object sender, EventArgs e)
        {
            switch (mainSelectedLang)
            {
                case 0:
                    MessageBox.Show(Translations.PAYMENT_HISTORY_NOR + ":\n\n" + 
                                    "Date:\t\t\t\tAmount:\t\t\t\tHighway:\n\n" + 
                                    "02/04/21\t\t\t23 NOK\t\t\t\t3\n" + 
                                    "05/04/21\t\t\t34 NOK\t\t\t\t4\n" +
                                    "08/04/21\t\t\t51 NOK\t\t\t\t1\n");
                    break;
                case 1:
                    MessageBox.Show(Translations.PAYMENT_HISTORY_NOR + ":\n\n" +
                                    "Date:\t\t\t\tAmount:\t\t\t\tHighway:\n\n" +
                                    "02/04/21\t\t\t23 EUR\t\t\t\t3\n" +
                                    "05/04/21\t\t\t34 EUR\t\t\t\t4\n" +
                                    "08/04/21\t\t\t51 EUR\t\t\t\t1\n");
                    break;
                case 2:
                    MessageBox.Show(Translations.PAYMENT_HISTORY_NOR + ":\n\n" +
                                    "Date:\t\t\t\tAmount:\t\t\t\tHighway:\n\n" +
                                    "02/04/21\t\t\t23 GBP\t\t\t\t3\n" +
                                    "05/04/21\t\t\t34 GBP\t\t\t\t4\n" +
                                    "08/04/21\t\t\t51 GBP\t\t\t\t1\n");
                    break;
                default:
                    MessageBox.Show(Translations.PAYMENT_HISTORY_NOR + ":\n\n" +
                                    "Date:\t\t\t\tAmount:\t\t\t\tHighway:\n\n" +
                                    "02/04/21\t\t\t23 NOK\t\t\t\t3\n" +
                                    "05/04/21\t\t\t34 NOK\t\t\t\t4\n" +
                                    "08/04/21\t\t\t51 NOK\t\t\t\t1\n");
                    break;
            }
        }

        ///
        /// Application will terminate upon windows form exit button
        ///

        private void UserPanel_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

    }
}
