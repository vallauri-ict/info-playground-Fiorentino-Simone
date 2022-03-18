using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scontro_fra_veicoli
{
    class Veicolo : IConfronta
    {
        List<Veicolo> vAus = new List<Veicolo>();
        List<Veicolo> veicoli = new List<Veicolo>();
        Veicolo v1;
        Veicolo v2;

        Random rnd = new Random();
        Random rndFortuna = new Random();
        protected int Peso { get; set; }
        protected int Dimensione { get; set; }
        protected int Velocità { get; set; }
        protected int Integrita { get; set; }
        public string Type { get; set; }

        public void Scontro()
        {
            int diff, diff1;

            System.Windows.Forms.MessageBox.Show("Scontro fra " + v1.Type + " e " + v2.Type, "SCONTRO FRA VEICOLI");
            if (rndFortuna.Next(1, 101) < 8)//Per la probabiloità di fortuna
            {
                v2.Integrita = 0;
            }
            else
            {
                if (v1.Type == v2.Type)
                {
                    if (v1.Type == "camion")
                    {
                        if (v1.Peso > v2.Peso)
                        {
                            diff = v1.Peso - v2.Peso;
                            diff = diff / 750;
                            v2.Integrita -= diff + 5;
                            v1.Integrita -= rnd.Next(1, 3);
                        }
                        else
                        {
                            diff = v2.Peso - v1.Peso;
                            diff = diff / 1000;
                            v1.Integrita -= diff + 5;
                            v2.Integrita -= rnd.Next(1, 3);

                        }
                    }
                    else
                    {
                        if (v1.Type == "auto")
                        {
                            if (v1.Dimensione > v2.Dimensione)
                            {
                                diff = v1.Dimensione - v2.Dimensione;
                                diff = diff / 750;
                                v2.Integrita -= diff + 5;
                                v1.Integrita -= rnd.Next(1, 3);
                            }
                            else
                            {
                                diff = v2.Dimensione - v1.Dimensione;
                                diff = diff / 1000;
                                v1.Integrita -= diff + 5;
                                v2.Integrita -= rnd.Next(1, 3);

                            }
                        }
                        else
                        {
                            v1.Integrita -= rnd.Next(1, 3);
                            v2.Integrita -= rnd.Next(4, 7);
                        }
                    }
                }
                else//2 veicoli diversi si scontrano
                {
                    diff = v1.Dimensione + v1.Peso;
                    diff1 = v2.Dimensione + v2.Peso;
                    if (diff > diff1)
                    {
                        diff = diff / diff1;
                        v2.Integrita -= diff;
                        v1.Integrita -= rnd.Next(2, 5);

                    }
                    else
                    {
                        diff = diff1 / diff;
                        v1.Integrita -= (diff / 10) + 1;
                        v2.Integrita -= rnd.Next(3, 6);
                    }
                }
            }

            Stampa();
            if (v1.Integrita <= 0)
                veicoli.RemoveAt(veicoli.IndexOf(v1));
            if (v2.Integrita <= 0)
                veicoli.RemoveAt(veicoli.IndexOf(v2));
            //veicoli.RemoveAt(veicoli.IndexOf(v2));


        }

        public void Stampa()
        {
            System.Windows.Forms.MessageBox.Show("Veicolo 1 : " + v1.Type + " Integrita: " + v1.Integrita + "\nVeicolo 2 : " + v2.Type + " Integrita: " + v2.Integrita, "VEICOLI DOPO L'IMPATTO");
        }

        public List<Veicolo> turno(List<Veicolo> v)
        {
            int n1 = rnd.Next(0, v.Count);
            int n2;
            veicoli = v;
            do
            {
                n2 = rnd.Next(0, v.Count);
            } while (n1 == n2);
            v1 = v.ElementAt(n1);//Il veicolo che prova lo scontro
            v2 = v.ElementAt(n2);//Il veicolo che subisce lo scontro
            if (rnd.Next(0, v2.Velocità) < v2.Velocità / 2)//avvenuto scontro
                Scontro();
            else
                System.Windows.Forms.MessageBox.Show("Impatto evitato fra " + v1.Type + " e " + v2.Type);

            v = veicoli;
            return v;




        }
    }
}
