using Data.Core.BusinessLogicLayer;
using SinemaOtomasyonu.FilmBilgiDetayi.Yetişkin_Film_Detayı.Bilim_Kurgu_Filmleri_Detay;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SinemaOtomasyonu.FilmTürleriListesi.Aksiyon_Filmleri_Listesi
{
    public partial class BilimkurguFilmListesi : Form
    {
        SinemaSistemService Bll;
        public BilimkurguFilmListesi()
        {
            InitializeComponent();
            Bll = new SinemaSistemService();
        }

        private void btn_alien_Click(object sender, EventArgs e)
        {
            int id = Bll.sinemaID();
            Bll.filmAdi("Alien",id);
            AlienFilmDetay alienFilmDetay = new AlienFilmDetay();
            alienFilmDetay.Show();
        }

        private void btn_annihilation_Click(object sender, EventArgs e)
        {
            int id = Bll.sinemaID();
            Bll.filmAdi("Annihilation",id);
            AnnihilationFilmDetayi annihilationFilmDetayi = new AnnihilationFilmDetayi();
            annihilationFilmDetayi.Show();
        }

        private void btn_gelecegeDönüs_Click(object sender, EventArgs e)
        {
            int id = Bll.sinemaID();
            Bll.filmAdi("Geleceğe Dönüş",id);
            GelecegeDönüsFilmDetayi gelecegeDönüsFilmDetayi = new GelecegeDönüsFilmDetayi();
            gelecegeDönüsFilmDetayi.Show();
        }

        private void btn_iRobot_Click(object sender, EventArgs e)
        {
            int id = Bll.sinemaID();
            Bll.filmAdi("Ben Robot", id);
            RobotFilmDetayi robotFilmDetayi = new RobotFilmDetayi();
            robotFilmDetayi.Show();
        }

        private void btn_yedinciHayat_Click(object sender, EventArgs e)
        {
            int id = Bll.sinemaID();
            Bll.filmAdi("Yedinci Hayat",id);
            YedinciHayatFilmDetayi yedinciHayatFilmDetayi = new YedinciHayatFilmDetayi();
            yedinciHayatFilmDetayi.Show();
        }

        private void btn_ikibinAltmis_Click(object sender, EventArgs e)
        {
            int id = Bll.sinemaID();
            Bll.filmAdi("2067", id);
            IkibinAtmisYedi ıkibinAtmisYedi = new IkibinAtmisYedi();
            ıkibinAtmisYedi.Show();
        }

        private void btn_AyinDüsüsü_Click(object sender, EventArgs e)
        {
            int id = Bll.sinemaID();
            Bll.filmAdi("Ayın Düşüşü",id);
            AyinDüsüsüFilmDetayi ayinDüsüsüFilmDetayi = new AyinDüsüsüFilmDetayi();
            ayinDüsüsüFilmDetayi.Show();
        }
    }
}
