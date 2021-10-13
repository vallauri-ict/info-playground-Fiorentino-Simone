using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Verifica_FIORENTINO_SIMONE
{
    public partial class frmMain : Form
    {
        FrmApri1 frm;
        frmApri2 frm2;

        public frmMain()
        {
            InitializeComponent();
        }

        private void apri1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm = new FrmApri1();
            frm.StartPosition = FormStartPosition.Manual;
            frm.Location = new Point(0, 0);
            frm.MdiParent = this;
            this.toolStripStatusLabel1.Text = "";
            frm.Show();
        }

        private void apri2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frm.chk != "" && frm.cmb != "")
            {
                string lblAuto = frm.cmb; 
                string lblChk = frm.chk;
                toolStripStatusLabel1.Text = "Trattore scelto: " + lblAuto+" "+lblChk;
                frm2 = new frmApri2(lblAuto,lblChk);
                frm2.MdiParent = this;
                frm2.StartPosition = FormStartPosition.Manual;
                frm2.Location = new Point(400, 0);
                frm2.Show();
            }
            else
            {
                FrmAvviso frm = new FrmAvviso();
                frm.ShowDialog();
            }
            
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            frm = new FrmApri1();
        }

        private void esciToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            FormModaleChiusura frm = new FormModaleChiusura();
            frm.Text = "Uscire?";
            if (frm.ShowDialog() != DialogResult.OK)
                e.Cancel = true;
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            FormInformazioniAutore frm = new FormInformazioniAutore();
            frm.ShowDialog();
        }
    }
}
