/**
 * Course: Introduktion till programmering och C#, L0002B
 * 
 * Assignment: 2 (Console Application)
 * User: Simon Mellberg 960520-3034
 * LTU username: Simmel-9
 * 
 * 
 * Sammanfattning:
 *      Läs in uppgifter, sortera och presentera för användaren samt skriva ner till en fil.
 * 
 * Begränsningar:
 *      Kan inte välja namn på filen som skrivs ut, den fungerar som en log-fil.
 *      Använder regex för att kontrollera namnet.
 *      
 */

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;

namespace Uppgift2_simmel_9_consoleapp
{

    /**
     * User
     * 
     * Innehåller information om säljaren.
     *
     */
    public class User {

        public string name;
        public string socialNr;
        public string district;
        public int amountSold;

    }

    /**
     * ListofGroups
     * 
     * Innehåller de fyra säljgrupperna.
     *
     */
    public class ListofGroups{

        public List<User> G1;
        public List<User> G2;
        public List<User> G3;
        public List<User> G4;

    }

    class Program {
        //Filnamn.
        private static readonly string fileName = $"{DateTime.Now.ToString("yyyy-dd-M--HH-mm-ss")}.txt";

        static void Main(string[] args) {
            //Initiera listor för alla grupper.
            ListofGroups Groups = new ListofGroups {
                G1 = new List<User>(),
                G2 = new List<User>(),
                G3 = new List<User>(),
                G4 = new List<User>()
            };

            CreateFile(fileName);

            //Samla in data
            Groups = CollectSellerData(Groups);
            
            PrinttoFileandConsole(String.Format("{0,-15} {1,-12} {2,-12} {3,-12}\n", "Namn", "Persnr", "Distrikt", "Antal"));
            
            //Skriv ut grupperna ifall det finns några användare i gruppen. Sortera listorna innan.
            if (Groups.G1.Count != 0) {
                Groups.G1 = BubbleSortList(Groups.G1);
                PrintUserList(Groups.G1);
                PrinttoFileandConsole($"{Groups.G1.Count} säljare har nått nivå 1: 0-49 artiklar\n\n");
            }
            if (Groups.G2.Count != 0) {
                Groups.G2 = BubbleSortList(Groups.G2);
                PrintUserList(Groups.G2);
                PrinttoFileandConsole($"{Groups.G2.Count} säljare har nått nivå 2: 50-99 artiklar\n\n");
            }
            if (Groups.G3.Count != 0) {
                Groups.G3 = BubbleSortList(Groups.G3);
                PrintUserList(Groups.G3);
                PrinttoFileandConsole($"{Groups.G3.Count} säljare har nått nivå 3: 100-199 artiklar\n\n");
            }
            if (Groups.G4.Count != 0) {
                Groups.G4 = BubbleSortList(Groups.G4);
                PrintUserList(Groups.G4);
                PrinttoFileandConsole($"{Groups.G4.Count} säljare har nått nivå 4: över 199 artiklar\n\n");
            }
        }

        /**
         * CreateFile
         * 
         * Skapa en fil för att kunna skriva till senare.
         *
         */
        public static void CreateFile (String fileName) {
            // Check if file already exists. If yes, delete it.     
            if (File.Exists(fileName)) {
                File.Delete(fileName);
            }
            // Create a new file
            using (StreamWriter sw = File.CreateText(fileName)) {
                sw.Close();
            }

        }

        /**
         * PrinttoFileandConsole
         * 
         * Skriver både ner till fil samt till konsollen.
         *
         */
        public static void PrinttoFileandConsole(String linetoPrint) {
            Console.Write(linetoPrint);

            File.AppendAllText(fileName, linetoPrint);

        }

        /**
         * PrintUserList
         * 
         * Skriver ut listan med användare.
         *
         */
        public static void PrintUserList(List<User> list) {
            for (int i = 0; i < list.Count; i++) {
                User user = list[i];

                String Buffer;
                Buffer = String.Format("{0,-15} {1,-12} {2,-12} {3,-12}\n", user.name, user.socialNr, user.district, user.amountSold);

                //Skriv ut till skärmen och textfilen.
                PrinttoFileandConsole(Buffer);

            }
        }

        /**
         * BubbleSortList
         * 
         * Sorterar listan till det minsta värdet på .amountSold först.
         * 
         */
        public static List<User> BubbleSortList(List<User> Users) {
            Boolean listChanged = true;

            for (int j = 0; j <= Users.Count - 2; j++) {
                listChanged = false;
                for (int i = 0; i <= Users.Count - 2; i++) {
                    if (Users[i].amountSold > Users[i + 1].amountSold) {
                        User temp = Users[i + 1];
                        Users[i + 1] = Users[i];
                        Users[i] = temp;

                        listChanged = true;
                    }
                }
                //Om ingen bytt plats så kan vi avsluta nu. Då listan är sorterad.
                if (listChanged == false) {
                    break;
                }
            }

            return Users;
        }

        /**
         * CollectSellerData
         * 
         * Samlar ihop data från användaren om alla säljare.
         *
         */
        public static ListofGroups CollectSellerData(ListofGroups Groups) {
            int input = -1;

            //Ta reda på hur många säljare det är.
            while (input <= 0) {
                Console.Write("Hur många säljare: ");
                try {
                    input = int.Parse(Console.ReadLine());
                    if (input <= 0) {
                        Console.WriteLine("Skriv in ett positivt tal större än 0. [n >= 1]");
                    }
                }
                catch {
                    Console.WriteLine("Otillåten input");
                }
            }

            //Loopa igenom alla säljare som data ska tas in för.
            for (int i = 0; i < input; i++) {
                Console.WriteLine($"Säljare {i+1}");

                User userTemp = GetInfoFromKeyboard();

                //Placera säljaren i rätt grupp.
                switch (userTemp.amountSold) {
                    case var expression when userTemp.amountSold < 50:
                        Groups.G1.Add(userTemp);
                        break;

                    case var expression when (userTemp.amountSold >= 50 && userTemp.amountSold <= 99):
                        Groups.G2.Add(userTemp);
                        break;

                    case var expression when (userTemp.amountSold >= 100 && userTemp.amountSold <= 199):
                        Groups.G3.Add(userTemp);
                        break;
                        
                    case var expression when (userTemp.amountSold > 199):
                        Groups.G4.Add(userTemp);
                        break;

                }
            }

            return Groups;
        }

        /**
         *
         * GetInfoFromKeyboard
         * 
         * Validerar informationen som tas emot från användaren för varje användare.
         *
         */
        public static User GetInfoFromKeyboard() {
            User user = new User();
            String temp = "";

            //Namn
            while (true) {
                try {
                    Console.Write("Namn: ");
                    temp = Console.ReadLine();

                    if (temp.Length < 3) {
                        throw new Exception("Namnet behöver vara minst 3 bokstäver.");
                    }
                    //else if (temp.Any(x => !char.IsLetter(x))) {
                    else if (!Regex.Match(temp, "([A-Za-z ])+$").Success) {
                        throw new Exception("Får inte innehålla siffror");
                    }
                    else {
                        //Acceptabelt format
                        user.name = temp;
                        break;
                    }
                }
                catch (FormatException e) {
                    Console.WriteLine($"Otillåten input + {e}");
                    continue;
                }
                catch (Exception ex) {
                    Console.WriteLine(ex.Message);
                    continue;
                }
            }

            //Personnummer
            while (true) {
                try {
                    Console.Write("Personnummer (ÅÅMMDDXXXX): ");
                    temp = Console.ReadLine();

                    //Första kontroll.
                    if (temp.Length != 10) {
                        throw new Exception("Personnummret måste vara 10 tecken långt.");
                    } else if (temp.Any(char.IsLetter)) {
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
                                user.socialNr = temp;
                                break;
                            }

                            //Månader med 30 dagar
                            else if ((day >= 1 && day <= 30) && (month == 4 || month == 6 || month == 9 || month == 11)) {
                                //Helt ok
                                user.socialNr = temp;
                                break;
                            }

                            //Februari
                            else if ((day >= 1 && day <= 28) && (month == 2)) {
                                //Helt ok
                                user.socialNr = temp;
                                break;
                            }

                            //Skottår
                            else if (day == 29 && month == 2 && (year % 400 == 0 || (year % 4 == 0 && year % 100 != 0))) {
                                //Helt ok
                                user.socialNr = temp;
                                break;
                            }
                            else {
                                throw new Exception("Dagen är inte korrekt");
                            }
                        } else {
                            throw new Exception("Månad är inte korrekt");
                        }
                    } else {
                        throw new Exception("År är inte korrekt");
                    }
                }
                catch (FormatException e) {
                    Console.WriteLine("Otillåten input");
                    continue;
                }
                catch (Exception ex) {
                    Console.WriteLine(ex.Message);
                    continue;
                }
            }

            //Distrikt
            while (true) {
                try {
                    Console.Write("Distrikt: ");
                    temp = Console.ReadLine();
                    
                    user.district = temp;
                    break;
                }
                catch (FormatException e) {
                    Console.WriteLine($"Otillåten input: {e}");
                    continue;
                }
                catch (Exception ex) {
                    Console.WriteLine(ex.Message);
                    continue;
                }
            }

            //Antal sålda artiklar.
            while (true) {
                try {
                    Console.Write("Antal sålda artiklar: ");
                    temp = Console.ReadLine();
                    int num = int.Parse(temp);

                    //Negativa tal
                    if (num < 0) {
                        throw new Exception("Antal sålt kan inte vara negativt.");
                    }

                        //Acceptabelt format
                        user.amountSold = num; ;
                    break;
                }
                catch (FormatException e) {
                    Console.WriteLine($"Otillåten input: {e}");
                    continue;
                }
                catch (Exception ex) {
                    Console.WriteLine(ex.Message);
                    continue;
                }
            }

            Console.WriteLine();

            return user;
        }
    }
}
