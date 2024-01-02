using OkulApp.MODEL;
using System;
using System.Data.SqlClient;
using System.Runtime.CompilerServices;
using DAL;

namespace OkulApp.BLL
{
    public class OgrenciBL
    {

        private static Helper hlp;

        static OgrenciBL()
        {
            hlp = new Helper();
        }
        public bool OgrenciEkle(Ogrenci ogr)
        {
            try
            {
                SqlParameter[] p = {
                             new SqlParameter("@Ad",ogr.Ad),
                             new SqlParameter("@Soyad",ogr.Soyad),
                             new SqlParameter("@Numara",ogr.Numara)
                         };


                return hlp.ExecuteNonQuery("Insert into tblogrenci values(@Ad,@Soyad,@Numara)", p) > 0;
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

        public bool OgrenciGuncelle(Ogrenci ogr)
        {
            try
            {
                SqlParameter[] p = {
                             new SqlParameter("@Ad",ogr.Ad),
                             new SqlParameter("@Soyad",ogr.Soyad),
                             new SqlParameter("@Numara",ogr.Numara),
                             new SqlParameter("@Ogrenciid",ogr.Ogrenciid)
                         };


                return hlp.ExecuteNonQuery("UPDATE tblogrenci SET Ad = @Ad, Soyad = @Soyad WHERE Numara = @Numara", p) > 0;
            }
            catch (SqlException ex)
            {

                Console.WriteLine($"SQL Hata Kodu: {ex.Number}");
                Console.WriteLine($"Hata Mesajı: {ex.Message}");
                throw;
            }
        }

        public bool OgrenciSil(int id)
        {
            try
            {
                SqlParameter[] p = { new SqlParameter("@Ogrenciid", id) };

                return hlp.ExecuteNonQuery("Delete from tblogrenci where Ogrenciid=@Ogrenciid", p) > 0;
            }
            catch (SqlException ex)
            {

                Console.WriteLine($"SQL Hata Kodu: {ex.Number}");
                Console.WriteLine($"Hata Mesajı: {ex.Message}");
                throw;
            }
        }

        public Ogrenci OgrenciBul(string numara)
        {
            try
            {
                SqlParameter[] p = { new SqlParameter("@Numara", numara) };

                var dr = hlp.ExecuteReader("Select Ogrenciid,Ad,Soyad,Numara from tblogrenci where Numara=@Numara", p);
                Ogrenci ogr = null;
                if (dr.Read())
                {
                    ogr = new Ogrenci();
                    ogr.Ogrenciid = Convert.ToInt32(dr["Ogrenciid"]);
                    ogr.Ad = dr["Ad"].ToString();
                    ogr.Soyad = dr["Soyad"].ToString();
                    ogr.Numara = dr["Numara"].ToString();


                }
                dr.Close();

                return ogr;
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
