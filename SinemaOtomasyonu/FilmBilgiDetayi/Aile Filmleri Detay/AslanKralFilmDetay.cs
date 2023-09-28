using SinemaOtomasyonu.Saatler;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SinemaOtomasyonu.FilmBilgiDetayi.Aile_Filmleri_Detay
{
    public partial class AslanKralFilmDetay : Form
    {
        public AslanKralFilmDetay()
        {
            InitializeComponent();
        }

        private void btn_anasayfa_Click(object sender, EventArgs e)
        {
            SinemaAnaEkran sinemaAnaEkran = new SinemaAnaEkran();
            sinemaAnaEkran.Show();
            this.Close();


        }

        private void button1_Click(object sender, EventArgs e)
        {
            Saatler.Saatler saat = new Saatler.Saatler();
            saat.Show();
                
        }
    }
}
