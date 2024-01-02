using OkulApp.MODEL;
using System;
using System.Data.SqlClient;
using System.Runtime.CompilerServices;
using DAL;

namespace OkulAppOgretmen.BLL
{
    public class OgretmenBL
    {

        private static Helper hlp;

        static OgretmenBL()
        {
            hlp = new Helper();
        }
        public bool OgretmenEkle(Ogrenci ogrt)
        {
            try
            {
                SqlParameter[] p = {
                             new SqlParameter("@Ad",ogrt.Ad2),
                             new SqlParameter("@Soyad",ogrt.Soyad2),
                             new SqlParameter("@TC",ogrt.TC)
                         };


                return hlp.ExecuteNonQuery("Insert into tblogretmen values(@Ad,@Soyad,@TC)", p) > 0;
            }
            catch (SqlException ex)
            {
                Console.WriteLine($"SQL Hata Kodu: {ex.Number}");
                Console.WriteLine($"Hata Mesajı: {ex.Message}");
                throw;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Hata Mesajı: {ex.Message}");
                throw;
            }

        }

        public bool OgretmenGuncelle(Ogrenci ogrt)
        {
            try
            {
                SqlParameter[] p = {
                             new SqlParameter("@Ad",ogrt.Ad2),
                             new SqlParameter("@Soyad",ogrt.Soyad2),
                             new SqlParameter("@TC",ogrt.TC),
                             new SqlParameter("@Ogrenciid",ogrt.Ogretmenid)
                         };


                return hlp.ExecuteNonQuery("UPDATE tblogretmen SET Ad = @Ad, Soyad = @Soyad WHERE TC = @TC", p) > 0;
            }
            catch (SqlException ex)
            {

                Console.WriteLine($"SQL Hata Kodu: {ex.Number}");
                Console.WriteLine($"Hata Mesajı: {ex.Message}");
                throw;
            }
        }

        public bool OgretmenSil(int id)
        {
            try
            {
                SqlParameter[] p = { new SqlParameter("@Ogretmenid", id) };

                return hlp.ExecuteNonQuery("Delete from tblogretmen where Ogretmenid=@Ogretmenid", p) > 0;
            }
            catch (SqlException ex)
            {

                Console.WriteLine($"SQL Hata Kodu: {ex.Number}");
                Console.WriteLine($"Hata Mesajı: {ex.Message}");
                throw;
            }
        }

        public Ogrenci OgretmenBul(string TC)
        {
            try
            {
                SqlParameter[] p = { new SqlParameter("@TC", TC) };

                var dr = hlp.ExecuteReader("Select Ogretmenid,Ad,Soyad,TC from tblogretmen where TC=@TC", p);
                Ogrenci ogrt = null;
                if (dr.Read())
                {
                    ogrt = new Ogrenci();
                    ogrt.Ogretmenid = Convert.ToInt32(dr["Ogretmenid"]);
                    ogrt.Ad2 = dr["Ad"].ToString();
                    ogrt.Soyad2 = dr["Soyad"].ToString();
                    ogrt.TC = dr["TC"].ToString();


                }
                dr.Close();

                return ogrt;
            }
            catch (SqlException ex)
            {
                Console.WriteLine($"SQL Hata Kodu: {ex.Number}");
                Console.WriteLine($"Hata Mesajı: {ex.Message}");
                throw;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Hata Mesajı: {ex.Message}");
                throw;
            }
        }
    }
}


//Helperda bulunan connection ve commandlerin dispose edilmesii (IDisposable Pattern)
//Öğretmen entity'si için kalan CRUD işemleri
