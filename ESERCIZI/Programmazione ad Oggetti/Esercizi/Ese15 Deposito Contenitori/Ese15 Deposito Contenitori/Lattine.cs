using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ese15_Deposito_Contenitori
{
    internal class Lattine : Contenitore
    {
        public Lattine() : base()
        {
            base.Tipo = "LATTINE";
            base.CodiceUnivoco = "LATTINE_";
            base.Peso = 200; //maggiore siccome ha più stoccaggio
        }
    }
}
