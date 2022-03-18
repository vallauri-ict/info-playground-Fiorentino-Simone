using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Scontro_fra_veicoli
{
    public partial class frmMain : Form
    {
        Veicolo veicolo = new Veicolo();
        List<Veicolo> v = new List<Veicolo>();
        Random rnd = new Random();
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnCamion_Click(object sender, EventArgs e)
        {
            Camion c = new Camion(rnd.Next(5000, 8000));
            v.Add(c);
        }

        private void btnAuto_Click(object sender, EventArgs e)
        {
            Auto a = new Auto(rnd.Next(13, 50));
            v.Add(a);
        }

        private void btnMoto_Click(object sender, EventArgs e)
        {
            Moto m = new Moto(rnd.Next(90, 130));
            v.Add(m);
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            while (v.Count > 1)
            {
                v = veicolo.turno(v);
            }
            MessageBox.Show("Scontri terminati");
            if(v.Count == 0)
                MessageBox.Show("Tutti i veicoli sono stati distrutti. C'è un pareggio");
            else
            {
                veicolo = v.ElementAt(0);
                MessageBox.Show("Il vincitore è " + veicolo.Type);
            }
        }
    }
}
