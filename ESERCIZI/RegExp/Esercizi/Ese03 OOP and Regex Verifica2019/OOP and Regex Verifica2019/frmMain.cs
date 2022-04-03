using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_and_Regex_Verifica2019
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        string errore = "";
        Dictionary<string, string> dictSoci = new Dictionary<string, string>();

        private void btnInviaDati_Click(object sender, EventArgs e)
        {
            bool trovato = false;
            foreach (var item in dictSoci)
            {
                if (item.Key == txtMatricola.Text)
                {
                    trovato = true;
                    errore = item.Key;
                }
            }
            if (!trovato)
            {
                Socio s = new Socio(txtMatricola.Text,txtNome.Text,txtCognome.Text);

                addInDictionary(s);

                Associazione associazione = Associazione.GetInstance();
                associazione.AddSocio(s);
            }
            else
            {
                string nameErrato = dictSoci[errore];
                MessageBox.Show("il nome: "+nameErrato+ " è gia presente");
            }
            pulisciCampi();
        }

        private void pulisciCampi()
        {
            txtMatricola.Text = "";
            txtNome.Text = "";
            txtCognome.Text = "";
        }

        private void addInDictionary(Socio s)
        {
            dictSoci.Add(s.matricola, s.nome + " " + s.cognome);
        }

        #region TEXTCHANGED
        private void txtMatricola_TextChanged(object sender, EventArgs e)
        {
            /*Regex matricola = new Regex(@"");
            if (matricola.IsMatch(txtMatricola.Text) && txtMatricola.Text != "")
                txtMatricola.BackColor = Color.White;
            else
                txtMatricola.BackColor = Color.FromArgb(255, 77, 77);*/
        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {
            Regex nome = new Regex(@"^[a-zA-Z]{3,}$");
            if (nome.IsMatch(txtNome.Text) && txtNome.Text != "")
                txtNome.BackColor = Color.White;
            else
                txtNome.BackColor = Color.FromArgb(255, 77, 77);
        }

        private void txtCognome_TextChanged(object sender, EventArgs e)
        {
            Regex cognome = new Regex(@"^[a-zA-Z]{3,}$");
            if (cognome.IsMatch(txtCognome.Text) && txtCognome.Text != "")
                txtCognome.BackColor = Color.White;
            else
                txtCognome.BackColor = Color.FromArgb(255, 77, 77);
        }
        #endregion

        private void btnVisualizzaSoci_Click(object sender, EventArgs e)
        {
            Associazione associazione = Associazione.GetInstance();
            List<Socio> soci = associazione.returnList();

            string msg = "";
            foreach (var item in soci)
            {
                msg += item.nome + " \n";
            }
            MessageBox.Show("Soci presenti: "+msg);
        }
    }
}
