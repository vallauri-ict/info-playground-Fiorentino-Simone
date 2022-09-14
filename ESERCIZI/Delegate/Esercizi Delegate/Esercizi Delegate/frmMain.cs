using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Esercizi_Delegate
{
    public partial class frmMain : Form
    {

        //dichiarazione del delegate che accetta due parametri e restituisce un valore
        public delegate double operazione(double a, double b);


        public frmMain()
        {
            InitializeComponent();
        }

        //scrivo le tre funzioni che utilizzero con i delegate 
        //firma uguale al delegate

        public double somma(double x, double y)
        {
            return x + y;
        }

        public double sottrazione(double x, double y)
        {
            return x - y;
        }

        public double moltiplicazione(double x, double y)
        {
            return x * y;
        }


        private void btnPlus_Click(object sender, EventArgs e)
        {
            //uso del delegate metodo 1
            //instanzia del delegate

            operazione op = new operazione(somma);
            double a = double.Parse(Interaction.InputBox("Inserisci il primo numero: ")); 
            double b = double.Parse(Interaction.InputBox("Inserisci il secondo numero: "));
            MessageBox.Show("Somma: " + op(a, b));
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            operazione op = sottrazione;
            double a = double.Parse(Interaction.InputBox("Inserisci il primo numero: "));
            double b = double.Parse(Interaction.InputBox("Inserisci il secondo numero: "));
            MessageBox.Show("Differenza in modulo: " + differenza(a, b, op));
        }

        private double differenza(double a, double b, operazione op)
        {
            //cosi da avere sempre un modulo
            if (a > b) return op(a, b);
            else return op(b, a);
        }

        private void btnMultiple_Click(object sender, EventArgs e)
        {
            operazione op = moltiplicazione;
            double a = double.Parse(Interaction.InputBox("Inserisci il primo numero: "));
            double b = double.Parse(Interaction.InputBox("Inserisci il secondo numero: "));
            MessageBox.Show("Prodotto: " + op(a, b));
        }
    }
}
