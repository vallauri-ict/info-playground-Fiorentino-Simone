using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace Data_e_Orario
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        public int[] mesi31 = new int[]
        {
            1,3,5,7,8,10,12
        };

        Data dt;
        DataOra dtOra;

        #region BUTTON CLICK FOR DATA
        private void btnCreaData_Click(object sender, EventArgs e)
        {
            try
            {
                dt = new Data();
                MessageBox.Show("CREAZIONE DELLA DATA EFFETTUATA, senza parametri, CON SUCCESSO", "successo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("CREAZIONE NON EFFETTUATA,\n ERRORE: "+ex.Message,"Errore!",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void btnCreaDataConParametri_Click(object sender, EventArgs e)
        {
            try
            {
                string output = inserimentoGiornoMeseAnno();
                string[] val = new string[3];
                val = output.Split(':');
                dt = new Data(Convert.ToInt32(val[0]), Convert.ToInt32(val[1]), Convert.ToInt32(val[2]));
                MessageBox.Show("CREAZIONE DELLA DATA EFFETTUATA, con parametri, CON SUCCESSO", "successo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("CREAZIONE NON EFFETTUATA,\n ERRORE: " + ex.Message, "Errore!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnToString_Click(object sender, EventArgs e)
        {
            if (dt == null) dt = new Data();
            MessageBox.Show("TOSTRING: " + dt.ToString());
        }

        private void btnBisestile_Click(object sender, EventArgs e)
        {
            if (dt == null) dt = new Data();
            if (dt.Bisestile())
                MessageBox.Show("L'anno non è bisestile");
            else MessageBox.Show("L'anno è bisestile");
        }

        private void btnLeggiData_Click(object sender, EventArgs e)
        {
            if (dt == null) dt = new Data();
            string output = inserimentoGiornoMeseAnno();
            string[] val = new string[3];
            val = output.Split(':');
            MessageBox.Show("DATA: " + dt.Leggi(Convert.ToInt32(val[0]), Convert.ToInt32(val[1]), Convert.ToInt32(val[2])));
        }

        private void btnScriviData_Click(object sender, EventArgs e)
        {
            if (dt == null) dt = new Data();
            string output = inserimentoGiornoMeseAnno();
            string[] val = new string[3];
            val = output.Split(':');
            MessageBox.Show("DATA: " + dt.Scrivi(Convert.ToInt32(val[0]), Convert.ToInt32(val[1]), Convert.ToInt32(val[2])));
        }

        private void btnDomani_Click(object sender, EventArgs e)
        {
            try
            {
                if (dt == null) dt = new Data();
                dt.Domani();
                MessageBox.Show("INCREMENTO DATA DI UN GIORNO", "successo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("INCREMENTO NON EFFETTUATO,\n ERRORE: " + ex.Message, "Errore!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnDecrementa_Click(object sender, EventArgs e)
        {
            try
            {
                if (dt == null) dt = new Data();
                dt.Ieri();
                MessageBox.Show("DECREMENTO DATA DI UN GIORNO", "successo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("DECREMENTO NON EFFETTUATO,\n ERRORE: " + ex.Message, "Errore!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnConosciGiorno_Click(object sender, EventArgs e)
        {
            if (dt == null) dt = new Data();
            MessageBox.Show("Attualmente è: " + dt.Giorno());
        }
        #endregion



        #region HELPED FUNCTION
        private string inserimentoGiornoMeseAnno()
        {
            int mese, giorno, anno;
            do
            {
                anno = Convert.ToInt32(Interaction.InputBox("Inserisci un anno: (compreso tra 1900 e 2022)", "ANNO:"));
                mese = Convert.ToInt32(Interaction.InputBox("Inserisci un mese: (compreso tra 1 e 12)", "MESE:"));
            } while ((mese < 1 || mese > 12) || (anno < 1900 || anno > 2022));

            if (mesi31.Contains(mese))//vuol dire che di 31
            {
                do
                {
                    giorno = Convert.ToInt32(Interaction.InputBox("Inserisci un giorno: (compreso tra 1 e 31)", "GIORNO:"));
                } while (giorno < 1 || giorno > 31);
            }
            else if (mese != 2)//vuol dire che di 30
            {
                do
                {
                    giorno = Convert.ToInt32(Interaction.InputBox("Inserisci un giorno: (compreso tra 1 e 30)", "GIORNO:"));
                } while (giorno < 1 || giorno > 30);
            }
            else //vuol dire che di 28
            {
                if (Data.Bisestile(anno))
                {
                    do
                    {
                        giorno = Convert.ToInt32(Interaction.InputBox("Inserisci un giorno: (compreso tra 1 e 29)", "GIORNO:"));
                    } while (giorno < 1 || giorno > 29);
                }
                else
                {
                    do
                    {
                        giorno = Convert.ToInt32(Interaction.InputBox("Inserisci un giorno: (compreso tra 1 e 28)", "GIORNO:"));
                    } while (giorno < 1 || giorno > 28);
                }
            }
            return giorno.ToString() + ":" + mese.ToString() + ":" + anno.ToString();
        }

        private string inserimentoOra()
        {
            int ora, minuti, secondi;
            do
            {
                ora = Convert.ToInt32(Interaction.InputBox("Inserisci un anno: (compreso tra 1 e 24)", "ORA:"));
            } while (ora < 1 || ora > 24);

            do
            {
                minuti = Convert.ToInt32(Interaction.InputBox("Inserisci un minuto: (compreso tra 1 e 60)", "MINUTO:"));
                secondi = Convert.ToInt32(Interaction.InputBox("Inserisci un mese: (compreso tra 1 e 60)", "SECONDI:"));
            } while ((minuti < 1 || minuti > 60) || (secondi < 1 || secondi > 60));
            return ora.ToString() + ":" + minuti.ToString() + ":" + secondi.ToString();
        }
        #endregion

        #region DATA E ORA
        private void btnCreaOra_Click(object sender, EventArgs e)
        {
            try
            {
                dtOra = new DataOra();
                MessageBox.Show("CREAZIONE DELLA DATA E ORA EFFETTUATA, senza parametri, CON SUCCESSO", "successo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("CREAZIONE NON EFFETTUATA,\n ERRORE: " + ex.Message, "Errore!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCreaOraConParametri_Click(object sender, EventArgs e)
        {
            try
            {
                string output = inserimentoOra();
                string[] val = new string[3];
                val = output.Split(':');
                dtOra = new DataOra(Convert.ToInt32(val[0]), Convert.ToInt32(val[1]), Convert.ToInt32(val[2]));
                MessageBox.Show("CREAZIONE DELLA DATA E ORA EFFETTUATA, con parametri, CON SUCCESSO", "successo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("CREAZIONE NON EFFETTUATA,\n ERRORE: " + ex.Message, "Errore!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCreaDataEOra_Click(object sender, EventArgs e)
        {
            try
            {
                string output = inserimentoOra();
                string[] val = new string[3];
                val = output.Split(':');

                string outputData = inserimentoGiornoMeseAnno();
                string[] valData = new string[3];
                valData = outputData.Split(':');

                dtOra = new DataOra(Convert.ToInt32(val[0]), Convert.ToInt32(val[1]), Convert.ToInt32(val[2]),
                    Convert.ToInt32(valData[0]), Convert.ToInt32(valData[1]), Convert.ToInt32(valData[2]));
                MessageBox.Show("CREAZIONE DELLA DATA E ORA EFFETTUATA, con parametri, CON SUCCESSO", "successo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("CREAZIONE NON EFFETTUATA,\n ERRORE: " + ex.Message, "Errore!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnToStringDataEOra_Click(object sender, EventArgs e)
        {
            if (dtOra == null) dtOra = new DataOra();
            MessageBox.Show("TOSTRING: " + dtOra.ToString());
        }

        private void btnLeggiDataEOra_Click(object sender, EventArgs e)
        {
            if (dtOra == null) dtOra = new DataOra();
            string output = inserimentoOra();
            string[] val = new string[3];
            val = output.Split(':');

            string outputData = inserimentoGiornoMeseAnno();
            string[] valData = new string[3];
            valData = outputData.Split(':');
            MessageBox.Show("DATA E ORA: " + dtOra.Leggi(Convert.ToInt32(val[0]), Convert.ToInt32(val[1]), Convert.ToInt32(val[2]),
                    Convert.ToInt32(valData[0]), Convert.ToInt32(valData[1]), Convert.ToInt32(valData[2])));
        }

        private void btnScriviDataEOra_Click(object sender, EventArgs e)
        {
            if (dtOra == null) dtOra = new DataOra();
            string output = inserimentoOra();
            string[] val = new string[3];
            val = output.Split(':');

            string outputData = inserimentoGiornoMeseAnno();
            string[] valData = new string[3];
            valData = outputData.Split(':');
            MessageBox.Show("DATA E ORA: " + dtOra.Scrivi(Convert.ToInt32(val[0]), Convert.ToInt32(val[1]), Convert.ToInt32(val[2]),
                    Convert.ToInt32(valData[0]), Convert.ToInt32(valData[1]), Convert.ToInt32(valData[2])));
        }
        #endregion
    }
}
