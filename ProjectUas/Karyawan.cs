using System;
using System.Collections;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using MySql.Data.MySqlClient;
using System.Drawing.Imaging;
using System.Globalization;

namespace ProjectUas
{
    public partial class Input_Pegawai : Form
    {
        ArrayList pegawailist = new ArrayList();
        System.Collections.ArrayList DaftarPegawai = new ArrayList();
        MySqlConnection conn = new MySqlConnection("server = localhost; database = db_project; uid = root; sslMode = none; password =");
        
        public Input_Pegawai()
        {
            InitializeComponent();
        }

        public void display_data()
        {

            Pegawai pegawai = new Pegawai();
            DataTable dt = new DataTable();
            dt = Pegawai.ReadAll();
            dataGridViewPegawai.DataSource = dt;
            dataGridViewPegawai.AutoGenerateColumns = false;
            dataGridViewPegawai.Columns["ID"].Visible = true;
            dataGridViewPegawai.Columns["foto"].Visible = true;
            dataGridViewPegawai.Columns["Gambar"].Visible = false;
            dataGridViewPegawai.RowTemplate.Height = 50;
            dataGridViewPegawai.Show();
        }

        private void btnUploudImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";

            if (dialog.ShowDialog() == DialogResult.OK)
            {
               /* string picture = dialog.FileName.ToString();*/
                textbox_image_path.Text = dialog.FileName;
                /*pictureBoxProfile.Image = Image.FromFile(dialog.FileName);*/
                if (dialog.FileName != "") pictureBoxProfile.Image = new Bitmap(dialog.FileName);
            }
        }

        private void buttonInsert_Click(object sender, EventArgs e)
        {
/*
            //Cara Awal
            byte[] imgbt = null;
            FileStream fstream = new FileStream(this.textbox_image_path.Text, FileMode.Open, FileAccess.Read);
            BinaryReader br = new BinaryReader(fstream);
            imgbt = br.ReadBytes((int)fstream.Length);
*/
            Pegawai dataPegawai = new Pegawai();
            dataPegawai.nama = textBoxNama.Text;
            dataPegawai.id = textBoxId.Text;
            dataPegawai.pendidikan = comboBoxPendidikan.SelectedItem.ToString();
            dataPegawai.tempat_lahir = textBoxTempat.Text;
            dataPegawai.tanggal_lahir = dateTimePickerPegawai.Value.ToString("yyyy-MM-dd");
            dataPegawai.jenis_kelamin = comboBoxJenisKelamin.SelectedItem.ToString();
            dataPegawai.no_hp = textBoxNoHp.Text;
            dataPegawai.alamat = textBoxAlamat.Text;
            /*dataPegawai.image = pictureBoxProfile.Image;*/

            var source = textbox_image_path.Text;
            DateTime dateTime = DateTime.Now;
            var fileName = "img_" + dateTime.Ticks.ToString() + ".jpeg";
            var destinationFolder = Path.Combine(Environment.CurrentDirectory, "Gambar");
            var destination = Path.Combine(destinationFolder, fileName);

            try
            {
                File.Copy(source, destination);
                dataPegawai.image = destination.ToString();
            }
            catch (Exception err)
            {
                dataPegawai.image = "";
                String error = err.Message;
            }

            DaftarPegawai.Add(dataPegawai);
            DataTable dataTable = new DataTable();
            dataGridViewPegawai.DataSource = null;
            dataGridViewPegawai.DataSource = DaftarPegawai;

            String response;
            response = dataPegawai.Insert();
            if (response == null) {
                display_data();
                MessageBox.Show("Insert Data Berhasil"); 
            
            }
            else if (response != null)
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
            textBoxId.Text = "";
            textBoxNama.Text = "";
            textBoxNoHp.Text = "";
            textBoxAlamat.Text = "";
            textBoxTempat.Text = "";
            textbox_image_path.Text = "";
            comboBoxJenisKelamin.Text = "";
            comboBoxPendidikan.Text = "";
            textbox_image_path.Text = "";
            dateTimePickerPegawai.Value = DateTime.Now;
            pictureBoxProfile.ImageLocation = null;
        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            Pegawai pegawai = new Pegawai();
            DataTable dt = new DataTable();
            dt = Pegawai.ReadAll();
            dataGridViewPegawai.DataSource = dt;
            dataGridViewPegawai.AutoGenerateColumns = false;
            dataGridViewPegawai.Columns["ID"].Visible = true;
            dataGridViewPegawai.Columns["Gambar"].Visible = true;
            dataGridViewPegawai.Columns["foto"].Visible = true;
            dataGridViewPegawai.Show();
        }

        private void dataGridViewPegawai_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Pegawai pegawai = new Pegawai();
            int selectedrowindex = dataGridViewPegawai.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow = dataGridViewPegawai.Rows[selectedrowindex];
            pegawai.id = Convert.ToString(selectedRow.Cells["id"].Value);
            pegawai.nama = Convert.ToString(selectedRow.Cells["nama"].Value);
            pegawai.pendidikan = Convert.ToString(selectedRow.Cells["pendidikan"].Value);
            pegawai.tempat_lahir = Convert.ToString(selectedRow.Cells["tempat_lahir"].Value);
            pegawai.tanggal_lahir = Convert.ToString(selectedRow.Cells["tanggal_lahir"].Value);
            pegawai.jenis_kelamin = Convert.ToString(selectedRow.Cells["jenis_kelamin"].Value);
            pegawai.alamat = Convert.ToString(selectedRow.Cells["alamat"].Value);
            pegawai.no_hp = Convert.ToString(selectedRow.Cells["no_hp"].Value);
            pegawai.image = Convert.ToString(selectedRow.Cells["gambar"].Value);

            if (Convert.ToBoolean(selectedRow.Cells["delete"].Selected) == true)
            {
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result = MessageBox.Show("Yakin mau menghapus " + pegawai.nama + " ?", "Hapus data pegawai", buttons);
                if (result == DialogResult.Yes)
                {
                    string response;
                    response = pegawai.Delete();
                    if (response == null) MessageBox.Show("Data Berhasil Di Hapus");
                    else MessageBox.Show(response);
                    display_data();
                }
                else
                {

                }
            }
            /*else if (Convert.ToBoolean(selectedRow.Cells["ubah"].Selected) == true)
            {
                *//*FormUbahPegawai frmUbhPegawai = new FormUbahPegawai();
                frmUbhPegawai.FormClosing += new FormUbahPegawai
                frmUbhPegawai.Show();*//*
;            }*/

        }

        private void button6_Click(object sender, EventArgs e)
        {
            Pegawai pegawai = new Pegawai();
            DataTable dt = new DataTable();
            dt = Pegawai.select(textBoxSearch.Text);
            dataGridViewPegawai.AutoGenerateColumns = false;
            dataGridViewPegawai.DataSource = dt;
            dataGridViewPegawai.Columns["id"].Visible = true;
            dataGridViewPegawai.Columns["foto"].Visible = false;
            dataGridViewPegawai.Columns["Gambar"].Visible = true;
            dataGridViewPegawai.RowHeadersVisible = false;
            dataGridViewPegawai.RowTemplate.MinimumHeight = 60;
            dataGridViewPegawai.Show();
        }

        private void Input_Pegawai_Load(object sender, EventArgs e)
        {
            /*Pegawai pegawai = new Pegawai();
            DataTable dt = new DataTable();
            dt = Pegawai.ReadAll();
            dataGridViewPegawai.DataSource = dt;
            dataGridViewPegawai.AutoGenerateColumns = false;
            *//*dataGridViewPegawai.Columns["ID"].Visible = true;*//*
            dataGridViewPegawai.Columns["Gambar"].Visible = true;
            dataGridViewPegawai.Columns["foto"].Visible = false;
            dataGridViewPegawai.Show();*/
            display_data();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBoxNama_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxTempat_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxAlamat_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePickerPegawai_ValueChanged(object sender, EventArgs e)
        {

        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {

            Pegawai dataPegawai = new Pegawai();
            dataPegawai.nama = textBoxNama.Text;
            dataPegawai.id = textBoxId.Text;
            dataPegawai.pendidikan = comboBoxPendidikan.SelectedItem.ToString();
            dataPegawai.tempat_lahir = textBoxTempat.Text;
            dataPegawai.tanggal_lahir = dateTimePickerPegawai.Value.ToString("yyyy-MM-dd");
            dataPegawai.jenis_kelamin = comboBoxJenisKelamin.SelectedItem.ToString();
            dataPegawai.no_hp = textBoxNoHp.Text;
            dataPegawai.alamat = textBoxAlamat.Text;

            //image
            var source = textbox_image_path.Text;
            DateTime dateTime = DateTime.Now;
            var fileName = "img_" + dateTime.Ticks.ToString() + ".jpeg";
            var destinationFolder = Path.Combine(Environment.CurrentDirectory, "Gambar");
            var destination = Path.Combine(destinationFolder, fileName);

            try
            {
                File.Copy(source, destination);
                dataPegawai.image = destination.ToString();
            }
            catch (Exception err)
            {
                dataPegawai.image = "";
                String error = err.Message;
            }


            String response = dataPegawai.Update();
            if (response == null)
            {
                MessageBox.Show("Ubah pegawai berhasil");
                display_data();
            }
            else
            {
                MessageBox.Show("Ubah pegawai gagal. Error: " + response);
            }

            //cara youtube
            /*conn.Open();
            MySqlCommand cmd = new MySqlCommand("UPDATE data_pegawai Nama = '" + textBoxNama.Text + "',Pendidikan = '" + comboBoxPendidikan.Text + "',Tempat_lahir = '" + textBoxTempat.Text + "',Tanggal_Lahir = '" + dateTimePickerPegawai.Text + "',Jenis_Kelamin ='" +comboBoxJenisKelamin.Text + "',No_Hp = '" + textBoxNoHp.Text + "',Alamat = '" + textBoxAlamat + "'",conn);
        */
        }

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxPendidikan_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textbox_image_path_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxId_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void comboBoxJenisKelamin_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void pictureBoxProfile_Click(object sender, EventArgs e)
        {

        }

        private void dataGridViewPegawai_CellClick(object sender, DataGridViewCellEventArgs e)
        {

                DateTime dt = DateTime.ParseExact(dataGridViewPegawai.CurrentRow.Cells["tanggal_lahir"].Value.ToString(),"yyyy-MM-dd",CultureInfo.InvariantCulture);
                dateTimePickerPegawai.Value = dt;

                textBoxId.Text = dataGridViewPegawai.CurrentRow.Cells["id"].Value.ToString();
                textBoxNama.Text = dataGridViewPegawai.CurrentRow.Cells["nama"].Value.ToString();
                comboBoxPendidikan.Text = dataGridViewPegawai.CurrentRow.Cells["pendidikan"].Value.ToString();
                textBoxTempat.Text = dataGridViewPegawai.CurrentRow.Cells["tempat_lahir"].Value.ToString();
                /*dateTimePickerPegawai.Text = dataGridViewPegawai.CurrentRow.Cells["tanggal_lahir"].Value;*/
                comboBoxJenisKelamin.Text = dataGridViewPegawai.CurrentRow.Cells["jenis_kelamin"].Value.ToString();
                textBoxNoHp.Text = dataGridViewPegawai.CurrentRow.Cells["no_hp"].Value.ToString();
                textBoxAlamat.Text = dataGridViewPegawai.CurrentRow.Cells["alamat"].Value.ToString();
           /* MemoryStream ms = new MemoryStream();
            Bitmap img = (Bitmap)dataGridViewPegawai.CurrentRow.Cells["foto"].Value;
            img.Save(ms, ImageFormat.Jpeg);
            pictureBoxProfile.Image = Image.FromStream(ms);*/

        }

        private void dataGridViewPegawai_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dataGridViewPegawai.Columns[e.ColumnIndex].Name == "foto")
            {
                // Your code would go here - below is just the code I used to test 
                string s = dataGridViewPegawai.Rows[e.RowIndex].Cells["gambar"].Value.ToString();//
                if (s != "") e.Value = Image.FromFile(s);
                else e.Value = null;
            }
        }
    }
}
