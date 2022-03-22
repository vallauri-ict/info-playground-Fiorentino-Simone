using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Verifica_Fiorentino_19_03_2022
{
    internal class Rosa : Pianta, IPrezzoRosa
    {
        protected string varietà;

        List<Rosa> roseList = new List<Rosa>();

        public Rosa(string descrizione,
            string tipo,
            string genere,
            int costo,
            string varietà) : base(descrizione,tipo, genere, costo)
        {
            this.varietà = varietà;
            num++;
        }

        public Rosa()
        {

        }

        public double calcolaPrezzo(int numero)
        {
            //moltiplicando il costo aumentando del 20% se il numero di rose acquistate è tra 1 e 10
            double price = 0;
            if (numero>=1 && numero<=10)
            {
                price = (base.costo + (base.costo * 20 / 100)) * numero;
            }
            else if (numero>10)
            {
                price = (base.costo + (base.costo * 10 / 100)) * numero;
            }
            return price;
        }

        public void aggiungiListaRosa(Rosa p)
        {
            roseList.Add(p);
        }

        public void stampaRose(ListBox lst)
        {
            lst.Items.Clear();
            foreach (var item in roseList)
            {
                lst.Items.Add(item.descrizione);
            }
        }

        public void venditaUltimaRosa()
        {
            roseList.RemoveAt(roseList.Count - 1);
        }

        public void eliminaRosaItem(int item)
        {
            roseList.RemoveAt(item);
        }
    }
}
