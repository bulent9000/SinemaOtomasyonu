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

namespace SinemaOtomasyonu.FilmBilgiDetayi.Yetişkin_Film_Detayı.Aksiyon_Filmleri_Detay
{
    public partial class OpenheimerFilmDetayi : Form
    {
        public OpenheimerFilmDetayi()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SinemaAnaEkran sinemaAnaEkran = new SinemaAnaEkran();
            sinemaAnaEkran.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenheimerFilmSaatleri openheimerFilmSaatleri = new OpenheimerFilmSaatleri();
            openheimerFilmSaatleri.Show();
            this.Hide();
        }
    }
}
