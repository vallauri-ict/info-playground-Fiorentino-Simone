using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ese01_Introduzione_OOP
{
    class Rectangle
    {
        public int sideBase, sideAltezza;
        //int side2; di default non visibile nel main siccome è private

        public Rectangle() : this (1)
        {

        }


        private Rectangle (int lato) : this(lato,lato) //passiamo base che vale 1 ripreso da public Rectangle() : this (1)
                                                       //se non inserisco il descrittore viene messo di default private
                                                       //di solito i costruttori private vengono richiamati da altri costruttori scirvendo this:(lista dei parametri del costruttore private)
        {
            
        } 

        public Rectangle (int Base,int Altezza) //carica i rispettivi valori dentro i parametri 
        {
            sideAltezza = Altezza;
            sideBase = Base;
        }
    }
}
