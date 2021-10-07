using System;
using System.Collections.Generic;

/**
 * Course: Introduktion till programmering och C#, L0002B
 * 
 * Assignment: 1 (Console Application)
 * User: Simon Mellberg 960520-3034
 * LTU username: Simmel-9
 * 
 * 
 * Sammanfattning:
 *      Beräkna hur mycket växel användaren ska få tillbaka i valörer.
 * 
 * Begränsningar:
 *      While-loop känns inte som den snyggaste lösningen för att ta in
 *          informationen från användaren.
 *          
 *      Variabelnamn och funktioner har en aning inkonsekvent namnkonvention.
 *          Kanske ska skriva programmen på engelska istället för att blanda.
 *          
 *      Vissa kodrader är längre än 80 tecken.
 *      
 */


namespace Uppgift1_simmel_9
{
    /**
     * Klass Values för att spara nödvändig information om valörerna.
     * Som även simplifierar utskriften senare.
     */
    public class Values {
        public int Value;
        public string Singular;
        public string Plural;

        public Values(int Value, string Singular, string Plural) {
            this.Value = Value;
            this.Singular = Singular;
            this.Plural = Plural;
        }
    }

    /**
     * Klass PriceAndPayment för att hålla reda på vad användaren betalat in.
     */
    public class PriceAndPayment {
        public int Price { get; set; }
        public int Payment { get; set; }
    }

    class Program
    {
        static void Main(string[] args) {

            //Initiera lista med valörer användandes utav classen Values.
            List<Values> listOfValues = new List<Values> {
                new Values(500, "femhundrakronorsedel", "femhundrakronorssedlar"),
                new Values(100, "hundrakronorsedel", "hundrakronorssedlar"),
                new Values(50, "femtiokronorsedel", "femtiokronorssedlar"),
                new Values(20, "tjugokronorsedel", "tjugokronorssedlar"),
                new Values(10, "tiokrona", "tiokronor"),
                new Values(5, "femkrona", "femkronor"),
                new Values(1, "enkrona", "enkronor")
            };

            //Initiera variabler.
            PriceAndPayment UserInput = new PriceAndPayment();

            //Hämta information från användaren även om användaren gör fel.
            UserInput = GetInfoFromUser(UserInput);
            
            //Beräkna hur mycket användaren är skyldig.
            int change = UserInput.Payment - UserInput.Price;

            //Ifall användaren betalat precis rätt så får den ingen växel tillbaka
            if (UserInput.Payment == UserInput.Price) {
                Console.WriteLine("Du har betalat precis rätt summa. Ingen växel tillbaka.");

            //Annars beräkna växeln.
            } else {

                Console.WriteLine("Växel tillbaka:");

                //Ta reda på hur växeln ska delas tillbaka med störst värde först.
                foreach (Values currency in listOfValues) {
                    int changeBack = change / currency.Value;
                    if (changeBack == 1) {
                        Console.WriteLine($"{changeBack} {currency.Singular}");
                    } else if (changeBack > 1) {
                        Console.WriteLine($"{changeBack} {currency.Plural}");
                    }
                    change -= (changeBack * currency.Value);
                }
            }
        }

        /**
         * PriceAndPayment
         * 
         * Tar reda på hur mycket användaren köpt för och betalat in.
         * Whileloop för att få in rätt information.
         */
        static PriceAndPayment GetInfoFromUser(PriceAndPayment UserInput) {

            //Ta fram information
            while ((UserInput.Price = GetIntFromUser("Ange pris: ")) == -1) {
            }

            //Upprepa ifall användaren inte betalat tillräckligt.
            do {
                while ((UserInput.Payment = GetIntFromUser("Betalt: ")) == -1) {
                }

                if (UserInput.Price > UserInput.Payment) {
                    Console.WriteLine("Du har inte betalat tillräckligt mycket.");
                }

            } while (UserInput.Price > UserInput.Payment);

            return UserInput;
        }

        /**
         * Ta in numeriskt värde från användaren.
         * 
         * Return: -1 ifall det blev fel. Annars värdet ifrån användaren.
         */
        static int GetIntFromUser(string question) {
            Console.Write(question);
            int input = 0;
            
            try {
                input = int.Parse(Console.ReadLine());
                if (input >= 0) {
                    return input;
                } else {
                    Console.WriteLine("Du kan inte skriva in negativa tal.");
                    return -1;
                }
                 
            } catch {
                Console.WriteLine("Otillåten input");
                return -1;
            }
        }
    }
}
