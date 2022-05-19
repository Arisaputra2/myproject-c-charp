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
using System.Drawing.Imaging;

namespace ProjectUas
{
    public partial class FormBarang : Form
    {
        ArrayList pegawailist = new ArrayList();
        System.Collections.ArrayList DataBarang = new ArrayList();
        MySqlConnection conn =  new MySqlConnection("server = localhost; database = db_project; uid = root; sslMode = none; password =");
        /*MySqlCommand cmd;*/

        public FormBarang()
        {
            InitializeComponent();
        }

        public void display_data()
        {
            DataTable dt = new DataTable();
            dt = Barang.SelectAll();
            dataGridViewBarang.DataSource = dt;
            dataGridViewBarang.AutoGenerateColumns = false;
            dataGridViewBarang.Columns["id"].Visible = true;
            dataGridViewBarang.Columns["foto"].Visible = true;
            dataGridViewBarang.Columns["gambar"].Visible = true;
            dataGridViewBarang.Show();

        }

        private void buttonInsert_Click(object sender, EventArgs e)
        {
            
            //cara 1
           
             byte[] imgbt = null;
            FileStream fstream = new FileStream(this.textbox_image_path.Text, FileMode.Open, FileAccess.Read);
            BinaryReader br = new BinaryReader(fstream);
            imgbt = br.ReadBytes((int)fstream.Length);

            Barang dataBarang = new Barang();
            dataBarang.Id = textBoxIDbarang.Text;
            dataBarang.Kode = comboBoxKode.SelectedItem.ToString();
            dataBarang.Nama = comboBoxNama.Text;
            dataBarang.Jumlah = Convert.ToInt32(textJumlah.Text);
            dataBarang.Harga = textHarga.Text;
            /*dataBarang.Gambar = pictureBoxProfile.Image;*/

            var source = textbox_image_path.Text;
            DateTime dateTime = DateTime.Now;
            var fileName = "img_" + dateTime.Ticks.ToString();
            var destinationFolder = Path.Combine(Environment.CurrentDirectory, "gambar");
            var destination = Path.Combine(destinationFolder, fileName);

            try
            {
                File.Copy(source, destination);
                dataBarang.Gambar = destination.ToString();
            }
            catch (Exception err)
            {
                dataBarang.Gambar = "";
                String error = err.Message;
            }

            DataBarang.Add(dataBarang);
            DataTable dataTable = new DataTable();
            dataGridViewBarang.DataSource = null;
            dataGridViewBarang.DataSource = DataBarang;

            String response;
            response = dataBarang.Insert();
            if (response == null) {
                display_data();
                MessageBox.Show("Insert Data Berhasil"); 
            
            }
            else
                MessageBox.Show("Insert Data Gagal " + response);

            //cara 2
            /*  cmd = new MySqlCommand("INSERT INTO data_barang (id_barang,kode_barang,nama_barang,jumlah_barang,harga_barang,gambar_barang) " +
                  "VALUES (@id_barang,@kode_barang,@nama_barang,@jumlah_barang,@harga_barang,@gambar_barang)", conn);
              cmd.Parameters.AddWithValue("id_barang", textBoxIDbarang.Text);
              cmd.Parameters.AddWithValue("kode_barang", comboBoxKode.Text);
              cmd.Parameters.AddWithValue("nama_barang", comboBoxNama.Text);
              cmd.Parameters.AddWithValue("jumlah_barang", textJumlah.Text);
              cmd.Parameters.AddWithValue("harga_barang", textHarga.Text);
              MemoryStream ms = new MemoryStream();
              pictureBoxProfile.Image.Save(ms, pictureBoxProfile.Image.RawFormat);
              cmd.Parameters.AddWithValue("gambar_barang", ms.ToArray());
              conn.Open();
              cmd.ExecuteNonQuery();
              conn.Close();
              MessageBox.Show("Data Berhasil Dimasukkan");*/

        }

        private void btnUploudImage_Click(object sender, EventArgs e)
        {
            //open dialog
            OpenFileDialog dialog = new OpenFileDialog();
            //image filter
            dialog.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                /* imglocation = dialog.FileName.ToString();
                 textbox_image_path.Text = imglocation;
                 pictureBoxProfile.ImageLocation = imglocation;*/
                textbox_image_path.Text = dialog.FileName;
                if (dialog.FileName != "") pictureBoxProfile.Image = new Bitmap(dialog.FileName);
            }
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBoxIDbarang.Text = "";
            comboBoxNama.Text = "";
            textJumlah.Text = "";
            textHarga.Text = "";
            textbox_image_path.Text = "";
            comboBoxKode.Text = "";
            pictureBoxProfile.ImageLocation = null;
        }

        private void dataGridViewPegawai_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Barang barang = new Barang();
            int selectedrowindex = dataGridViewBarang.SelectedCells[0].RowIndex;
            DataGridViewRow selectedrow = dataGridViewBarang.Rows[selectedrowindex];
            barang.Id = Convert.ToString(selectedrow.Cells["id"].Value);
            barang.Kode = Convert.ToString(selectedrow.Cells["kode"].Value);
            barang.Nama = Convert.ToString(selectedrow.Cells["nama"].Value);
            barang.Jumlah = Convert.ToInt32(selectedrow.Cells["jumlah"].Value);
            barang.Harga = Convert.ToString(selectedrow.Cells["harga"].Value);
            barang.Gambar = Convert.ToString(selectedrow.Cells["gambar"].Value);

            if (Convert.ToBoolean(selectedrow.Cells["delete"].Selected) == true)
            {
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result = MessageBox.Show("Yakin mau menghapus " + barang.Nama + " ?", "Hapus data barang", buttons);
                if (result == DialogResult.Yes)
                {
                    string response;
                    response = barang.Delete();
                    if (response == null) MessageBox.Show("Data Berhasil Di Hapus");
                    else MessageBox.Show(response);
                    display_data();
                }
                else
                {

                }
            }
        }
       /* private void loadDataBarang()
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
            dt = Barang.SelectAll();
            dataGridViewBarang.DataSource = dt;
            dataGridViewBarang.AutoGenerateColumns = false;
           /* dataGridViewBarang.Columns["id_barang"].Visible = true;
            dataGridViewBarang.Columns["gambar_barang"].Visible = false;*/
            dataGridViewBarang.Show();



        }

       
        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            Barang dataBarang = new Barang();
            dataBarang.Id = textBoxIDbarang.Text;
            dataBarang.Kode = comboBoxKode.SelectedItem.ToString();
            dataBarang.Nama = comboBoxNama.Text;
            dataBarang.Jumlah = Convert.ToInt32(textJumlah.Text);
            dataBarang.Harga = textHarga.Text;

            //image
            var source = textbox_image_path.Text;
            DateTime dateTime = DateTime.Now;
            var fileName = "img_" + dateTime.Ticks.ToString();
            var destinationFolder = Path.Combine(Environment.CurrentDirectory, "Gambar");
            var destination = Path.Combine(destinationFolder, fileName);

            try
            {
                File.Copy(source, destination);
                dataBarang.Gambar = destination.ToString();
            }
            catch (Exception err)
            {
                dataBarang.Gambar = "";
                String error = err.Message;
            }


            String response = dataBarang.Update();
            if (response == null)
            {
                MessageBox.Show("Ubah barang berhasil");
                this.Close();
            }
            else
            {
                MessageBox.Show("Ubah barang gagal. Error: " + response);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Barang barang = new Barang();
            DataTable dt = new DataTable();
            dt = Barang.select(txtboxCariPengguna.Text);
            dataGridViewBarang.AutoGenerateColumns = false;
            dataGridViewBarang.DataSource = dt;
            dataGridViewBarang.Columns["id"].Visible = true;
            dataGridViewBarang.Columns["foto"].Visible = false;
            dataGridViewBarang.Columns["gambar"].Visible = false;
            dataGridViewBarang.RowHeadersVisible = false;
            dataGridViewBarang.RowTemplate.MinimumHeight = 60;
            dataGridViewBarang.Show();
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

        private void buttonDelete_Click(object sender, EventArgs e)
        {

        }

        private void FormBarang_Load_1(object sender, EventArgs e)
        {
            Barang barang = new Barang();
            DataTable dt = new DataTable();
            dt = Barang.SelectAll();
            dataGridViewBarang.DataSource = dt;
            dataGridViewBarang.AutoGenerateColumns = false;
            dataGridViewBarang.AllowUserToAddRows = false;
            dataGridViewBarang.Columns["foto"].Visible = false;
            
            /*dataGridViewBarang.Columns["foto"].Visible = true;*/
       /*     comboBoxNama.Text = barang.Nama;
            comboBoxKode.Text = barang.Kode;
            textJumlah.Text = barang.Jumlah.ToString();
            textHarga.Text = barang.Harga;

            textbox_image_path.Text = barang.Gambar.ToString();
            if (textbox_image_path != "") pictureBoxProfile.Image = Bitmap(textbox_image_path.Text);*/

            dataGridViewBarang.Show();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridViewBarang_CellClick(object sender, DataGridViewCellEventArgs e)
        {            
            textBoxIDbarang.Text = dataGridViewBarang.CurrentRow.Cells["id"].Value.ToString();
            comboBoxKode.Text = dataGridViewBarang.CurrentRow.Cells["kode"].Value.ToString();
            comboBoxNama.Text = dataGridViewBarang.CurrentRow.Cells["nama"].Value.ToString();
            textJumlah.Text = dataGridViewBarang.CurrentRow.Cells["jumlah"].Value.ToString();
            textHarga.Text = dataGridViewBarang.CurrentRow.Cells["harga"].Value.ToString();
           /* pictureBoxProfile.Image = Convert.ToString(dataGridViewBarang.CurrentRow.Cells["gambar_barang"].Value);*/
        }
    }
}
