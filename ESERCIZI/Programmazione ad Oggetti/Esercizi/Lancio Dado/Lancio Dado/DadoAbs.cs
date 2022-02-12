using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lancio_Dado
{
    internal class DadoAbs : OggettoLanciato
    {
        Random random = new Random();
        public DadoAbs()
        {
            x = 1;
        }

        protected override void Lancia()
        {
            x = random.Next(6) + 1;
        }
    }
}
