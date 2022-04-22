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
    public partial class FormDataPegawai : Form
    {
        ArrayList pegawailist = new ArrayList();
        System.Collections.ArrayList DaftarPegawai = new ArrayList();
        
        public FormDataPegawai()
        {
            InitializeComponent();

        }

        private void btnUploud_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Choose Image(*.jpg;) | *jpg";
            
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                string picture = dialog.FileName.ToString();
                textbox_image_path.Text = picture;
                pictureBox1.ImageLocation = picture;
            }
        }

        private void btnInput_Click(object sender, EventArgs e)
        {
            byte[] imgbt = null;
            FileStream fstream = new FileStream(this.textbox_image_path.Text, FileMode.Open, FileAccess.Read);
            BinaryReader br = new BinaryReader(fstream);
            imgbt = br.ReadBytes((int)fstream.Length);

           
            Pegawai datapegawai = new Pegawai();
            datapegawai.nama = textBoxNama.Text;
            /*datapegawai.id = textBoxID.Text;*/
            datapegawai.pendidikan = comboBoxPendidikan.SelectedItem.ToString();
            datapegawai.tanggal_lahir = dateTimePickerPegawai.Value.ToString("yyyyMMdd");
            datapegawai.jenis_kelamin = comboBoxJenisKelamin.SelectedItem.ToString();
            datapegawai.no_hp = textBoxNoHp.Text;
            datapegawai.alamat = textBoxAlamat.Text;
            datapegawai.image = pictureBox1.ToString();



            DaftarPegawai.Add(datapegawai);
            DataTable dataTable = new DataTable();
            dataGridViewPegawai.DataSource = null;
            dataGridViewPegawai.DataSource = DaftarPegawai;

            String response;
            response = datapegawai.Insert();
            if (response == null) MessageBox.Show("Insert Data Berhasil");
            else
                MessageBox.Show("Insert Data Gagal " + response);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridViewPegawai_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           /* int selectedrowindex = dataGridViewPegawai.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow = dataGridViewPegawai.Rows[selectedrowindex];


            textBoxNama.Text = Convert.ToString(selectedRow.Cells["Nama"].Value);
            textBoxID.Text = Convert.ToString(selectedRow.Cells["ID"].Value);
            comboBoxPendidikan.Text = Convert.ToString(selectedRow.Cells["Pendidikan"].Value);
            dateTimePickerPegawai.Text = Convert.ToString(selectedRow.Cells["Tanggal_Lahir"].Value);
            comboBoxJenisKelamin.Text = Convert.ToString(selectedRow.Cells["Jenis_Kelamin"].Value);
            textBoxNoHp.Text = Convert.ToString(selectedRow.Cells["No_Hp"].Value);
            textBoxAlamat.Text = Convert.ToString(selectedRow.Cells["Alamat"].Value);
            *//*pictureBox1.Image = Convert.ToChar(selectedRow.Cells["Gambar"].Value);*/
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            Pegawai pegawai = new Pegawai();
            DataTable dt = new DataTable();
            dt = pegawai.ReadAll();
            dataGridViewPegawai.DataSource = dt;
            dataGridViewPegawai.Show();
        }

        private void FormDataPegawai_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
                      
        }
    }
}
