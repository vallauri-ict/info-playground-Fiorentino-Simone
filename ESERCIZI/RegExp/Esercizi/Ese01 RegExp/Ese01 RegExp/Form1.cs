using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Ese01_RegExp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            Regex rgx = new Regex(@"^[a-zA-Z0-9]\d{2}[a-zA-Z0-9](-\d{3}){2}[A-Za-z0-9]$"); //il @ serve per evitare di scrivere \\d rispetto che \d
            string pattern = @"^[a-zA-Z0-9]\d{2}[a-zA-Z0-9](-\d{3}){2}[A-Za-z0-9]$";
            string str = txtStringa.Text;

            string ris = rgx.IsMatch(str) == true ? "CORRETTA" : "SBAGLIATA";
            MessageBox.Show("LA STRINGA INSERITA: "+str+ " E': " +ris);
            MessageBox.Show("LA STRINGA INSERITA: " + str + " E': " + Regex.IsMatch(str,pattern)); //questa mbox è la medesima di quella sopra solo che una utilizza il metodo statico e l'altro il metodo dell'oggetto            
        }

        private void btnMatch_Click(object sender, EventArgs e)
        {
            string str = lblCar.Text;
            string pattern = @"(\w+)\s+(car)";

            Regex regex = new Regex(pattern);
            Match m = regex.Match(str); //la prima ricorrenza matchata
            int count = 0;
            while (m.Success)
            {
                MessageBox.Show("Trovato gruppo: "+(++count)+ " valore: " + m.Value
                    +" Alla posizione: "+m.Index); //stampiamo il value del match
                m=m.NextMatch(); //successivo match
            }
        }

        private void btnSplit_Click(object sender, EventArgs e)
        {
            string str = "123ABCDE456FGHIJKL789MNOPQ012";
            string pattern = @"\d+";

            Regex regex = new Regex(pattern);
            string[] result = regex.Split(str);
            for (int i = 0; i < result.Length; i++)
            {
                MessageBox.Show("Stringa "+(i+1)+ ": \n"+result[i]+"\n");
            }
        }

        private void btnReplace_Click(object sender, EventArgs e)
        {
            string input = lblReplace.Text;
            string pattern = @"\s+"; //uguale ad usare \\s+
            string replacement = " ";
            Regex rgx = new Regex(pattern);
            string result = rgx.Replace(input, replacement);
            MessageBox.Show("Original String: "+ input);
            MessageBox.Show("Replacement String: "+ result);
        }
    }
}