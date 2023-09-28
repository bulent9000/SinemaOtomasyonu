using Data.Core.BusinessLogicLayer;
using SinemaOtomasyonu.FilmBilgiDetayi.Aile_Filmleri_Detay;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SinemaOtomasyonu.FilmTürleriListesi.Aile_Filmleri
{
    public partial class AileFilmListesi : Form
    {
        SinemaSistemService Bll;
        public AileFilmListesi()
        {
            InitializeComponent();
            Bll = new SinemaSistemService();
        }

        private void btn_aslanKral_Click(object sender, EventArgs e)
        {
           
            int id=Bll.sinemaID();
            Bll.filmAdi("Aslan Kral",id);


            AslanKralFilmDetay aslanKralFilmDetay = new AslanKralFilmDetay();
            aslanKralFilmDetay.Show();
        }

        private void btn_barbie_Click(object sender, EventArgs e)
        {
            int id = Bll.sinemaID();
            Bll.filmAdi("Barbie", id);
            BarbieFilmDetayi barbieFilmDetayi = new BarbieFilmDetayi();
            barbieFilmDetayi.Show();
        }

        private void btn_doru_Click(object sender, EventArgs e)
        {
            int id = Bll.sinemaID();
            Bll.filmAdi("Doru", id);
            DoruFilmDetayi doruFilmDetayi = new DoruFilmDetayi();
            doruFilmDetayi.Show();
        }

        private void btn_örümcekAdam_Click(object sender, EventArgs e)
        {
            int id = Bll.sinemaID();
            Bll.filmAdi("Örümcek Adam", id);
            OrümcekAdamFilmDetay orümcekAdamFilmDetay = new OrümcekAdamFilmDetay();
            orümcekAdamFilmDetay.Show();
        }

        private void btn_OrmanınCocugu_Click(object sender, EventArgs e)
        {
            int id = Bll.sinemaID();
            Bll.filmAdi("Ormanın Çocuğu", id);
            OrmanCocuguFilmDetayi ormanCocuguFilmDetayi = new OrmanCocuguFilmDetayi();
            ormanCocuguFilmDetayi.Show();
        }

        private void btn_uzayKöpekleri_Click(object sender, EventArgs e)
        {
            int id = Bll.sinemaID();
            Bll.filmAdi("Uzay Köpekleri", id);
            UzayKöpekleriFilmDetay uzayKöpekleriFilmDetay = new UzayKöpekleriFilmDetay();
            uzayKöpekleriFilmDetay.Show();
        }

        private void btn_ninjaKaplumbagalar_Click(object sender, EventArgs e)
        {
            int id = Bll.sinemaID();
            Bll.filmAdi("Ninja Kaplumbağalar", id);
            NinjaKaplumbagaFilmDetayi ninjaKaplumbagaFilmDetayi = new NinjaKaplumbagaFilmDetayi();
            ninjaKaplumbagaFilmDetayi.Show();
        }

        private void btn_KarlarUlkesi_Click(object sender, EventArgs e)
        {
            int id = Bll.sinemaID();
            Bll.filmAdi("Karlar Ülkesi", id);
            KarlarUlkesiFilmDetayi karlarUlkesiFilmDetayi = new KarlarUlkesiFilmDetayi();
            karlarUlkesiFilmDetayi.Show();
        }

        private void btn_ScoobyDoo_Click(object sender, EventArgs e)
        {
            int id = Bll.sinemaID();
            Bll.filmAdi("Scooby Doo",id);
            ScoobyDooFilmDetay scoobyDooFilmDetay = new ScoobyDooFilmDetay();
            scoobyDooFilmDetay.Show();
        }

        private void btn_öksüzKiz_Click(object sender, EventArgs e)
        {
            int id = Bll.sinemaID();
            Bll.filmAdi("Öksüz Kız",id);
            OksüzKizFilmDetayi oksüzKizFilmDetayi = new OksüzKizFilmDetayi();
            oksüzKizFilmDetayi.Show();
        }
    }
}
