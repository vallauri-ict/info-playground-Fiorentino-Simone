using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_and_Regex_Verifica2019
{
    class Associazione
    {
        private static Associazione _instance = null;

        private List<Socio> SocioList = new List<Socio>();
        private Associazione()
        { // costruttore privato
          // eventuali inizializzazioni di istanza
        }

        public static Associazione GetInstance()
        {
            if (_instance == null) _instance = new Associazione();
            return _instance;
        }

        public void AddSocio(Socio socio)
        {
            _instance.SocioList.Add(socio);
        }

        public List<Socio> returnList()
        {
            return SocioList;
        }
    }
}
