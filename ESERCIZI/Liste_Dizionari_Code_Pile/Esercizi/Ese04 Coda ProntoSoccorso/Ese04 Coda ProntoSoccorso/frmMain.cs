using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ese04_Coda_ProntoSoccorso
{
    public partial class frmMain : Form
    {
        public struct paziente{
            public string nome;
            public string eta;
            public string colore;
            public float temperatura;
        }

        public frmMain()
        {
            InitializeComponent();
        }

        Queue<paziente> codRosso = new Queue<paziente>();
        Queue<paziente> codGiallo = new Queue<paziente>();
        Queue<paziente> codVerde = new Queue<paziente>();
        Queue<paziente> codBianco = new Queue<paziente>();

        float[] temperature=new float[1000];
        int k = 0;

        private void btnInserisciPaziente_Click(object sender, EventArgs e)
        {
            /* TODO: 
             * 1. inserimento delle informazioni nella struct
             * 2. decide il colore (prima rossi, poi gialli, poi verdi, poi bianchi)
             * 3. inserire in base al colore il paziente nella lista corretta
             */

            if (txtNome.Text == "" || txtEtà.Text == "" || cmbColore.Text == "")
            {
                MessageBox.Show("Valori non inseriti correttamente!!");
                return;
            }
            else
            {
                /* Rosso (Urgentissimo)
                Giallo (Grave)
                Verde (Moderato)
                Bianco (Lieve)*/

                paziente ricoverato;
                //caricamento in struct
                ricoverato.nome = txtNome.Text;
                ricoverato.eta = txtEtà.Text;
                ricoverato.colore = cmbColore.Text;
                ricoverato.temperatura = float.Parse(nupTemperatura.Value.ToString());
                temperature[k] = ricoverato.temperatura;
                k++;

                switch (ricoverato.colore)
                {
                    case "Rosso (Urgentissimo)":
                        codRosso.Enqueue(ricoverato);
                        break;

                    case "Giallo (Grave)":
                        codGiallo.Enqueue(ricoverato);
                        break;

                    case "Verde (Moderato)":
                        codVerde.Enqueue(ricoverato);
                        break;

                    case "Bianco (Lieve)":
                        codBianco.Enqueue(ricoverato);
                        break;
                }
            }
        }

        private void btnGestisciPazienti_Click(object sender, EventArgs e)
        {
            paziente ricoverati;
            ricoverati.nome = "";
            ricoverati.eta = "";
            ricoverati.colore = "";
            ricoverati.temperatura = -1;
            lblInserimentoRis.Text = "";

            if (codRosso.Count == 0)
            {
                if (codGiallo.Count == 0)
                {
                    if (codVerde.Count == 0)
                    {
                        if (codBianco.Count == 0)
                        {
                            MessageBox.Show("Nessun paziente ricoverato");
                            return;
                        }
                        else //si lavora sul bianco
                            ricoverati = codBianco.Dequeue();
                    }
                    else //si lavora sul verde
                        ricoverati = codVerde.Dequeue();
                }
                else //si ragiona sul giallo
                    ricoverati = codGiallo.Dequeue();
            }
            else //si ragiona sul rosso
                ricoverati=codRosso.Dequeue();
            lblInserimentoRis.Text = ricoverati.nome + " \n" + ricoverati.eta + " anni di età \n" + ricoverati.colore + " \n" + ricoverati.temperatura.ToString() + " di temperatura";
        }

        private void btnResocontoTemp_Click(object sender, EventArgs e)
        {
            //ordinamento delle temperature
            ordinamentoTemperature(temperature);

            //visualizzazione max temp e min temp
            lblInserimentoRis.Text = "Temperatura Max: " + temperature[0] + "\nTemperatura minima" + temperature[--k];
        }

        private void ordinamentoTemperature(float[] temperature)
        {
            int posmin;
            float aus;

            for (int i = 0; i <= temperature.Length-2; i++)
            {
                posmin = i;
                for (int j = i+1; j <= temperature.Length-1; j++)
                {
                    if (temperature[posmin]<temperature[j])
                    {
                        posmin = j;
                    }
                }
                if (posmin != i)
                {
                    aus = temperature[i];
                    temperature[i] = temperature[posmin];
                    temperature[posmin] = aus;
                }
            }
        }
    }
}
