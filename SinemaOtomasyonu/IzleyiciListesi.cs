using Data.Core.BusinessLogicLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SinemaOtomasyonu
{
    public partial class IzleyiciListesi : Form
    {
        SinemaSistemService service;
        public IzleyiciListesi()
        {
            InitializeComponent();
            service=new SinemaSistemService();
        }

        private void btn_listele_Click(object sender, EventArgs e)
        {
            dgw_izleyiciListe.DataSource=service.izleyiciGetir();



        }

        private void btn_kapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
