using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ese05_Ereditarietà_Metodi
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnMostro_Click(object sender, EventArgs e)
        {
            //scrivendo m box con TAB + TAB crea la MessageBox.Show("Test")
            Mostro m = new Mostro();
            MessageBox.Show("Mostro: --> Verso: " + m.Verso().ToString() + "\n"
                + "Punti: " + m.Valore());
        }

        private void btnMannaro_Click(object sender, EventArgs e)
        {
            Mannaro mn = new Mannaro();
            MessageBox.Show("Mannaro: --> Verso: " + mn.Verso().ToString() + "\n"
                + "Punti: " + mn.Valore());
            mn.Muta();
            MessageBox.Show("Mannaro: --> Verso: " + mn.Verso().ToString() + "\n"
                + "Punti: " + mn.Valore());
        }

        private void btnSpettro_Click(object sender, EventArgs e)
        {
            Spettro s = new Spettro();
            MessageBox.Show("Spettro: --> Punti: " + s.Valore().ToString() + "\n" +"verso: "+s.Verso());

            Spettro s2 = new Spettro(50);
            MessageBox.Show("Spettro: --> Punti: " + s2.Valore().ToString() + "\n");
        }
    }
}
