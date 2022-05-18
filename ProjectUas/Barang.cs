using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace ProjectUas
{
    internal class Barang:Connection
    {
        /*protected String conString = ConfigurationManager.ConnectionStrings["dbcashier"].ConnectionString;*/
         MySqlConnection conn;
         MySqlCommand cmd;

        public int Id { get; set; }
        public String Kode { get; set; }
        public String Nama { get; set; }
        public int Jumlah { get; set; }
        public String Harga { get; set; }
        public String Gambar { get; set; }


        public Barang()
        {
            conn = new MySqlConnection(conString);
            cmd = new MySqlCommand();
        }

       /* public static DataTab
        {

        }*/

        public DataTable SelectAll()
        {
            DataTable dt = new DataTable();
            //cara 1
            using (MySqlCommand cmd = new MySqlCommand("SELECT * FROM data_barang", conn))
            {
                try
                {
                    conn.Open();
                    MySqlDataReader rdr = cmd.ExecuteReader();
                    dt.Load(rdr);
                    conn.Close();
                }
                catch (Exception e)
                {
                    String error = e.Message;
                }
            }
            return dt;

        }

        public String Insert()
        {
            String error = null;
            conn.Open();
            cmd = conn.CreateCommand();
            cmd.CommandText = "INSERT INTO data_barang (id_barang,kode_barang,nama_barang,jumlah_barang,harga_barang,gambar_barang) " +
                "VALUES (@,@kode_barang,@nama_barang,@jumlah_barang,@harga_barang,@gambar_barang)";
            cmd.Parameters.AddWithValue("@id_barang", this.Id);
            cmd.Parameters.AddWithValue("@kode_barang",this.Kode);
            cmd.Parameters.AddWithValue("@nama_barang", this.Nama);
            cmd.Parameters.AddWithValue("@jumlah_barang", this.Jumlah);
            cmd.Parameters.AddWithValue("@harga_barang", this.Harga);
            cmd.Parameters.AddWithValue("@gambar_barang", this.Gambar);

            try
            {
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception e)
            {
                error = e.Message;
            }
            return error;
        }

        public String Delete()
        {
            string result = null;
            using (MySqlCommand cmd = new MySqlCommand("DELETE FROM data_barang WHERE id_barang=@id_barang ", conn))
            {
                cmd.Parameters.AddWithValue("id_barang", this.Id);
                try
                {
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();
                }
                catch (Exception e)
                {
                    return e.Message;
                }
            }
            return result;
        }

        /*public String select()
        {
            DataTable dt = new DataTable();
            cmd = conn.CreateCommand();
            if (nm_pegawai != "")
            {
                cmd.CommandText = "SELECT a.*,b.nm_jabatan FROM pegawai a LEFT JOIN jabatan b ON a.id_jabatan = b.id_jabatan WHERE a.nm_pegawai=@nm_pegawai";
                cmd.Parameters.AddWithValue("@nm_pegawai", nm_pegawai);
            }
            else cmd.CommandText = "SELECT a.*,b.nm_jabatan FROM pegawai a LEFT JOIN jabatan b ON a.id_jabatan = b.id_jabatan";
            try
            {
                conn.Open();
                MySqlDataReader rdr = cmd.ExecuteReader();
                dt.Load(rdr);
                conn.Close();
            }
            catch (Exception e)
            {
                String error = e.Message;
            }
            return dt;
        }*/
    }
}
