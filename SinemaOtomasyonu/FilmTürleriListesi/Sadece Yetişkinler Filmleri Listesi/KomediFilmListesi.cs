using Data.Core.BusinessLogicLayer;
using SinemaOtomasyonu.FilmBilgiDetayi.Yetişkin_Film_Detayı.Komedi_Film_Detayları;
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
    public partial class KomediFilmListesi : Form
    {
        SinemaSistemService Bll;
        public KomediFilmListesi()
        {
            InitializeComponent();
            Bll = new SinemaSistemService();
        }

        private void btn_mrBean_Click(object sender, EventArgs e)
        {
            int id = Bll.sinemaID();
            Bll.filmAdi("Mr Bean", id);
            MrBeanFilmDetayi mrBeanFilmDetayi = new MrBeanFilmDetayi();
            mrBeanFilmDetayi.Show();


        }

        private void btn_scaryMovie_Click(object sender, EventArgs e)
        {
            int id = Bll.sinemaID();
            Bll.filmAdi("Scary Movie",id);
            ScaryMovieFilmDetayi scaryMovieFilmDetayi = new ScaryMovieFilmDetayi();
            scaryMovieFilmDetayi.Show();
        }

        private void btn_Spy_Click(object sender, EventArgs e)
        {
            int id = Bll.sinemaID();
            Bll.filmAdi("Casus",id);
            AjanFilmDetayi ajanFilmDetayi = new AjanFilmDetayi();
            ajanFilmDetayi.Show();
        }

        private void btn_saskinDedektif_Click(object sender, EventArgs e)
        {
            int id = Bll.sinemaID();
            Bll.filmAdi("Şaşkın Dedektif", id);
            SaskinDedektifFilmDetayi saskinDedektifFilmDetayi = new SaskinDedektifFilmDetayi();
            saskinDedektifFilmDetayi.Show();
        }

        private void btn_cruella_Click(object sender, EventArgs e)
        {
            int id = Bll.sinemaID();
            Bll.filmAdi("Cruella",id);
            CruellaFilmDetayi cruellaFilmDetayi = new CruellaFilmDetayi();
            cruellaFilmDetayi.Show();
        }
    }
}
