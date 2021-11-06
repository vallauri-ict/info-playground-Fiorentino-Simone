using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ese05_Ereditarietà_Metodi
{
    class Mostro
    {
        /// <summary>
        ///  RICORDO: protected si utilizza per rendere private una variabile/metodo
        ///  la quale però può essere acceduta da una classe figlia
        /// </summary>
        protected double punti; 
        protected string verso;

        public Mostro() : this(25)
        {
            //punti = 25; equivalente a quella scrittura this(25) in più fa anche la riga 26
        }

        public Mostro(int p)
        {
            this.punti = p;
            verso = "grugnito";
        }

        public double Valore()
        {
            return punti;
        }

        public string Verso()
        {
            return verso;
        }
    }
}
