using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ese_03_Squadre_di_Calcio
{
    class Squadre
    {

        //1^ PUNTO : Dichiarare un oggetto Squadra, con attributi pubblici Nome, Città, Giocate, Vinte, Pareggiate
        public string Nome;
        public string Città;
        public int Giocate;
        public int Vinte;
        public int Pareggiate;


        //2^ PUNTO: Definire un costruttore senza parametri che costruisce una squadra predefinita
        public Squadre()
        {
            Nome = "Atlante";
            Città = "Monteacuto";
            Giocate = 3;
            Vinte = 2;
            Pareggiate = 0;
        }


        //3^PUNTO: Definire un costruttore opportuno per inizializzare tutti gli attributi
        public void SquadreDefault()
        {
            Nome = "";
            Città = "";
            Giocate = 0;
            Vinte = 0;
            Pareggiate = 0;
        }
    }
}
