using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PreparazioneVerifica
{
    public abstract class CVelivolo:ICMP
    {
        protected string produttore;
        protected int hmax;
        protected int hnow;

        public CVelivolo(string produttore, int hmax, int hnow)
        {
            this.produttore = produttore;
            this.hmax = hmax;
            this.hnow = hnow;
        }

        public abstract string Fly();
        public virtual string DisplayInfo()
        {
            return $"Produttore: {produttore}, Altezza max: {hmax}, Altezza attuale: {hnow}";
        }
        public abstract bool Superiore(CVelivolo v);

    }
}
