using Data.Core.BusinessLogicLayer;
using Data.Core.Entities;
using SinemaOtomasyonu.Aile_Film_Koltukları.Aslan_Kral_Film_Koltukları;
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
    public partial class Saatler : Form
    {
        SinemaSistemService Bll;
        List<saatler> saatler;

        public Saatler()
        {
            InitializeComponent();
            Bll = new SinemaSistemService();
        }



        #region aslan kral saatler
        private void cmb_salonlar_SelectedIndexChanged(object sender, EventArgs e)
        {

            saatler = new List<saatler>();


            if (cmb_salonlar.SelectedItem is "1")
            {
                saatler.Add(new saatler() { saat = "Saat seçiniz..." });
                saatler.Add(new saatler() { saat = "11:30" });                                    
                saatler.Add(new saatler() { saat = "13:00" });
                cmb_saatler.DataSource = saatler;
              
            }

            else if (cmb_salonlar.SelectedItem is "2")
            {
                saatler.Add(new saatler() { saat = "Saat seçiniz..." });
                saatler.Add(new saatler() { saat = "11:30" });             
                saatler.Add(new saatler() { saat = "15:00" });
                saatler.Add(new saatler() { saat = "16:30" });
                cmb_saatler.DataSource = saatler;



            }
            else if (cmb_salonlar.SelectedItem is "3")
            {

                saatler.Add(new saatler() { saat = "Saat seçiniz..." });
                saatler.Add(new saatler() { saat = "14:00" });
                saatler.Add(new saatler() { saat = "15:00" });               
                saatler.Add(new saatler() { saat = "19:00" });
      
                cmb_saatler.DataSource = saatler;

            }
            else if (cmb_salonlar.SelectedItem is "4")
            {
                saatler.Add(new saatler() { saat = "Saat seçiniz..." });
                saatler.Add(new saatler() { saat = "16:30" });
                saatler.Add(new saatler() { saat = "19:00" });
                cmb_saatler.DataSource = saatler;

            }

        }
        #endregion

        #region Aslan kral koltuk

        private void btn_aslanKralKoltukEkrani_Click(object sender, EventArgs e)
        {
           
            if (cmb_salonlar.Text == "1" && cmb_saatler.Text == "11:30")
            {

                int filmId=Bll.filmID();
                Bll.salonSaat(cmb_salonlar.Text, cmb_saatler.Text,filmId);
                SalonBirSaatOnbirOtuz salonBirSaatOnbirOtuz = new SalonBirSaatOnbirOtuz();
                salonBirSaatOnbirOtuz.Show();
                this.Hide();

            }
            else if (cmb_salonlar.Text == "1" && cmb_saatler.Text == "13:00")
            {
                int filmId = Bll.filmID();
                Bll.salonSaat(cmb_salonlar.Text, cmb_saatler.Text, filmId);
                SalonBirSaatOnüc salonBirSaatOnüc = new SalonBirSaatOnüc();
                salonBirSaatOnüc.Show();
                this.Hide();

            }

            else if (cmb_salonlar.Text == "2" && cmb_saatler.Text == "11:30")
            {
                int filmId = Bll.filmID();
                Bll.salonSaat(cmb_salonlar.Text, cmb_saatler.Text, filmId);
                SalonIkiSaatOnbirOtuz salonIkiSaatOnbirOtuz = new SalonIkiSaatOnbirOtuz();
                salonIkiSaatOnbirOtuz.Show();
                this.Hide();

            }
          
            else if (cmb_salonlar.Text == "2" && cmb_saatler.Text == "15:00")
            {

                int filmId = Bll.filmID();
                Bll.salonSaat(cmb_salonlar.Text, cmb_saatler.Text, filmId);
                SalonIkiSaatOnBes salonIkiSaatOnBes = new SalonIkiSaatOnBes();
                salonIkiSaatOnBes.Show();
                this.Hide();
            }
            else if (cmb_salonlar.Text == "2" && cmb_saatler.Text == "16:30")
            {
                int filmId = Bll.filmID();
                Bll.salonSaat(cmb_salonlar.Text, cmb_saatler.Text, filmId);
                SalonIkiSaatOnaltiOtuz salonIkiSaatOnaltiOtuz = new SalonIkiSaatOnaltiOtuz();
                salonIkiSaatOnaltiOtuz.Show();
                this.Hide();
                    
            }

            else if (cmb_salonlar.Text == "3" && cmb_saatler.Text == "14:00")
            {
                int filmId = Bll.filmID();
                Bll.salonSaat(cmb_salonlar.Text, cmb_saatler.Text, filmId);
                SalonUcSaatOndört salonUcSaatOndört = new SalonUcSaatOndört();
                salonUcSaatOndört.Show();
                this.Hide();

            }
            else if (cmb_salonlar.Text == "3" && cmb_saatler.Text == "15:00")
            {
                int filmId = Bll.filmID();
                Bll.salonSaat(cmb_salonlar.Text, cmb_saatler.Text, filmId);
                SalonUcSaatOnBes salonUcSaatOnBes = new SalonUcSaatOnBes();
                salonUcSaatOnBes.Show();
                this.Hide();



            }
            else if (cmb_salonlar.Text == "3" && cmb_saatler.Text == "19:00")
            {
                int filmId = Bll.filmID();
                Bll.salonSaat(cmb_salonlar.Text, cmb_saatler.Text, filmId);
                SalonUcSaatOndokuz salonUcSaatOndokuz = new SalonUcSaatOndokuz();
                salonUcSaatOndokuz.Show();
                this.Hide();

            }
            else if (cmb_salonlar.Text == "4" && cmb_saatler.Text == "16:30")
            {
                int filmId = Bll.filmID();
                Bll.salonSaat(cmb_salonlar.Text, cmb_saatler.Text, filmId);
                SalonDörtSaatOnaltiOtuz salonDörtSaatOnaltiOtuz = new SalonDörtSaatOnaltiOtuz();
                salonDörtSaatOnaltiOtuz.Show();
                this.Hide();


            }
            else if (cmb_salonlar.Text == "4" && cmb_saatler.Text == "19:00")
            {
                int filmId = Bll.filmID();
                Bll.salonSaat(cmb_salonlar.Text, cmb_saatler.Text, filmId);
                SalonDörtSaatOndokuz salonDörtSaatOndokuz = new SalonDörtSaatOndokuz();
                salonDörtSaatOndokuz.Show();
                this.Hide();
            }


        }

        #endregion
    }
}
