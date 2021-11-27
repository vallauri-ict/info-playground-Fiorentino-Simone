using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ese07_Factory_Quadrato
{
    class Quadrato
    {
        private int lato;
        private Quadrato(int val)
        {
            lato = val;
        }

        public static Quadrato creaQuadrato(int val)
        {
            if (val > 0) return new Quadrato(val);
            else throw new Exception("Il lato deve essere maggiore di 0");
        }
    }
}
