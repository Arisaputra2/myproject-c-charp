namespace ProjectUas
{
    partial class Input_Pegawai
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxNama = new System.Windows.Forms.TextBox();
            this.textBoxTempat = new System.Windows.Forms.TextBox();
            this.textBoxAlamat = new System.Windows.Forms.TextBox();
            this.dateTimePickerPegawai = new System.Windows.Forms.DateTimePicker();
            this.buttonClear = new System.Windows.Forms.Button();
            this.buttonInsert = new System.Windows.Forms.Button();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.dataGridViewPegawai = new System.Windows.Forms.DataGridView();
            this.delete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.foto = new System.Windows.Forms.DataGridViewImageColumn();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gambar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nama = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pendidikan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tempat_lahir = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tanggal_lahir = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jenis_kelamin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.no_hp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.alamat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button6 = new System.Windows.Forms.Button();
            this.btnUploudImage = new System.Windows.Forms.Button();
            this.comboBoxPendidikan = new System.Windows.Forms.ComboBox();
            this.textbox_image_path = new System.Windows.Forms.TextBox();
            this.textBoxNoHp = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.labelId = new System.Windows.Forms.Label();
            this.textBoxId = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnDisplay = new System.Windows.Forms.Button();
            this.comboBoxJenisKelamin = new System.Windows.Forms.ComboBox();
            this.pictureBoxProfile = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPegawai)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProfile)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nama";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(55, 147);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Pendidikan";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(55, 197);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(111, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "Tempat,Tanggal Lahir";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(55, 249);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "Jenis Kelamin";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(55, 341);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 13);
            this.label7.TabIndex = 19;
            this.label7.Text = "Alamat";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(55, 297);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 13);
            this.label6.TabIndex = 20;
            this.label6.Text = "No. Hp";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // textBoxNama
            // 
            this.textBoxNama.Location = new System.Drawing.Point(192, 87);
            this.textBoxNama.Multiline = true;
            this.textBoxNama.Name = "textBoxNama";
            this.textBoxNama.Size = new System.Drawing.Size(214, 24);
            this.textBoxNama.TabIndex = 21;
            this.textBoxNama.TextChanged += new System.EventHandler(this.textBoxNama_TextChanged);
            // 
            // textBoxTempat
            // 
            this.textBoxTempat.Location = new System.Drawing.Point(192, 186);
            this.textBoxTempat.Multiline = true;
            this.textBoxTempat.Name = "textBoxTempat";
            this.textBoxTempat.Size = new System.Drawing.Size(83, 24);
            this.textBoxTempat.TabIndex = 24;
            this.textBoxTempat.TextChanged += new System.EventHandler(this.textBoxTempat_TextChanged);
            // 
            // textBoxAlamat
            // 
            this.textBoxAlamat.Location = new System.Drawing.Point(192, 330);
            this.textBoxAlamat.Multiline = true;
            this.textBoxAlamat.Name = "textBoxAlamat";
            this.textBoxAlamat.Size = new System.Drawing.Size(214, 52);
            this.textBoxAlamat.TabIndex = 26;
            this.textBoxAlamat.TextChanged += new System.EventHandler(this.textBoxAlamat_TextChanged);
            // 
            // dateTimePickerPegawai
            // 
            this.dateTimePickerPegawai.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerPegawai.Location = new System.Drawing.Point(281, 191);
            this.dateTimePickerPegawai.Name = "dateTimePickerPegawai";
            this.dateTimePickerPegawai.Size = new System.Drawing.Size(125, 20);
            this.dateTimePickerPegawai.TabIndex = 28;
            this.dateTimePickerPegawai.ValueChanged += new System.EventHandler(this.dateTimePickerPegawai_ValueChanged);
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(532, 297);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(75, 23);
            this.buttonClear.TabIndex = 30;
            this.buttonClear.Text = "Clear";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // buttonInsert
            // 
            this.buttonInsert.Location = new System.Drawing.Point(421, 297);
            this.buttonInsert.Name = "buttonInsert";
            this.buttonInsert.Size = new System.Drawing.Size(75, 23);
            this.buttonInsert.TabIndex = 31;
            this.buttonInsert.Text = "Insert";
            this.buttonInsert.UseVisualStyleBackColor = true;
            this.buttonInsert.Click += new System.EventHandler(this.buttonInsert_Click);
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Location = new System.Drawing.Point(421, 328);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(186, 26);
            this.buttonUpdate.TabIndex = 32;
            this.buttonUpdate.Text = "Update";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Location = new System.Drawing.Point(23, 405);
            this.textBoxSearch.Multiline = true;
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(498, 24);
            this.textBoxSearch.TabIndex = 34;
            this.textBoxSearch.TextChanged += new System.EventHandler(this.textBoxSearch_TextChanged);
            // 
            // dataGridViewPegawai
            // 
            this.dataGridViewPegawai.AllowUserToAddRows = false;
            this.dataGridViewPegawai.AllowUserToDeleteRows = false;
            this.dataGridViewPegawai.AllowUserToOrderColumns = true;
            this.dataGridViewPegawai.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPegawai.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.delete,
            this.foto,
            this.id,
            this.gambar,
            this.nama,
            this.pendidikan,
            this.tempat_lahir,
            this.tanggal_lahir,
            this.jenis_kelamin,
            this.no_hp,
            this.alamat});
            this.dataGridViewPegawai.Location = new System.Drawing.Point(23, 435);
            this.dataGridViewPegawai.Name = "dataGridViewPegawai";
            this.dataGridViewPegawai.ReadOnly = true;
            this.dataGridViewPegawai.Size = new System.Drawing.Size(584, 166);
            this.dataGridViewPegawai.TabIndex = 35;
            this.dataGridViewPegawai.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewPegawai_CellClick);
            this.dataGridViewPegawai.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewPegawai_CellContentClick);
            this.dataGridViewPegawai.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridViewPegawai_CellFormatting);
            // 
            // delete
            // 
            this.delete.HeaderText = "Delete";
            this.delete.Name = "delete";
            this.delete.ReadOnly = true;
            this.delete.Text = "Delete";
            this.delete.ToolTipText = "Delete";
            this.delete.UseColumnTextForButtonValue = true;
            this.delete.Width = 60;
            // 
            // foto
            // 
            this.foto.HeaderText = "Foto";
            this.foto.MinimumWidth = 10;
            this.foto.Name = "foto";
            this.foto.ReadOnly = true;
            this.foto.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.foto.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // id
            // 
            this.id.DataPropertyName = "ID";
            this.id.HeaderText = "ID";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            // 
            // gambar
            // 
            this.gambar.DataPropertyName = "Gambar";
            this.gambar.HeaderText = "Gambar";
            this.gambar.MinimumWidth = 10;
            this.gambar.Name = "gambar";
            this.gambar.ReadOnly = true;
            this.gambar.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.gambar.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // nama
            // 
            this.nama.DataPropertyName = "Nama";
            this.nama.HeaderText = "Nama";
            this.nama.Name = "nama";
            this.nama.ReadOnly = true;
            // 
            // pendidikan
            // 
            this.pendidikan.DataPropertyName = "Pendidikan";
            this.pendidikan.HeaderText = "Pendidikan";
            this.pendidikan.Name = "pendidikan";
            this.pendidikan.ReadOnly = true;
            // 
            // tempat_lahir
            // 
            this.tempat_lahir.DataPropertyName = "Tempat_lahir";
            this.tempat_lahir.HeaderText = "Tempat Lahir";
            this.tempat_lahir.Name = "tempat_lahir";
            this.tempat_lahir.ReadOnly = true;
            // 
            // tanggal_lahir
            // 
            this.tanggal_lahir.DataPropertyName = "Tanggal_Lahir";
            this.tanggal_lahir.HeaderText = "Tanggal Lahir";
            this.tanggal_lahir.Name = "tanggal_lahir";
            this.tanggal_lahir.ReadOnly = true;
            // 
            // jenis_kelamin
            // 
            this.jenis_kelamin.DataPropertyName = "Jenis_Kelamin";
            this.jenis_kelamin.HeaderText = "Jenis Kelamin";
            this.jenis_kelamin.Name = "jenis_kelamin";
            this.jenis_kelamin.ReadOnly = true;
            // 
            // no_hp
            // 
            this.no_hp.DataPropertyName = "No_Hp";
            this.no_hp.HeaderText = "No. Hp";
            this.no_hp.Name = "no_hp";
            this.no_hp.ReadOnly = true;
            // 
            // alamat
            // 
            this.alamat.DataPropertyName = "Alamat";
            this.alamat.HeaderText = "Alamat";
            this.alamat.Name = "alamat";
            this.alamat.ReadOnly = true;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(533, 405);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 23);
            this.button6.TabIndex = 36;
            this.button6.Text = "Search";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // btnUploudImage
            // 
            this.btnUploudImage.Location = new System.Drawing.Point(421, 265);
            this.btnUploudImage.Name = "btnUploudImage";
            this.btnUploudImage.Size = new System.Drawing.Size(186, 23);
            this.btnUploudImage.TabIndex = 37;
            this.btnUploudImage.Text = "Uploud Image";
            this.btnUploudImage.UseVisualStyleBackColor = true;
            this.btnUploudImage.Click += new System.EventHandler(this.btnUploudImage_Click);
            // 
            // comboBoxPendidikan
            // 
            this.comboBoxPendidikan.FormattingEnabled = true;
            this.comboBoxPendidikan.Items.AddRange(new object[] {
            "SD",
            "SMP",
            "SMA",
            "KULIAH",
            "Lainnya"});
            this.comboBoxPendidikan.Location = new System.Drawing.Point(192, 139);
            this.comboBoxPendidikan.Name = "comboBoxPendidikan";
            this.comboBoxPendidikan.Size = new System.Drawing.Size(214, 21);
            this.comboBoxPendidikan.TabIndex = 38;
            this.comboBoxPendidikan.SelectedIndexChanged += new System.EventHandler(this.comboBoxPendidikan_SelectedIndexChanged);
            // 
            // textbox_image_path
            // 
            this.textbox_image_path.Location = new System.Drawing.Point(421, 230);
            this.textbox_image_path.Multiline = true;
            this.textbox_image_path.Name = "textbox_image_path";
            this.textbox_image_path.Size = new System.Drawing.Size(186, 20);
            this.textbox_image_path.TabIndex = 40;
            this.textbox_image_path.TextChanged += new System.EventHandler(this.textbox_image_path_TextChanged);
            // 
            // textBoxNoHp
            // 
            this.textBoxNoHp.Location = new System.Drawing.Point(192, 287);
            this.textBoxNoHp.MaxLength = 13;
            this.textBoxNoHp.Multiline = true;
            this.textBoxNoHp.Name = "textBoxNoHp";
            this.textBoxNoHp.Size = new System.Drawing.Size(214, 23);
            this.textBoxNoHp.TabIndex = 41;
            this.textBoxNoHp.TextChanged += new System.EventHandler(this.textBoxNoHp_TextChanged);
            this.textBoxNoHp.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxNoHp_KeyPress);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkOrchid;
            this.panel2.Controls.Add(this.labelId);
            this.panel2.Controls.Add(this.textBoxId);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.btnDisplay);
            this.panel2.Controls.Add(this.comboBoxJenisKelamin);
            this.panel2.Controls.Add(this.textBoxNoHp);
            this.panel2.Controls.Add(this.textbox_image_path);
            this.panel2.Controls.Add(this.comboBoxPendidikan);
            this.panel2.Controls.Add(this.btnUploudImage);
            this.panel2.Controls.Add(this.button6);
            this.panel2.Controls.Add(this.dataGridViewPegawai);
            this.panel2.Controls.Add(this.textBoxSearch);
            this.panel2.Controls.Add(this.buttonUpdate);
            this.panel2.Controls.Add(this.buttonInsert);
            this.panel2.Controls.Add(this.buttonClear);
            this.panel2.Controls.Add(this.pictureBoxProfile);
            this.panel2.Controls.Add(this.dateTimePickerPegawai);
            this.panel2.Controls.Add(this.textBoxAlamat);
            this.panel2.Controls.Add(this.textBoxTempat);
            this.panel2.Controls.Add(this.textBoxNama);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(653, 613);
            this.panel2.TabIndex = 1;
            // 
            // labelId
            // 
            this.labelId.AutoSize = true;
            this.labelId.Location = new System.Drawing.Point(641, 9);
            this.labelId.Name = "labelId";
            this.labelId.Size = new System.Drawing.Size(0, 13);
            this.labelId.TabIndex = 46;
            // 
            // textBoxId
            // 
            this.textBoxId.Enabled = false;
            this.textBoxId.Location = new System.Drawing.Point(192, 49);
            this.textBoxId.Name = "textBoxId";
            this.textBoxId.ReadOnly = true;
            this.textBoxId.Size = new System.Drawing.Size(214, 20);
            this.textBoxId.TabIndex = 45;
            this.textBoxId.TextChanged += new System.EventHandler(this.textBoxId_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(55, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(18, 13);
            this.label2.TabIndex = 44;
            this.label2.Text = "ID";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // btnDisplay
            // 
            this.btnDisplay.Location = new System.Drawing.Point(421, 360);
            this.btnDisplay.Name = "btnDisplay";
            this.btnDisplay.Size = new System.Drawing.Size(186, 39);
            this.btnDisplay.TabIndex = 43;
            this.btnDisplay.Text = "Refresh Data";
            this.btnDisplay.UseVisualStyleBackColor = true;
            this.btnDisplay.Click += new System.EventHandler(this.btnDisplay_Click);
            // 
            // comboBoxJenisKelamin
            // 
            this.comboBoxJenisKelamin.FormattingEnabled = true;
            this.comboBoxJenisKelamin.Items.AddRange(new object[] {
            "Laki-Laki",
            "Perempuan"});
            this.comboBoxJenisKelamin.Location = new System.Drawing.Point(192, 241);
            this.comboBoxJenisKelamin.Name = "comboBoxJenisKelamin";
            this.comboBoxJenisKelamin.Size = new System.Drawing.Size(214, 21);
            this.comboBoxJenisKelamin.TabIndex = 42;
            this.comboBoxJenisKelamin.SelectedIndexChanged += new System.EventHandler(this.comboBoxJenisKelamin_SelectedIndexChanged);
            // 
            // pictureBoxProfile
            // 
            this.pictureBoxProfile.BackColor = System.Drawing.SystemColors.ControlDark;
            this.pictureBoxProfile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBoxProfile.Location = new System.Drawing.Point(421, 36);
            this.pictureBoxProfile.Name = "pictureBoxProfile";
            this.pictureBoxProfile.Size = new System.Drawing.Size(186, 189);
            this.pictureBoxProfile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxProfile.TabIndex = 29;
            this.pictureBoxProfile.TabStop = false;
            this.pictureBoxProfile.Click += new System.EventHandler(this.pictureBoxProfile_Click);
            // 
            // Input_Pegawai
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(653, 613);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Input_Pegawai";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Input_Pegawai_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPegawai)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProfile)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxNama;
        private System.Windows.Forms.TextBox textBoxTempat;
        private System.Windows.Forms.TextBox textBoxAlamat;
        private System.Windows.Forms.DateTimePicker dateTimePickerPegawai;
        private System.Windows.Forms.PictureBox pictureBoxProfile;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Button buttonInsert;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.DataGridView dataGridViewPegawai;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button btnUploudImage;
        private System.Windows.Forms.ComboBox comboBoxPendidikan;
        private System.Windows.Forms.TextBox textbox_image_path;
        private System.Windows.Forms.TextBox textBoxNoHp;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox comboBoxJenisKelamin;
        private System.Windows.Forms.Button btnDisplay;
        private System.Windows.Forms.TextBox textBoxId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelId;
        private System.Windows.Forms.DataGridViewButtonColumn delete;
        private System.Windows.Forms.DataGridViewImageColumn foto;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn gambar;
        private System.Windows.Forms.DataGridViewTextBoxColumn nama;
        private System.Windows.Forms.DataGridViewTextBoxColumn pendidikan;
        private System.Windows.Forms.DataGridViewTextBoxColumn tempat_lahir;
        private System.Windows.Forms.DataGridViewTextBoxColumn tanggal_lahir;
        private System.Windows.Forms.DataGridViewTextBoxColumn jenis_kelamin;
        private System.Windows.Forms.DataGridViewTextBoxColumn no_hp;
        private System.Windows.Forms.DataGridViewTextBoxColumn alamat;
    }
}