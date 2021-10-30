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
        public string nome;
        public string città;
        public int giocate;
        public int vinte;
        public int pareggiate;

        private int myProperty;
        private int myPropertyRO; //creo una variabile readonly, usando solo il get


        //2^ PUNTO: Definire un costruttore senza parametri che costruisce una squadra predefinita
        public Squadre()
        {
            nome = "Atlante";
            città = "Monteacuto";
            giocate = 3;
            vinte = 2;
            pareggiate = 0;
        }

        //3^PUNTO: Definire un costruttore opportuno per inizializzare tutti gli attributi
        public Squadre(string nome, string città, int giocate, int vinte, int pareggiate)
        {
            //in caso avessi il readonly (public readonly int) prima la vado a settare nel costruttore: es: myProperty=0;
            this.nome = nome;
            this.città = città;
            this.giocate = giocate;
            this.vinte = vinte;
            this.pareggiate = pareggiate;
            myProperty = 0; //setta 
            int valore = myProperty; //legge
        }

        public int MyProperty
        {
            get //leggere il valore
            {
                return myProperty;
            }
            set //settare il valore
            {
                myProperty = value; //il value è il valore della mia property
            }
        }

        public int MyPropertyRO
        {
            get //leggere il valore
            {
                return myPropertyRO;
            }
        }
    }
}
