using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ese04_Ereditarietà
{
    class Mostro
    {
        public string nome;
        public double punti;
        
        public Mostro()
        {
            nome = "Senza Nome";
            punti = 500;
        }

        public Mostro(string n)
        {
            this.nome = n;
            this.punti = 100;
        }

        public double Valore()
        { // punti del Mostro
            return punti;
        }
    }
}
