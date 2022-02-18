using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lancio_Dado
{
    internal class MonetaAbs : OggettoLanciato
    {
        Random random = new Random();
        public MonetaAbs()
        {
            x = 0;
        }

        public override void Lancia()
        {
            x = random.Next(0, 2) + 1;
        }
    }
}
