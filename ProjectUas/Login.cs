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

        public Login()
        {
            InitializeComponent();
           
        }

        private void button1_Click(object sender, EventArgs e)
        { 

            User user = new User();
            user.username = txtUsername.Text;
            user.password = txtPassword.Text;
            if (user.validasi())
            {
                MessageBox.Show("User berhasil login");
                this.Hide();
                Wellcome frmWellcome = new Wellcome();
                frmWellcome.Show();
            }
            else
            {
                MessageBox.Show("User gagal login");
                txtUsername.Text = "";
                txtPassword.Text = "";
            }
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
            txtPassword.PasswordChar = default;
            if (btnVisible.Visible == true)
            {
                btnVisible.Visible = false;
                btnInvisible.Visible = true;
            }
        }

        private void btnInvisible_Click(object sender, EventArgs e)
        {
            txtPassword.PasswordChar = '*';
            if (btnInvisible.Visible == true)
            {
                btnInvisible.Visible = false;
                btnVisible.Visible = true;
            }
        }

    }
}
