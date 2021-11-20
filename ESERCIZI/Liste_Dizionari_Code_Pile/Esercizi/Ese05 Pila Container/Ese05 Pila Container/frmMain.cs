using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ese05_Pila_Container
{
    public partial class frmMain : Form
    {
        public struct container
        {
            public int cod;
            public int peso;
            public int tara;
        }

        public frmMain()
        {
            InitializeComponent();
        }

        Stack<container> pila = new Stack<container>();

        private void btnInserisciContainer_Click(object sender, EventArgs e)
        {
            if (txtPeso.Text=="" || txtTara.Text=="" || txtCodice.Text=="")
            {
                MessageBox.Show("Campi non completati correttamente !!");
            }
            else
            {
                container Container;
                Container.cod = Convert.ToInt32(txtCodice.Text);
                Container.peso = Convert.ToInt32(txtPeso.Text);
                Container.tara = Convert.ToInt32(txtTara.Text);
                pila.Push(Container); //inseriamo nella pila
            }
        }

        private void btnEstraiPila_Click(object sender, EventArgs e)
        {
            try
            {
                container containerEstratto;
                containerEstratto = pila.Pop(); //ricordo: estrae con una politica LIFO (Last in First Out)
                MessageBox.Show("Container estratto: \n COD: " + containerEstratto.cod.ToString() + "\n PESO: " + containerEstratto.peso.ToString() + "\n TARA: " + containerEstratto.tara.ToString());
            }
            catch (Exception)
            {
                MessageBox.Show("Non ci sono container da estrarre !!");
            }
        }
    }
}
