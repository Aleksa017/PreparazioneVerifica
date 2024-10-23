using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PreparazioneVerifica
{
    public class CAereo:CVelivolo, IEquatable<CAereo>
    {
        private List<string> ListaPass;
        public CAereo(string produttore, int hmax, int hnow): base(produttore, hmax, hnow) 
        {
            ListaPass = new List<string>();
        }

        public override string Fly()
        {
            return $"The Airplane is flying at an altiutude of {hnow} feet";
        }
        public override string DisplayInfo()
        {
            string msg = string.Empty;
            foreach (string s in ListaPass)
                msg += $"\n{s}";
            return $"{base.DisplayInfo()}, Numero passeggeri: {ListaPass.Count}";
        }

        public void AddPasseggero(string cod)
        {
            ListaPass.Add(cod);
        }
        
        public string RemovePasseggero(string cod)
        {
            if (ListaPass.Contains(cod))
            {
                ListaPass.Remove(cod);
                return "Elemento eliminato";
            }
            return "Elemento non eliminato";
        }

        public bool Equals(CAereo a)
        {
            if (a == null) return false;
            return produttore == a.produttore && hmax == a.hmax && hnow == a.hnow && ListaPass.Count == a.ListaPass.Count;
        }

        public override bool Superiore(CVelivolo v) //this è migliore del riferimento?
        {
            if(v == null) return false;
            if (v is CAereo a)
                return ListaPass.Count > a.ListaPass.Count;
            return false;
        }
    }
}
