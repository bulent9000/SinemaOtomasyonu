using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SinemaOtomasyonu.FilmBilgiDetayi.Yetişkin_Film_Detayı.Bilim_Kurgu_Filmleri_Detay
{
    public partial class AyinDüsüsüFilmDetayi : Form
    {
        public AyinDüsüsüFilmDetayi()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SinemaAnaEkran sinemaAnaEkran = new SinemaAnaEkran();
            sinemaAnaEkran.Show();
            this.Close();
        }
    }
}
