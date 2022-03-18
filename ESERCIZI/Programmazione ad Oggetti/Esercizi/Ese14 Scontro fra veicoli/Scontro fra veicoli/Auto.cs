using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scontro_fra_veicoli
{
    class Auto : Veicolo
    {
        public Auto(int d)
        {
            Dimensione = d;
            Integrita = 100;
            Peso = 1000;
            Velocità = 70;
            Type = "auto";
        }
    }
}
