using Data.Core.BusinessLogicLayer;
using SinemaOtomasyonu.FilmBilgiDetayi.Yetişkin_Film_Detayı.Drama_Film_Detayları;
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
    public partial class DramaFilmListesi : Form
    {
        SinemaSistemService Bll;
        public DramaFilmListesi()
        {
            InitializeComponent();
            Bll = new SinemaSistemService();
        }

        private void btn_esaretinBedeli_Click(object sender, EventArgs e)
        {
            int id = Bll.sinemaID();
            Bll.filmAdi("Esaretin Bedeli", id);
            EsaretinBedeliFilmDetayi esaretinBedeliFilmDetayi = new EsaretinBedeliFilmDetayi();
            esaretinBedeliFilmDetayi.Show();

        }

        private void btn_adalet_Click(object sender, EventArgs e)
        {
            int id = Bll.sinemaID();
            Bll.filmAdi("Adalet 3", id);
            AdaletFilmDetayi adaletFilmDetayi = new AdaletFilmDetayi();
            adaletFilmDetayi.Show();

        }

        private void btn_Dunkirk_Click(object sender, EventArgs e)
        {
            int id = Bll.sinemaID();
            Bll.filmAdi("Dunkirk",id);
            DunkirkFilmDetayi dunkirkFilmDetayi = new DunkirkFilmDetayi();
            dunkirkFilmDetayi.Show();
        }

        private void btn_SislerinIcinde_Click(object sender, EventArgs e)
        {
            int id = Bll.sinemaID();
            Bll.filmAdi("Sislerin İçinde", id);
            SislerinIcindeFilmDetayi sislerinIcindeFilmDetayi = new SislerinIcindeFilmDetayi();
            sislerinIcindeFilmDetayi.Show();
        }

        private void btn_Hugo_Click(object sender, EventArgs e)
        {
            int id = Bll.sinemaID();
            Bll.filmAdi("Hugo", id);
            HugoFilmDetayi hugoFilmDetayi = new HugoFilmDetayi();
            hugoFilmDetayi.Show();
        }

        private void btn_Leon_Click(object sender, EventArgs e)
        {
            int id = Bll.sinemaID();
            Bll.filmAdi("Leon", id);
            LeonFilmDetayi leonFilmDetayi = new LeonFilmDetayi();
            leonFilmDetayi.Show();
        }
    }
}
