using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ese10_VolumeOggetti
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }
        #region VARIABILI

        Cilindro cilindro;
        Parallelepipedo parallelepipedo;

        #endregion

        #region METODI CILINDRO
        private void btnAreaCilindro_Click(object sender, EventArgs e)
        {
            try
            {
                cilindro = new Cilindro(Convert.ToInt32(txtRaggio.Text), Convert.ToInt32(txtAltezza.Text));
                MessageBox.Show(cilindro.StampaArea());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Errore nella creazione e richiesta dell'area, messaggio: "+ex.Message);
            }
            
        }

        private void btnVolumeCilindro_Click(object sender, EventArgs e)
        {
            try
            {
                MessageBox.Show(cilindro.StampaVolume());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Errore nella creazione e richiesta dell'area, messaggio: " + ex.Message);
            }
        }
        #endregion

        #region METODI PARALLELEPIPEDO
        private void btnAreaParallelepipedo_Click(object sender, EventArgs e)
        {
            try
            {
                parallelepipedo = new Parallelepipedo(Convert.ToInt32(txtLato1.Text), Convert.ToInt32(txtLato2.Text), Convert.ToInt32(txtAltezza.Text));
                MessageBox.Show(parallelepipedo.StampaArea());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Errore nella creazione e richiesta dell'area, messaggio: " + ex.Message);
            }
        }

        private void btnVolumeParallelepipedo_Click(object sender, EventArgs e)
        {
            try
            {
                MessageBox.Show(parallelepipedo.StampaVolume());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Errore nella creazione e richiesta dell'area, messaggio: " + ex.Message);
            }
        }
        #endregion
    }
}
