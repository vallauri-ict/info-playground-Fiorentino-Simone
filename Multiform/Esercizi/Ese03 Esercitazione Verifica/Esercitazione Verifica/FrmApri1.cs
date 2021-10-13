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

    public partial class FrmApri1 : Form
    {
        public string chBoxPelle="";
        public string chBoxStoffa="";
        public string cmbValue="";

        public FrmApri1()
        {
            InitializeComponent();
        }

        private void chkPelle_CheckedChanged(object sender, EventArgs e)
        {
            if (chkPelle.Checked)
                chBoxPelle = "Pelle";
            else chBoxPelle = "";
        }

        private void chkStoffa_CheckedChanged(object sender, EventArgs e)
        {
            if (chkStoffa.Checked)
                chBoxStoffa = "Stoffa";
            else chBoxStoffa = "";
        }

        private void cmbMarche_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbValue = cmbMarche.SelectedItem.ToString();
        }
    }
}
