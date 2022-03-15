using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    ///
    /// Public class that uses readonly static variables for all translations in the application
    /// Creating a separate class is more efficient than declaring the variables in the forms themselves
    /// Readonly static is more efficient than using constants since the translations will never change
    /// Using readonly allows for the application to be upgraded/changed without constraints from constants
    ///

    public static class Translations
    {
        public readonly static string WELCOME_NOR = "Velkommen!";
        public readonly static string WELCOME_GER = "Willkommen!";
        public readonly static string WELCOME_ENG = "Welcome!";

        public readonly static string SIGNUP_NOR = "Melde deg på";
        public readonly static string SIGNUP_GER = "Anmelden";
        public readonly static string SIGNUP_ENG = "Sign up";

        public readonly static string LOGIN_NOR = "Logg Inn";
        public readonly static string LOGIN_GER = "Einloggen";
        public readonly static string LOGIN_ENG = "Log in";

        public readonly static string FIRST_NAME_NOR = "Fornavn";
        public readonly static string FIRST_NAME_GER = "Vorname";
        public readonly static string FIRST_NAME_ENG = "First name";

        public readonly static string LAST_NAME_NOR = "Etternavn";
        public readonly static string LAST_NAME_GER = "Nachname";
        public readonly static string LAST_NAME_ENG = "Last name";

        public readonly static string PASSPORT_NUMBER_NOR = "Passnummer";
        public readonly static string PASSPORT_NUMBER_GER = "Ausweisnummer";
        public readonly static string PASSPORT_NUMBER_ENG = "Passport number";

        public readonly static string CAR_MODEL_NOR = "Bilmodell";
        public readonly static string CAR_MODEL_GER = "Auto model";
        public readonly static string CAR_MODEL_ENG = "Car model";

        public readonly static string CAR_REG_NUMBER_NOR = "Registreringsnummer";
        public readonly static string CAR_REG_NUMBER_GER = "Registrationsnummer";
        public readonly static string CAR_REG_NUMBER_ENG = "Registration number";

        public readonly static string SUBMIT_NOR = "Sende inn";
        public readonly static string SUBMIT_GER = "Einreichen";
        public readonly static string SUBMIT_ENG = "Submit";

        public readonly static string ACCOUNT_NAME_NOR = "Brukernavn";
        public readonly static string ACCOUNT_NAME_GER = "Kontobezeichnung";
        public readonly static string ACCOUNT_NAME_ENG = "Account name";

        public readonly static string CARD_NUMBER_NOR = "Kortnummer";
        public readonly static string CARD_NUMBER_GER = "Kartennummer";
        public readonly static string CARD_NUMBER_ENG = "Card number";

        public readonly static string EXPIRY_DATE_NOR = "Utløpsdato";
        public readonly static string EXPIRY_DATE_GER = "Verfallsdatum";
        public readonly static string EXPIRY_DATE_ENG = "Expiry date";

        public readonly static string CARD_SECURITY_CODE_NOR = "Kort sikkerhetskode";
        public readonly static string CARD_SECURITY_CODE_GER = "Karten-Sicherheitscode";
        public readonly static string CARD_SECURITY_CODE_ENG = "Card security code";

        public readonly static string SUCCESS_SIGNUP_MSG_NOR = "Suksess: Fortsett for å logge på.";
        public readonly static string SUCCESS_SIGNUP_MSG_GER = "Erfolgreich: Bitte melden Sie sich an.";
        public readonly static string SUCCESS_SIGNUP_MSG_ENG = "Success: Please proceed to log in.";

        public readonly static string SUCCESS_LOGIN_MSG_NOR = "Suksess: Du har blitt logget inn.\n\nDu vil nå bli omdirigert for å legge til kjøretøy- og bankinformasjon.";
        public readonly static string SUCCESS_LOGIN_MSG_GER = "Erfolg: Sie wurden angemeldet.\n\nSie werden nun weitergeleitet, um Fahrzeug- und Bankinformationen hinzuzufügen.";
        public readonly static string SUCCESS_LOGIN_MSG_ENG = "Success: You have been logged in.\n\nYou will now be redirected to add vehicle & bank information.";

        public readonly static string SUCCESS_CAR_MSG_NOR = "Suksess: Skriv inn bankdetaljene dine nå.";
        public readonly static string SUCCESS_CAR_MSG_GER = "Erfolgreich: Bitte geben Sie nun Ihre Bankverbindung ein.";
        public readonly static string SUCCESS_CAR_MSG_ENG = "Success: Now please enter your bank details.";

        public readonly static string ERROR_EMPTY_MSG_NOR = "Feil: Sørg for at alle tekstbokser er fylt ut.";
        public readonly static string ERROR_EMPTY_MSG_GER = "Fehler: Bitte stellen Sie sicher, dass alle Textfelder ausgefüllt sind.";
        public readonly static string ERROR_EMPTY_MSG_ENG = "Error: Please make sure all text boxes are filled.";

        public readonly static string ERROR_CREDS_MSG_NOR = "Feil: Kontroller at legitimasjonen din er riktig.";
        public readonly static string ERROR_CREDS_MSG_GER = "Fehler: Bitte stellen Sie sicher, dass Ihre Anmeldeinformationen korrekt sind.";
        public readonly static string ERROR_CREDS_MSG_ENG = "Error: Please make sure your credentials are correct.";

        public readonly static string ERROR_OTHER_MSG_NOR = "Feil: Ukjent feil oppstod - prøv igjen.";
        public readonly static string ERROR_OTHER_MSG_GER = "Fehler: Unbekannter Fehler aufgetreten - bitte versuchen Sie es erneut.";
        public readonly static string ERROR_OTHER_MSG_ENG = "Error: Unknown error occurred - please try again.";
    }
}
