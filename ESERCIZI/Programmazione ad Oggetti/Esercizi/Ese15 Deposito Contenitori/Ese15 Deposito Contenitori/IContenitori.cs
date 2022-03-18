using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ese15_Deposito_Contenitori
{
    internal interface IContenitori
    {
        //metodo che permette il confronto tra pesi di contenitori

        int Peso { get; set; }
        string Tipo { get; set; }
        string CodiceUnivoco { get; set; }
        string Liquido { get; set; }
        int Qta { get; set; }

        string Confronta(Contenitore c1, Contenitore c2);
    }
}
