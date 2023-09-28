using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SinemaOtomasyonu.Aile_Film_Koltukları.Aslan_Kral_Film_Koltukları
{
    public partial class SalonUcSaatOnBes : Form
    {
        Data.Core.BusinessLogicLayer.SinemaSistemService service;
        string koltukN;
        int sonuc;
        public SalonUcSaatOnBes()
        {
            InitializeComponent();
            service = new Data.Core.BusinessLogicLayer.SinemaSistemService();
        }

        private void btn_1_Click(object sender, EventArgs e)
        {

            koltukN = btn_1.Text;
            koltukSorgu(koltukN, sender);
            renkDegis(sender);
            IzleyiciKayitEkrani ek = new IzleyiciKayitEkrani();
            ek.Show();
        }
        private void koltukSorgu(string koltukNum, object sender)
        {



            if (koltukNum.Length == 8)   //Oda numarası tek haneli ise
            {
                char deger = koltukNum[7];
                koltukNum = Convert.ToString(deger);


            }
            else if (koltukNum.Length == 9)   //koltuk numarası iki haneli ise
            {
                char deger1 = koltukNum[7];
                string ikiHane1 = Convert.ToString(deger1);

                char deger2 = koltukNum[8];
                string ikiHane2 = Convert.ToString(deger2);


                koltukNum = ikiHane1 + ikiHane2;
            }

            service = new Data.Core.BusinessLogicLayer.SinemaSistemService();

            sonuc = service.koltukSorgu(koltukNum);

            if (sonuc > 0)
            {

                MessageBox.Show("Bu koltuğa izleyici kayıtlıdır", "Uyarı",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                DialogResult result = MessageBox.Show("Yeni Kayıt için mevcut izleyiciyi silmek ister misiniz?", "Soru",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    service = new Data.Core.BusinessLogicLayer.SinemaSistemService();
                    izleyiciSilme(koltukNum);
                    renkDegis(sender);

                    int seansId = service.seansID();
                    service.koltukKayit(koltukNum, seansId);

                }
                else
                {
                    this.Close();

                }
            }
            else
            {


                service = new Data.Core.BusinessLogicLayer.SinemaSistemService();
                int seansId = service.seansID();
                service.koltukKayit(koltukNum, seansId);

                renkDegis(sender);

            }



        }
        private void izleyiciSilme(string koltukNumara)
        {
            DialogResult result = MessageBox.Show("Müşteri silinecektir onaylıyor musunuz?", "Bildirim", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                service = new Data.Core.BusinessLogicLayer.SinemaSistemService();
                int silinmeBilgi = service.izleyiciSilinme(koltukNumara);
                if (silinmeBilgi > 0)
                {

                    MessageBox.Show("İzleyici silindi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);


                }
                else
                {
                    MessageBox.Show("Silme işlemi başarısız", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }



            }
            else
            {
                this.Close();
            }
        }

        private void renkDegis(object sender)
        {

            Control ctrl = ((Control)sender);
            switch (ctrl.BackColor.Name)
            {
                case "Red":
                    ctrl.BackColor = Color.Green;
                    break;
                case "Green":
                    ctrl.BackColor = Color.Red;
                    break;

                default:
                    ctrl.BackColor = Color.Green;
                    break;
            }
        }

        #region Koltuklar
        private void btn_2_Click(object sender, EventArgs e)
        {
            koltukN = btn_2.Text;
            koltukSorgu(koltukN, sender);
            renkDegis(sender);
            IzleyiciKayitEkrani ek = new IzleyiciKayitEkrani();
            ek.Show();
        }

        private void btn_3_Click(object sender, EventArgs e)
        {
            koltukN = btn_3.Text;
            koltukSorgu(koltukN, sender);
            renkDegis(sender);
            IzleyiciKayitEkrani ek = new IzleyiciKayitEkrani();
            ek.Show();
        }

        private void btn_4_Click(object sender, EventArgs e)
        {
            koltukN = btn_4.Text;
            koltukSorgu(koltukN, sender);
            renkDegis(sender);
            IzleyiciKayitEkrani ek = new IzleyiciKayitEkrani();
            ek.Show();
        }

        private void btn_5_Click(object sender, EventArgs e)
        {
            koltukN = btn_5.Text;
            koltukSorgu(koltukN, sender);
            renkDegis(sender);
            IzleyiciKayitEkrani ek = new IzleyiciKayitEkrani();
            ek.Show();
        }

        private void btn_6_Click(object sender, EventArgs e)
        {
            koltukN = btn_6.Text;
            koltukSorgu(koltukN, sender);
            renkDegis(sender);
            IzleyiciKayitEkrani ek = new IzleyiciKayitEkrani();
            ek.Show();
        }

        private void btn_7_Click(object sender, EventArgs e)
        {
            koltukN = btn_7.Text;
            koltukSorgu(koltukN, sender);
            renkDegis(sender);
            IzleyiciKayitEkrani ek = new IzleyiciKayitEkrani();
            ek.Show();
        }

        private void btn_8_Click(object sender, EventArgs e)
        {
            koltukN = btn_8.Text;
            koltukSorgu(koltukN, sender);
            renkDegis(sender);
            IzleyiciKayitEkrani ek = new IzleyiciKayitEkrani();
            ek.Show();
        }

        private void btn_9_Click(object sender, EventArgs e)
        {
            koltukN = btn_9.Text;
            koltukSorgu(koltukN, sender);
            renkDegis(sender);
            IzleyiciKayitEkrani ek = new IzleyiciKayitEkrani();
            ek.Show();
        }

        private void btn_10_Click(object sender, EventArgs e)
        {
            koltukN = btn_10.Text;
            koltukSorgu(koltukN, sender);
            renkDegis(sender);
            IzleyiciKayitEkrani ek = new IzleyiciKayitEkrani();
            ek.Show();
        }

        private void btn_11_Click(object sender, EventArgs e)
        {
            koltukN = btn_11.Text;
            koltukSorgu(koltukN, sender);
            renkDegis(sender);
            IzleyiciKayitEkrani ek = new IzleyiciKayitEkrani();
            ek.Show();
        }

        private void btn_12_Click(object sender, EventArgs e)
        {
            koltukN = btn_12.Text;
            koltukSorgu(koltukN, sender);
            renkDegis(sender);
            IzleyiciKayitEkrani ek = new IzleyiciKayitEkrani();
            ek.Show();
        }

        private void btn_13_Click(object sender, EventArgs e)
        {
            koltukN = btn_13.Text;
            koltukSorgu(koltukN, sender);
            renkDegis(sender);
            IzleyiciKayitEkrani ek = new IzleyiciKayitEkrani();
            ek.Show();
        }

        private void btn_14_Click(object sender, EventArgs e)
        {
            koltukN = btn_14.Text;
            koltukSorgu(koltukN, sender);
            renkDegis(sender);
            IzleyiciKayitEkrani ek = new IzleyiciKayitEkrani();
            ek.Show();
        }

        private void btn_15_Click(object sender, EventArgs e)
        {
            koltukN = btn_15.Text;
            koltukSorgu(koltukN, sender);
            renkDegis(sender);
            IzleyiciKayitEkrani ek = new IzleyiciKayitEkrani();
            ek.Show();
        }

        private void btn_16_Click(object sender, EventArgs e)
        {
            koltukN = btn_16.Text;
            koltukSorgu(koltukN, sender);
            renkDegis(sender);
            IzleyiciKayitEkrani ek = new IzleyiciKayitEkrani();
            ek.Show();
        }

        private void btn_17_Click(object sender, EventArgs e)
        {
            koltukN = btn_17.Text;
            koltukSorgu(koltukN, sender);
            renkDegis(sender);
            IzleyiciKayitEkrani ek = new IzleyiciKayitEkrani();
            ek.Show();
        }

        private void btn_18_Click(object sender, EventArgs e)
        {
            koltukN = btn_18.Text;
            koltukSorgu(koltukN, sender);
            renkDegis(sender);
            IzleyiciKayitEkrani ek = new IzleyiciKayitEkrani();
            ek.Show();
        }

        private void btn_19_Click(object sender, EventArgs e)
        {
            koltukN = btn_19.Text;
            koltukSorgu(koltukN, sender);
            renkDegis(sender);
            IzleyiciKayitEkrani ek = new IzleyiciKayitEkrani();
            ek.Show();
        }

        private void btn_20_Click(object sender, EventArgs e)
        {
            koltukN = btn_20.Text;
            koltukSorgu(koltukN, sender);
            renkDegis(sender);
            IzleyiciKayitEkrani ek = new IzleyiciKayitEkrani();
            ek.Show();
        }

        private void btn_21_Click(object sender, EventArgs e)
        {
            koltukN = btn_21.Text;
            koltukSorgu(koltukN, sender);
            renkDegis(sender);
            IzleyiciKayitEkrani ek = new IzleyiciKayitEkrani();
            ek.Show();
        }

        private void btn_22_Click(object sender, EventArgs e)
        {
            koltukN = btn_22.Text;
            koltukSorgu(koltukN, sender);
            renkDegis(sender);
            IzleyiciKayitEkrani ek = new IzleyiciKayitEkrani();
            ek.Show();
        }

        private void btn_23_Click(object sender, EventArgs e)
        {
            koltukN = btn_23.Text;
            koltukSorgu(koltukN, sender);
            renkDegis(sender);
            IzleyiciKayitEkrani ek = new IzleyiciKayitEkrani();
            ek.Show();
        }

        private void btn_24_Click(object sender, EventArgs e)
        {
            koltukN = btn_24.Text;
            koltukSorgu(koltukN, sender);
            renkDegis(sender);
            IzleyiciKayitEkrani ek = new IzleyiciKayitEkrani();
            ek.Show();
        }

        private void btn_25_Click(object sender, EventArgs e)
        {
            koltukN = btn_25.Text;
            koltukSorgu(koltukN, sender);
            renkDegis(sender);
            IzleyiciKayitEkrani ek = new IzleyiciKayitEkrani();
            ek.Show();
        }

        private void btn_26_Click(object sender, EventArgs e)
        {
            koltukN = btn_26.Text;
            koltukSorgu(koltukN, sender);
            renkDegis(sender);
            IzleyiciKayitEkrani ek = new IzleyiciKayitEkrani();
            ek.Show();
        }

        private void btn_27_Click(object sender, EventArgs e)
        {
            koltukN = btn_27.Text;
            koltukSorgu(koltukN, sender);
            renkDegis(sender);
            IzleyiciKayitEkrani ek = new IzleyiciKayitEkrani();
            ek.Show();
        }

        private void btn_28_Click(object sender, EventArgs e)
        {
            koltukN = btn_28.Text;
            koltukSorgu(koltukN, sender);
            renkDegis(sender);
            IzleyiciKayitEkrani ek = new IzleyiciKayitEkrani();
            ek.Show();
        }

        private void btn_29_Click(object sender, EventArgs e)
        {
            koltukN = btn_29.Text;
            koltukSorgu(koltukN, sender);
            renkDegis(sender);
            IzleyiciKayitEkrani ek = new IzleyiciKayitEkrani();
            ek.Show();
        }

        private void btn_30_Click(object sender, EventArgs e)
        {
            koltukN = btn_30.Text;
            koltukSorgu(koltukN, sender);
            renkDegis(sender);
            IzleyiciKayitEkrani ek = new IzleyiciKayitEkrani();
            ek.Show();
        }

        private void btn_31_Click(object sender, EventArgs e)
        {
            koltukN = btn_31.Text;
            koltukSorgu(koltukN, sender);
            renkDegis(sender);
            IzleyiciKayitEkrani ek = new IzleyiciKayitEkrani();
            ek.Show();
        }

        private void btn_32_Click(object sender, EventArgs e)
        {
            koltukN = btn_32.Text;
            koltukSorgu(koltukN, sender);
            renkDegis(sender);
            IzleyiciKayitEkrani ek = new IzleyiciKayitEkrani();
            ek.Show();
        }

        private void btn_33_Click(object sender, EventArgs e)
        {
            koltukN = btn_33.Text;
            koltukSorgu(koltukN, sender);
            renkDegis(sender);
            IzleyiciKayitEkrani ek = new IzleyiciKayitEkrani();
            ek.Show();
        }

        private void btn_34_Click(object sender, EventArgs e)
        {
            koltukN = btn_34.Text;
            koltukSorgu(koltukN, sender);
            renkDegis(sender);
            IzleyiciKayitEkrani ek = new IzleyiciKayitEkrani();
            ek.Show();
        }

        private void btn_35_Click(object sender, EventArgs e)
        {
            koltukN = btn_35.Text;
            koltukSorgu(koltukN, sender);
            renkDegis(sender);
            IzleyiciKayitEkrani ek = new IzleyiciKayitEkrani();
            ek.Show();
        }

        private void btn_36_Click(object sender, EventArgs e)
        {
            koltukN = btn_36.Text;
            koltukSorgu(koltukN, sender);
            renkDegis(sender);
            IzleyiciKayitEkrani ek = new IzleyiciKayitEkrani();
            ek.Show();
        }

        private void btn_37_Click(object sender, EventArgs e)
        {
            koltukN = btn_37.Text;
            koltukSorgu(koltukN, sender);
            renkDegis(sender);
            IzleyiciKayitEkrani ek = new IzleyiciKayitEkrani();
            ek.Show();
        }

        private void btn_38_Click(object sender, EventArgs e)
        {
            koltukN = btn_38.Text;
            koltukSorgu(koltukN, sender);
            renkDegis(sender);
            IzleyiciKayitEkrani ek = new IzleyiciKayitEkrani();
            ek.Show();
        }

        private void btn_39_Click(object sender, EventArgs e)
        {
            koltukN = btn_39.Text;
            koltukSorgu(koltukN, sender);
            renkDegis(sender);
            IzleyiciKayitEkrani ek = new IzleyiciKayitEkrani();
            ek.Show();
        }

        private void btn_40_Click(object sender, EventArgs e)
        {
            koltukN = btn_40.Text;
            koltukSorgu(koltukN, sender);
            renkDegis(sender);
            IzleyiciKayitEkrani ek = new IzleyiciKayitEkrani();
            ek.Show();
        }

        private void btn_41_Click(object sender, EventArgs e)
        {
            koltukN = btn_41.Text;
            koltukSorgu(koltukN, sender);
            renkDegis(sender);
            IzleyiciKayitEkrani ek = new IzleyiciKayitEkrani();
            ek.Show();
        }

        private void btn_42_Click(object sender, EventArgs e)
        {
            koltukN = btn_42.Text;
            koltukSorgu(koltukN, sender);
            renkDegis(sender);
            IzleyiciKayitEkrani ek = new IzleyiciKayitEkrani();
            ek.Show();
        }

        private void btn_43_Click(object sender, EventArgs e)
        {
            koltukN = btn_43.Text;
            koltukSorgu(koltukN, sender);
            renkDegis(sender);
            IzleyiciKayitEkrani ek = new IzleyiciKayitEkrani();
            ek.Show();
        }
        #endregion
    }
}
