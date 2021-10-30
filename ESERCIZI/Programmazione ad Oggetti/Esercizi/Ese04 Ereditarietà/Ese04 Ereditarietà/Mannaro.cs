using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ese04_Ereditarietà
{
    class Mannaro : Mostro
    {
        public int punti;

        public Mannaro(string n) //lui crea mostro all'inizio, quindi non si può richiamare il padre passandoli un parametro nel costruttore (o in generale rchiamare qualsiasi altro costruttore) che NON SIA QUELLO BASE (senza parametro)
        {
            nome = n;
            punti = 500; 
        }

        public double Valore_Proprio()
        { // punti del Mannaro
            return punti;
        }
        public double Valore_Padre()
        { // punti Mostro
            return base.punti;
        }
        public double Valore()
        { // somma punti
            return punti + base.Valore();
        }
    }
}
