using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ese02_Controllo_compatibilità
{
    public partial class frmMain : Form
    {
        Persona abele = new Persona(); //abele punta a una persona appena creata

        public frmMain()
        {
            InitializeComponent();
        }

        private void btnPassaggioPerValore_Click(object sender, EventArgs e)
        {
            abele.età = 18;
            MessageBox.Show("Età PRIMA del richiamo a compleanno di Abele:\n" + abele.età);
            Compleanno(abele);
            MessageBox.Show("Età DOPO del richiamo a compleanno di Abele:\n" + abele.età);
        }

        private void Compleanno(Persona p)
        {
            p.età++;
        }

        private void Supplenza(ref Persona p)
        {
            p = new Persona();
            p.età++;
        }

        private void btnPassaggioPerREF_Click(object sender, EventArgs e)
        {
            abele.età = 54;
            MessageBox.Show("Età PRIMA del richiamo a supplenza di Abele:\n" + abele.età);
            Supplenza(ref abele);
            MessageBox.Show("Età DOPO del richiamo a supplenza di Abele:\n" + abele.età);
        }
    }
}
