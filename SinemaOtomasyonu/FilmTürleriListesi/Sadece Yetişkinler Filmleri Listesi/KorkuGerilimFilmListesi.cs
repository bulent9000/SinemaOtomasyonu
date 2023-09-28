using Data.Core.BusinessLogicLayer;
using SinemaOtomasyonu.FilmBilgiDetayi.Yetişkin_Film_Detayı.Korku_Filmleri_Detayları;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SinemaOtomasyonu.FilmTürleriListesi.Sadece_Yetişkinler_Filmleri_Listesi
{
    public partial class KorkuGerilimFilmListesi : Form
    {
        SinemaSistemService Bll;
        public KorkuGerilimFilmListesi()
        {
            InitializeComponent();
            Bll = new SinemaSistemService();
        }

        private void btn_ciglikAlti_Click(object sender, EventArgs e)
        {
            int id = Bll.sinemaID();
            Bll.filmAdi("Çığlık 6",id);
            CiglikAltiFilmDetayi ciglikAltiFilmDetayi = new CiglikAltiFilmDetayi();
            ciglikAltiFilmDetayi.Show();
        }

        private void btn_konusBenimle_Click(object sender, EventArgs e)
        {
            int id = Bll.sinemaID();
            Bll.filmAdi("Konuş Benimle",id);
            KonusBenimleFilmDetayi konusBenimleFilmDetayi = new KonusBenimleFilmDetayi();
            konusBenimleFilmDetayi.Show();

        }

        private void btn_otobanKatilleri_Click(object sender, EventArgs e)
        {
            int id = Bll.sinemaID();
            Bll.filmAdi("Otoban Katilleri",id);
            OtobanKatilleriFilmDetayi otobanKatilleriFilmDetayi = new OtobanKatilleriFilmDetayi();
            otobanKatilleriFilmDetayi.Show();
        }

        private void btn_korkuYolu_Click(object sender, EventArgs e)
        {
            int id = Bll.sinemaID();
            Bll.filmAdi("Korku Yolu",id);
            KorkuYoluFilmDetayi korkuYoluFilmDetayi = new KorkuYoluFilmDetayi();
            korkuYoluFilmDetayi.Show();
        }

        private void btn_korkuGecesi_Click(object sender, EventArgs e)
        {
            int id = Bll.sinemaID();
            Bll.filmAdi("Korku Gecesi",id);
            KorkuGecesiFilmDetayi korkuGecesiFilmDetayi = new KorkuGecesiFilmDetayi();
            korkuGecesiFilmDetayi.Show();
        }

        private void btn_KorkuSeansi_Click(object sender, EventArgs e)
        {
            int id = Bll.sinemaID();
            Bll.filmAdi("Korku Seansı", id);
            KorkuSeansiFilmDetayi korkuSeansiFilmDetayi = new KorkuSeansiFilmDetayi();
            korkuSeansiFilmDetayi.Show();
        }

        private void btn_dracula_Click(object sender, EventArgs e)
        {
            int id = Bll.sinemaID();
            Bll.filmAdi("Dracula",id);
            DrakulaFilmDetaylari drakulaFilmDetaylari = new DrakulaFilmDetaylari();
            drakulaFilmDetaylari.Show();
        }
    }
}
