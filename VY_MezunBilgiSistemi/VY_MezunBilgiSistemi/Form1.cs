using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VY_MezunBilgiSistemi
{
    public partial class Form1 : Form
    {

        Ogrenciİslemleri ogrİslem = new Ogrenciİslemleri();
        Sirketler sirketListesi = new Sirketler();


        public Form1()
        {
            InitializeComponent();
        }
        public void txtTemizle(Control clt)
        {
            foreach (Control item in clt.Controls)
            {
                if (item is TextBox)
                    ((TextBox)item).Clear();
                if (item.Controls.Count > 0)
                    txtTemizle(item);
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            Ogrenci ogr1 = new Ogrenci();
            ogr1.OgrNo = 10;
            ogr1.OgrAdi = "Ahmet";
            ogr1.OgrAdres = "İzmir";
            ogr1.Mail = "ahmets";
            ogr1.IlgiAlani = "Spor";
            ogr1.Tel = 211221;
            ogr1.Uyruk = "Türkiye";
            ogr1.YabanciDil = "Advanced";
            ogr1.DogumTarihi = 1996;
            StajBilgileri s1 = new StajBilgileri();
            s1.OgrNo = 10;
            s1.SirketAdi = "Hybrid";
            s1.SirketAdresi = "İstanbul";
            s1.Gorevi = "Stajer";
            EgitimBilgileri e1 = new EgitimBilgileri();
            e1.OgrNo = 10;
            e1.Bolumİndex = 0;
            e1.BolumAdi = "Yazılım";
            e1.BaslangicYili = 2012;
            e1.BitisYili = 2016;
            e1.Ortalama = 80;
            e1.BasariBelgesi = true;
            ogrİslem.OgrenciKayitOl(ogr1);
            ogrİslem.OgrenciBilgiEkle(ogr1);
            ogrİslem.OgrenciEgitimBilgiEkle(e1);
            ogrİslem.OgrenciStajBilgiEkle(s1);

            h.Add(0, ogr1);
            h.Add(0, e1);
            h.Add(0, s1);

            Ogrenci ogr2 = new Ogrenci();
            ogr2.OgrNo = 1;
            ogr2.OgrAdi = "Ahmet";
            ogr2.OgrAdres = "İzmir";
            ogr2.Mail = "ahmets";
            ogr2.IlgiAlani = "Spor";
            ogr2.Tel = 211221;
            ogr2.Uyruk = "Türkiye";
            ogr2.YabanciDil = "Advanced";
            ogr2.DogumTarihi = 1996;
            StajBilgileri s2 = new StajBilgileri();
            s2.OgrNo = 1;
            s2.SirketAdi = "Hybrid";
            s2.SirketAdresi = "İstanbul";
            s2.Gorevi = "Stajer";
            EgitimBilgileri e2 = new EgitimBilgileri();
            e2.OgrNo = 1;
            e2.Bolumİndex = 1;
            e2.BolumAdi = "Yazılım";
            e2.BaslangicYili = 2012;
            e2.BitisYili = 2016;
            e2.Ortalama = 90;
            e2.BasariBelgesi = true;
            ogrİslem.OgrenciKayitOl(ogr2);
            ogrİslem.OgrenciBilgiEkle(ogr2);
            ogrİslem.OgrenciEgitimBilgiEkle(e2);
            ogrİslem.OgrenciStajBilgiEkle(s2);

            h.Add(1, ogr2);
            h.Add(1, e2);
            h.Add(1, s2);

            Ogrenci ogr3 = new Ogrenci();
            ogr3.OgrNo = 16;
            ogr3.OgrAdi = "Ahmet";
            ogr3.OgrAdres = "İzmir";
            ogr3.Mail = "ahmets";
            ogr3.IlgiAlani = "Spor";
            ogr3.Tel = 211221;
            ogr3.Uyruk = "Türkiye";
            ogr3.YabanciDil = "Advanced";
            ogr3.DogumTarihi = 1996;
            StajBilgileri s3 = new StajBilgileri();
            s3.OgrNo = 16;
            s3.SirketAdi = "Hybrid";
            s3.SirketAdresi = "İstanbul";
            s3.Gorevi = "Stajer";
            EgitimBilgileri e3 = new EgitimBilgileri();
            e3.OgrNo = 16;
            e3.Bolumİndex = 0;
            e3.BolumAdi = "Yazılım";
            e3.BaslangicYili = 2012;
            e3.BitisYili = 2016;
            e3.Ortalama = 250;
            e3.BasariBelgesi = true;
            ogrİslem.OgrenciKayitOl(ogr3);
            ogrİslem.OgrenciBilgiEkle(ogr3);
            ogrİslem.OgrenciEgitimBilgiEkle(e3);
            ogrİslem.OgrenciStajBilgiEkle(s3);

            h.Add(0, ogr3);
            h.Add(0, e3);
            h.Add(0, s3);

            Ogrenci ogr4 = new Ogrenci();
            ogr4.OgrNo = 18;
            ogr4.OgrAdi = "Ahmet";
            ogr4.OgrAdres = "İzmir";
            ogr4.Mail = "ahmets";
            ogr4.IlgiAlani = "Spor";
            ogr4.Tel = 211221;
            ogr4.Uyruk = "Türkiye";
            ogr4.YabanciDil = "Advanced";
            ogr4.DogumTarihi = 1996;
            StajBilgileri s4 = new StajBilgileri();
            s4.OgrNo = 18;
            s4.SirketAdi = "Hybrid";
            s4.SirketAdresi = "İstanbul";
            s4.Gorevi = "Stajer";
            EgitimBilgileri e4 = new EgitimBilgileri();
            e4.OgrNo = 18;
            e4.Bolumİndex = 1;
            e4.BolumAdi = "Yazılım";
            e4.BaslangicYili = 2012;
            e4.BitisYili = 2016;
            e4.Ortalama = 110;
            e4.BasariBelgesi = true;
            ogrİslem.OgrenciKayitOl(ogr4);
            ogrİslem.OgrenciBilgiEkle(ogr4);
            ogrİslem.OgrenciEgitimBilgiEkle(e4);
            ogrİslem.OgrenciStajBilgiEkle(s4);

            h.Add(1, ogr4);
            h.Add(1, e4);
            h.Add(1, s4);

            Ogrenci ogr5 = new Ogrenci();
            ogr5.OgrNo = 19;
            ogr5.OgrAdi = "Ahmet";
            ogr5.OgrAdres = "İzmir";
            ogr5.Mail = "ahmets";
            ogr5.IlgiAlani = "Spor";
            ogr5.Tel = 211221;
            ogr5.Uyruk = "Türkiye";
            ogr5.YabanciDil = "Intermediate";
            ogr5.DogumTarihi = 1996;
            StajBilgileri s5 = new StajBilgileri();
            s5.OgrNo = 19;
            s5.SirketAdi = "Hybrid";
            s5.SirketAdresi = "İstanbul";
            s5.Gorevi = "Stajer";
            EgitimBilgileri e5 = new EgitimBilgileri();
            e5.OgrNo = 19;
            e5.Bolumİndex = 0;
            e5.BolumAdi = "Yazılım";
            e5.BaslangicYili = 2012;
            e5.BitisYili = 2016;
            e5.Ortalama = 50;
            e5.BasariBelgesi = true;
            ogrİslem.OgrenciKayitOl(ogr5);
            ogrİslem.OgrenciBilgiEkle(ogr5);
            ogrİslem.OgrenciEgitimBilgiEkle(e5);
            ogrİslem.OgrenciStajBilgiEkle(s5);

            h.Add(0, ogr5);
            h.Add(0, e5);
            h.Add(0, s5);
            
        }
        HashTable h = new HashTable();

        private void btnKayitOl_Click(object sender, EventArgs e)
        {
            
            Ogrenci ogr = new Ogrenci();
            ogr.OgrNo = int.Parse(txtOgrNo.Text);
            ogr.OgrAdi = txtOgrAdi.Text;
            ogr.OgrAdres = txtOgrAdres.Text;
            ogr.Mail = txtMail.Text;
            ogr.IlgiAlani = txtIlgiAlani.Text;
            ogr.Tel = Convert.ToDouble(txtTelefon.Text);
            ogr.Uyruk = txtUyruk.Text;
            ogr.YabanciDil = comboYabanciDil.Text;
            ogr.DogumTarihi = Convert.ToDouble(txtDogumTarihi.Text);

            StajBilgileri s = new StajBilgileri();
            s.OgrNo= int.Parse(txtOgrNo.Text);
            s.SirketAdi = txtSirketAdi.Text;
            s.SirketAdresi = txtSirketAdresi.Text;
            s.Gorevi = txtGorev.Text;

            EgitimBilgileri e1 = new EgitimBilgileri();
            e1.OgrNo= int.Parse(txtOgrNo.Text);
            e1.BolumAdi = comboBolumAdi.SelectedItem.ToString();
            e1.Bolumİndex = comboBolumAdi.SelectedIndex;
            e1.BaslangicYili = int.Parse(txtBaslangicYil.Text);
            e1.BitisYili = int.Parse(txtBitisYil.Text);
            e1.Ortalama = Convert.ToDouble(txtOrtalama.Text);
            if (rdbTrue.Checked == true)
                e1.BasariBelgesi = true;
            else
                e1.BasariBelgesi = false;

            ogrİslem.OgrenciKayitOl(ogr);
            ogrİslem.OgrenciBilgiEkle(ogr);
            ogrİslem.OgrenciEgitimBilgiEkle(e1);
            ogrİslem.OgrenciStajBilgiEkle(s);
            h.Add(comboBolumAdi.SelectedIndex, ogr);
            h.Add(comboBolumAdi.SelectedIndex, e1);
            h.Add(comboBolumAdi.SelectedIndex, s);
           
            txtTemizle(this);
        }
        int OncekiNo = 0;
        private void btnGoster_Click(object sender, EventArgs e)
        {
            İkiliAramaAgacDugumu temp = ogrİslem.OgrenciAra(int.Parse(txtOgrArama.Text));
            if (temp == null)
                MessageBox.Show("Aranan kişi bulunamadı...");
            else
            {
                Ogrenci obilgi = new Ogrenci();
                EgitimBilgileri ebilgi = new EgitimBilgileri();
                StajBilgileri sbilgi = new StajBilgileri();
                obilgi=(Ogrenci)temp.Bilgi.Head.Data;
                ebilgi = (EgitimBilgileri)temp.Bilgi.Head.Next.Data;
                sbilgi = (StajBilgileri)temp.Bilgi.Head.Next.Next.Data;
                
                txtGuncelAd.Text = obilgi.OgrAdi;
                txtGuncelAdres.Text = obilgi.OgrAdres;
                txtGuncelDogum.Text = Convert.ToString(obilgi.DogumTarihi);
                txtGuncelİlgi.Text = obilgi.IlgiAlani;
                txtGuncelMail.Text = obilgi.Mail;
                txtGuncelOgrNo.Text = Convert.ToString(obilgi.OgrNo);
                OncekiNo = obilgi.OgrNo;
                txtGuncelTel.Text = Convert.ToString(obilgi.Tel);
                txtGuncelUyruk.Text = obilgi.Uyruk;
                txtGuncelYabanciDil.Text = obilgi.YabanciDil;
                
                txtGuncelSirketAdi.Text = sbilgi.SirketAdi;
                txtGuncelSirketAdres.Text = sbilgi.SirketAdresi;
                txtGuncelGorevi.Text = sbilgi.Gorevi;

                //txtGuncelBolum.Text=ebilgi.BolumAdi;
                txtGuncelBasYil.Text = Convert.ToString(ebilgi.BaslangicYili);
                txtGuncelBitisYil.Text = Convert.ToString(ebilgi.BitisYili);
                txtGuncelOrt.Text = Convert.ToString(ebilgi.Ortalama);
                if (ebilgi.BasariBelgesi == true)
                {
                    rdbGuncelTrue.Checked = true;
                    rdbGuncelFalse.Checked = false;
                }
                else
                {
                    rdbGuncelTrue.Checked = false;
                    rdbGuncelFalse.Checked = true;
                }
                
            }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            Ogrenci ogr = new Ogrenci();
            BaglıListe [] o = new BaglıListe [(ogrİslem.AgacDugumSayisi())];
            
            İkiliAramaAgacDugumu temp = ogrİslem.OgrenciAra(OncekiNo);
            ogrİslem.OgrenciSil(temp);

            ogr.OgrAdi = txtGuncelAd.Text;
            ogr.OgrAdres = txtGuncelAdres.Text;
            ogr.DogumTarihi = Convert.ToDouble(txtGuncelDogum.Text);
            ogr.IlgiAlani = txtGuncelİlgi.Text;
            ogr.Mail = txtGuncelMail.Text;
            ogr.OgrNo = int.Parse(txtGuncelOgrNo.Text);
            ogr.Tel = Convert.ToDouble(txtGuncelTel.Text);
            ogr.Uyruk = txtGuncelUyruk.Text;
            ogr.YabanciDil = txtGuncelYabanciDil.Text;

            StajBilgileri s1 = new StajBilgileri();
            s1.OgrNo = int.Parse(txtGuncelOgrNo.Text);
            s1.SirketAdi = txtGuncelSirketAdi.Text;
            s1.SirketAdresi = txtGuncelSirketAdres.Text;
            s1.Gorevi = txtGuncelGorevi.Text;

            EgitimBilgileri e1 = new EgitimBilgileri();
            e1.OgrNo = int.Parse(txtGuncelOgrNo.Text);
            e1.BolumAdi = comboGuncelBolum.SelectedItem.ToString();
            e1.Bolumİndex = comboGuncelBolum.SelectedIndex;
            e1.BaslangicYili = int.Parse(txtGuncelBasYil.Text);
            e1.BitisYili = int.Parse(txtGuncelBitisYil.Text);
            e1.Ortalama = Convert.ToDouble(txtGuncelOrt.Text);
            if (rdbGuncelTrue.Checked == true)
                e1.BasariBelgesi = true;
            else
                e1.BasariBelgesi = false;
            h.Remove();
            ogrİslem.OgrenciKayitOl(ogr);
            ogrİslem.OgrenciBilgiEkle(ogr);
            ogrİslem.OgrenciEgitimBilgiEkle(e1);
            ogrİslem.OgrenciStajBilgiEkle(s1);
            int dügümsayisi = ogrİslem.AgacDugumSayisi();
            o=ogrİslem.OgrenciCekme(dügümsayisi);
            Ogrenci obilgi = new Ogrenci();
            EgitimBilgileri ebilgi = new EgitimBilgileri();
            StajBilgileri sbilgi = new StajBilgileri();
   
            for (int i = 0; i < dügümsayisi; i++)
            {
                obilgi = (Ogrenci)o[i].Head.Data;
                ebilgi = (EgitimBilgileri)o[i].Head.Next.Data;
                sbilgi = (StajBilgileri)o[i].Head.Next.Next.Data;
                h.Add(ebilgi.Bolumİndex, obilgi);
                h.Add(ebilgi.Bolumİndex, ebilgi);
                h.Add(ebilgi.Bolumİndex, sbilgi);
            }
  
            txtTemizle(this);
            MessageBox.Show("Bilgiler Güncellendi...");
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            BaglıListe[] og = new BaglıListe[ogrİslem.AgacDugumSayisi()];
            BaglıListe yeniliste = new BaglıListe();
            Node n = new Node();
            int no = int.Parse(txtSilinenOgrNo.Text);
            İkiliAramaAgacDugumu temp = ogrİslem.OgrenciAra(no);
            if (temp == null)
                MessageBox.Show("Aranan kişi bulunamadı...");
            else
            {
                ogrİslem.OgrenciSil(temp);
                MessageBox.Show("Kişi Silindi...");
            }
            int dügümsayisi = ogrİslem.AgacDugumSayisi();
            og = ogrİslem.OgrenciCekme(dügümsayisi);
            Ogrenci obilgi = new Ogrenci();
            EgitimBilgileri ebilgi = new EgitimBilgileri();
            StajBilgileri sbilgi = new StajBilgileri();
            h.Remove();
            for (int i = 0; i < og.Length; i++)
            {
                obilgi = (Ogrenci)og[i].Head.Data;
                ebilgi = (EgitimBilgileri)og[i].Head.Next.Data;
                sbilgi = (StajBilgileri)og[i].Head.Next.Next.Data;
                h.Add(ebilgi.Bolumİndex, obilgi);
                h.Add(ebilgi.Bolumİndex, ebilgi);
                h.Add(ebilgi.Bolumİndex, sbilgi);
            }
            txtTemizle(this);
        }

        private void btnBasariSiralama_Click(object sender, EventArgs e)
        {
            Ogrenci obilgi = new Ogrenci();
            EgitimBilgileri ebilgi = new EgitimBilgileri();
            StajBilgileri sbilgi = new StajBilgileri();
            listSiralama.Items.Clear();
            HeapNode[] tmp = new HeapNode[10];
            float max;
            int maxi = 0;
            try
            {
                if (comboHeap.Text == "Yazılım")
                {
                    int[] a = new int[10];
                    for (int m = 0; m < 10; m++)
                    {
                        if (h.Table[0]!= null)
                            tmp[m] = h.Table[0].HeapArray[m];
                        else
                            break;
                    }
                    for (int i = 0; i < 10; i++)
                    {
                        max = 0;
                        for (int ii = i; ii < 10; ii++)
                        {
                            if (tmp[ii] != null)
                            {
                                if (tmp[ii].Basarıderecesi > max)
                                {
                                    max = tmp[ii].Basarıderecesi;
                                    maxi = ii;
                                }

                            }

                        }
                        HeapNode tmpp = tmp[i];
                        tmp[i] = tmp[maxi];
                        tmp[maxi] = tmpp;


                    }

                    for (int j = 0; j < 10; j++)
                    {
                            if (tmp[j] != null)
                            {
                                obilgi = (Ogrenci)tmp[j].HeapBaglıliste.Head.Data;
                                ebilgi = (EgitimBilgileri)tmp[j].HeapBaglıliste.Head.Next.Data;
                                sbilgi = (StajBilgileri)tmp[j].HeapBaglıliste.Head.Next.Next.Data;
                                listSiralama.Items.Add("Başarı Derecesi : " + tmp[j].Basarıderecesi + " İsim : " + obilgi.OgrAdi + " Öğrenci No : " + obilgi.OgrNo);
                            }
                    }


                }
            else if (comboHeap.Text == "Mekatronik")
              {
                    int[] a = new int[10];
                    for (int m = 0; m < 10; m++)
                    {
                        if (h.Table[1] != null)
                            tmp[m] = h.Table[1].HeapArray[m];
                        else
                            break;
                    }
                  for (int i = 0; i < 10; i++)
                  {
                      max = 0;
                      for (int ii = i; ii < 10; ii++)
                      {
                          if (tmp[ii] != null)
                          {
                              if (tmp[ii].Basarıderecesi > max)
                              {
                                  max = tmp[ii].Basarıderecesi;
                                  maxi = ii;
                              }

                          }

                      }
                      HeapNode tmpp = tmp[i];
                      tmp[i] = tmp[maxi];
                      tmp[maxi] = tmpp;


                  }

                  for (int j = 0; j < 10; j++)
                  {
                          if (tmp[j] != null)
                          {
                                obilgi = (Ogrenci)tmp[j].HeapBaglıliste.Head.Data;
                                ebilgi = (EgitimBilgileri)tmp[j].HeapBaglıliste.Head.Next.Data;
                                sbilgi = (StajBilgileri)tmp[j].HeapBaglıliste.Head.Next.Next.Data;
                                listSiralama.Items.Add("Başarı Derecesi : " + tmp[j].Basarıderecesi + " İsim : " + obilgi.OgrAdi + " Öğrenci No : " + obilgi.OgrNo);
                            }
                  }

              }
              else if (comboHeap.Text == "Makine")
              {
                    int[] a = new int[10];
                    for (int m = 0; m < 10; m++)
                    {
                        if (h.Table[2]!= null)
                            tmp[m] = h.Table[2].HeapArray[m];
                        else
                            break;
                    }
                  for (int i = 0; i < 10; i++)
                  {
                      max = 0;
                      for (int ii = i; ii < 10; ii++)
                      {
                          if (tmp[ii] != null)
                          {
                              if (tmp[ii].Basarıderecesi > max)
                              {
                                  max = tmp[ii].Basarıderecesi;
                                  maxi = ii;
                              }

                          }

                      }
                      HeapNode tmpp = tmp[i];
                      tmp[i] = tmp[maxi];
                      tmp[maxi] = tmpp;


                  }

                  for (int j = 0; j < 10; j++)
                  {
                          if (tmp[j] != null)
                          {
                                obilgi = (Ogrenci)tmp[j].HeapBaglıliste.Head.Data;
                                ebilgi = (EgitimBilgileri)tmp[j].HeapBaglıliste.Head.Next.Data;
                                sbilgi = (StajBilgileri)tmp[j].HeapBaglıliste.Head.Next.Next.Data;
                                listSiralama.Items.Add("Başarı Derecesi : " + tmp[j].Basarıderecesi + " İsim : " + obilgi.OgrAdi + " Öğrenci No : " + obilgi.OgrNo);
                            }
                  }


              }
              else if (comboHeap.Text == "Enerji")
              {

                    int[] a = new int[10];
                    for (int m = 0; m < 10; m++)
                    {
                        if (h.Table[3] != null)
                            tmp[m] = h.Table[3].HeapArray[m];
                        else
                            break;
                    }
                    for (int i = 0; i < 10; i++)
                  {
                      max = 0;
                      for (int ii = i; ii < 10; ii++)
                      {
                          if (tmp[ii] != null)
                          {
                              if (tmp[ii].Basarıderecesi > max)
                              {
                                  max = tmp[ii].Basarıderecesi;
                                  maxi = ii;
                              }

                          }

                      }
                      HeapNode tmpp = tmp[i];
                      tmp[i] = tmp[maxi];
                      tmp[maxi] = tmpp;


                  }

                  for (int j = 0; j < 10; j++)
                  {
                          if (tmp[j] != null)
                          {
                                obilgi = (Ogrenci)tmp[j].HeapBaglıliste.Head.Data;
                                ebilgi = (EgitimBilgileri)tmp[j].HeapBaglıliste.Head.Next.Data;
                                sbilgi = (StajBilgileri)tmp[j].HeapBaglıliste.Head.Next.Next.Data;
                                listSiralama.Items.Add("Başarı Derecesi : " + tmp[j].Basarıderecesi + " İsim : " + obilgi.OgrAdi + " Öğrenci No : " + obilgi.OgrNo);
                            }
                  }


              }
              else if (comboHeap.Text == "EndüstriyelTasarım")
              {
                    int[] a = new int[10];
                    for (int m = 0; m < 10; m++)
                    {
                        if (h.Table[4] != null)
                            tmp[m] = h.Table[4].HeapArray[m];
                        else
                            break;
                    }
                    for (int i = 0; i < 10; i++)
                      {
                          max = 0;
                          for (int ii = i; ii < 10; ii++)
                          {
                              if (tmp[ii] != null)
                              {
                                  if (tmp[ii].Basarıderecesi > max)
                                  {
                                      max = tmp[ii].Basarıderecesi;
                                      maxi = ii;
                                  }

                              }

                          }
                          HeapNode tmpp = tmp[i];
                          tmp[i] = tmp[maxi];
                          tmp[maxi] = tmpp;


                      }

                      for (int j = 0; j < 10; j++)
                      {
                          if (tmp[j] != null)
                          {
                              if (tmp[j] != null)
                              {
                                    obilgi = (Ogrenci)tmp[j].HeapBaglıliste.Head.Data;
                                    ebilgi = (EgitimBilgileri)tmp[j].HeapBaglıliste.Head.Next.Data;
                                    sbilgi = (StajBilgileri)tmp[j].HeapBaglıliste.Head.Next.Next.Data;
                                    listSiralama.Items.Add("Başarı Derecesi : " + tmp[j].Basarıderecesi + " İsim : " + obilgi.OgrAdi + " Öğrenci No : " + obilgi.OgrNo);
                                }
                          }
                      }
                  }

              
              else if (comboHeap.Text == "Otomotiv")
              {
                    int[] a = new int[10];
                    for (int m = 0; m < 10; m++)
                    {
                        if (h.Table[5] != null)
                            tmp[m] = h.Table[5].HeapArray[m];
                        else
                            break;
                    }
                    
                  for (int i = 0; i < 10; i++)
                  {
                      max = 0;
                      for (int ii = i; ii < 10; ii++)
                      {
                          if (tmp[ii] != null)
                          {
                              if (tmp[ii].Basarıderecesi > max)
                              {
                                  max = tmp[ii].Basarıderecesi;
                                  maxi = ii;
                              }

                          }

                      }
                      HeapNode tmpp = tmp[i];
                      tmp[i] = tmp[maxi];
                      tmp[maxi] = tmpp;


                  }

                  for (int j = 0; j < 10; j++)
                  {
                          if (tmp[j] != null)
                          {
                                obilgi = (Ogrenci)tmp[j].HeapBaglıliste.Head.Data;
                                ebilgi = (EgitimBilgileri)tmp[j].HeapBaglıliste.Head.Next.Data;
                                sbilgi = (StajBilgileri)tmp[j].HeapBaglıliste.Head.Next.Next.Data;
                                listSiralama.Items.Add("Başarı Derecesi : " + tmp[j].Basarıderecesi + " İsim : " + obilgi.OgrAdi + " Öğrenci No : " + obilgi.OgrNo);
                            }
                  }


              }
              else if (comboHeap.Text == "BilişimSistemleri")
              {
                  int[] a = new int[10];
                  for (int m = 0; m < 10; m++)
                  {
                        if (h.Table[6] != null)
                            tmp[m] = h.Table[6].HeapArray[m];
                        else
                            break;
                    }
                  for (int i = 0; i < 10; i++)
                  {
                      max = 0;
                      for (int ii = i; ii < 10; ii++)
                      {
                          if (tmp[ii] != null)
                          {
                              if (tmp[ii].Basarıderecesi > max)
                              {
                                  max = tmp[ii].Basarıderecesi;
                                  maxi = ii;
                              }

                          }

                      }
                      HeapNode tmpp = tmp[i];
                      tmp[i] = tmp[maxi];
                      tmp[maxi] = tmpp;


                  }

                  for (int j = 0; j < 10; j++)
                  {
                          if (tmp[j] != null)
                          {
                                obilgi = (Ogrenci)tmp[j].HeapBaglıliste.Head.Data;
                                ebilgi = (EgitimBilgileri)tmp[j].HeapBaglıliste.Head.Next.Data;
                                sbilgi = (StajBilgileri)tmp[j].HeapBaglıliste.Head.Next.Next.Data;
                                listSiralama.Items.Add("Başarı Derecesi : " + tmp[j].Basarıderecesi + " İsim : " + obilgi.OgrAdi + " Öğrenci No : " + obilgi.OgrNo);
                            }
                  }

              }
          }
            catch
            {


            }
            }
          private void btnIngilizceSiralama_Click(object sender, EventArgs e)
          {
            listSiralama.Items.Clear();
            int dügümsayisi = ogrİslem.AgacDugumSayisi();
            Ogrenci obilgi = new Ogrenci();
            EgitimBilgileri ebilgi = new EgitimBilgileri();
            StajBilgileri sbilgi = new StajBilgileri();
            HeapNode[] tmp = new HeapNode[10];
              try
              {
                  if (comboHeap.Text == "Yazılım")
                  {
                    
                    for (int j = 0; j <10 ; j++)
                    {
                        if (h.Table[0] != null)
                        {
                            if (h.Table[0].HeapArray[j] != null)
                            {
                                tmp[j] = h.Table[0].HeapArray[j];
                            }
                            else
                                break;
                        }
                        else
                            break;
                    }
                    for (int m = 0; m <10; m++)
                    {
                        if (tmp[m] != null)
                        {
                            obilgi = (Ogrenci)tmp[m].HeapBaglıliste.Head.Data;
                            ebilgi = (EgitimBilgileri)tmp[m].HeapBaglıliste.Head.Next.Data;
                            sbilgi = (StajBilgileri)tmp[m].HeapBaglıliste.Head.Next.Next.Data;
                             if (obilgi != null && obilgi.YabanciDil == "Advanced")
                                {
                                    if (ebilgi.BasariBelgesi == true)
                                        listSiralama.Items.Add("Başarı Derecesi : " + (ebilgi.Ortalama + 10) + " İsim : " + obilgi.OgrAdi + " Öğrenci No : " + obilgi.OgrNo);
                                    else
                                        listSiralama.Items.Add("Başarı Derecesi : " + (ebilgi.Ortalama + 10) + " İsim : " + obilgi.OgrAdi + " Öğrenci No : " + obilgi.OgrNo);
                                }
                        }
                    }
                  }
                  else if (comboHeap.Text == "Mekatronik")
                  {
                    for (int j = 0; j < 10; j++)
                    {
                        if (h.Table[1] != null)
                        {
                            if (h.Table[1].HeapArray[j] != null)
                            {
                                tmp[j] = h.Table[1].HeapArray[j];
                            }
                            else
                                break;
                        }
                        else
                            break;
                    }
                    for (int m = 0; m < 10; m++)
                    {
                        if (tmp[m] != null)
                        {
                            obilgi = (Ogrenci)tmp[m].HeapBaglıliste.Head.Data;
                            ebilgi = (EgitimBilgileri)tmp[m].HeapBaglıliste.Head.Next.Data;
                            sbilgi = (StajBilgileri)tmp[m].HeapBaglıliste.Head.Next.Next.Data;
                            if (obilgi != null && obilgi.YabanciDil == "Advanced")
                            {
                                if (ebilgi.BasariBelgesi == true)
                                    listSiralama.Items.Add("Başarı Derecesi : " + (ebilgi.Ortalama + 10) + " İsim : " + obilgi.OgrAdi + " Öğrenci No : " + obilgi.OgrNo);
                                else
                                    listSiralama.Items.Add("Başarı Derecesi : " + (ebilgi.Ortalama + 10) + " İsim : " + obilgi.OgrAdi + " Öğrenci No : " + obilgi.OgrNo);
                            }
                        }
                    }
                }
                  else if (comboHeap.Text == "Makine")
                  {
                    for (int j = 0; j < 10; j++)
                    {
                        if (h.Table[2] != null)
                        {
                            if (h.Table[2].HeapArray[j] != null)
                            {
                                tmp[j] = h.Table[2].HeapArray[j];
                            }
                            else
                                break;
                        }
                        else
                            break;
                    }
                    for (int m = 0; m < 10; m++)
                    {
                        if (tmp[m] != null)
                        {
                            obilgi = (Ogrenci)tmp[m].HeapBaglıliste.Head.Data;
                            ebilgi = (EgitimBilgileri)tmp[m].HeapBaglıliste.Head.Next.Data;
                            sbilgi = (StajBilgileri)tmp[m].HeapBaglıliste.Head.Next.Next.Data;
                            if (obilgi != null && obilgi.YabanciDil == "Advanced")
                            {
                                if (ebilgi.BasariBelgesi == true)
                                    listSiralama.Items.Add("Başarı Derecesi : " + (ebilgi.Ortalama + 10) + " İsim : " + obilgi.OgrAdi + " Öğrenci No : " + obilgi.OgrNo);
                                else
                                    listSiralama.Items.Add("Başarı Derecesi : " + (ebilgi.Ortalama + 10) + " İsim : " + obilgi.OgrAdi + " Öğrenci No : " + obilgi.OgrNo);
                            }
                        }
                    }
                }
                  else if (comboHeap.Text == "Enerji")
                  {
                    for (int j = 0; j < 10; j++)
                    {
                        if (h.Table[3] != null)
                        {
                            if (h.Table[3].HeapArray[j] != null)
                            {
                                tmp[j] = h.Table[3].HeapArray[j];
                            }
                            else
                                break;
                        }
                        else
                            break;
                    }
                    for (int m = 0; m < 10; m++)
                    {
                        if (tmp[m] != null)
                        {
                            obilgi = (Ogrenci)tmp[m].HeapBaglıliste.Head.Data;
                            ebilgi = (EgitimBilgileri)tmp[m].HeapBaglıliste.Head.Next.Data;
                            sbilgi = (StajBilgileri)tmp[m].HeapBaglıliste.Head.Next.Next.Data;
                            if (obilgi != null && obilgi.YabanciDil == "Advanced")
                            {
                                if (ebilgi.BasariBelgesi == true)
                                    listSiralama.Items.Add("Başarı Derecesi : " + (ebilgi.Ortalama + 10) + " İsim : " + obilgi.OgrAdi + " Öğrenci No : " + obilgi.OgrNo);
                                else
                                    listSiralama.Items.Add("Başarı Derecesi : " + (ebilgi.Ortalama + 10) + " İsim : " + obilgi.OgrAdi + " Öğrenci No : " + obilgi.OgrNo);
                            }
                        }
                    }
                }
                  else if (comboHeap.Text == "EndüstriyelTasarım")
                  {
                    for (int j = 0; j < 10; j++)
                    {
                        if (h.Table[4] != null)
                        {
                            if (h.Table[4].HeapArray[j] != null)
                            {
                                tmp[j] = h.Table[4].HeapArray[j];
                            }
                            else
                                break;
                        }
                        else
                            break;
                    }
                    for (int m = 0; m < 10; m++)
                    {
                        if (tmp[m] != null)
                        {
                            obilgi = (Ogrenci)tmp[m].HeapBaglıliste.Head.Data;
                            ebilgi = (EgitimBilgileri)tmp[m].HeapBaglıliste.Head.Next.Data;
                            sbilgi = (StajBilgileri)tmp[m].HeapBaglıliste.Head.Next.Next.Data;
                            if (obilgi != null && obilgi.YabanciDil == "Advanced")
                            {
                                if (ebilgi.BasariBelgesi == true)
                                    listSiralama.Items.Add("Başarı Derecesi : " + (ebilgi.Ortalama + 10) + " İsim : " + obilgi.OgrAdi + " Öğrenci No : " + obilgi.OgrNo);
                                else
                                    listSiralama.Items.Add("Başarı Derecesi : " + (ebilgi.Ortalama + 10) + " İsim : " + obilgi.OgrAdi + " Öğrenci No : " + obilgi.OgrNo);
                            }
                        }
                    }
                }
                  else if (comboHeap.Text == "Otomotiv")
                  {
                    for (int j = 0; j < 10; j++)
                    {
                        if (h.Table[5] != null)
                        {
                            if (h.Table[5].HeapArray[j] != null)
                            {
                                tmp[j] = h.Table[5].HeapArray[j];
                            }
                            else
                                break;
                        }
                        else
                            break;
                    }
                    for (int m = 0; m < 10; m++)
                    {
                        if (tmp[m] != null)
                        {
                            obilgi = (Ogrenci)tmp[m].HeapBaglıliste.Head.Data;
                            ebilgi = (EgitimBilgileri)tmp[m].HeapBaglıliste.Head.Next.Data;
                            sbilgi = (StajBilgileri)tmp[m].HeapBaglıliste.Head.Next.Next.Data;
                            if (obilgi != null && obilgi.YabanciDil == "Advanced")
                            {
                                if (ebilgi.BasariBelgesi == true)
                                    listSiralama.Items.Add("Başarı Derecesi : " + (ebilgi.Ortalama + 10) + " İsim : " + obilgi.OgrAdi + " Öğrenci No : " + obilgi.OgrNo);
                                else
                                    listSiralama.Items.Add("Başarı Derecesi : " + (ebilgi.Ortalama + 10) + " İsim : " + obilgi.OgrAdi + " Öğrenci No : " + obilgi.OgrNo);
                            }
                        }
                    }
                }
                  else if (comboHeap.Text == "BilişimSistemleri")
                  {
                    for (int j = 0; j < 10; j++)
                    {
                        if (h.Table[6] != null)
                        {
                            if (h.Table[6].HeapArray[j] != null)
                            {
                                tmp[j] = h.Table[6].HeapArray[j];
                            }
                            else
                                break;
                        }
                        else
                            break;
                    }
                    for (int m = 0; m < 10; m++)
                    {
                        if (tmp[m] != null)
                        {
                            obilgi = (Ogrenci)tmp[m].HeapBaglıliste.Head.Data;
                            ebilgi = (EgitimBilgileri)tmp[m].HeapBaglıliste.Head.Next.Data;
                            sbilgi = (StajBilgileri)tmp[m].HeapBaglıliste.Head.Next.Next.Data;
                            if (obilgi != null && obilgi.YabanciDil == "Advanced")
                            {
                                if (ebilgi.BasariBelgesi == true)
                                    listSiralama.Items.Add("Başarı Derecesi : " + (ebilgi.Ortalama + 10) + " İsim : " + obilgi.OgrAdi + " Öğrenci No : " + obilgi.OgrNo);
                                else
                                    listSiralama.Items.Add("Başarı Derecesi : " + (ebilgi.Ortalama + 10) + " İsim : " + obilgi.OgrAdi + " Öğrenci No : " + obilgi.OgrNo);
                            }
                        }
                    }
                }
              }
              catch { }
             
          }

          private void btnSirketKayit_Click(object sender, EventArgs e)
          {
              Sirket s = new Sirket();
              s.sirketAdi = txtSirketAdiKayit.Text;
              s.sirketAdresi = txtSirketAdresKayit.Text;
              s.sirketEposta = txtSirketEpostaKayit.Text;
              s.sirketTel = txtSirketTelKayit.Text;


              sirketListesi.sirketEkle(s);

              MessageBox.Show("Şirketiniz başarıyla kaydedilmiştir.");
          }

          private void btnTeklif_Click(object sender, EventArgs e)
          {

          
        }

        private void btnInOrder_Click(object sender, EventArgs e)
        {
            listAramaIslemleri.Items.Clear();
            int elemansayisi = ogrİslem.İkiliArama.DugumSayisi();
            ogrİslem.İkiliArama.InOrder(elemansayisi);
            
            for(int i = 0; i < elemansayisi; i++)
            {
                BaglıListe tmp = ogrİslem.İkiliArama.dizi[i];
                Ogrenci obilgi = (Ogrenci)tmp.Head.Data;
                EgitimBilgileri ebilgi = (EgitimBilgileri)tmp.Head.Next.Data;
                StajBilgileri sbilgi = (StajBilgileri)tmp.Head.Next.Next.Data;

                listAramaIslemleri.Items.Add("Öğrenci Adı : " + obilgi.OgrAdi + " Öğrenci No : " + obilgi.OgrNo + " Öğrenci Başarı Durumu : "  + ebilgi.Ortalama + " Staj Yeri : " + sbilgi.SirketAdi);
            }
        }

        private void btnPreOrder_Click(object sender, EventArgs e)
        {
            listAramaIslemleri.Items.Clear();
            int elemansayisi = ogrİslem.İkiliArama.DugumSayisi();
            ogrİslem.İkiliArama.PreOrder(elemansayisi);

            for (int i = 0; i < elemansayisi; i++)
            {
                BaglıListe tmp = ogrİslem.İkiliArama.dizi[i];
                Ogrenci obilgi = (Ogrenci)tmp.Head.Data;
                EgitimBilgileri ebilgi = (EgitimBilgileri)tmp.Head.Next.Data;
                StajBilgileri sbilgi = (StajBilgileri)tmp.Head.Next.Next.Data;
                listAramaIslemleri.Items.Add("Öğrenci Adı : " + obilgi.OgrAdi + " Öğrenci No : " + obilgi.OgrNo + " Öğrenci Başarı Durumu : "  + ebilgi.Ortalama + " Staj Yeri : " + sbilgi.SirketAdi);
            }
        }

        private void btnPostOrder_Click(object sender, EventArgs e)
        {
            listAramaIslemleri.Items.Clear();
            int elemansayisi = ogrİslem.İkiliArama.DugumSayisi();
            ogrİslem.İkiliArama.PostOrder(elemansayisi);

            for (int i = 0; i < elemansayisi; i++)
            {
                BaglıListe tmp = ogrİslem.İkiliArama.dizi[i];
                Ogrenci obilgi = (Ogrenci)tmp.Head.Data;
                EgitimBilgileri ebilgi = (EgitimBilgileri)tmp.Head.Next.Data;
                StajBilgileri sbilgi = (StajBilgileri)tmp.Head.Next.Next.Data;
                listAramaIslemleri.Items.Add("Öğrenci Adı : " + obilgi.OgrAdi + " Öğrenci No : " + obilgi.OgrNo + " Öğrenci Başarı Durumu : "  + ebilgi.Ortalama + " Staj Yeri : " + sbilgi.SirketAdi);
            }
        }

        private void btnDerinlik_Click(object sender, EventArgs e)
        {
            MessageBox.Show(ogrİslem.İkiliArama.YaprakSayisi().ToString());
        }

        private void btnElemanSayisi_Click(object sender, EventArgs e)
        {
            MessageBox.Show(ogrİslem.İkiliArama.DugumSayisi().ToString());
        }
    }
}
