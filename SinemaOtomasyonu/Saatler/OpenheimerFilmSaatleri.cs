using Data.Core.BusinessLogicLayer;
using Data.Core.Entities;
using SinemaOtomasyonu.Aile_Film_Koltukları.Barbie_Film_Koltukları;
using SinemaOtomasyonu.Yetişkin_Film_Koltukları.Aksiyon_Film_Koltukları.Openheimer_Film_Koltukları;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SinemaOtomasyonu.Saatler
{
    public partial class OpenheimerFilmSaatleri : Form
    {
        SinemaSistemService Bll;
        List<saatler> saatler;
        public OpenheimerFilmSaatleri()
        {
            InitializeComponent();
            Bll = new SinemaSistemService();
        }

        private void cmb_salonlar_SelectedIndexChanged(object sender, EventArgs e)
        {
            saatler = new List<saatler>();


            if (cmb_salonlar.SelectedItem is "3")
            {
                saatler.Add(new saatler() { saat = "Saat seçiniz..." });
                saatler.Add(new saatler() { saat = "14:00" });
                saatler.Add(new saatler() { saat = "18:00" });
                saatler.Add(new saatler() { saat = "21:30" });
                cmb_saatler.DataSource = saatler;



            }

           
        }

        private void btn_OpenheimerKoltukEkrani_Click(object sender, EventArgs e)
        {
            if (cmb_salonlar.Text == "3" && cmb_saatler.Text == "14:00")
            {


                int filmId = Bll.filmID();
                Bll.salonSaat(cmb_salonlar.Text, cmb_saatler.Text, filmId);

                //Bu kısım değişecek
                OpenheimerSalUcOnDört salonUcSaatOnDört = new OpenheimerSalUcOnDört();
                salonUcSaatOnDört.Show();
                this.Hide();

            }

            else if (cmb_salonlar.Text == "3" && cmb_saatler.Text == "18:00")
            {

                int filmId = Bll.filmID();
                Bll.salonSaat(cmb_salonlar.Text, cmb_saatler.Text, filmId);
                OpenheimerSalUcOnsekiz salonUcSaatOnSekiz = new OpenheimerSalUcOnsekiz();
                salonUcSaatOnSekiz.Show();
                this.Hide();
            }
            else if (cmb_salonlar.Text == "3" && cmb_saatler.Text == "21:30")
            {
                int filmId = Bll.filmID();
                Bll.salonSaat(cmb_salonlar.Text, cmb_saatler.Text, filmId);
                OpenheimerSalUcYirmibirOtuz salonUcYirmiBirOtuz = new OpenheimerSalUcYirmibirOtuz();
                salonUcYirmiBirOtuz.Show();
                this.Hide();

            }
        }
    }
}
