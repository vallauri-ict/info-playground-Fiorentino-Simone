using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lancio_Dado
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnLancioDado_Click(object sender, EventArgs e)
        {
            Dado d=new Dado();
            d.Lancio();
            MessageBox.Show("Lancio del dado:"+ d.N);
        }

        private void btnLancioMoneta_Click(object sender, EventArgs e)
        {
            Moneta moneta = new Moneta();
            moneta.Lancia();
            string msg = moneta.V == 0 ? "Testa" : "Croce";
            MessageBox.Show("Lancio della moneta con valore: " + msg);
        }

        #region METODI ABSTRACT
        private void btnLancioDadoAbstract_Click(object sender, EventArgs e)
        {
            DadoAbs d=new DadoAbs();
            d.Lancia();
            MessageBox.Show("Lancio del dado, astratto: "+d.X);
        }

        private void btnLancioMonetaAbstract_Click(object sender, EventArgs e)
        {
            MonetaAbs mAbs = new MonetaAbs();
            mAbs.Lancia();
            MessageBox.Show("Lancio della moneta, astratto: " + mAbs.X);
        }
        #endregion
    }
}
