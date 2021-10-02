using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsEse02
{
    public partial class frmPadre : Form
    {
        public frmPadre()
        {
            InitializeComponent();
        }

        private void bntApriFiglia1_Click(object sender, EventArgs e)
        {
            FormFiglia frm = new FormFiglia();
            frm.MdiParent = this; //diciamo che è figlia del padre, cioè this
            frm.Text = "Figlia 1";
            frm.Size = new Size(200, 150);
            frm.StartPosition = FormStartPosition.Manual;
            frm.Location = new Point(0, 20);
            frm.Show();
        }

        private void btnApriFiglia2_Click(object sender, EventArgs e)
        {
            FormFiglia2 frm = new FormFiglia2();
            frm.MdiParent = this; //diciamo che è figlia del padre, cioè this
            frm.Text = "Figlia 2";
            frm.Size = new Size(200, 150);
            frm.StartPosition = FormStartPosition.Manual;
            frm.Location = new Point(205, 20);
            frm.Show();
        }

        private void btnFinestreAperte_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Sono state aperte " + this.MdiChildren.Length+ " finestre");
            foreach (Form frm in this.MdiChildren) //utilizzo una variabile ausiliare di tipo Form siccome sto lavorando con delle form, all'interno della matrice MdiChildren
                MessageBox.Show("Finestra aperta: " + frm.Text);    
        }

        private void apri1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStripStatusLbl.Text = "Premuto Apri 1";
        }

        private void apri2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStripStatusLbl.Text = "Premuto Apri 2";
        }

        private void esciToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmPadre_FormClosing(object sender, FormClosingEventArgs e)
        {
            FormModaleEsci frm = new FormModaleEsci();
            frm.Text = "Uscire?";
            if (frm.ShowDialog() != DialogResult.OK)
                e.Cancel = true; //controlla la chiusura e mette cancel a true quindi non viene chiuso
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            //creare Modale 
            infoCreatore fr = new infoCreatore();
            fr.ShowDialog();
        }
    }
}
