using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PreparazioneVerifica
{
    public class CElicottero:CVelivolo, IEquatable<CElicottero>
    {
        private int nEliche;

        public CElicottero(string produttore, int hmax, int hnow, int nEliche) : base(produttore, hmax, hnow)
        {
            this.nEliche = nEliche;
        }

        public override string Fly()
        {
            return $"The helicopter is flying at an altiutude of {hnow} feet";
        }

        public override string DisplayInfo()
        {
            return $"{base.DisplayInfo()}, Numero eliche: {nEliche}";
        }

        public bool Equals(CElicottero e) 
        {
            if(e == null) return false;
            return produttore == e.produttore && hmax == e.hmax && hnow == e.hnow && nEliche == e.nEliche;
        }

        public override bool Superiore(CVelivolo v) //this è migliore del riferimento?
        {
            if (v == null) return false;
            if (v is CElicottero e)
                return nEliche > e.nEliche && hmax > e.hmax;
            return false;
        }
    }
}
