using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SinemaOtomasyonu.FilmBilgiDetayi.Yetişkin_Film_Detayı.Drama_Film_Detayları
{
    public partial class AdaletFilmDetayi : Form
    {
        public AdaletFilmDetayi()
        {
            InitializeComponent();
        }

        private void AdaletFilmDetayi_Load(object sender, EventArgs e)
        {

        }

        private void btn_anasayfa_Click(object sender, EventArgs e)
        {
            SinemaAnaEkran sinemaAnaEkran = new SinemaAnaEkran();
            sinemaAnaEkran.Show();
            this.Close();
        }
    }
}
