using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Verifica_Fiorentino_19_03_2022
{
    internal class Pianta : PiantaA, IPrezzoPianta
    {
        private string colore; //la modifico dal form
        List<Pianta> pianteList = new List<Pianta>();
        

        public Pianta(string descrizione,
            string tipo,
            string genere,
            int costo)
        {
            base.descrizione = descrizione;
            base.tipo = tipo;
            base.genere = genere;
            base.costo = costo;
            num++;
        }
        
        public Pianta()
        {
            
        }

        public double calcolaPrezzo()
        {
            //prezzo deve essere calcolato aumentando del 40% il costo con il metodo calcola prezzo
            return base.costo + (base.costo * 40 / 100);
        }

        public void inserisciColore(string color)
        {
            //aggiungere il colore solo per le piante NON sempreverdi
            this.colore = color;
        }

        public void aggiungiLista(Pianta p)
        {
            pianteList.Add(p);  
        }

        public void stampaPianta(ListBox lst)
        {
            lst.Items.Clear();
            foreach (var item in pianteList)
            {
                lst.Items.Add(item.descrizione);
            }
        }

        public void venditaUltimoPianta()
        {
            pianteList.RemoveAt(pianteList.Count - 1);
        }

        internal void eliminaPiantaItem(int item)
        {
            pianteList.RemoveAt(item);
        }
    }
}
