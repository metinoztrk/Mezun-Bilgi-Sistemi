using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VY_MezunBilgiSistemi
{
    public class HeapNode
    {
        public BaglıListe HeapBaglıliste;
     //   public Ogrencino Bilgi { get; set; }
        public float Basarıderecesi { get; set; }
        public HeapNode(Ogrencino bilgi)
        {
            HeapBaglıliste = new BaglıListe();
            HeapBaglıliste.InsertLast(bilgi);
           // this.Bilgi = bilgi;
           /* if(bilgi.egitimBilgileri.BasariBelgesi==true)
            {
                Basarıderecesi =Convert.ToSingle(bilgi.egitimBilgileri.Ortalama)+10;
            }
            else
            {
                Basarıderecesi = Convert.ToSingle(bilgi.egitimBilgileri.Ortalama);
            }    */ 
        }
    }
}
