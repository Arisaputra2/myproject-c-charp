using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using MySql.Data.MySqlClient;

namespace ProjectUas
{
    public partial class FormDeletePegawai : Form
    {
        MySqlConnection conn = new MySqlConnection("server = localhost; database = db_project; uid = root; sslMode = none; password =");
        /*MySqlCommand cmd;*/
        public FormDeletePegawai()
        {
            InitializeComponent();
        }



        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            conn.Open();
            MySqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "DELETE FROM data_pegawai where ID = '" + textBox1.Text + "'";
            cmd.ExecuteNonQuery();
            conn.Close();

            MessageBox.Show("Data Berhasil Di Hapus");
            this.Close();
        }
    }
}
