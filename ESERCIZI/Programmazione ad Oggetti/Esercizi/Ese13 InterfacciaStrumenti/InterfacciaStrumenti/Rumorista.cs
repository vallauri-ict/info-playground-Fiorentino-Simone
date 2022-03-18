using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacciaStrumenti
{
    internal class Rumorista : Persona, ISuonatore //andiamo ad ereditare la classe da persona e dire il nome dell'interfaccia
    {
        public string NomeArte { get; set; } //usiamo la forma contrtta della get and set

        public void Suona()
        {
            System.Windows.Forms.MessageBox.Show("Emette suoni con la bocca");
        }
    }
}
