using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ese03_Dictionary_di_un_negozio
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }


        public struct Articolo
        {
            public string nome;
            public string chiave;
        }
        Dictionary<string, Articolo> DictNegozio = new Dictionary<string, Articolo>();

        private void btnInserisciArticolo_Click(object sender, EventArgs e)
        {
            try
            {
                Articolo art;

                art.nome = txtNomeArticolo.Text;
                art.chiave = txtKeyArticolo.Text;
                DictNegozio.Add(art.chiave, art);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Messaggio di errore generato: "+ex.Message, "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void btnVisualizzaArticoli_Click(object sender, EventArgs e)
        {
            lblRisultato.Text = "";
            foreach (Articolo arc in DictNegozio.Values)
            {
                lblRisultato.Text += "\nChiave: "+arc.chiave+ "\nTitolo: "+arc.nome;
            }
            lblRisultato.Text += "\nCi sono: " + DictNegozio.Count + " elementi";
        }

        private void vbtnRicercaWithKey_Click(object sender, EventArgs e)
        {
            try
            {
                Articolo art = DictNegozio[txtKeyArticolo.Text]; //inserisco tipo string siccome nella dichiarazione ho specificato tipologia string
                lblRisultato.Text = art.chiave + " " + art.nome;
            }
            catch (Exception)
            {
                MessageBox.Show("Chiave inesistente");
            }
        }
    }
}
