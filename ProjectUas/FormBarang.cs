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
    public partial class FormBarang : Form
    {
        ArrayList pegawailist = new ArrayList();
        System.Collections.ArrayList DataBarang = new ArrayList();
        public FormBarang()
        {
            InitializeComponent();
        }

        private void buttonInsert_Click(object sender, EventArgs e)
        {
            byte[] imgbt = null;
            FileStream fstream = new FileStream(this.textbox_image_path.Text, FileMode.Open, FileAccess.Read);
            BinaryReader br = new BinaryReader(fstream);
            imgbt = br.ReadBytes((int)fstream.Length);

            Barang dataBarang = new Barang();
            /*dataBarang.Id = Convert.ToInt32(textBoxId.Text);*/
            dataBarang.Kode = comboBoxKode.SelectedItem.ToString();
            dataBarang.Nama = textNama.Text;
            dataBarang.Jumlah = Convert.ToInt32(textJumlah.Text);
            dataBarang.Harga = textHarga.Text;
            dataBarang.Gambar = pictureBoxProfile.ToString();



            DataBarang.Add(dataBarang);
            DataTable dataTable = new DataTable();
            dataGridViewBarang.DataSource = null;
            dataGridViewBarang.DataSource = DataBarang;

            String response;
            response = dataBarang.Insert();
            if (response == null) MessageBox.Show("Insert Data Berhasil");
            else
                MessageBox.Show("Insert Data Gagal " + response);
        }

        /*private void LoadDataPegawai()
        {
            DataTable dt = new DataTable();
            dt = Barang.SelectAll();
            dataGridViewBarang.AutoGenerateColumns = false;
            dataGridViewBarang.DataSource = dt;
            dataGridViewBarang.Columns["id_pegawai"].Visible = false;
            dataGridViewBarang.Columns["id_jabatan"].Visible = false;
            dataGridViewBarang.Columns["gambar"].Visible = false;
            dataGridViewBarang.RowHeadersVisible = false;
            dataGridViewBarang.RowTemplate.MinimumHeight = 60;
            dataGridViewBarang.Show();
        }*/

        private void btnUploudImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Choose Image(*.jpg;) | *jpg";

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                string picture = dialog.FileName.ToString();
                textbox_image_path.Text = picture;
                pictureBoxProfile.ImageLocation = picture;
            }
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            textNama.Text = "";
            textJumlah.Text = "";
            textHarga.Text = "";
            textbox_image_path.Text = "";
            comboBoxKode.Text = "";
        }

        private void dataGridViewPegawai_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Barang barang = new Barang();
            int selectedrowindex = dataGridViewBarang.SelectedCells[0].RowIndex;
            DataGridViewRow selectedrow = dataGridViewBarang.Rows[selectedrowindex];
            barang.Id = Convert.ToInt32(selectedrow.Cells["id_barang"].Value);
            barang.Kode = Convert.ToString(selectedrow.Cells["kode_barang"].Value);
            barang.Nama = Convert.ToString(selectedrow.Cells["nama_barang"].Value);
            barang.Jumlah = Convert.ToInt32(selectedrow.Cells["jumlah_barang"].Value);
            barang.Harga = Convert.ToString(selectedrow.Cells["harga_barang"].Value);
            barang.Gambar = Convert.ToString(selectedrow.Cells["gambar_barang"].Value);

            if (Convert.ToBoolean(selectedrow.Cells["hapus"].Selected) == true)
            {
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result = MessageBox.Show("Yakin ingin menghapus " + barang.Nama + "?", " Hapus Data Barang ", buttons);
                if (result == DialogResult.Yes)
                {
                    string response;
                    response = barang.Delete();
                    if (response == null) MessageBox.Show("Sukses");
                    else MessageBox.Show(response);
                }
                else
                {

                }
            }
            else if (Convert.ToBoolean(selectedrow.Cells["ubah"].Selected) == true)
            {
               /* FormUbah frmubah = new FormUbah();
                frmubah.FormClosing += FormClosingEventHandler(FormBarang);*/
            }
        }
       /* private void loadDataPengguna()
        {
            DataTable dt = new DataTable();
            dt = Barang.SelectAll();
            //dataGridViewPengguna.AutoGenerateColumns = false;
            dataGridViewBarang.DataSource = dt;
            dataGridViewBarang.Columns["id_barang"].Visible = false;
            dataGridViewBarang.Columns["kode_barang"].Visible = false;
            dataGridViewBarang.Columns["nama_barang"].Visible = false;
            dataGridViewBarang.Columns["harga_barang"].Visible = false;
            dataGridViewBarang.RowHeadersVisible = false;
            dataGridViewBarang.Show();
        }*/

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            Barang barang = new Barang();
            DataTable dt = new DataTable();
            dt = barang.SelectAll();
            dataGridViewBarang.DataSource = dt;
            dataGridViewBarang.AutoGenerateColumns = false;
            dataGridViewBarang.Columns["id_barang"].Visible = true;
            dataGridViewBarang.Columns["gambar_barang"].Visible = false;
            dataGridViewBarang.Show();
        }

        private void FormBarang_Load(object sender, EventArgs e)
        {
            Barang barang = new Barang();
            DataTable dt = new DataTable();
            dt = barang.SelectAll();
            dataGridViewBarang.DataSource = dt;
            dataGridViewBarang.AutoGenerateColumns = false;
            dataGridViewBarang.Columns["id_barang"].Visible = true;
            dataGridViewBarang.Columns["gambar_barang"].Visible = false;
            dataGridViewBarang.Show();
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            FormUbah frmUbah = new FormUbah();
            frmUbah.Show();
            FormBarang frmBarang = new FormBarang();
            ActiveControl.Enabled = false;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            /*Barang barang = new Barang();
            DataTable dt = new DataTable();
            *//*dt = Barang.SelectAll(txtboxCariPengguna.Text);*//*
            dt = Barang.select(txtboxCariPengguna);
            dataGridViewBarang.AutoGenerateColumns = false;
            dataGridViewBarang.DataSource = dt;
            dataGridViewBarang.Columns["id_barang"].Visible = false;
            *//*dataGridViewBarang.Columns[""].Visible = false;*//*
            dataGridViewBarang.Columns["gambar"].Visible = false;
            dataGridViewBarang.RowHeadersVisible = false;
            dataGridViewBarang.RowTemplate.MinimumHeight = 60;
            dataGridViewBarang.Show();*/
        }

        private void dataGridViewBarang_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dataGridViewBarang.Columns[e.ColumnIndex].Name == "gambar_barang")
            {
                // Your code would go here - below is just the code I used to test 
                string s = dataGridViewBarang.Rows[e.RowIndex].Cells["gambar_barang"].Value.ToString();//
                if (s != "") e.Value = Image.FromFile(s);
                else e.Value = null;
            }
        }
    }
}
