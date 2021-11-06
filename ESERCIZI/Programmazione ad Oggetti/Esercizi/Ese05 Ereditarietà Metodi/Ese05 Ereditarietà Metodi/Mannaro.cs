using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ese05_Ereditarietà_Metodi
{
    class Mannaro : Mostro
    {
        /// <summary>
        ///  RICORDO: protected si utilizza per rendere private una variabile/metodo
        ///  la quale però può essere acceduta da una classe figlia
        /// </summary>
        protected bool mutato;
        protected new string verso; //il new non interferisce il funzionamento, ma rende leggibile il codice

        public Mannaro()
        {
            punti = 33;
            verso = "ululato";
            mutato = true;
        }

        public new double Valore()
        {
            if (mutato) return 2 * base.Valore();
            else return base.Valore();
        }

        public new string Verso() 
        {
            if (mutato) return verso; //nel caso non avessi dichiarato una variabile protected verso, lui avrebbe preso quella del padre lo stesso
            else return base.verso;
        }

        public void Muta()
        {
            mutato = !mutato;
        }
    }
}
