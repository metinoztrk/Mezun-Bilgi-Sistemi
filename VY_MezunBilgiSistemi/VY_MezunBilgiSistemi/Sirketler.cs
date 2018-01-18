using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VY_MezunBilgiSistemi
{
    public class Sirketler
    {
        public List<Sirket> kayitliSirketler { get; set; }

        public Sirketler()
        {
            kayitliSirketler = new List<Sirket>();
        }

        public void sirketEkle(Sirket s)
        {
            kayitliSirketler.Add(s);
        }
    }
}
