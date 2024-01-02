
using System;
using System.Data.SqlClient;
using System.Configuration;

namespace DAL
{
    public class Helper
    {
        SqlConnection cn;
        SqlCommand cmd;
        string cstr = ConfigurationManager.ConnectionStrings["cstr"].ConnectionString;
        public int ExecuteNonQuery(string cmdtext, SqlParameter[] p = null)
        {
            try
            {
                using (cn = new SqlConnection(cstr))
                {
                    using (cmd = new SqlCommand(cmdtext, cn))
                    {
                        if (p != null)
                        {
                            cmd.Parameters.AddRange(p);
                        }
                        cn.Open();
                        return cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine($"SQL Hata Kodu: {ex.Number}");
                Console.WriteLine($"Hata Mesajı: {ex.Message}");
                throw;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Bilinmeyen Hata: {ex.Message}");
                throw;
            }
        }

        public SqlDataReader ExecuteReader(string cmdtext, SqlParameter[] p = null)
        {

            try
            {
                cn = new SqlConnection(cstr);
                cmd = new SqlCommand(cmdtext, cn);

                if (p != null)
                {
                    cmd.Parameters.AddRange(p);
                }
                cn.Open();
                return cmd.ExecuteReader(System.Data.CommandBehavior.CloseConnection);
            }
            catch (SqlException ex)
            {
                Console.WriteLine($"SQL Hata Kodu: {ex.Number}");
                Console.WriteLine($"Hata Mesajı: {ex.Message}");
                throw;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Bilinmeyen Hata: {ex.Message}");
                throw;
            }
        }
    }
}
