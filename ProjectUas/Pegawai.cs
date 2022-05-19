using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace ProjectUas
{
    internal class Pegawai:Connection
    {
        /*protected String conString = ConfigurationManager.ConnectionStrings["dbcashier"].ConnectionString;
        static MySqlConnection conn;
        static MySqlCommand cmd;*/
       /* protected String conString = "server=localhost; database=db_project; uid=root; SslMode = none; AllowLoadLocalInfile=true";*/
        static MySqlConnection conn;
        static MySqlCommand cmd;
        

        public String nama { get; set; }
        public String id { get; set; }
        public String pendidikan { get; set; }
        public String tempat_lahir { get; set; }
        public String tanggal_lahir { get; set; }
        public String jenis_kelamin { get; set; }
        public String no_hp { get; set; }
        public String alamat { get; set; }
        public String image { get; set; }


        public Pegawai()
        {
            conn = new MySqlConnection(conString);
            cmd = new MySqlCommand();
        }

        public String Insert()
        {
            String error = null;
            conn.Open();
            cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "INSERT INTO data_pegawai (Nama,ID,Pendidikan,Tempat_lahir,Tanggal_Lahir,Jenis_Kelamin,Alamat,No_Hp,Gambar) " +
                "VALUES (@Nama,@ID,@Pendidikan,@Tempat_lahir,@Tanggal_Lahir,@Jenis_Kelamin,@Alamat,@No_Hp,@Gambar)";
            cmd.Parameters.AddWithValue("@Nama", this.nama);
            cmd.Parameters.AddWithValue("@ID", this.id);
            cmd.Parameters.AddWithValue("@Pendidikan", this.pendidikan);
            cmd.Parameters.AddWithValue("@Tempat_lahir", this.tempat_lahir);
            cmd.Parameters.AddWithValue("@Tanggal_Lahir", this.tanggal_lahir);
            cmd.Parameters.AddWithValue("@Jenis_Kelamin", this.jenis_kelamin);
            cmd.Parameters.AddWithValue("@Alamat", this.alamat);
            cmd.Parameters.AddWithValue("@No_Hp", this.no_hp);
            cmd.Parameters.AddWithValue("@Gambar", this.image);

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

        public static DataTable ReadAll()
        {
            DataTable dt = new DataTable();
            {
                /*cara1*/
                using (MySqlCommand cmd = new MySqlCommand("SELECT * FROM data_pegawai", conn))
                {
                    try
                    {
                        conn.Open();
                        MySqlDataReader rdr = cmd.ExecuteReader();
                        dt.Load(rdr);
                    }
                    catch (Exception e)
                    {
                        String error = e.Message; 
                    }
                    return dt;
                }

            }
        }

        public String Delete()
        {
            string result = null;
            using (MySqlCommand cmd = new MySqlCommand("DELETE FROM data_pegawai WHERE ID=@ID ", conn))
            {
                cmd.Parameters.AddWithValue("@ID", this.id);
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

        public String Update()
        {
            String result = null;
            using (MySqlCommand cmd = new MySqlCommand("UPDATE data_pegawai set Nama=@Nama" +
                "Pendidikan=@Pendidikan,Tempat_lahir=@Tempat_lahir,Tanggal_Lahir=@Tanggal_Lahir,Jenis_Kelamin=@Jenis_Kelamin" +
                "Alamat=@Alamat,No_Hp=@No_Hp,Gambar=@Gambar WHERE ID=@ID", conn))
            {
                cmd.Parameters.AddWithValue("@Nama", this.nama);
                cmd.Parameters.AddWithValue("@ID", this.id);
                cmd.Parameters.AddWithValue("@Pendidikan", this.pendidikan);
                cmd.Parameters.AddWithValue("@Tempat_lahir", this.tempat_lahir);
                cmd.Parameters.AddWithValue("@Tanggal_Lahir", this.tanggal_lahir);
                cmd.Parameters.AddWithValue("@Jenis_Kelamin", this.jenis_kelamin);
                cmd.Parameters.AddWithValue("@Alamat", this.alamat);
                cmd.Parameters.AddWithValue("@No_Hp", this.no_hp);
                cmd.Parameters.AddWithValue("@Gambar", this.image);
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

        public static DataTable select(String nama)
        {
            DataTable dt = new DataTable();
            cmd = conn.CreateCommand();
            if(nama != "")
            {
                cmd.CommandText = "SELECT * FROM data_pegawai WHERE Nama=@Nama";
                cmd.Parameters.AddWithValue("@Nama",nama);
            }else
            {
                cmd.CommandText = ("SELECT * FROM data_pegawai WHERE ID=@ID");
            }
            try
            {
                conn.Open();
                MySqlDataReader dr = cmd.ExecuteReader();
                dt.Load(dr);
                conn.Close();
            }catch (Exception e)
            {
                String error = e.Message;
            }
            return dt;
            
        }

    }
}
