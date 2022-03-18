using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ese15_Deposito_Contenitori
{
    internal class Contenitore : IContenitori //bisogna dire al compilatore cos'è la variabile T 
    {

        int peso;
        string tipo;
        string codiceUnivoco;
        string liquido;
        int qta;


        public int Peso { get => peso; set => peso = value; }
        public string Tipo { get => tipo; set => tipo = value; }
        public string CodiceUnivoco { get => codiceUnivoco; set => codiceUnivoco = value; }
        public string Liquido { get => liquido; set => liquido = value; }
        public int Qta { get => qta; set => qta = value; }

        public Contenitore()
        {
            this.liquido = "";
            this.Qta = 0;
        }

        public string Confronta(Contenitore c1, Contenitore c2)
        {
            string msg;

            if (c1.qta > c2.qta)
                msg = "IL PRIMO HA QUANTITA' SUPERIORE";
            else if (c1.qta < c2.qta)
                msg = "IL SECONDO HA QUANTITA' SUPERIORE";
            else
                msg = "LA QUANTITA' DEI CONTENITORI E' UGUALE";
                
            return msg;
        }
    }
}
