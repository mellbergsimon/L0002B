using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/**
 * Course: Introduktion till programmering och C#, L0002B
 * 
 * Assignment: 1 (Windows Forms Application)
 * User: Simon Mellberg 960520-3034
 * LTU username: Simmel-9
 * 
 * 
 * Sammanfattning:
 *      Beräkna hur mycket växel användaren ska få tillbaka i valörer.
 * 
 * Begränsningar:
 *      Ingen hantering av negativa tal annat än att numericupdown hanterar det själv.
 *      Inget felmeddelande till användaren med andra ord.
 *      
 */

namespace Uppgift1_Simmel_9 {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void ChangeCalc_Click(object sender, EventArgs e) {
            //Initiera lista med valutor.
            List<int> Values = new List<int> {
                500,
                100,
                50,
                20,
                10,
                5,
                1
            };

            //Beräkna hur mycket användaren är skyldig.
            int change = (int)PricePayed.Value - (int)PricetoPay.Value;

            //Ifall användaren betalat precis rätt så får den ingen växel tillbaka
            if (PricePayed.Value == PricetoPay.Value) {
                resultBox.Text = "Du har betalat precis rätt summa. Ingen växel tillbaka.";

                //Annars beräkna växeln.
            } else {

                resultBox.Text = "Valör | Antal";

                //Ta reda på hur växeln ska delas tillbaka med störst värde först.
                foreach (int numbers in Values) {
                    int changeBack = change / numbers;

                    if (changeBack >= 1) {
                        //Skriv ut valörerna i textrutan.
                        resultBox.Text += Environment.NewLine + String.Format(" {0,4} | {1,-5}", numbers, changeBack);
                    }
                    
                    change -= (changeBack * numbers);
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e) {

        }
    }
}
