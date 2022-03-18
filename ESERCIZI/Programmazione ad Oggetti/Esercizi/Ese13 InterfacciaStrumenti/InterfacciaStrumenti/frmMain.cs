using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InterfacciaStrumenti
{
    public partial class frmMain : Form
    {
        Complesso cmp=new Complesso();
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnRumorista_Click(object sender, EventArgs e)
        {
            Rumorista rumorista = new Rumorista();
            cmp.AggiungiRumorista(rumorista);
        }

        private void btnChitarra_Click(object sender, EventArgs e)
        {
            Chitarra chitarra = new Chitarra();
            cmp.AggiungiStrumento(chitarra);
        }

        private void btnTromba_Click(object sender, EventArgs e)
        {
            Tromba tromba = new Tromba();
            cmp.AggiungiStrumento(tromba);
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            cmp.Play();
        }
    }
}
