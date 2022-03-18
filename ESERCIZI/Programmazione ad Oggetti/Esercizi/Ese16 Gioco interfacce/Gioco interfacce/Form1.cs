using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gioco_interfacce
{
    public partial class Form1 : Form
    {
        Random rnd = new Random();
        public Form1()
        {
            InitializeComponent();
        }


        private void btnIniziaGioco_Click(object sender, EventArgs e)
        {
            
            bool luna = rnd.Next(0, 2) == 0 ? true : false;
            Eroe eroe = new Eroe();
            Licantropo l = new Licantropo(luna);
            Vampiro v = new Vampiro();
            for (int i = 0; i < 3; i++)
                eroe.Combatti();
            v.Azzanna();
            for (int i = 0; i < 2; i++)
            {
                l.Azzanna();
                l.Combatti();
            }

            MessageBox.Show(eroe.GetForza(), "EROE");
            MessageBox.Show(v.GetForza(), "VAMPIRO");
            MessageBox.Show(l.GetForza(), "LICANTROPO");
        }
    }
}
