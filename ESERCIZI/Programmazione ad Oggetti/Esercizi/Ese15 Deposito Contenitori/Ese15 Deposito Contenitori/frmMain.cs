using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ese15_Deposito_Contenitori
{
    public partial class frmMain : Form
    {
        public const int MAX_CONTENITORI = 40;

        Contenitore[] contenitoreList = new Contenitore[MAX_CONTENITORI];
        int id = 0;

        public frmMain()
        {
            InitializeComponent();
        }

        private void btnAggiungi_Click(object sender, EventArgs e)
        {
            /*
             TIPO: 
             * LATTINE
             * BIDONE
            */

            Contenitore contenitore;

            if (cmbTipo.Text == "LATTINE") contenitore = new Lattine();
            else contenitore = new Bidone();

            contenitore.Qta = Convert.ToInt32(NupQta.Value);
            contenitore.Liquido = txtLiquido.Text;

            contenitore.CodiceUnivoco += id.ToString();
            
            contenitoreList[id] = contenitore;
            id++;

        }

        private void btnElenco_Click(object sender, EventArgs e)
        {
            string msg = stampaContenitori(contenitoreList);
            MessageBox.Show("Contenitori Registrati: "+ Environment.NewLine + msg);
        }

        private string stampaContenitori(Contenitore[] contenitori)
        {
            string msg = "";

            for (int i = 0; i < contenitori.Length; i++)
            {
                if (contenitori[i] != null) msg += contenitori[i].CodiceUnivoco + " Con indice:" + i + Environment.NewLine;
            }

            return msg;
        }

        private void btnConfronta_Click(object sender, EventArgs e)
        {
            Contenitore[] contenitori = {
                contenitoreList.ElementAt(Convert.ToInt32(txtIndice1.Text) - 1),
                contenitoreList.ElementAt(Convert.ToInt32(txtIndice2.Text) - 1)
            };

            Contenitore c = new Contenitore();

            if (contenitori[0].Tipo != contenitori[1].Tipo) { MessageBox.Show("Contenitori diversi!!"); return; }
            else
            {
                //bisogna compararli
                string ris = c.Confronta(contenitori[0], contenitori[1]);
                MessageBox.Show(ris);
            }
        }

        private void btnFiltra_Click(object sender, EventArgs e)
        {
            Utils utility = new Utils();

            Contenitore[] contenitoriRipuliti;
            Contenitore campione = new Contenitore();
            campione.Liquido = txtCampione.Text;

            contenitoriRipuliti = utility.filtra(contenitoreList, campione);
            if (contenitoriRipuliti.Length <= 0)
            {
                MessageBox.Show("Nessun elemento");
            }
            else
            {
                string msg = stampaContenitori(contenitoriRipuliti);
                MessageBox.Show("Contenitori ripuliti: " + Environment.NewLine + msg);
            }
        }
    }
}
