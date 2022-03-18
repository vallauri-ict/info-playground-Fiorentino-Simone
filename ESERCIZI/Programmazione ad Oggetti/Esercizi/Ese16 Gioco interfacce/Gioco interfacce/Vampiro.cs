using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gioco_interfacce
{
    class Vampiro : Mostro
    {
        protected int forza;

        public Vampiro()
        {
            forza = 15;
        }

        public void Azzanna()
        {
            forza = forza - 2;
        }

        public string GetForza()
        {
            return "Forza rimanente come vampiro:" + forza;
        }
    }
}
