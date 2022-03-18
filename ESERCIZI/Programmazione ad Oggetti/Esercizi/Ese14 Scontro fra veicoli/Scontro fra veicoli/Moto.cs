using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scontro_fra_veicoli
{
    class Moto : Veicolo
    {
        public Moto(int v)
        {
            Velocità = v;
            Integrita = 100;
            Peso = 150;
            Dimensione = 2;
            Type = "moto";
        }
    }
}
