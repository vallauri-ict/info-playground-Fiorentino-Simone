using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacciaStrumenti
{
    internal class Complesso
    {
        List<ISuonatore> suonatori = new List<ISuonatore>(); //è una lista di ISuonatore quindi possiamo aggiungere sia Strumento che Rumorista

        public void AggiungiStrumento(Strumento str)
        {
            suonatori.Add(str);
        }

        public void AggiungiRumorista(Rumorista rum)
        {
            suonatori.Add(rum);
        }

        public void Play()
        {
            foreach (var suonatore in suonatori)
            {
                suonatore.Suona(); //ogni suonatore farà una mbox
            }
        }
    }
}
