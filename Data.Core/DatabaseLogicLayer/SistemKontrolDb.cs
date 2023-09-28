using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Core.DatabaseLogicLayer
{
    public class SistemKontrolDb
    {

       int returnValue;
       public SqlConnection con;

        public SistemKontrolDb()
        {
            con = new SqlConnection(ConnectionStringOlustur());
        }


        public SqlDataReader koltukSorgu(SqlCommand cmd)
        {
          
            cmd.Connection = con;
            baglantiAyarla();
            return cmd.ExecuteReader();

        }


        public string ConnectionStringOlustur()
        {
            SqlConnectionStringBuilder build = new SqlConnectionStringBuilder();
            build.DataSource = "DESKTOP-1PBLKBH\\SQLEXPRESS";
            build.InitialCatalog = "SinemaOtomasyon";
            build.UserID = "sa";
            build.Password = "12345";
            return build.ConnectionString;

        }


        public void baglantiAyarla()
        {

            if (con.State== ConnectionState.Open)
            {

                con.Close();


            }
            else
            {
                con.Open();

            }

        }

        public int izleyiciSilme(SqlCommand cmd)
        {

            cmd.Connection = con;
            baglantiAyarla();
            returnValue = cmd.ExecuteNonQuery();
            baglantiAyarla();
            return returnValue;
        }

        public int sinemaBilgiEkleme(SqlCommand cmd)
        {

            cmd.Connection = con;
            baglantiAyarla();
            returnValue = cmd.ExecuteNonQuery();
            baglantiAyarla();
            return returnValue;


        }

        public int filmAdiEkleme(SqlCommand cmd)
        {

            cmd.Connection = con;
            baglantiAyarla();
            returnValue = cmd.ExecuteNonQuery();
            baglantiAyarla();
            return returnValue;


        }

        public int filmSalonSaatEkle(SqlCommand cmd)
        {

            cmd.Connection = con;
            baglantiAyarla();
            returnValue = cmd.ExecuteNonQuery();
            baglantiAyarla();
            return returnValue;


        }
        public int koltukEkleme(SqlCommand cmd)
        {

            cmd.Connection = con;
            baglantiAyarla();
            returnValue = cmd.ExecuteNonQuery();
            baglantiAyarla();
            return returnValue;


        }


        public SqlDataReader sinemaIDCek(SqlCommand cmd)
        {

            cmd.Connection = con;
            baglantiAyarla();
            return cmd.ExecuteReader();
            
        }

        public SqlDataReader filmIDCek(SqlCommand cmd)
        {

            cmd.Connection = con;
            baglantiAyarla();
            return cmd.ExecuteReader();

        }

        public SqlDataReader seansIDCek(SqlCommand cmd)
        {

            cmd.Connection = con;
            baglantiAyarla();
            return cmd.ExecuteReader();

        }

        public SqlDataReader izleyiciBilgiCek(SqlCommand cmd)
        {

            cmd.Connection = con;
            baglantiAyarla();
            return cmd.ExecuteReader();

        }

        public int izleyiciKayit(SqlCommand cmd)
        {
            cmd.Connection = con;
            baglantiAyarla();
            returnValue = cmd.ExecuteNonQuery();
            baglantiAyarla();
            return returnValue;


        }
        public SqlDataReader izleyiciGetirme(SqlCommand cmd)
        {

            cmd.Connection = con;
            baglantiAyarla();
            return cmd.ExecuteReader();

        }

    }
}
