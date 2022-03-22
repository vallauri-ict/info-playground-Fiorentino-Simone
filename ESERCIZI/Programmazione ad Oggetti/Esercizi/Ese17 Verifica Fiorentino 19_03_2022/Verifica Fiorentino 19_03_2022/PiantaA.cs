using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Verifica_Fiorentino_19_03_2022
{
    internal abstract class PiantaA
    {
        protected static int num = 0; //numero progressivo
        protected string descrizione;
        protected string tipo; //caricate da combobox
        protected string genere; //caricate da combobox
        protected int costo;
        protected readonly double prezzo; //(di sola lettura)
    }
}
