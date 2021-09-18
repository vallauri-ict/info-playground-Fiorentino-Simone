using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsEse01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnOpenForm2_Click(object sender, EventArgs e)
        {
            Form2 f2;
            f2 = new Form2(); //istanzio l'oggetto 
            f2.Text = "Form 2 creata da Designer"; //inserisco il text alla form 2
            f2.Show(); //la visualizzo, ricordo che se chiudo la principale chiudo anche le altre

            //creo la Form2B
            Form2 Form2B = new Form2(10); //passo 10 che sarebbe la n
            Form2B.Text = "Form 2 da Designer con parametro";
            Form2B.Show();
        }

        private void btnForm2Controllo_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2(txtFormDaPassare);
            f2.Text = "Form 2 con passaggio di un TextBox";
            f2.Show();
        }
    }
}
