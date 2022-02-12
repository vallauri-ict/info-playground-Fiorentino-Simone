using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lancio_Dado
{
    internal class Dado
    {
        Random rnd = new Random();
        private int n;
        public int N { get => n; } //le property sono in maiuscolo

        public Dado()
        {
            this.n = 1;
        }

        public Dado(int n)
        {
            this.n = n;
        }

        public void Lancio()
        {
            n=rnd.Next(6)+1;
        }
    }
}
