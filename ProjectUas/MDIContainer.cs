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
    public partial class MDIContainer : Form
    {
        public MDIContainer()
        {
            InitializeComponent();
        }

        private void inputDataPegawaiToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FormDataPegawai frmInputPegawai = new FormDataPegawai();
            frmInputPegawai.MdiParent = this;
            frmInputPegawai.Show();
           /* if (frmInputPegawai != null)
            {
                frmInputPegawai.Opacity();
            }
            else
            {
                Close();
            }*/


        }

        private void daftarPegawaiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormDaftarPegawai frmDaftarPegawai = new FormDaftarPegawai();
            frmDaftarPegawai.MdiParent = this;
            frmDaftarPegawai.Show();
            /*if (frmDaftarPegawai != null)
            {
                frmDaftarPegawai.Show();
            }
            else
            {
                Close();
            }*/ 
            
        }
    }
}
