using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VY_MezunBilgiSistemi
{
        public class Ogrenci:Ogrencino
        {
        public string OgrAdi { get; set; }
        public string OgrAdres { get; set; }
        public double Tel { get; set; }
        public string Mail { get; set; }
        public string Uyruk { get; set; }
        public double DogumTarihi { get; set; }
        
        public string YabanciDil { get; set; }
        public string IlgiAlani { get; set; }
        //   public StajBilgileri stajBilgileri { get; set; }
        //   public EgitimBilgileri egitimBilgileri { get; set; }
    }
}
