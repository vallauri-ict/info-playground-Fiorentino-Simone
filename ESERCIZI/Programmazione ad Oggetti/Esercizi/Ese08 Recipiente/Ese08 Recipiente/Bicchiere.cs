using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ese08_Recipiente
{
    internal class Bicchiere : Recipiente
    {
        private int capacità;

        public Bicchiere()
        {
            this.capacità = 100;
        }

        public Bicchiere(int k)
        {
            if (k > 1000) this.capacità = 1000;
            else if(k>=0) this.capacità = k;
            else System.Windows.Forms.MessageBox.Show("Inserimento non corretto");
        }

        public override string ToString()
        {
            return this.capacità.ToString();
        }

        public int Get()
        {
            return capacità;
        }

        public void Set(int k)
        {
            this.capacità = k;
        }
    }
}
