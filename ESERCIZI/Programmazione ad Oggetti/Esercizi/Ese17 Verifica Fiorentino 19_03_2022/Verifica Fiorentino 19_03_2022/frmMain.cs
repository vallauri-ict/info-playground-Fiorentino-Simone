using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Verifica_Fiorentino_19_03_2022
{
    public partial class frmMain : Form
    {
        Pianta p = new Pianta();
        Rosa r = new Rosa();
        
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnAggiungiPianta_Click(object sender, EventArgs e)
        {
            //crea una pianta e la aggiunge nella lista
            Pianta pianta = new Pianta(
                txtDescrizionePianta.Text,
                cmbTipoPianta.Text,
                cmbGenerePianta.Text,
                Convert.ToInt32(txtCostoPianta.Text));

            if (cmbTipoPianta.Text != "SEMPREVERDE") pianta.inserisciColore(txtColore.Text);
            p.aggiungiLista(pianta);
        }

        private void btnAggiungiRosa_Click(object sender, EventArgs e)
        {
            //crea una rosa e la aggiunge nella lista
            Rosa rosa = new Rosa(txtDescrizioneRosa.Text,
                cmbTipoRosa.Text,
                cmbGenereRosa.Text,
                Convert.ToInt32(txtCostoRosa.Text),
                txtVarietà.Text);
            r.aggiungiListaRosa(rosa);
        }

        private void btnVisualizzaListaPianta_Click(object sender, EventArgs e)
        {
            p.stampaPianta(lstPianta);
        }

        private void btnVisualizzaListaRosa_Click(object sender, EventArgs e)
        {
            r.stampaRose(lstRosa);
        }

        private void btnVenditaUltimaPianta_Click(object sender, EventArgs e)
        {
            p.venditaUltimoPianta();
            p.stampaPianta(lstPianta);
        }

        private void btnVenditaUltimaRosa_Click(object sender, EventArgs e)
        {
            r.venditaUltimaRosa();
            r.stampaRose(lstRosa);
        }

        private void btnVenditaPiantaLst_Click(object sender, EventArgs e)
        {
            try
            {
                int item=lstPianta.SelectedIndex;
                p.eliminaPiantaItem(item);
                p.stampaPianta(lstPianta);

                /*double prezzo = p.calcolaPrezzo();
                MessageBox.Show("Con prezzo:" + prezzo);*/
            }
            catch (Exception)
            {
                MessageBox.Show("Seleziona un item dalla lista piante");
            }
        }

        private void btnVenditaRosaList_Click(object sender, EventArgs e)
        {
            try
            {
                int item = lstRosa.SelectedIndex;
                r.eliminaRosaItem(item);
                r.stampaRose(lstRosa);

                /*double prezzo = r.calcolaPrezzo(Convert.ToInt32(nupQuantità.Value));
                MessageBox.Show("Con prezzo:"+ prezzo);*/
            }
            catch (Exception)
            {
                MessageBox.Show("Seleziona un item dalla lista rose");
            }
        }
    }
}
