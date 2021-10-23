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
    public partial class FrmApri1 : Form
    {
        public string cmb="";
        public string chk="";

        public FrmApri1()
        {
            InitializeComponent();
        }

        private void cmbMarca_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmb = cmbMarca.SelectedItem.ToString();
        }

        private void rbCabinato_CheckedChanged(object sender, EventArgs e)
        {
            if (rbCabinato.Checked)
                chk = "Cabinato";
            else chk = "";
        }

        private void rbNonCambinato_CheckedChanged(object sender, EventArgs e)
        {
            if (rbNonCambinato.Checked)
                chk = "Non Cabinato";
            else chk = "";
        }
    }
}
