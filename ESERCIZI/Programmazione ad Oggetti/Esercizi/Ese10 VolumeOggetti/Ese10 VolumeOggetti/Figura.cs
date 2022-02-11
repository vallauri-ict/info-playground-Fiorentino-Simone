using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ese10_VolumeOggetti
{
    abstract class Figura
    {
        protected int altezza;

        #region METODO ASTRATTO
        abstract protected double Area(); //perchè dipende dalla figura e quindi è astratto
        #endregion

        #region METODI PUBLIC
        public double Volume()
        {
            return Area() * altezza;
        }
        public string StampaArea()
        {
            return "AREA: " + Area();
        }

        public string StampaVolume()
        {
            return "VOLUME: " + Volume();
        }
        #endregion
    }
}
