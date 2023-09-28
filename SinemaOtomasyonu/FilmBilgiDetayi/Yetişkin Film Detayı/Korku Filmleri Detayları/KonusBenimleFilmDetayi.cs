using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SinemaOtomasyonu.FilmBilgiDetayi.Yetişkin_Film_Detayı.Korku_Filmleri_Detayları
{
    public partial class KonusBenimleFilmDetayi : Form
    {
        public KonusBenimleFilmDetayi()
        {
            InitializeComponent();
        }

        private void btn_anasayfa_Click(object sender, EventArgs e)
        {
            SinemaAnaEkran sinemaAnaEkran = new SinemaAnaEkran();
            sinemaAnaEkran.Show();
            this.Close();
        }
    }
}
