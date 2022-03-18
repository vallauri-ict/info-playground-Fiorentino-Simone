using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ese15_Deposito_Contenitori
{
    internal class Bidone : Contenitore
    {
        public Bidone() : base()
        {
            base.Tipo = "BIDONE";
            base.CodiceUnivoco = "BIDONE_";
            base.Peso = 400; //maggiore siccome ha più stoccaggio
        }
    }
}
