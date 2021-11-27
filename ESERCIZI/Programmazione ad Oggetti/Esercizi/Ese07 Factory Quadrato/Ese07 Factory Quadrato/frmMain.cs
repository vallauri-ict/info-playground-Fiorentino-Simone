using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ese07_Factory_Quadrato
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnFactory_Click(object sender, EventArgs e)
        {
            try
            {
                MessageBox.Show("Prova con lato = 5");
                Quadrato q = Quadrato.creaQuadrato(5); //non la instanzio siccome usiamo il metodo factory
                MessageBox.Show("Prova con lato = 0");
                Quadrato ql = Quadrato.creaQuadrato(0);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,
                    "Errore!",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void btnProvaSingleton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Creazione primo oggetto Singleton");
            Singleton s1 = Singleton.GetInstance();
            MessageBox.Show("Progressivo: " + s1.n);

            MessageBox.Show("Prova creazione secondo oggetto Singleton");
            Singleton s2 = Singleton.GetInstance();
            MessageBox.Show("Progressivo: "+s1.n); //se funziona, non dovrebbe incrementare il valore di n siccome non deve instanziare un nuovo oggetto

            MessageBox.Show("Prima instanza: " + s1 + "\nSeconda instanza" + s2);
        }

        private void btnIndexata_Click(object sender, EventArgs e)
        {
            StringheIndexate s = new StringheIndexate(10);

            for (int i = 0; i < 10; i++)
            {
                s[i] = i.ToString();
            }

            for (int i = 0; i < 10; i++)
            {
                MessageBox.Show("s["+i+"]="+s[i]);
            }
        }
    }
}
