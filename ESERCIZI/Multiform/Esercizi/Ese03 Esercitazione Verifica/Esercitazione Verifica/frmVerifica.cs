using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Esercitazione_Verifica
{

    /// <summary>
    /// ///////////////////////////////////////ESERCITAZIONE FIORENTINO SIMONE 4B INF ////////////////////////////////////////////////////
    /// </summary>
    public partial class frmVerifica : Form
    {
        FrmApri1 frm1; //per leggere le variabili pubbliche tra una form e un altra bisogna crearsi delle variabili Form nella form padre
        frmApri2 frm2;

        public frmVerifica()
        {
            InitializeComponent();
        }


        private void apri1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm1.MdiParent = this;
            frm1.Show();
        }

        private void apri2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if ((frm1.chBoxPelle!="" || frm1.chBoxStoffa!="") && (frm1.cmbValue!=""))
            {
                string lblInterni;
                string lblMarca=frm1.cmbValue;
                if (frm1.chBoxStoffa != "" && frm1.chBoxStoffa != "")
                    lblInterni = "Rivestimenti della macchina con: " + frm1.chBoxStoffa + " e " + frm1.chBoxPelle;
                else lblInterni = "Rivestimento della macchina con: " + frm1.chBoxPelle + "" + frm1.chBoxStoffa;
                toolStripStatusLblTipologiaAuto.Text = "Auto scelta: " + lblMarca;
                frm2 = new frmApri2(lblMarca,lblInterni);
                frm2.MdiParent = this;
                frm2.StartPosition = FormStartPosition.Manual;
                frm2.Location = new Point(400, 0);
                frm2.Show();
            }
            else
            {
                FrmAvviso frm = new FrmAvviso();
                frm.ShowDialog(); //importante uso della ShowDialog senno non la apre in modale
            }
           
        }

        private void frmVerifica_Load(object sender, EventArgs e)
        {
            frm1 = new FrmApri1();
        }

        private void frmVerifica_FormClosing(object sender, FormClosingEventArgs e)
        {
            FormModaleChiusura frm = new FormModaleChiusura();
            frm.Text = "Uscire?";
            if (frm.ShowDialog() != DialogResult.OK)
                e.Cancel = true; //controlla la chiusura e mette cancel a true quindi non viene chiuso
        }

        private void esciToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            FormInformazioniAutore frm = new FormInformazioniAutore();
            frm.ShowDialog();
        }
    }
}
