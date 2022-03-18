using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gioco_interfacce
{
    class Licantropo : Mostro, Umano
    {
        private bool isUomo;
        protected int forzaUmano, forzaMostro;
        public Licantropo(bool luna)
        {
            isUomo = !luna;
            if (luna)
            {
                forzaMostro = 15;
                forzaUmano = 0;
            }
            else
            {
                forzaUmano = 10;
                forzaMostro = 0;
            }
        }
        public string GetForza()
        {
            return "Forza rimanente come umano:" + forzaUmano + "\nForza rimanente come mostro: " + forzaMostro;
        }
        public void Azzanna()
        {
            if (!isUomo)
                forzaMostro = forzaMostro - 2;
        }
        public void Combatti()
        {
            if (isUomo) forzaUmano = forzaUmano - 3;
        }
    }
}
