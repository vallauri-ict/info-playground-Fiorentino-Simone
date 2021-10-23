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
    public partial class Form2 : Form
    {
        private int n;
        private TextBox txt;
        public Form2()
        {
            InitializeComponent(); //questo deve essere sempre esser creato perchè ci deve essere un costruttore senza parametri che inizializza i componenti
        }

        public Form2(int n) //creo il secondo costruttore 
        {
            InitializeComponent(); 
            this.n = n;
        }

        public Form2(TextBox txt) //creo il terzo costruttore dove passo come parametro il testo di Form1
        {
            InitializeComponent();
            this.txt = txt;
            //txt.Text = "Ciao da F2";
        }

        private void BtnLeggiValoriDaTxt_Click(object sender, EventArgs e)
        {
            if (txt==null)
                MessageBox.Show("Non è stato passato l'oggetto del Txt");
            else
                MessageBox.Show("Il testo visualizzato da txtForm1: " + txt.Text);
        }

        private void btnInviaForm1_Click(object sender, EventArgs e)
        {
            if (txt == null)
                MessageBox.Show("Non è stato passato l'oggetto del Txt");
            else
                txt.Text = txtF2.Text;
        }

        private void btnForm2ApriFiglia_Click(object sender, EventArgs e)
        {
            FormFiglia form = new FormFiglia();
            this.AddOwnedForm(form);//vado ad aggiungere a Form2 la FormFiglia
            form.Show();
        }
    }
}
