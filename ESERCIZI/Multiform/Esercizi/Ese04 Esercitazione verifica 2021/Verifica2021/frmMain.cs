using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Verifica2021
{
    public partial class frmMain : Form
    {
        FormApri1 frm;
        frmFinestra2 frm2;

        public frmMain()
        {
            InitializeComponent();
        }

        public frmMain(string scelta)
        {
            InitializeComponent();
            this.toolStripStatusLabel1.Text = scelta;
        }

        private void apri1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm = new FormApri1(true);
            frm.MdiParent = this;
            frm.StartPosition = FormStartPosition.Manual;
            frm.Location = new Point(0, 0);
            frm.Show();
        }

        public void esciToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void apri2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm2 = new frmFinestra2();
            frm2.MdiParent = this; //this.ParentForm ==> per assegnare MdiParent al main
            frm2.StartPosition = FormStartPosition.Manual;
            frm2.Location = new Point(700, 0);
            frm2.Show();
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            FormModaleChiusura frm = new FormModaleChiusura();
            frm.Text = "Uscire?";
            if (frm.ShowDialog() != DialogResult.OK)
                e.Cancel = true; //controlla la chiusura e mette cancel a true quindi non viene chiuso
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            FormInformazioniAutore frm = new FormInformazioniAutore();
            frm.ShowDialog();
        }
    }
}
