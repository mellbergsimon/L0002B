/**
 * Course: Introduktion till programmering och C#, L0002B
 * 
 * Assignment: 3 (Windows Form Application)
 * User: Simon Mellberg 960520-3034
 * LTU username: Simmel-9
 * 
 * 
 * Sammanfattning:
 *      Kontrollera personnummer
 * 
 * Begränsningar:   Rätt nöjd men det är tvingat vilket format det ska vara på personnumret. Hade varit roligt 
 *                  att kunna erbjuda flera sätt att skriva in personnumret.
 *                  
 *                  Kontrollering utav förnamn och efternamn är i princip exakt likadan så de hade eventuellt 
 *                  kunnat göras till en funktion.
 *                  
 *                  Den verkar inte kunna presentera flera felmeddelanden samtidigt. Kanske har det att göra med
 *                  hur programmet hanterar exceptions.
 *      
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Uppgift3_simmel_9 {

    
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void OK_Click(object sender, EventArgs e) {
            ResultBox.Clear();
            Person person = new Person();
            String temp = PersonNr.Text;
            int errors = 0;

            //Kontrollera förnamn
            try {
                if (temp.Length < 3) {
                    throw new Exception("Förnamnet behöver vara minst 3 bokstäver.");
                }
                else if (!Regex.Match(Firstname.Text, "^([a-zA-Z])+$").Success) {
                    throw new Exception("Förnamnet inte innehålla siffror eller mellanslag");
                }
                else {
                    //Acceptabelt format
                    person.Firstname = Firstname.Text;
                }
            }
            catch (Exception ex) {
                errors += 1;
                ResultBox.Text = ex.Message;
            }

            //Kontrollera efternamn
            try {
                if (temp.Length < 3) {
                    throw new Exception("Efternamnet behöver vara minst 3 bokstäver.");
                }
                else if (!Regex.Match(Lastname.Text, "^([A-Za-z])+$").Success) {
                    throw new Exception("Efternamnet får inte innehålla siffror eller mellanslag");
                }
                else {
                    //Acceptabelt format
                    person.Lastname = Lastname.Text;
                }
            }
            catch (Exception ex) {
                errors += 1;
                ResultBox.Text = ex.Message;
            }

            //Kontrollera personnummer
            try {
                //Första kontroll.
                if (temp.Length != 10) {
                    throw new Exception("Personnummret måste vara 10 tecken långt.");
                }
                else if (temp.Any(char.IsLetter)) {
                    throw new Exception("Får inte innehålla bokstäver eller mellanslag");
                }

                //Konvertera till int från input.
                int year = int.Parse(temp.Substring(0, 2));
                int month = int.Parse(temp.Substring(2, 2));
                int day = int.Parse(temp.Substring(4, 2));

                //Kontrollera födelsedag
                if (year >= 0 && year <= 99) {
                    //Kolla månader
                    if (month >= 1 && month <= 12) {
                        //Månader med 31 dagar
                        if ((day >= 1 && day <= 31) && (month == 1 || month == 3 || month == 5 || month == 7 || month == 8 || month == 10 || month == 12)) {
                            //Helt ok
                        }

                        //Månader med 30 dagar
                        else if ((day >= 1 && day <= 30) && (month == 4 || month == 6 || month == 9 || month == 11)) {
                            //Helt ok
                        }

                        //Februari
                        else if ((day >= 1 && day <= 28) && (month == 2)) {
                            //Helt ok
                        }

                        //Skottår
                        else if (day == 29 && month == 2 && (year % 400 == 0 || (year % 4 == 0 && year % 100 != 0))) {
                            //Helt ok
                        }
                        else {
                            throw new Exception("Dagen är inte korrekt");
                        }
                        //Acceptabelt format
                        
                    }
                    else {
                        throw new Exception("Månad är inte korrekt");
                    }
                }
                else {
                    throw new Exception("År är inte korrekt");
                }
                //21-algoritm
                if (Tjugoettalgoritm(temp)) {
                    person.Personnr = temp;
                } else {
                    throw new Exception("Kontrollsiffran stämmer ej");
                }

            }
            catch (Exception ex) {
                errors += 1;
                ResultBox.Text = ex.Message;
            }

            //Skriv bara ut information om det inte skett några fel.
            if (errors == 0) { 
                //Skriv ut information på skärmen och de borde existera.
                if (person.Firstname != null) {
                    ResultBox.Text += "Förnamn: " + person.Firstname;
                }
                if (person.Lastname != null) {
                    ResultBox.Text += Environment.NewLine + "Efternamn: " + person.Lastname;
                }
                if (person.Personnr != null) {
                    ResultBox.Text += Environment.NewLine + "Personnummer: " + person.Personnr;
                }
                //Man eller kvinna
                if (int.Parse(person.Personnr.Substring(8,1)) % 2 == 1) {
                    ResultBox.Text += Environment.NewLine + "Man";
                } else {
                    ResultBox.Text += Environment.NewLine + "Kvinna";
                }
            }
        }

        public Boolean Tjugoettalgoritm (string PersonNr) {
            int sum = 0;
            int temp;

            for (int i = 0; i < PersonNr.Length; i++) {
                if  (i % 2 == 0) {
                    temp = int.Parse(PersonNr.Substring(i,1)) * 2;
                }
                else {
                    temp = int.Parse(PersonNr.Substring(i,1)) * 1;
                }

                //Ifall det blir större än 10.
                if (temp >= 10) {
                    sum += (1 + temp % 10);
                } else {
                    sum += temp;
                }
            }
            return (sum % 10 == 0);
        }

        private void button1_Click(object sender, EventArgs e) {
            Application.Exit();
        }
    }
}
