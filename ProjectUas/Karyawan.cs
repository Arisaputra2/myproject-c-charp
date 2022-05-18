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
    public partial class Input_Pegawai : Form
    {
        ArrayList pegawailist = new ArrayList();
        System.Collections.ArrayList DaftarPegawai = new ArrayList();
        public Input_Pegawai()
        {
            InitializeComponent();
        }

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

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonInsert_Click(object sender, EventArgs e)
        {
            byte[] imgbt = null;
            FileStream fstream = new FileStream(this.textbox_image_path.Text, FileMode.Open, FileAccess.Read);
            BinaryReader br = new BinaryReader(fstream);
            imgbt = br.ReadBytes((int)fstream.Length);

            Pegawai dataBarang = new Pegawai();
            dataBarang.nama = textBoxNama.Text;
            dataBarang.id = textBoxId.Text;
            dataBarang.pendidikan = comboBoxPendidikan.SelectedItem.ToString();
            dataBarang.tempat_lahir = textBoxTempat.Text;
            dataBarang.tanggal_lahir = dateTimePickerPegawai.Value.ToString("yyyy-MM-dd");
            dataBarang.jenis_kelamin = comboBoxJenisKelamin.SelectedItem.ToString();
            dataBarang.no_hp = textBoxNoHp.Text;
            dataBarang.alamat = textBoxAlamat.Text;
            dataBarang.image = Convert.ToString(value: pictureBoxProfile);



            DaftarPegawai.Add(dataBarang);
            DataTable dataTable = new DataTable();
            dataGridViewPegawai.DataSource = null;
            dataGridViewPegawai.DataSource = DaftarPegawai;

            String response;
            response = dataBarang.Insert();
            if (response == null) MessageBox.Show("Insert Data Berhasil");
            else
                MessageBox.Show("Insert Data Gagal " + response);
        }


        private void textBoxNoHp_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxNoHp_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back;
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBoxNama.Text = "";
            textBoxNoHp.Text = "";
            textBoxAlamat.Text = "";
            textBoxTempat.Text = "";
            textbox_image_path.Text = "";
            comboBoxJenisKelamin.Text = "";
            comboBoxPendidikan.Text = "";
            textbox_image_path.Text = "";
            pictureBoxProfile.ImageLocation = null;
        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            Pegawai pegawai = new Pegawai();
            DataTable dt = new DataTable();
            dt = pegawai.ReadAll();
            dataGridViewPegawai.DataSource = dt;
            dataGridViewPegawai.AutoGenerateColumns = false;
            dataGridViewPegawai.Columns["ID"].Visible = true;
            dataGridViewPegawai.Columns["Gambar"].Visible = false;
            dataGridViewPegawai.Show();
        }

        private void dataGridViewPegawai_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Pegawai pegawai = new Pegawai();
            int selectedrowindex = dataGridViewPegawai.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow = dataGridViewPegawai.Rows[selectedrowindex];
            pegawai.pendidikan = Convert.ToString(selectedRow.Cells["Pendidikan"].Value);
            pegawai.tempat_lahir = Convert.ToString(selectedRow.Cells["Tempat_lahir"].Value);
            pegawai.tanggal_lahir = Convert.ToString(selectedRow.Cells["Tanggal_Lahir"].Value);
            pegawai.jenis_kelamin = Convert.ToString(selectedRow.Cells["Jenis_Kelamin"].Value);
            pegawai.alamat = Convert.ToString(selectedRow.Cells["Alamat"].Value);
            pegawai.no_hp = Convert.ToString(selectedRow.Cells["No_Hp"].Value);
            pegawai.image = Convert.ToString(selectedRow.Cells["Gambar"].Value);
        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {

        }

        private void Input_Pegawai_Load(object sender, EventArgs e)
        {
            Pegawai pegawai = new Pegawai();
            DataTable dt = new DataTable();
            dt = pegawai.ReadAll();
            dataGridViewPegawai.DataSource = dt;
            dataGridViewPegawai.AutoGenerateColumns = false;
            dataGridViewPegawai.Columns["ID"].Visible = true;
            dataGridViewPegawai.Columns["Gambar"].Visible = false;
            dataGridViewPegawai.Show();
        }
    }
}
