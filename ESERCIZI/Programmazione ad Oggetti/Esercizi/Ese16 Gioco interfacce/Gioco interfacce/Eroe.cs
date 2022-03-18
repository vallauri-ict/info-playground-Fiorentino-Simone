using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gioco_interfacce
{
    class Eroe : Umano
    {
        protected int forza;

        public Eroe()
        {
            forza = 10;
        }

        public void Combatti()
        {
            forza = forza - 3;
        }

        public string GetForza()
        {
            return "Forza rimanente come eroe:" + forza;
        }
    }
}
