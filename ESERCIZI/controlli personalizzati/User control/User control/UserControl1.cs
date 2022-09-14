using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace User_control
{
    public partial class UserControl1: UserControl
    {

        private bool numero = false; //se true la texbox accetta solo numeri
        private string testo; //testo della textbox
        private int cifreDecimali = 0; //contiene il numerk di cifre 

        public bool Numero { get => numero; set => numero = value; }
        public string Testo { 
            get
            {
                testo = txtUser.Text;
                return testo;
            } 
            set
            {
                testo = value;
                txtUser.Text = testo;
            }
        }
        public int CifreDecimali
        {
            get => cifreDecimali; set
            {
                cifreDecimali = value;
                reimpostaTesto();
            }
        }

        public UserControl1()
        {
            InitializeComponent();
        }

        private void reimpostaTesto()
        {
            if (numero && Testo != "")
            {
                try
                {
                    //controllare che non ci sia più di una virgola
                    if (contaVirgole(Testo) > 1)
                    {
                        throw new Exception("Ci sono troppe virgole");
                    }
                    double numero = Math.Round(Convert.ToDouble(Testo), CifreDecimali);
                    testo = numero.ToString();
                }
                catch (Exception)
                {
                    throw new Exception("Valore non valido");
                }
            }
        }

        private int contaVirgole(string testo)
        {
            int count = 0;
            for (int i = 0; i < testo.Length; i++)
            {
                char c = testo[i];
                if (c==';')
                {
                    count++;
                }
            }
            return count;
        }

        
        private void Pulisci()
        {
            Testo = "";
        }

        private void txtUser_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Numero)
            {
                if (!(char.IsDigit(e.KeyChar) || e.KeyChar == ',' || char.IsControl(e.KeyChar)))
                {
                    e.Handled = true;
                }
            }
        }

        private void txtUser_Leave(object sender, EventArgs e)
        {
            reimpostaTesto();
        }
    }
}
            
