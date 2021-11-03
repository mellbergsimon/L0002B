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
 * Begränsningar: Se form1.cs
 *      
 *      
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Uppgift3_simmel_9 {
    /**
     * Information om personen
     */
    public class Person {
        public string Firstname;
        public string Lastname;
        public string Personnr;
    }
    static class Program {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main() {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
