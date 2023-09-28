using Data.Core.BusinessLogicLayer;
using Data.Core.Entities;
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
    public partial class IzleyiciKayitEkrani : Form
    {
        SinemaSistemService service;
        List<SinemaIzleyiciKayitEkrani> izleyiciBilgi;

        BiletAlIzleyiciKayit bilet;
        public IzleyiciKayitEkrani()
        {
            InitializeComponent();
            service = new SinemaSistemService();
            bilet = new BiletAlIzleyiciKayit();
        }

        private void IzleyiciKayitEkrani_Load(object sender, EventArgs e)
        {

            izleyiciBilgi = service.izleyiciListe();

            foreach (var item in izleyiciBilgi)
            {

                lbl_sehir.Text=item.sehir;
                lbl_mekan.Text = item.mekan;
                lbl_filmTürü.Text = item.filmTürü;
                lbl_filmTarih.Text =Convert.ToString(item.etkinlikTarihi);
                lbl_filmAdi.Text = item.filmAdi;
                lbl_filmSaati.Text = item.saat;
                lbl_salonNo.Text = item.salonNo;
                lbl_koltukNo.Text = item.koltukNo;

            }
           




        }

        private void btn_biletAl_Click(object sender, EventArgs e)
        {
            if (rbtn_yetiskin.Checked)
            {

                biletKayit();
                bilet.fiyat = lbl_fiyat55.Text;
                bilet.Durum = "Yetişkin";

                service.izleyiciSonKayit(bilet);


            }
            else if (rbtn_ögrenci.Checked)
            {

                biletKayit();
                bilet.fiyat = lbl_fiyat15.Text;
                bilet.Durum = "Öğrenci";
                service.izleyiciSonKayit(bilet);

            }
            else if (rbtn_onbesYasAlti.Checked)
            {

                biletKayit();
                bilet.fiyat = lbl_fiyat5.Text;
                bilet.Durum = "15 yaş altı";
                service.izleyiciSonKayit(bilet);
            }
        }
        public void biletKayit()
        {

            bilet.tc_kimlikNo = txt_tcNo.Text;
            bilet.adi = txt_Adi.Text;
            bilet.soyadi = txt_soyadi.Text;
            bilet.telefon = txt_telefonu.Text;
            bilet.mail = txt_mail.Text;
            bilet.filmAdi = lbl_filmAdi.Text;
            bilet.filmTürü = lbl_filmTürü.Text;
            bilet.filmSaati = lbl_filmSaati.Text;
            bilet.filmTarihi = Convert.ToDateTime(lbl_filmTarih.Text);
            bilet.salonNo = lbl_salonNo.Text;
            bilet.koltukNo = lbl_koltukNo.Text;
            bilet.mekan = lbl_mekan.Text;
            bilet.sehir = lbl_sehir.Text;


        }

        private void btn_izleyiciListele_Click(object sender, EventArgs e)
        {
            IzleyiciListesi ızleyiciListesi = new IzleyiciListesi();
            ızleyiciListesi.Show();
        }
    }
}
