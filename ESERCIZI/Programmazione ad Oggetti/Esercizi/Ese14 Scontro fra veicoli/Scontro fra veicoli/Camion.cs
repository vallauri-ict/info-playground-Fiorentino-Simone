using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scontro_fra_veicoli
{
    class Camion : Veicolo
    {
        public Camion(int p)
        {
            Peso = p;
            Dimensione = 12;
            Velocità = 60;
            Integrita = 100;
            Type = "camion";
        }
    }
}
