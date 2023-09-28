using Data.Core.DatabaseLogicLayer;
using Data.Core.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Core.BusinessLogicLayer
{
    public class SinemaSistemService
    {
        SqlCommand cmd;
        SqlDataReader reader;
        string mevcutKoltuk;
        SistemKontrolDb Dll;
        List<SinemaIzleyiciKayitEkrani> izleyiciKayit;
        List<BiletAlIzleyiciKayit> izleyiciGelen;
        public SinemaSistemService()
        {
            Dll = new SistemKontrolDb();
        }

        public void koltukKayit(string koltukNo,int seansId)
        {
            cmd = new SqlCommand("insert into koltukKayit(koltukNo,seansId) Values(@koltukNo,@seansId)");
            cmd.Parameters.AddWithValue("@koltukNo", koltukNo);
            cmd.Parameters.AddWithValue("@seansId", seansId);
            Dll.koltukEkleme(cmd);


        }


        public int koltukSorgu(string koltukNo)
        {
            cmd = new SqlCommand("select * from koltukKayit where koltukNo=@koltukNo");
            cmd.Parameters.Add("koltukNo",System.Data.SqlDbType.NVarChar).Value = koltukNo;
            Dll = new SistemKontrolDb();

            reader=Dll.koltukSorgu(cmd);

            while (reader.Read())
            {
                mevcutKoltuk= reader.IsDBNull(1) ? string.Empty : reader.GetString(1);



            }

            reader.Close();
            Dll.baglantiAyarla();

            if (koltukNo == mevcutKoltuk)
            {
                return 1;


            }
            else
            {
                return 0;

            }

        }


        public int izleyiciSilinme(string koltukNom)
        {

            cmd = new SqlCommand("delete from izleyiciKayit where koltukNo=@koltukNumara ");
            cmd.Parameters.Add("@koltukNumara", SqlDbType.NVarChar).Value = koltukNom;


            return Dll.izleyiciSilme(cmd);


        }

        public void sinemaBilgiEkle(SinemaBilgi sinemaBilgi)
        {
            //şehir,mekan,film türü,etkinlik tarihi yollandı
      
            cmd = new SqlCommand("insert into sinemaBilgiKayit(Sehir,Mekan,FilmTürü,EtkinlikTarihi) Values(@sehir,@mekan,@filmTürü,@etkinlikTarihi) ");

            cmd.Parameters.AddWithValue("@sehir",sinemaBilgi.sehir);
            cmd.Parameters.AddWithValue("@mekan", sinemaBilgi.mekan);
            cmd.Parameters.AddWithValue("@filmTürü", sinemaBilgi.filmTür);
            cmd.Parameters.AddWithValue("@etkinlikTarihi", sinemaBilgi.etkinlikTarih);

            Dll.sinemaBilgiEkleme(cmd);



        }


        public void filmAdi(string filmAdi,int sinemaId)
        {
           
            cmd = new SqlCommand("insert into filmAdiKayit(FilmAdi,sinemaId) Values(@filmAdi,@sinemaId)");
            cmd.Parameters.AddWithValue("@filmAdi",filmAdi);
            cmd.Parameters.AddWithValue("@sinemaId",sinemaId);

            Dll.filmAdiEkleme(cmd);

        }

        public void salonSaat(string salon,string saat,int filmID)
        {

            cmd = new SqlCommand("insert into filmSalonSaatKayit(Salon,Saat,filmId) Values(@salon,@saat,@filmID)");
            cmd.Parameters.AddWithValue("@salon", salon);
            cmd.Parameters.AddWithValue("@saat", saat);
            cmd.Parameters.AddWithValue("@filmID", filmID);

            Dll.filmSalonSaatEkle(cmd);


        }

        public int sinemaID()
        {
            int ID=0;
            cmd = new SqlCommand("select sinemaId from sinemaBilgiKayit");
         
            reader=Dll.sinemaIDCek(cmd);
            while (reader.Read())
            {

                int  sinemaID = reader.IsDBNull(0) ? 0 : reader.GetInt32(0);

                ID = sinemaID;
            }
            reader.Close();
            Dll.baglantiAyarla();
            return ID;

        }

        public int filmID()
        {
            int ID = 0;
            cmd = new SqlCommand("select * from filmAdiKayit");

            reader = Dll.filmIDCek(cmd);
            while (reader.Read())
            {

                int filmID = reader.IsDBNull(0) ? 0 : reader.GetInt32(0);

                ID = filmID;
            }
            reader.Close();
            Dll.baglantiAyarla();
            return ID;

        }

        public int seansID()
        {
            int ID = 0;
            cmd = new SqlCommand("select * from filmSalonSaatKayit");

            reader = Dll.seansIDCek(cmd);
            while (reader.Read())
            {

                int seansID = reader.IsDBNull(0) ? 0 : reader.GetInt32(0);

                ID = seansID;
            }
            reader.Close();
            Dll.baglantiAyarla();
            return ID;

        }


        public List<SinemaIzleyiciKayitEkrani> izleyiciListe()
        {
            izleyiciKayit = new List<SinemaIzleyiciKayitEkrani>();
            cmd = new SqlCommand("select \r\nsbk.Sehir,sbk.Mekan,sbk.FilmTürü,sbk.EtkinlikTarihi,\r\nfak.FilmAdi,\r\nfssk.Saat,fssk.Salon,\r\nkk.koltukNo\r\n\r\nfrom sinemaBilgiKayit sbk\r\njoin filmAdiKayit fak\r\non sbk.sinemaId=fak.sinemaId\r\njoin filmSalonSaatKayit fssk\r\non fssk.filmId=fak.filmId\r\njoin koltukKayit kk\r\non kk.seansId=fssk.seansId");
            SqlDataReader reader = Dll.izleyiciBilgiCek(cmd);

            while (reader.Read())
            {
                izleyiciKayit.Add(new SinemaIzleyiciKayitEkrani()
                {
                    sehir = reader.IsDBNull(0) ? string.Empty : reader.GetString(0),
                    mekan = reader.IsDBNull(1) ? string.Empty : reader.GetString(1),
                    filmTürü = reader.IsDBNull(2) ? string.Empty : reader.GetString(2),
                    etkinlikTarihi = reader.IsDBNull(3) ? DateTime.MinValue : reader.GetDateTime(3),
                    filmAdi = reader.IsDBNull(4) ? string.Empty : reader.GetString(4),
                    saat = reader.IsDBNull(5) ? string.Empty : reader.GetString(5),
                    salonNo = reader.IsDBNull(6) ? string.Empty : reader.GetString(6),
                    koltukNo= reader.IsDBNull(7) ? string.Empty : reader.GetString(7)
                });


            }

            reader.Close();
            Dll.baglantiAyarla();
            return izleyiciKayit;



            ////
        }


        public int izleyiciSonKayit(BiletAlIzleyiciKayit liste)
        {

            cmd = new SqlCommand("insert into izleyiciSonKayit(TcKimlikNo,Adi,Soyadi,Telefon,Mail,FilmAdi,FilmTürü,FilmSaati,FilmTarihi,SalonNo,KoltukNo,Mekan,Sehir,Fiyat,Durum)" +
                " Values(@TcKimlikNo,@Adi,@Soyadi,@Telefon,@Mail,@FilmAdi,@FilmTürü,@FilmSaati,@FilmTarihi,@SalonNo,@KoltukNo,@Mekan,@Sehir,@Fiyat,@Durum)");

            cmd.Parameters.AddWithValue("@TcKimlikNo", liste.tc_kimlikNo);
            cmd.Parameters.AddWithValue("@Adi", liste.adi);
            cmd.Parameters.AddWithValue("@Soyadi", liste.soyadi);
            cmd.Parameters.AddWithValue("@Telefon", liste.telefon);
            cmd.Parameters.AddWithValue("@Mail", liste.mail);
            cmd.Parameters.AddWithValue("@FilmAdi", liste.filmAdi);
            cmd.Parameters.AddWithValue("@FilmTürü", liste.filmTürü);
            cmd.Parameters.AddWithValue("@FilmSaati", liste.filmSaati);
            cmd.Parameters.AddWithValue("@FilmTarihi", liste.filmTarihi);
            cmd.Parameters.AddWithValue("@SalonNo", liste.salonNo);
            cmd.Parameters.AddWithValue("@KoltukNo", liste.koltukNo);
            cmd.Parameters.AddWithValue("@Mekan", liste.mekan);
            cmd.Parameters.AddWithValue("@Sehir", liste.sehir);
            cmd.Parameters.AddWithValue("@Fiyat", liste.fiyat);
            cmd.Parameters.AddWithValue("@Durum", liste.Durum);

            return Dll.izleyiciKayit(cmd);

        }
        public List<BiletAlIzleyiciKayit> izleyiciGetir()
        {
            izleyiciGelen = new List<BiletAlIzleyiciKayit>();
            cmd = new SqlCommand("select * from izleyiciSonKayit");

            SqlDataReader reader = Dll.izleyiciGetirme(cmd);

            while (reader.Read())
            {
                izleyiciGelen.Add(new BiletAlIzleyiciKayit()
                {

                    tc_kimlikNo= reader.IsDBNull(0) ? string.Empty : reader.GetString(0),
                    adi= reader.IsDBNull(1) ? string.Empty : reader.GetString(1),
                    soyadi= reader.IsDBNull(2) ? string.Empty : reader.GetString(2),
                    telefon= reader.IsDBNull(3) ? string.Empty : reader.GetString(3),
                    mail= reader.IsDBNull(4) ? string.Empty : reader.GetString(4),
                    filmAdi= reader.IsDBNull(5) ? string.Empty : reader.GetString(5),
                    filmTürü= reader.IsDBNull(6) ? string.Empty : reader.GetString(6),
                    filmSaati= reader.IsDBNull(7) ? string.Empty : reader.GetString(7),
                    filmTarihi = reader.IsDBNull(8) ? DateTime.MinValue : reader.GetDateTime(8),
                    salonNo= reader.IsDBNull(9) ? string.Empty : reader.GetString(9),
                    koltukNo= reader.IsDBNull(10) ? string.Empty : reader.GetString(10),
                    mekan= reader.IsDBNull(11) ? string.Empty : reader.GetString(11),
                    sehir= reader.IsDBNull(12) ? string.Empty : reader.GetString(12),
                    fiyat= reader.IsDBNull(13) ? string.Empty : reader.GetString(13),
                    Durum= reader.IsDBNull(14) ? string.Empty : reader.GetString(14),
                  
                  
                });


            }

            reader.Close();
            Dll.baglantiAyarla();
            return izleyiciGelen;




        }

    }
}
