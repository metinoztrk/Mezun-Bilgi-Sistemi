using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VY_MezunBilgiSistemi
{
    public class İkiliAramaAgacDugumu
    {
        public int NO;
        public BaglıListe Bilgi;
        public İkiliAramaAgacDugumu sol;
        public İkiliAramaAgacDugumu sag;
        public İkiliAramaAgacDugumu()
        {

        }
        public İkiliAramaAgacDugumu(Ogrenci bilgi)
        {
            this.NO =bilgi.OgrNo;
            Bilgi = new BaglıListe();
            sol = null;
            sag = null;
        }
    }
}
