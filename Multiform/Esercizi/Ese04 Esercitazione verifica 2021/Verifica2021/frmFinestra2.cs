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
    public partial class frmFinestra2 : Form
    {
        public string colore;
        public string choose;
        FormApri1 frm2;
        frmMain frmMain;

        public frmFinestra2()
        {
            InitializeComponent();
        }

        public frmFinestra2(string scelta, FormApri1 frm) //creo un costruttore per passare la variabile globale della formApri1
        {
            //ricordo non funziona FormApri1.scelta, bisogna PER FORZA usare il costruttore
            InitializeComponent();
            this.choose = scelta;
            frm.Enabled = false;
        }

        private void btnInizia_Click(object sender, EventArgs e)
        {
            bool check = false;
            if (rbBianco.Checked)
            {
                colore = rbBianco.Text;
                check = true;
            }

            if (rbNero.Checked)
            {
                colore = rbNero.Text;
                check = true; 
            }

            if (rbRandom.Checked)
            {
                colore = rbRandom.Text;
                check = true;
            }

            if (check)
                MessageBox.Show("La partita: " + choose + " con il " + colore + " sta per iniziare");
            else
                MessageBox.Show("Seleziona un colore");
        }

        private void btnAnnulla_Click(object sender, EventArgs e)
        {
            frm2 = new FormApri1(true);
            /*BISOGAN PER FORZA RISCRIVERE QUESTE LINEE DI CODICE PER CREARE UNA NUOVA FINESTRA, non basta la form.show() */
            frm2.MdiParent = this.ParentForm;
            frm2.StartPosition = FormStartPosition.Manual;
            frm2.Location = new Point(0, 0);
            frm2.Show();
        }

        private void frmFinestra2_Load(object sender, EventArgs e)
        {
            rbBianco.Checked = false;
            rbRandom.Checked = false;
            rbNero.Checked = false;
        }
    }
}
