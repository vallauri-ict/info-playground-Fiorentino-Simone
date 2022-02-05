using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_e_Orario
{
    internal class Data
    {

        #region VARIABILI

        private int giorno;
        private int mese;
        private int anno;
        private int[] mesi31 = new int[]
        {
            1,3,5,7,8,10,12
        };
        private Dictionary<int, int> mesiValore = new Dictionary<int, int>()
        {
            {1,6},
            {2,2},
            {3,2},
            {4,5},
            {5,0},
            {6,3},
            {7,5},
            {8,1},
            {9,4},
            {10,6},
            {11,2},
            {12,4}
        };
        #endregion

        #region COSTRUTTORI
        public Data()
        {
            giorno = 1;
            mese = 1;
            anno = 1900;
        }

        public Data(int giorno, int mese, int anno)
        {
            this.giorno = giorno;
            this.mese = mese;
            this.anno = anno;
        }

        #endregion

        #region METODI VIRTUAL
        public override string ToString()
        {
            return (giorno.ToString())+"/"+(mese.ToString())+"/"+(anno.ToString());
        }

        public virtual bool Bisestile()
        {
            bool bisestile;
            if (anno % 4 == 0)
            {
                if (anno % 100 == 0)
                {
                    if (anno % 400 == 0)
                        bisestile = true;
                    else bisestile = false;
                }
                else bisestile = true;
            }
            else bisestile = false;
            return bisestile;

            //return DateTime.IsLeapYear(anno);--> ci dice se è bisestile
        }


        public static bool Bisestile(int anno)
        {
            bool bisestile;
            if (anno % 4 == 0)
            {
                if (anno % 100 == 0)
                {
                    if (anno % 400 == 0)
                        bisestile = true;
                    else bisestile = false;
                }
                else bisestile = true;
            }
            else bisestile = false;
            return bisestile;
        }

        public virtual void Leggi(int giorno,int mese, int anno)
        {
            //SET 
            this.giorno = giorno;
            this.mese = mese;
            this.anno = anno;
        }

        public virtual void Scrivi(ref int giorno, ref int mese, ref int anno)
        {
            //GET
            giorno=this.giorno; 
            mese=this.mese;
            anno=this.anno;
        }

        public virtual void Domani()
        {
            DateTime dt = new DateTime(anno,mese,giorno);
            dt=dt.AddDays(1);
            anno = dt.Year;
            mese = dt.Month;
            giorno=dt.Day;

            //si poteva usare anche:
            /*
            if (mesi31.Contains(this.mese)) //vuol dire che è di 31 giorni
                incrementaGiorno(31);
            else //vuol dire che è di 30 o 28
            {
                if(this.mese == 2)
                {
                    if (Bisestile()) //vuol dire che è di 29
                        incrementaGiorno(29);
                    else //vuol dire che è di 28
                        incrementaGiorno(28);
                }
                else //vuol dire che è di 30
                    incrementaGiorno(30);
            }*/

        }

        public virtual void Ieri()
        {
            //decrementaGiorno();
            DateTime dt = new DateTime(anno, mese, giorno);
            dt = dt.Subtract(TimeSpan.FromDays(1));
            anno = dt.Year;
            mese = dt.Month;
            giorno = dt.Day;
        }

        public virtual string Giorno()
        {
            DateTime dt = new DateTime(anno, mese, this.giorno);
            string gg;
            gg = dt.ToString("dddd");
            return gg; 

            /*string giornoLetterale = "";
            string an = anno.ToString();
            an=an.Substring(2, 2);
            int aa = Convert.ToInt32(an);
            aa=aa + (aa / 4);
            int codAnno = aa - (aa / 7) * 7;
            int codMese = mesiValore[this.mese];
            int giornoDellaSettimana = (codAnno + codMese + this.giorno) % 7;
            switch (giornoDellaSettimana)
            {
                case 0:
                    giornoLetterale = "Domenica";
                    break;

                case 1:
                    giornoLetterale = "Lunedì";
                    break;

                case 2:
                    giornoLetterale = "Martedì";
                    break;

                case 3:
                    giornoLetterale = "Mercoledì";
                    break;

                case 4:
                    giornoLetterale = "Giovedì";
                    break;

                case 5:
                    giornoLetterale = "Venerdì";
                    break;

                case 6:
                    giornoLetterale = "Sabato";
                    break;
            }
            return giornoLetterale;*/
        }
        #endregion

        /*#region METODI SUPPORT PRIVATE
        private void decrementaGiorno()
        {
            if (this.giorno <= 1 && this.mese!=1)
            {
                int previousMonth = this.mese;
                previousMonth--;
                if (previousMonth == 0) previousMonth = 12;

                if (mesi31.Contains(previousMonth)) //vuol dire che è di 31 giorni il mese precedente
                {
                    this.giorno = 31;
                }
                else //vuol dire che è di 30 o 28
                {
                    if (previousMonth == 2)
                    {
                        if (Bisestile()) //vuol dire che è di 29
                            this.giorno = 29;
                        else //vuol dire che è di 28
                            this.giorno = 28;
                    }
                    else //vuol dire che è di 30
                        this.giorno = 30;
                }
                this.mese= previousMonth;
            }
            else if(this.giorno > 1 && this.mese!=1)
                this.giorno--;
            
            //se il mese è gennaio bisogna tornare un anno indietro
            if(this.mese==1 && this.giorno <= 1)
            {
                this.mese=12;
                this.anno--;
                this.giorno = 31;
            }
            else if(this.mese==1 && giorno>=1)
            {
                giorno--;
            }
        }

        private void incrementaGiorno(int max)
        {
            if (this.giorno >= max)
            {
                if (this.mese >= 12)
                {
                    this.anno++;
                    this.mese = 1;
                    this.giorno = 1;
                }
                else
                {
                    this.mese++;
                    this.giorno = 1;
                }
            }
            else
                this.giorno++;
        }
        #endregion*/
    }
}
