using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_e_Orario
{
    internal class DataOra : Data
    {
        #region VARIABILI
        private int ore;
        private int minuti;
        private int secondi;
        #endregion

        #region COSTRUTTORI
        public DataOra()
        {
            ore = 1;
            minuti = 0;
            secondi = 0;
        }

        public DataOra(int ore, int minuti, int secondi)
        {
            this.ore = ore;
            this.minuti = minuti;
            this.secondi = secondi;
        }

        public DataOra(int giorno, int mese, int anno, int ore, int minuti, int secondi)
        {
            Data dt=new Data(giorno,mese,anno);
            this.ore=ore;
            this.minuti = minuti;
            this.secondi = secondi;
        }

        #endregion

        #region METODI VIRTUAL
        public override string ToString()
        {
            return base.ToString()+" --- "+(ore) + ":" + (minuti) + ":" + (secondi);
        }
        
        public virtual string Leggi(int giorno, int mese, int anno, int ore, int minuti, int secondi)
        {
            return Leggi(giorno,mese,anno)+" --- "+ore + ":" + minuti + ":" + secondi;
        }

        public virtual string Scrivi(int giorno, int mese, int anno, int ore, int minuti, int secondi)
        {
            string data = Scrivi(giorno, mese, anno);
            return data+" ----- "+this.ore + ":" + this.minuti + ":" + this.secondi;
        }
        #endregion
    }
}
