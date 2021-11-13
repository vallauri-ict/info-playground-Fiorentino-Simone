using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ese01_Liste_Funzionamento
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        public struct libro
        {
            public int id;
            public string titolo;
            public string autore;
        }
        List<libro> listaLibri = new List<libro>();

        private void btnListe_Click(object sender, EventArgs e)
        {
            libro l;
            l.id = Convert.ToInt32(textBox1.Text);
            l.titolo = textBox2.Text;
            l.autore = textBox3.Text;
            listaLibri.Add(l);
        }

        private void btnVisLista_Click(object sender, EventArgs e)
        {
            int i = 0;
            foreach (libro l in listaLibri)
            {
                MessageBox.Show(l.titolo);
                i++;
            }
        }
    }

}
}
