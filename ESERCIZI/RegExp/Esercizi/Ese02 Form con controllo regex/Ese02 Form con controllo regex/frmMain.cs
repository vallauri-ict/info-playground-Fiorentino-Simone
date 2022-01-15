using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Ese02_Form_con_controllo_regex
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }
        bool[] corretti = new bool[9];

        private void frmMain_Load(object sender, EventArgs e)
        {
            lblInizia.Text = "AVVIA LA FORM, premendo il pulsante qui sotto";
            lblTitolo.Visible = false;
            gbForm.Visible = false;
            btnAvviaForm.Location = new Point (300, 210);
            btnAvviaForm.Visible = true;

            
        }

        private void avviaForm_Click(object sender, EventArgs e)
        {
            lblInizia.Visible = false;
            btnAvviaForm.Visible = false;


            /*VISIBLE: */
            lblTitolo.Visible = true;
            gbForm.Visible = true;


            //NON CORRETTO

            /*foreach (var item in this.Controls)
            {
                if (item is TextBox)
                {
                    TextBox txt =  (TextBox)item;
                    txt.BackColor = "prova";
                }
            }


            foreach (Control item in this.Controls)
            {
                if (item is TextBox)
                {
                    (item as TextBox).BackColor = Color.Red;
                }
            }*/
        }


        /* FUNCTIONS TEXT CHANGED */
        private void txtNome_TextChanged(object sender, EventArgs e) //CORRETTA
        {
            string content = txtNome.Text;
            Regex rgx = new Regex(@"^([a-zA-Z]{3,})$");
            if (rgx.IsMatch(content))
            {
                txtNome.BackColor = Color.Green;
                corretti[0] = true;
            }
            else
            {
                txtNome.BackColor = Color.Red;
                corretti[0] = false;
            }
        }

        private void txtCognome_TextChanged(object sender, EventArgs e) //CORRETTA
        {
            string content = txtCognome.Text;
            Regex rgx = new Regex(@"^([a-zA-Z]{3,})$");
            if (rgx.IsMatch(content))
            {
                txtCognome.BackColor = Color.Green;
                corretti[1] = true;
            }
            else
            {
                txtCognome.BackColor = Color.Red;
                corretti[1] = false;
            }
        }

        private void txtEtà_TextChanged(object sender, EventArgs e) //CORRETTA
        {
            string content = txtEtà.Text;
            Regex rgx = new Regex(@"^([1-9]{0,1}[0-9]|^1[0-1][0-9])$");
            if (rgx.IsMatch(content))
            {
                txtEtà.BackColor = Color.Green;
                corretti[2] = true;
            }
            else
            {
                txtEtà.BackColor = Color.Red;
                corretti[2] = false;
            }
        }

        private void txtCAP_TextChanged(object sender, EventArgs e) //CORRETTA
        {
            string content = txtCAP.Text;
            Regex rgx = new Regex(@"^\d{5}$");
            if (rgx.IsMatch(content))
            {
                txtCAP.BackColor = Color.Green;
                corretti[3] = true;
            }
            else
            {
                txtCAP.BackColor = Color.Red;
                corretti[3] = false;
            }
        }

        private void txtCittà_TextChanged(object sender, EventArgs e) //CORRETTA
        {
            string content = txtCittà.Text;
            Regex rgx = new Regex(@"^[a-zA-Z]{3,}\s\([a-zA-Z]{2}\)$");
            if (rgx.IsMatch(content))
            {
                txtCittà.BackColor = Color.Green;
                corretti[4] = true;
            }
            else
            {
                txtCittà.BackColor = Color.Red;
                corretti[4] = false;
            }
        }

        private void txtMail_TextChanged(object sender, EventArgs e) //CORRETTA, ma NON bisogna lasciare spazi tra una mail e un altra 
        {
            string content = txtMail.Text;
            Regex rgx = new Regex(@"^(\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*)(,\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*)*$");
            if (rgx.IsMatch(content))
            {
                txtMail.BackColor = Color.Green;
                corretti[5] = true;
            }
            else
            {
                txtMail.BackColor = Color.Red;
                corretti[5] = false;
            }
        }
       

        private void txtCF_TextChanged(object sender, EventArgs e) //CORRETTA
        {
            string content = txtCF.Text;
            Regex rgx = new Regex(@"^[a-zA-Z]{6}[0-9]{2}[abcdehlmprstABCDEHLMPRST]{1}[0-9]{2}([a-zA-Z]{1}[0-9]{3})[a-zA-Z]{1}$");
            if (rgx.IsMatch(content))
            {
                txtCF.BackColor = Color.Green;
                corretti[6] = true;
            }
            else
            {
                txtCF.BackColor = Color.Red;
                corretti[6] = false;
            }
        }

        private void txtUserName_TextChanged(object sender, EventArgs e) //CORRETTA
        {
            string content = txtUserName.Text;
            Regex rgx = new Regex(@"[a-zA-Z]\w{4,}");
            if (rgx.IsMatch(content))
            {
                txtUserName.BackColor = Color.Green;
                corretti[7] = true;
            }
            else
            {
                txtUserName.BackColor = Color.Red;
                corretti[7] = false;
            }
        }

        private void txtPwd_TextChanged(object sender, EventArgs e) //NON CORRETTA
        {
            string content = txtPwd.Text;
            // REGEX NON CORRETTA: Regex rgx = new Regex(@"^(?=.*[A-Za-z])(?=.*\d)(?=.*[!-+])([A-Za-z\d!-+]{1,}){8,15}$");
            Regex rgx = new Regex(@"^(?=.*[A-Za-z])(?=.*\d)[A-Za-z\d]{8,}$");
            if (rgx.IsMatch(content))
            {
                txtPwd.BackColor = Color.Green;
                corretti[8] = true;
            }
            else
            {
                txtPwd.BackColor = Color.Red;
                corretti[8] = false;
            }
        }

        private void btnInvia_Click(object sender, EventArgs e)
        {
            bool procedi = true;
            int sbagliate = 0;
            string msg;
            for (int i = 0; i < corretti.Length; i++)
            {
                if (corretti[i] == false)
                {
                    procedi = false;
                    ++sbagliate;
                }
            }
            if (procedi)
            {
                msg = "Invio del form correttamente!!\nElenco mail:\n";
                if (txtMail.Text.Contains(","))
                {
                    for (int i = 0; i < txtMail.Text.Split(',').Length; i++)
                    {
                        if (i == 0)
                            msg += " ";
                        msg += txtMail.Text.Split(',')[i] + "\n";
                    }
                }
            }
            else
            {
                msg = "Ci sono " + sbagliate + " errori, non si può inviare il form!";
            }
            MessageBox.Show(msg,"Invio del Form",MessageBoxButtons.OK);
        }
    }
}
