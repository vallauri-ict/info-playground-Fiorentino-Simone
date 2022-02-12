using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Interfaccia_Comparable
{
    public partial class frmMain : Form
    {
        List<Persona> personaList=new List<Persona>();
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnInserisci_Click(object sender, EventArgs e)
        {
            Persona persona = new Persona();
            
            persona.Cognome = txtCognome.Text;
            persona.Nome = txtNome.Text;
            persona.Età = Convert.ToInt32(txtEtà.Text);
            
            personaList.Add(persona);
        }

        private void btnElenca_Click(object sender, EventArgs e)
        {
            personaList.Sort(); //ordina gli elementi della lista (con quello comparable che abbiamo messo noi)
            string s="";
            foreach  (var persona in personaList)
            {
                s += "Cognome: " + persona.Cognome + "\n"
                    + "Nome: " + persona.Nome + "\n"
                    + "Età: " + persona.Età + Environment.NewLine;
            }
            MessageBox.Show(s);
        }
    }
}
