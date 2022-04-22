using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql;
using MySql.Data.MySqlClient;


namespace ProjectUas
{
    public partial class Login : Form 
    {
        int i;
        MySqlConnection conn= new MySqlConnection("server = localhost; database = project; uid = root; sslMode = none; password =");

        public Login()
        {
            InitializeComponent();
           
        }

        private void button1_Click(object sender, EventArgs e)
        { 
            i = 0;
            conn.Open();
            MySqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from user where username ='" + textBox1.Text + "' and password= '" + textBox2.Text + "'";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            da.Fill(dt);
            i = Convert.ToInt32(dt.Rows.Count.ToString());
            if (i == 0)
            {
                MessageBox.Show("Username dan Password Tidak Benar");
                /*label3.Text = "Invalid Password";*/
            }
            else
            {
                MessageBox.Show("Anda Berhasil Login");
                this.Hide();
                Wellcome fdp = new Wellcome();
                fdp.Show();
            }
            conn.Close();
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
          
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void textBox2_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Enter(object sender, EventArgs e)
        {
          
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox2.PasswordChar = default;
            if (btnVisible.Visible == true)
            {
                btnVisible.Visible = false;
                btnInvisible.Visible = true;
            }
        }

        private void btnInvisible_Click(object sender, EventArgs e)
        {
            textBox2.PasswordChar = '*';
            if (btnInvisible.Visible == true)
            {
                btnInvisible.Visible = false;
                btnVisible.Visible = true;
            }
        }
    }
}
