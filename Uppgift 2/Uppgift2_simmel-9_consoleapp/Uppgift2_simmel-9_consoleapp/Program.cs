/**
 * Course: Introduktion till programmering och C#, L0002B
 * 
 * Assignment: 2 (Console Application)
 * User: Simon Mellberg 960520-3034
 * LTU username: Simmel-9
 * 
 * 
 * Sammanfattning:
 *      Läs in uppgifter, sortera och presentera för användaren samt spara ner till en fil.
 * 
 * Begränsningar:
 *      
 */


/*Uppgiftsbeskrivning:
 * 
 * Syftet med denna inlämning är att du ska få träna på flera moment; algoritmbeskrivning, inmatning, sortering och att skriva till en fil. 
 * Vidare ska programmet vara uppbyggt med lämpliga metoder (funktioner).
 * Hela lösningsförslaget ska också visas i ett flödesschema, pseudokod eller annan metod för algoritmbeskrivning.

 * Följande uppgifter ska alltså läsas in: namn, personnummer, vilket distrikt han/hon arbetar i, hur många artiklar han/hon har sålt under perioden.
 * Detta för att man har ett bonussystem där viss del av lönen är fast och viss del rörlig.
 * Den rörliga baseras på antal sålda artiklar (ni behöver dock inte beräkna lönen).
 * Man vill sen se statistik över försäljningen.
 * 
 * Det ska finnas följande fyra nivåer: under 50 artiklar, 50-99 artiklar, 100-199 artiklar samt en nivå över 199 artiklar.
 * När man läst in alla säljare ska resultatet sorteras innan det skrivs ut.
 * Sorteringen sker på antal sålda artiklar.
 * I utskriften ska alla resultat i sorterad ordning finnas med samt hur många säljare som ligger inom varje nivå och hur många artiklar var och en har sålt.
 
    Ex:
    Namn        Persnr      Distrikt    Antal
    Kalle Anka  4503038990  Piteå       173
    1 säljare har nått nivå 3: 100-199 artiklar

    Musse Pigg  3502038964  Boden   202
    Snobben     7805055673  Luleå   203
    2 säljare har nått nivå 4: över 199 artiklar
 
 */

using System;
using System.Collections.Generic;

namespace Uppgift2_simmel_9_consoleapp
{
    public class User {
        public string name;
        public string socialNr;
        public string district;
        public string amountSold;

    }
    class Program {
        static void Main(string[] args) {
            //Variabler:
            //Initiera lista med säljare
            List<User> Users = new List<User> { };

            Users = collectSellerData(Users);

            Console.WriteLine("Hello ZimeX!");
        }

        public List<User> collectSellerData(List<User> Users) {
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

            for (int i = 0; i < input; i++) {

            }

            return Users;
        }


        public List<User> getInfoFromUser(List<User> Users) {

            Console.Write("Namn: ");

            try {
                string inputString = Console.ReadLine();
            }
            catch {
                Console.WriteLine("Otillåten input");
            }
            return Users;
        }
    }
}
