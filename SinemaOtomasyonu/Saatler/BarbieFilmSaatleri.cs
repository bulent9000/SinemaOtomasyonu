using Data.Core.BusinessLogicLayer;
using Data.Core.Entities;
using SinemaOtomasyonu.Aile_Film_Koltukları.Aslan_Kral_Film_Koltukları;
using SinemaOtomasyonu.Aile_Film_Koltukları.Barbie_Film_Koltukları;
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
    public partial class BarbieFilmSaatleri : Form
    {
        SinemaSistemService Bll;
        List<saatler> saatler;
        public BarbieFilmSaatleri()
        {
            InitializeComponent();
            Bll = new SinemaSistemService();
        }
        #region Barbie koltuk ekranı
        private void btn_aslanKralKoltukEkrani_Click(object sender, EventArgs e)
        {

            //Barbi koltuk ekranı
      

            if (cmb_salonlar.Text == "2" && cmb_saatler.Text == "14:00")
            {

                
                int filmId = Bll.filmID();
                Bll.salonSaat(cmb_salonlar.Text, cmb_saatler.Text, filmId);

                //Bu kısım değişecek
                BarbieSalIkiSaatOndört salonIkiSaatOnDört = new BarbieSalIkiSaatOndört();
                salonIkiSaatOnDört.Show();
                this.Hide();

            }

            else if (cmb_salonlar.Text == "2" && cmb_saatler.Text == "18:00")
            {

                int filmId = Bll.filmID();
                Bll.salonSaat(cmb_salonlar.Text, cmb_saatler.Text, filmId);
                BarbieSalIkiSaatOnsekiz salonIkiSaatOnSekiz = new BarbieSalIkiSaatOnsekiz();
                salonIkiSaatOnSekiz.Show();
                this.Hide();
            }
            else if (cmb_salonlar.Text == "2" && cmb_saatler.Text == "21:30")
            {
                int filmId = Bll.filmID();
                Bll.salonSaat(cmb_salonlar.Text, cmb_saatler.Text, filmId);
                BarbieSalIkiYirmiBirOtuz salonIkiYirmiBirOtuz = new BarbieSalIkiYirmiBirOtuz();
                salonIkiYirmiBirOtuz.Show();
                this.Hide();

            }

       
            else if (cmb_salonlar.Text == "4" && cmb_saatler.Text == "15:00")
            {
                int filmId = Bll.filmID();
                Bll.salonSaat(cmb_salonlar.Text, cmb_saatler.Text, filmId);
                BarbieSalDörtOnbes salonDörtOnbes = new BarbieSalDörtOnbes();
                salonDörtOnbes.Show();
                this.Hide();


            }
            else if (cmb_salonlar.Text == "4" && cmb_saatler.Text == "20:30")
            {
                int filmId = Bll.filmID();
                Bll.salonSaat(cmb_salonlar.Text, cmb_saatler.Text, filmId);
                BarbieSalDörtYirmiOtuz salonDörtYirmiOtuz = new BarbieSalDörtYirmiOtuz();
                salonDörtYirmiOtuz.Show();
                this.Hide();
            }


        }
        #endregion
        #region Salonlar
        private void cmb_salonlar_SelectedIndexChanged(object sender, EventArgs e)
        {
            saatler = new List<saatler>();


            if (cmb_salonlar.SelectedItem is "2")
            {
                saatler.Add(new saatler() { saat = "Saat seçiniz..." });
                saatler.Add(new saatler() { saat = "14:00" });
                saatler.Add(new saatler() { saat = "18:00" });
                saatler.Add(new saatler() { saat = "21:30" });
                cmb_saatler.DataSource = saatler;



            }
         
            else if (cmb_salonlar.SelectedItem is "4")
            {
                saatler.Add(new saatler() { saat = "Saat seçiniz..." });
                saatler.Add(new saatler() { saat = "15:00" });
                saatler.Add(new saatler() { saat = "20:30" });
                cmb_saatler.DataSource = saatler;

            }
        }
        #endregion
    }


}


