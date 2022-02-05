using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ese08_Recipiente
{
    public partial class frmMain : Form
    {
        Recipiente rc = new Recipiente();
        Bicchiere bc = new Bicchiere();   
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnEditCapacità_Click(object sender, EventArgs e)
        {
            try
            {
                int k = Convert.ToInt32(Interaction.InputBox("Inserisci un numero per modificare la capacità: "));
                rc.Set(k);
                MessageBox.Show("Capacità del recipiente modificata correttamente");
            }
            catch (Exception)
            {
                MessageBox.Show("Inserimento non corretto ritentare");
            }
        }

        private void btnAggiungiContenuto_Click(object sender, EventArgs e)
        {
            try
            {
                int k = Convert.ToInt32(Interaction.InputBox("Inserisci un numero per aumentare il contenuto: "));
                rc.Metti(k);
                MessageBox.Show("Contenuto del recipiente modificata correttamente");
            }
            catch (Exception)
            {
                MessageBox.Show("Inserimento non corretto ritentare");
            }
        }

        private void btnTogliContenuto_Click(object sender, EventArgs e)
        {
            try
            {
                int k = Convert.ToInt32(Interaction.InputBox("Inserisci un numero per diminuire il contenuto: "));
                rc.Togli(k);
                MessageBox.Show("Contenuto del recipiente modificata correttamente");
            }
            catch (Exception)
            {
                MessageBox.Show("Inserimento non corretto ritentare");
            }
        }

        private void btnClassicContainer_Click(object sender, EventArgs e)
        {
            rc = new Recipiente();
            MessageBox.Show("Bicchiere creato");
        }

        private void btnCreaEditRecipiente_Click(object sender, EventArgs e)
        {
            try
            {
                int k = Convert.ToInt32(Interaction.InputBox("Inserisci un numero per il recipiente: "));
                rc = new Recipiente(k);
            }
            catch (Exception)
            {
                MessageBox.Show("Inserimento non corretto ritentare");
            }
            
        }

        private void btnVisualizzaLaCapacità_Click(object sender, EventArgs e)
        {
            MessageBox.Show("La capacità del recipiente è: "+ rc.ToString());
        }

        private void btnCreaBicchiere_Click(object sender, EventArgs e)
        {
            bc = new Bicchiere();
            MessageBox.Show("Bicchiere creato");
        }

        private void btnEditBicchiere_Click(object sender, EventArgs e)
        {
            try
            {
                int k = Convert.ToInt32(Interaction.InputBox("Inserisci un numero per il bicchiere: "));
                bc = new Bicchiere(k);
            }
            catch (Exception)
            {
                MessageBox.Show("Inserimento non corretto ritentare");
            }
        }

        private void btnShowCapacità_Click(object sender, EventArgs e)
        {
            MessageBox.Show("La capacità del bicchiere è: " + bc.ToString());
        }

        private void btnEditCapacitàBicchiere_Click(object sender, EventArgs e)
        {
            try
            {
                int k = Convert.ToInt32(Interaction.InputBox("Inserisci un numero per modificare la capacità: "));
                bc.Set(k);
                MessageBox.Show("Capacità del bicchiere modificata correttamente");
            }
            catch (Exception)
            {
                MessageBox.Show("Inserimento non corretto ritentare");
            }
        }
    }
}
