using Data.Core.BusinessLogicLayer;
using Data.Core.Entities;
using SinemaOtomasyonu.FilmBilgiDetayi.Aile_Filmleri_Detay;
using SinemaOtomasyonu.FilmBilgiDetayi.Yetişkin_Film_Detayı.Aksiyon_Filmleri_Detay;
using SinemaOtomasyonu.FilmBilgiDetayi.Yetişkin_Film_Detayı.Bilim_Kurgu_Filmleri_Detay;
using SinemaOtomasyonu.FilmBilgiDetayi.Yetişkin_Film_Detayı.Komedi_Film_Detayları;
using SinemaOtomasyonu.FilmBilgiDetayi.Yetişkin_Film_Detayı.Korku_Filmleri_Detayları;
using SinemaOtomasyonu.FilmTürleriListesi.Aile_Filmleri;
using SinemaOtomasyonu.FilmTürleriListesi.Aksiyon_Filmleri_Listesi;
using SinemaOtomasyonu.FilmTürleriListesi.Sadece_Yetişkinler_Filmleri_Listesi;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SinemaOtomasyonu
{
    public partial class SinemaAnaEkran : Form
    {
        SinemaSistemService service;
        List<SinemaMekanlari> sinemaMekan;
        public SinemaAnaEkran()
        {
            InitializeComponent();
            service = new SinemaSistemService();
        }

        private void cmb_sehirler_SelectedIndexChanged(object sender, EventArgs e)
        {
            #region  İstanbul Avrupa mekanları
            if (cmb_sehirler.SelectedItem is "İstanbul Avrupa")
            {

                sinemaMekan = new List<SinemaMekanlari>();
                #region
                sinemaMekan.Add(new SinemaMekanlari() { mekanAdi = "Airport Cinemas" });
                sinemaMekan.Add(new SinemaMekanlari() { mekanAdi = "AKM Yeşilçam Sineması" });
                sinemaMekan.Add(new SinemaMekanlari() { mekanAdi = "Arenapark Site sinemaları" });
                sinemaMekan.Add(new SinemaMekanlari() { mekanAdi = "Armoni Park Site Sinemaları" });
                sinemaMekan.Add(new SinemaMekanlari() { mekanAdi = "Atirus Sineması" });
                sinemaMekan.Add(new SinemaMekanlari() { mekanAdi = "Avcılar Pelican Mall Cinemapink" });
                sinemaMekan.Add(new SinemaMekanlari() { mekanAdi = "Bağcılar Arzu Sineması" });
                sinemaMekan.Add(new SinemaMekanlari() { mekanAdi = "Bakırköy Carousel Cinemapink" });
                sinemaMekan.Add(new SinemaMekanlari() { mekanAdi = "Beylikdüzü Migros Cinemapink" });
                sinemaMekan.Add(new SinemaMekanlari() { mekanAdi = "Biletinal Torun Center" });
                sinemaMekan.Add(new SinemaMekanlari() { mekanAdi = "Cineport Sinemaları Göktürk" });
                sinemaMekan.Add(new SinemaMekanlari() { mekanAdi = "Cinetech Torium Cinema" });
                sinemaMekan.Add(new SinemaMekanlari() { mekanAdi = "Cinens Sinemaları Venezia" });
                sinemaMekan.Add(new SinemaMekanlari() { mekanAdi = "City's Nişantaşı" });
                sinemaMekan.Add(new SinemaMekanlari() { mekanAdi = "Etiler Akmerkez Cinemapink" });
                sinemaMekan.Add(new SinemaMekanlari() { mekanAdi = "Fişekhane Cinemo" });
                sinemaMekan.Add(new SinemaMekanlari() { mekanAdi = "Güngören Park" });
                sinemaMekan.Add(new SinemaMekanlari() { mekanAdi = "Hope Alkazar Sineması" });
                sinemaMekan.Add(new SinemaMekanlari() { mekanAdi = "ING Cine City Etiler" });
                sinemaMekan.Add(new SinemaMekanlari() { mekanAdi = "Vega AVM" });
                sinemaMekan.Add(new SinemaMekanlari() { mekanAdi = "Olimpia Site" });
                sinemaMekan.Add(new SinemaMekanlari() { mekanAdi = "Starcity AVM" });
                sinemaMekan.Add(new SinemaMekanlari() { mekanAdi = "YBY Woods" });
                #endregion
                cmb_mekanlar.DataSource = sinemaMekan;
            }

            #endregion

            #region İstanbul Anadolu yakası
            else if (cmb_sehirler.SelectedItem is "İstanbul Anadolu")
            {

                sinemaMekan = new List<SinemaMekanlari>();
                #region
                sinemaMekan.Add(new SinemaMekanlari() { mekanAdi = "Cadde Bostan CKM Sineması" });
                sinemaMekan.Add(new SinemaMekanlari() { mekanAdi = "CINEMATICA-Metropol İstanbul" });
                sinemaMekan.Add(new SinemaMekanlari() { mekanAdi = "Yelken Kulübü Açık Hava Sineması" });
                sinemaMekan.Add(new SinemaMekanlari() { mekanAdi = "KAdıköy Sineması" });
                sinemaMekan.Add(new SinemaMekanlari() { mekanAdi = "Meydan İStanbul AVM" });
                sinemaMekan.Add(new SinemaMekanlari() { mekanAdi = "Plato AVM" });
                sinemaMekan.Add(new SinemaMekanlari() { mekanAdi = "Rings Cinemarine" });
                sinemaMekan.Add(new SinemaMekanlari() { mekanAdi = "Rita çiftlik sineması" });
                sinemaMekan.Add(new SinemaMekanlari() { mekanAdi = "Üsküdar nevçarşı" });
                sinemaMekan.Add(new SinemaMekanlari() { mekanAdi = "Bulvar 216 Açık Hava Sineması" });
                sinemaMekan.Add(new SinemaMekanlari() { mekanAdi = "Buyaka AVM Cinemapink" });

                #endregion
                cmb_mekanlar.DataSource = sinemaMekan;


            }
            #endregion

            #region Antalya 
            else if (cmb_sehirler.SelectedItem is "Antalya")
            {

                sinemaMekan = new List<SinemaMekanlari>();
                #region
                sinemaMekan.Add(new SinemaMekanlari() { mekanAdi = "Alanyum Sinemaları" });
                sinemaMekan.Add(new SinemaMekanlari() { mekanAdi = "Antalya Erasta Aksin Sinemaları" });
                sinemaMekan.Add(new SinemaMekanlari() { mekanAdi = "Kumluca Belediyesi Sinemaları" });
                sinemaMekan.Add(new SinemaMekanlari() { mekanAdi = "Megapol Sineması" });
                sinemaMekan.Add(new SinemaMekanlari() { mekanAdi = "Terracity Cinemapink" });
                sinemaMekan.Add(new SinemaMekanlari() { mekanAdi = "Cinetech Mall of Antalya" });
                sinemaMekan.Add(new SinemaMekanlari() { mekanAdi = "Cinetime Özdilekpark" });
                sinemaMekan.Add(new SinemaMekanlari() { mekanAdi = "Finike Belediye Sineması" });


                #endregion
                cmb_mekanlar.DataSource = sinemaMekan;


            }
            #endregion

            #region Bursa 
            else if (cmb_sehirler.SelectedItem is "Bursa")
            {

                sinemaMekan = new List<SinemaMekanlari>();
                #region
                sinemaMekan.Add(new SinemaMekanlari() { mekanAdi = "As Outlet Venüs Sineması" });
                sinemaMekan.Add(new SinemaMekanlari() { mekanAdi = "Barışmanço Kültür Merkezi" });
                sinemaMekan.Add(new SinemaMekanlari() { mekanAdi = "Cinebak Parkur Bursa" });
                sinemaMekan.Add(new SinemaMekanlari() { mekanAdi = "Cinemapink İnegöl AVM" });
                sinemaMekan.Add(new SinemaMekanlari() { mekanAdi = "Cinetech Korupark Sinema" });
                sinemaMekan.Add(new SinemaMekanlari() { mekanAdi = "Cinetech Zafer Piaza" });
                sinemaMekan.Add(new SinemaMekanlari() { mekanAdi = "Cinetime Özdilekpark Bursa Nilüfer" });
                sinemaMekan.Add(new SinemaMekanlari() { mekanAdi = "Gemlik Venüs Sineması" });
                sinemaMekan.Add(new SinemaMekanlari() { mekanAdi = "Karacabey Cinekaraca" });
                sinemaMekan.Add(new SinemaMekanlari() { mekanAdi = "Kent Meydanı Avşar" });




                #endregion
                cmb_mekanlar.DataSource = sinemaMekan;


            }
            #endregion

            #region Ankara 
            else if (cmb_sehirler.SelectedItem is "Ankara")
            {

                sinemaMekan = new List<SinemaMekanlari>();
                #region
                sinemaMekan.Add(new SinemaMekanlari() { mekanAdi = "Acity Cinevizyon" });
                sinemaMekan.Add(new SinemaMekanlari() { mekanAdi = "Ankaraforum Cinemapink" });
                sinemaMekan.Add(new SinemaMekanlari() { mekanAdi = "Ankara Optimum Avşar" });
                sinemaMekan.Add(new SinemaMekanlari() { mekanAdi = "Büyülü Fener Bahçelievler Sineması" });
                sinemaMekan.Add(new SinemaMekanlari() { mekanAdi = "Büyülü Fener Kızılay Sineması" });
                sinemaMekan.Add(new SinemaMekanlari() { mekanAdi = "Cer Modern Sinema" });
                sinemaMekan.Add(new SinemaMekanlari() { mekanAdi = "Cinemapink Ankara 365 AVM" });
                sinemaMekan.Add(new SinemaMekanlari() { mekanAdi = "D vizyon Sineması" });
                sinemaMekan.Add(new SinemaMekanlari() { mekanAdi = "Keçiören Cinefora" });
                sinemaMekan.Add(new SinemaMekanlari() { mekanAdi = "Kızılırmak Sineması" });




                #endregion
                cmb_mekanlar.DataSource = sinemaMekan;


            }
            #endregion


            
           
        }

        private void rbtn_ninjaKaplumbaga_Click(object sender, EventArgs e)
        {
            NinjaKaplumbagaFilmDetayi ninjaKaplumbagaFilmDetayi = new NinjaKaplumbagaFilmDetayi();
            ninjaKaplumbagaFilmDetayi.Show();



        }

        private void cmb_filmTürü_SelectedIndexChanged(object sender, EventArgs e)
        {


            if (cmb_sehirler.Text!="Şehir seçiniz..." && cmb_mekanlar.Text!= "Mekan seçiniz..." && !string.IsNullOrEmpty(dtp_tarih.Text))
            {

                if (cmb_filmTürü.Text is "Aile")
                {
                    gönder();
                    aileFilmListeEkrani();
                }
                else if (cmb_filmTürü.Text is "Aksiyon")
                {
                    gönder();
                    aksiyonFilmListeEkrani();
                }
                else if (cmb_filmTürü.Text is "Bilimkurgu")
                {
                    gönder();
                    bilimkurguFilmListeEkrani();
                }
                else if (cmb_filmTürü.Text is "Drama")
                {
                    gönder();
                    DramaFilmListeEkrani();
                }
                else if (cmb_filmTürü.Text is "Gerilim-Korku")
                {
                    gönder();
                    gerilimKorkuFilmListeEkrani();
                }
                else if (cmb_filmTürü.Text is "Komedi")
                {
                    gönder();
                    komediFilmListeEkrani();
                }




            }
            else
            {
                MessageBox.Show("Lütfen tüm alanları eksiksiz doldurunuz","Uyarı",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }





        }
        #region Ekran gösterme metotları

        #region Film liste Ekranı
        private void aileFilmListeEkrani()
        {
            AileFilmListesi aileFilmListe = new AileFilmListesi();
            aileFilmListe.Show();
           
        }
        private void aksiyonFilmListeEkrani()
        {
            AksiyonFilmListesi aksiyonFilmListesi = new AksiyonFilmListesi();
            aksiyonFilmListesi.Show();
           

        }
        private void bilimkurguFilmListeEkrani()
        {
            BilimkurguFilmListesi bilimkurguFilmListesi = new BilimkurguFilmListesi();
            bilimkurguFilmListesi.Show();
          


        }
        private void DramaFilmListeEkrani()
        {
            DramaFilmListesi dramaFilmListe = new DramaFilmListesi();
            dramaFilmListe.Show();
            
        }
        private void gerilimKorkuFilmListeEkrani()
        {
            KorkuGerilimFilmListesi korkuFilmlisteEkrani = new KorkuGerilimFilmListesi();
            korkuFilmlisteEkrani.Show();
           

        }
        private void komediFilmListeEkrani()
        {
            KomediFilmListesi komediFilmListesi = new KomediFilmListesi();
            komediFilmListesi.Show();
         
        }

        #endregion

        private void btn_dracula_Click(object sender, EventArgs e)
        {
            DrakulaFilmDetaylari drakulaFilmDetaylari = new DrakulaFilmDetaylari();
            drakulaFilmDetaylari.Show();


            


        }

        private void btn_barbie_Click(object sender, EventArgs e)
        {
            BarbieFilmDetayi barbieFilmDetayi = new BarbieFilmDetayi();
            barbieFilmDetayi.Show();
        }

        private void btn_meg2_Click(object sender, EventArgs e)
        {
            
        }

        private void btn_openheimer_Click(object sender, EventArgs e)
        {

            OpenheimerFilmDetayi openheimerFilmDetayi = new OpenheimerFilmDetayi();
            openheimerFilmDetayi.Show();


        }

        private void btn_doru_Click(object sender, EventArgs e)
        {
            DoruFilmDetayi doruFilmDetayi = new DoruFilmDetayi();
            doruFilmDetayi.Show();
        }

        private void btn_gelecegeDönüs_Click(object sender, EventArgs e)
        {
            GelecegeDönüsFilmDetayi gelecegeDönüsFilmDetayi = new GelecegeDönüsFilmDetayi();
            gelecegeDönüsFilmDetayi.Show();


        }

        private void btn_granTourismo_Click(object sender, EventArgs e)
        {

        }

        private void btn_katiliYakalamak_Click(object sender, EventArgs e)
        {
            KatiliYakalamakFilmDetayi katiliYakalamakFilmDetayi = new KatiliYakalamakFilmDetayi();
            katiliYakalamakFilmDetayi.Show();
        }

        private void btn_periliKösk_Click(object sender, EventArgs e)
        {

        }

        private void btn_suikastcilar_Click(object sender, EventArgs e)
        {
            SuikastcilarFilmDetayi suikastcilarFilmDetayi = new SuikastcilarFilmDetayi();
            suikastcilarFilmDetayi.Show();
        }

        private void btn_cruella_Click(object sender, EventArgs e)
        {
            CruellaFilmDetayi cruellaFilmDetayi = new CruellaFilmDetayi();
            cruellaFilmDetayi.Show();


        }

        #endregion


        public void gönder()
        {

            SinemaBilgi sinemaBilgi = new SinemaBilgi()
            {
                sehir = cmb_sehirler.Text,
                mekan = cmb_mekanlar.Text,
                filmTür = cmb_filmTürü.Text,
                etkinlikTarih = Convert.ToDateTime(dtp_tarih.Text)
            };
                     

            service.sinemaBilgiEkle(sinemaBilgi);

        }


    }
}
