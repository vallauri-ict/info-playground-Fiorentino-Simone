using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ese15_Deposito_Contenitori
{
    internal class Utils : Contenitore
    {
        public Contenitore[] filtra (Contenitore[] contenitori, Contenitore campione)
        {
            //in ingresso un vettore di contenitori ed un contenitore campione 
            // deve restituire il vettore contenitori ripulito di tutti i contenitori che contengono 
            // lo stesso liquido del contenitore campione passato per parametro

            Contenitore[] contenitoriRipuliti = new Contenitore[contenitori.Length];
            int j = 0;

            for (int i = 0; i < contenitori.Length; i++)
            {
                if (contenitori[i] != null)
                {
                    if (contenitori[i].Liquido == campione.Liquido)
                    {
                        contenitoriRipuliti[j] = contenitori[i];
                        j++;
                    }
                }
            }

            return contenitoriRipuliti;
        }
    }
}
