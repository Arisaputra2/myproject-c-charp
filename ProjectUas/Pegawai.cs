using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using MySql;
using System.Data;

namespace ProjectUas
{
    internal class Pegawai : Connection
    {
        public String nama { get; set; }
        public String id { get; set; }
        public String pendidikan { get; set; }
        public String tempat_lahir { get; set; }
        public String tanggal_lahir { get; set; }
        public String jenis_kelamin { get; set; }
        public String no_hp { get; set; }
        public String alamat { get; set; }
        public String image { get; set; }

        MySqlConnection conn;
        MySqlCommand cmd;

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
            /*cmd.Parameters.Add(new MySqlDataAdapter("@Gambar", image));*/

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

        public DataTable ReadAll()
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
                    catch (Exception )
                    {
                        
                    }
                    return dt;
                }

            }
        }
       /* public String login()
        {
            conn.Open();
            MySqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from user where username='"++"' and password = '"++"';
            conn.Clone();
        }*/

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

    }
}
