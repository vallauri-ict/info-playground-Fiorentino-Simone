using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ese01_Introduzione_OOP
{
    public partial class frmOOP : Form
    {       
        //posso anche scrivere: Rectangle r; e poi andarla a istanziarla dopo
        Rectangle r = new Rectangle(); //vado a istanziare l'oggetto

        public frmOOP()
        {
            InitializeComponent();
        }

        private void btnCrea_Click(object sender, EventArgs e)
        {
            //riprendendo la scrittura Rectangle r; io posso andare ora ad istaziarla scrivendo: r=new Rectagle();

            //vado ad assegnare a delle varibili globali (public) all'interno della classe precedentemente istanziata, i valori dei txt; 
            r.sideAltezza = Convert.ToInt32(txtAltezza.Text);
            r.sideBase = Convert.ToInt32(txtBase.Text);
            MessageBox.Show("L'altezza vale: " + r.sideAltezza + " e la base: " + r.sideBase);


            Rectangle t; //anche se non istanziato il t funziona siccome io vado ad assegnarli r che è il puntatore ad un area di memoria
            t = r;
            MessageBox.Show("L'altezza vale: " + t.sideAltezza + " e la base: " + t.sideBase);
        }
    }
}