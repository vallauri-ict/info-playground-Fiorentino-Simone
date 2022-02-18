using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaccia_Comparable
{
    internal class Persona : IComparable<Persona>
    {
        private string nome;
        private string cognome;
        private int età;

        public string Nome { get => nome; set => nome = value; }
        public string Cognome { get => cognome; set => cognome = value; }
        public int Età
        {
            get => età;
            set
            {
                età = (value >= 0) ? value : 0;
            }
        }

        public int CompareTo(Persona other)
        {
            return this.età - other.età;
        }
    }
}
