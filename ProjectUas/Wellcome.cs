using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectUas
{
    public partial class Wellcome : Form
    {
        public Wellcome()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Input_Pegawai frmInputPegawai = new Input_Pegawai();
            frmInputPegawai.TopLevel = false;
            frmInputPegawai.AutoScroll = true;
            this.PanelContent.Controls.Clear();
            this.PanelContent.Controls.Add(frmInputPegawai);
            frmInputPegawai.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
            Login frmLogin = new Login();
            frmLogin.Show();
        }

        private void btnBarang_Click(object sender, EventArgs e)
        {

        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            FormHome frmHome = new FormHome();
            frmHome.TopLevel = false;
            frmHome.AutoScroll = true;
            this.PanelContent.Controls.Clear();
            this.PanelContent.Controls.Add(frmHome);
            frmHome.Show();
        }
    }
}
