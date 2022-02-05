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

        public DataOra(int giorno, int mese, int anno)
        {
            base.Leggi(giorno,mese,anno);
        }

        public DataOra(int giorno, int mese, int anno, int ore, int minuti, int secondi)
        {
            base.Leggi(giorno, mese, anno);
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
        
        public override void Leggi(int ore, int minuti, int secondi) //la differenza tra override e new è che quando io inserisco delle instanze in una lista e poi voglio usare questo metodo, con il new riprende quello del padre (senza il cast) senno prende l'override
        {
            //SET 
            this.ore = ore;
            this.minuti = minuti;
            this.secondi = secondi;
        }

        public override void Scrivi(ref int ore,ref int minuti,ref int secondi)
        {
            //GET
            ore = this.ore;
            minuti = this.minuti;
            secondi = this.secondi;
        }
        #endregion
    }
}
