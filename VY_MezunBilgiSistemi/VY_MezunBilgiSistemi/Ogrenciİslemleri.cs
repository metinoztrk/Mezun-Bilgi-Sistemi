using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VY_MezunBilgiSistemi
{
    public class Ogrenciİslemleri
    {
        //private BaglıListe Staj;
       // private BaglıListe Egitim;
        //private BaglıListe ogrenci;
        public İkiliAramaAgaci İkiliArama;
        Ogrenci Ogr;

        public Ogrenciİslemleri()
        {
            //Staj = new BaglıListe();
            //Egitim = new BaglıListe();
            İkiliArama = new İkiliAramaAgaci();
            //ogrenci = new BaglıListe();
            Ogr = new Ogrenci();

        }
        public void OgrenciKayitOl(Ogrenci ogr)
        {
            İkiliArama.Ekle(ogr);
        }
        public void OgrenciBilgiEkle(Ogrenci ogr)
        {
            İkiliAramaAgacDugumu a = new İkiliAramaAgacDugumu();
            a=OgrenciAra(ogr.OgrNo);
            if (a == null)
            {
                İkiliArama.kok.Bilgi.InsertLast(ogr);
            }
            else
            {
                a.Bilgi.InsertLast(ogr);
            }
        }
        public void OgrenciEgitimBilgiEkle(EgitimBilgileri ogr)
        {
            İkiliAramaAgacDugumu a = new İkiliAramaAgacDugumu();
            a = OgrenciAra(ogr.OgrNo);
            if (a == null)
            {
                İkiliArama.kok.Bilgi.InsertLast(ogr);
            }
            else
            {
                a.Bilgi.InsertLast(ogr);
            }
        }
        public void OgrenciStajBilgiEkle(StajBilgileri ogr)
        {
            İkiliAramaAgacDugumu a = new İkiliAramaAgacDugumu();
            a = OgrenciAra(ogr.OgrNo);
            if (a == null)
            {
                İkiliArama.kok.Bilgi.InsertLast(ogr);
            }
            else
            {
                a.Bilgi.InsertLast(ogr);
            }
        }
        /* public void StajBilgilerEkle(StajBilgileri staj)
         {
             if (Staj.Head == null)
                 Staj.InsertFirst(staj);
             else
                 Staj.InsertLast(staj);
         }
         public void EgitimBilgileriEkle(EgitimBilgileri egitim)
         {
             if (Egitim.Head == null)
                 Egitim.InsertFirst(egitim);
             else
                 Egitim.InsertLast(egitim);
         }*/
        public İkiliAramaAgacDugumu OgrenciAra(int OgrNo)
        {
            İkiliAramaAgacDugumu temp = İkiliArama.Ara(OgrNo);
            if(temp== null)
            {
                return null;
            }
            return temp;
        }
        public void OgrenciGuncelle(Ogrenci ogr)
        {
            this.Ogr = ogr;
        }
        public bool OgrenciSil(İkiliAramaAgacDugumu ogr)
        {
            return (İkiliArama.Sil(ogr));
        }
        public BaglıListe [] OgrenciCekme(int uzunluk)
        {

            İkiliArama.PreOrder(uzunluk);
            return İkiliArama.Donus();
        }
        
        public int AgacDugumSayisi()
        {
            return İkiliArama.DugumSayisi();
        }
    }
}
