using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VY_MezunBilgiSistemi
{
    public class EgitimBilgileri:Ogrencino
    {
        public string BolumAdi { get; set; }
        public int Bolumİndex { get; set; }
        public int BaslangicYili { get; set; }
        public int BitisYili { get; set; }
        public double Ortalama { get; set; }
        public bool BasariBelgesi { get; set; }

    }
}
