using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ese10_VolumeOggetti
{
    internal class Cilindro : Figura
    {
        private int raggio;

        public Cilindro()
        {

        }

        public Cilindro(int raggio, int altezza)
        {
            this.raggio = raggio;
            base.altezza = altezza;
        }

        protected override double Area()
        {
            return Math.Pow(raggio, 2) * Math.PI;
        }
    }
}
