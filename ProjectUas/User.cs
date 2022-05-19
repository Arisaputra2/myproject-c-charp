using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace ProjectUas
{
    internal class User:Connection
    {
       /* protected String conString = "server=localhost; database=db_project; uid=root; SslMode = none; AllowLoadLocalInfile=true";*/
        static MySqlConnection conn;
        static MySqlCommand cmd;

        public String username { get; set; }
        public String password { get; set; }

        public User()
        {
            conn = new MySqlConnection(conString);
            cmd = new MySqlCommand();
        }

        public bool validasi()
        {
            bool result = false;
            conn.Open();
            cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT * FROM user WHERE username=@username AND password=md5(@password)";
            cmd.Parameters.AddWithValue("@username", this.username);
            cmd.Parameters.AddWithValue("@password", this.password);
            try
            {
                MySqlDataReader rdr = cmd.ExecuteReader();
                if (rdr.HasRows)
                {
                    rdr.Read();
                    //user = new User(Convert.ToInt16(rdr["id_user"]), rdr["username"].ToString(), rdr["password"].ToString(), Convert.ToInt16(rdr["id_pegawai"]), Convert.ToInt16(rdr["role"]));
                    /*id_user = Convert.ToInt16(rdr["id_user"]);
                    id_pegawai = Convert.ToInt16(rdr["id_pegawai"]);
                    role = Convert.ToInt16(rdr["role"]);*/
                    result = true;
                }
            }
            catch (Exception e)
            {
                String error = e.Message;
            }
            conn.Close();
            return result;

        }
        public string insert()
        {
            string result = null;
            using (MySqlCommand cmd = new MySqlCommand("INSERT INTO user (username,password) " +
                "VALUES (@username,md5(@password))", conn))
            {
                cmd.Parameters.AddWithValue("@username", this.username);
                cmd.Parameters.AddWithValue("@password", this.password);
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
