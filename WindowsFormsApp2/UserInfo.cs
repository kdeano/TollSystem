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

        // Declaring global variables for error (unknown) messages for all languages
        private static string errorOtherMsgNor = "Feil: Ukjent feil oppstod - prøv igjen.";
        private static string errorOtherMsgGer = "Fehler: Unbekannter Fehler aufgetreten - bitte versuchen Sie es erneut.";
        private static string errorOtherMsgEng = "Error: Unknown error occurred - please try again.";

        // Declaring global variables for error (empty strings) messages for all languages
        private static string errorEmptyMsgNor = "Feil: Sørg for at alle tekstbokser er fylt ut.";
        private static string errorEmptyMsgGer = "Fehler: Bitte stellen Sie sicher, dass alle Textfelder ausgefüllt sind.";
        private static string errorEmptyMsgEng = "Error: Please make sure all text boxes are filled.";

        // Declaring global variables for success messages for all languages
        private static string successMsgNor = "Suksess: Skriv inn bankdetaljene dine nå.";
        private static string successMsgGer = "Erfolgreich: Bitte geben Sie nun Ihre Bankverbindung ein.";
        private static string successMsgEng = "Success: Now please enter your bank details.";

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
                    txtCarModel.Text = "Bilmodell";
                    txtRegNum.Text = "Registreringsnummer";
                    btnSubmitCar.Text = "Sende inn";
                    mainSelectedLang = 0;
                    break;
                case 1:
                    pbFlag.Image = Properties.Resources.germany;
                    txtCarModel.Text = "Auto Model";
                    txtRegNum.Text = "Registrationsnummer";
                    btnSubmitCar.Text = "Einreichen";
                    mainSelectedLang = 1;
                    break;
                case 2:
                    pbFlag.Image = Properties.Resources.uk;
                    txtCarModel.Text = "Car model";
                    txtRegNum.Text = "Registration number";
                    btnSubmitCar.Text = "Submit";
                    mainSelectedLang = 2;
                    break;
                default:
                    pbFlag.Image = Properties.Resources.norway;
                    txtCarModel.Text = "Bilmodell";
                    txtRegNum.Text = "Registreringsnummer";
                    btnSubmitCar.Text = "Sende inn";
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
                    txtCarModel.Text = "Bilmodell";
                    txtRegNum.Text = "Registreringsnummer";
                    btnSubmitCar.Text = "Sende inn";
                    txtAccountName.Text = "Brukernavn";
                    txtCardNum.Text = "Kortnummer";
                    lblExpiryDate.Text = "Utløpsdato";
                    txtSecurityCode.Text = "Kort sikkerhetskode";
                    btnSubmitBank.Text = "Sende inn";
                    mainSelectedLang = 0;
                    break;
                case 1:
                    pbFlag.Image = Properties.Resources.germany;
                    txtCarModel.Text = "Auto Model";
                    txtRegNum.Text = "Registrationsnummer";
                    btnSubmitCar.Text = "Einreichen";
                    txtAccountName.Text = "Kontobezeichnung";
                    txtCardNum.Text = "Kartennummer";
                    lblExpiryDate.Text = "Verfallsdatum";
                    txtSecurityCode.Text = "Karten-Sicherheitscode";
                    btnSubmitBank.Text = "Einreichen";
                    mainSelectedLang = 1;
                    break;
                case 2:
                    pbFlag.Image = Properties.Resources.uk;
                    txtCarModel.Text = "Car model";
                    txtRegNum.Text = "Registration number";
                    btnSubmitCar.Text = "Submit";
                    txtAccountName.Text = "Account name";
                    txtCardNum.Text = "Card number";
                    lblExpiryDate.Text = "Expiry date";
                    txtSecurityCode.Text = "Card security code";
                    btnSubmitBank.Text = "Submit";
                    mainSelectedLang = 2;
                    break;
                default:
                    pbFlag.Image = Properties.Resources.norway;
                    txtCarModel.Text = "Bilmodell";
                    txtRegNum.Text = "Registreringsnummer";
                    btnSubmitCar.Text = "Sende inn";
                    txtAccountName.Text = "Brukernavn";
                    txtCardNum.Text = "Kortnummer";
                    lblExpiryDate.Text = "Utløpsdato";
                    txtSecurityCode.Text = "Kort sikkerhetskode";
                    btnSubmitBank.Text = "Sende inn";
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
                txtCarModel.Text == "Bilmodell" ||
                txtCarModel.Text == "Auto Model" ||
                txtCarModel.Text == "Car model")
            {
                txtCarModel.Clear();
            }
        }

        private void txtRegNum_Click(object sender, EventArgs e)
        {
            if (txtRegNum.Text.Length < 1 ||
                txtRegNum.Text == "Registreringsnummer" ||
                txtRegNum.Text == "Registrationsnummer" ||
                txtRegNum.Text == "Registration number")
            {
                txtRegNum.Clear();
            }
        }

        private void txtAccountName_Click(object sender, EventArgs e)
        {
            if (txtAccountName.Text.Length < 1 ||
                txtAccountName.Text == "Brukernavn" ||
                txtAccountName.Text == "Kontobezeichnung" ||
                txtAccountName.Text == "Account name")
            {
                txtAccountName.Clear();
            }
        }

        private void txtCardNum_Click(object sender, EventArgs e)
        {
            if (txtCardNum.Text.Length < 1 ||
                txtCardNum.Text == "Kortnummer" ||
                txtCardNum.Text == "Kartennummer" ||
                txtCardNum.Text == "Card number")
            {
                txtCardNum.Clear();
            }
        }

        private void txtSecurityCode_Click(object sender, EventArgs e)
        {
            if (txtSecurityCode.Text.Length < 1 ||
                txtSecurityCode.Text == "Kort sikkerhetskode" ||
                txtSecurityCode.Text == "Karten-Sicherheitscode" ||
                txtSecurityCode.Text == "Card security code")
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
                        MessageBox.Show(successMsgNor);
                        txtAccountName.Text = "";
                        txtCardNum.Text = "";
                        lblExpiryDate.Text = "";
                        txtSecurityCode.Text = "";
                        btnSubmitBank.Text = "";
                        break;
                    case 1:
                        MessageBox.Show(successMsgGer);
                        break;
                    case 2:
                        MessageBox.Show(successMsgEng);
                        break;
                    default:
                        MessageBox.Show(successMsgNor);
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
                        MessageBox.Show(errorEmptyMsgNor);
                        break;
                    case 1:
                        MessageBox.Show(errorEmptyMsgGer);
                        break;
                    case 2:
                        MessageBox.Show(errorEmptyMsgEng);
                        break;
                    default:
                        MessageBox.Show(errorEmptyMsgNor);
                        break;
                }
            } else
            {
                switch (mainSelectedLang)
                {
                    case 0:
                        MessageBox.Show(errorOtherMsgNor);
                        break;
                    case 1:
                        MessageBox.Show(errorOtherMsgGer);
                        break;
                    case 2:
                        MessageBox.Show(errorOtherMsgEng);
                        break;
                    default:
                        MessageBox.Show(errorOtherMsgNor);
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
    }
}
