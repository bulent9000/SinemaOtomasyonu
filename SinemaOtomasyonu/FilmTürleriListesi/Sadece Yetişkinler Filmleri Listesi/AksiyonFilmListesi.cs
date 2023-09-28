using Data.Core.BusinessLogicLayer;
using SinemaOtomasyonu.FilmBilgiDetayi.Yetişkin_Film_Detayı.Aksiyon_Filmleri_Detay;
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
    public partial class AksiyonFilmListesi : Form
    {
        SinemaSistemService Bll;
        public AksiyonFilmListesi()
        {
            InitializeComponent();
            Bll = new SinemaSistemService();
        }

        private void btn_katiliYakalamak_Click(object sender, EventArgs e)
        {
            int id = Bll.sinemaID();
            Bll.filmAdi("Katili Yakalamak",id);
            KatiliYakalamakFilmDetayi katiliYakalamakFilmDetayi = new KatiliYakalamakFilmDetayi();
            katiliYakalamakFilmDetayi.Show();
        }

        private void btn_okcu_Click(object sender, EventArgs e)
        {
            int id = Bll.sinemaID();
            Bll.filmAdi("Okçu",id);
            OkcuFilmDetayi okcuFilmDetayi = new OkcuFilmDetayi();
            okcuFilmDetayi.Show();
        }

        private void btn_openheimer_Click(object sender, EventArgs e)
        {
            int id = Bll.sinemaID();
            Bll.filmAdi("Openheimer",id);
            OpenheimerFilmDetayi openheimerFilmDetayi = new OpenheimerFilmDetayi();
            openheimerFilmDetayi.Show();
        }

        private void btn_suikastcilar_Click(object sender, EventArgs e)
        {
            int id = Bll.sinemaID();
            Bll.filmAdi("Suikastçılar",id);
            SuikastcilarFilmDetayi suikastcilarFilmDetayi = new SuikastcilarFilmDetayi();
            suikastcilarFilmDetayi.Show();
        }

        private void btn_karaSövalye_Click(object sender, EventArgs e)
        {
            int id = Bll.sinemaID();
            Bll.filmAdi("Kara Şovalye",id);
            KaraSovalyeFilmDetayi karaSovalyeFilmDetayi = new KaraSovalyeFilmDetayi();
            karaSovalyeFilmDetayi.Show();
        }

        private void btn_killCommand_Click(object sender, EventArgs e)
        {
            int id = Bll.sinemaID();
            Bll.filmAdi("Kill Command",id);
            KillCommandFilmDetayi killCommandFilmDetayi = new KillCommandFilmDetayi();
            killCommandFilmDetayi.Show();
        }

        private void btn_JohnWick_Click(object sender, EventArgs e)
        {
            int id = Bll.sinemaID();
            Bll.filmAdi("John Wick 4",id);
            JohnWickFilmDetayi johnWickFilmDetayi = new JohnWickFilmDetayi();
            johnWickFilmDetayi.Show();

        }

        private void btn_Istasyon19_Click(object sender, EventArgs e)
        {
            int id = Bll.sinemaID();
            Bll.filmAdi("İstasyon 19",id);
            IstasyonOndokuz ıstasyonOndokuz = new IstasyonOndokuz();
            ıstasyonOndokuz.Show();
        }

        private void btn_koruyucu_Click(object sender, EventArgs e)
        {
            int id = Bll.sinemaID();
            Bll.filmAdi("Koruyucu",id);
            KoruyucuFilmDetayi koruyucuFilmDetayi = new KoruyucuFilmDetayi();
            koruyucuFilmDetayi.Show();
        }

        private void btn_tunnel_Click(object sender, EventArgs e)
        {
            int id = Bll.sinemaID();
            Bll.filmAdi("Tünel",id);
            TunnelFilmDetayi tunnelFilmDetayi = new TunnelFilmDetayi();
            tunnelFilmDetayi.Show();
        }
    }
}
