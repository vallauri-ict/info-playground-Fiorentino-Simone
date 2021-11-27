using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ese07_Factory_Quadrato
{
    class Singleton
    {
        private static Singleton instanza = null;
        private static int id=0;
        public readonly int n;

        private Singleton()
        {
            //tecnica usata nelle fatture, quando si richiama sempre il costruttore. In questo caso però utilizziamo queste variabili solo per un controllo di avvenuta instanza
            id++;
            n = id;
        }

        public static Singleton GetInstance()
        {
            if (instanza == null) instanza = new Singleton();
            return instanza;
        }
    }
}
