using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ese07_Factory_Quadrato
{
    class StringheIndexate
    {
        private string[] myData;

        public StringheIndexate(int size)
        {
            myData = new string[size];
            for (int i = 0; i < size; i++)
            {
                myData[i] = "empty";
            }
        }

        public string this[int pos] //iteratore, quindi non viene richiamato come metodo
        {
            get { return myData[pos]; }
            set { myData[pos] = value; }
        }

    }
}
