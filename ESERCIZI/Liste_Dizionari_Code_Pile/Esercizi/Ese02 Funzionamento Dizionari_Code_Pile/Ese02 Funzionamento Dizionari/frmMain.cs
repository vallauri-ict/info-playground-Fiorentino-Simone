using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ese02_Funzionamento_Dizionari
{
    public partial class frmMain : Form
    {
        public struct libro
        {
            public string titolo;
            public string autore;
        }

        int pos = 0;
        Dictionary<int, libro> dictLibri = new Dictionary<int, libro>();
        Queue<libro> codLibri = new Queue<libro>();
        Stack<libro> pilaLibri = new Stack<libro>();

        public frmMain()
        {
            InitializeComponent();
        }

        private void btnAddBook_Click(object sender, EventArgs e)
        {
            libro lb;

            lb.titolo = txtTitolo.Text;
            lb.autore = txtAutore.Text;

            dictLibri.Add(pos++, lb); //lui va a incrementare prima il valore iniziale di pos e poi aggiunge il libro
        }

        private void btnVisDict_Click(object sender, EventArgs e)
        {
            foreach (int key in dictLibri.Keys) //vado a scorrere tutte le chaivi del dictionary
                MessageBox.Show("Chiave:" +key);

            //se voglio stampare e quindi scorrere i valori devo fare: 
            foreach (libro lb in dictLibri.Values)
                MessageBox.Show("(Valore) Titolo del libro: "+lb.titolo);
        }

        private void btnLibroIndice_Click(object sender, EventArgs e)
        {
            try
            {
                libro lb = dictLibri[Convert.ToInt32(nupIndiceLibro.Value)];
                MessageBox.Show("Libro con indice " + nupIndiceLibro.Value + ":  " + lb.titolo + "\t" + lb.autore);
            }
            catch (Exception)
            {
                MessageBox.Show("Chiave non presente nel libro");
            }   
        }

        private void btnInCoda_Click(object sender, EventArgs e)
        {
            libro lb;
            
            lb.titolo = txtTitolo.Text;
            lb.autore = txtAutore.Text;

            codLibri.Enqueue(lb); //lui va ad aggiunge il libro nella coda
        }

        private void btnInPila_Click(object sender, EventArgs e)
        {
            libro lb;

            lb.titolo = txtTitolo.Text;
            lb.autore = txtAutore.Text;

            pilaLibri.Push(lb); //lui va ad aggiunge il libro nella pila
        }

        private void btnEstraiDallaCoda_Click(object sender, EventArgs e)
        {
            try
            {
                libro lb = codLibri.Dequeue(); //elimina l'ultimo elemento della coda
                MessageBox.Show("Libro: " + lb.titolo + "\n Autore: " + lb.autore);
            }
            catch (Exception)
            {
                MessageBox.Show("Coda vuota");
            }   
        }

        private void btnEstraiDallaPila_Click(object sender, EventArgs e)
        {
            try
            {
                libro lb = pilaLibri.Pop(); //elimina il primo elemento della pila
                MessageBox.Show("Libro: " + lb.titolo + "\n Autore: " + lb.autore);
            }
            catch (Exception)
            {
                MessageBox.Show("Pila vuota");
            }
        }
    }
}
