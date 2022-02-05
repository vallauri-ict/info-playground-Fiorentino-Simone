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

        Cilindro cilindro;

        private void btnAreaCilindro_Click(object sender, EventArgs e)
        {
            cilindro = new Cilindro(Convert.ToInt32(txtRaggio.Text),Convert.ToInt32(txtAltezza.Text));
            MessageBox.Show(cilindro.StampaArea());
        }

        private void btnVolumeCilindro_Click(object sender, EventArgs e)
        {
            MessageBox.Show(cilindro.StampaVolume());
        }
    }
}
