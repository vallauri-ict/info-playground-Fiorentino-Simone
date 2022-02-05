using System.Collections.Generic;
using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ese08_Recipiente
{
    internal class Recipiente
    {
        private int capacità;
        private int contenuto;

        public Recipiente()
        {
            this.capacità = 1000;
        }

        public Recipiente(int k)
        {
            this.capacità = k;
        }

        //virtual --> lo si mette sul padre cosi da poter fare l'override dal figlio

        public override string ToString()
        {
            return capacità.ToString();
        }

        public virtual int Get()
        {
            return capacità;
        }

        public virtual void Set(int k)
        {
            this.capacità = k;
        }

        public virtual void Metti(int k)
        {
            if (!((contenuto + k) > capacità))
            {
                contenuto += k;
            }
            else System.Windows.Forms.MessageBox.Show("Il contenuto supera la capacità");
        }

        public virtual void Togli(int k)
        {
            if (!((contenuto - k) < capacità))
            {
                contenuto += k;
            }
            else System.Windows.Forms.MessageBox.Show("Il contenuto andrebbe sotto allo zero");
        }
    }
}
