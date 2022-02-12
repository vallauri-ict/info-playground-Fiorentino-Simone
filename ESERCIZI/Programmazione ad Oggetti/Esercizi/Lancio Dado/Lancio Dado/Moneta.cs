using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lancio_Dado
{
    internal class Moneta
    {
        private int v;

        public int V { get => v;}
        Random rnd=new Random();

        public Moneta()
        {
            this.v = 0;
        }

        public Moneta(int v)
        {
            this.v = v;
        }

        public void Lancia()
        {
            rnd.Next(0, 1)+1; //0 --> testa; 1--> croce
        }
    }
}
