﻿namespace ProjectUas
{
    partial class FormBarang
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textNama = new System.Windows.Forms.TextBox();
            this.textJumlah = new System.Windows.Forms.TextBox();
            this.textHarga = new System.Windows.Forms.TextBox();
            this.btnDisplay = new System.Windows.Forms.Button();
            this.textbox_image_path = new System.Windows.Forms.TextBox();
            this.btnUploudImage = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.txtboxCariPengguna = new System.Windows.Forms.TextBox();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.buttonInsert = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.pictureBoxProfile = new System.Windows.Forms.PictureBox();
            this.dataGridViewBarang = new System.Windows.Forms.DataGridView();
            this.comboBoxKode = new System.Windows.Forms.ComboBox();
            this.textBoxId = new System.Windows.Forms.TextBox();
            this.gambar = new System.Windows.Forms.DataGridViewImageColumn();
            this.foto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nama = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jumlah = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.harga = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ubah = new System.Windows.Forms.DataGridViewButtonColumn();
            this.hapus = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProfile)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBarang)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kode Barang";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(54, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nama Barang";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(54, 212);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Jumlah Barang";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(54, 258);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Harga Barang";
            // 
            // textNama
            // 
            this.textNama.Location = new System.Drawing.Point(214, 145);
            this.textNama.Multiline = true;
            this.textNama.Name = "textNama";
            this.textNama.Size = new System.Drawing.Size(152, 50);
            this.textNama.TabIndex = 5;
            // 
            // textJumlah
            // 
            this.textJumlah.Location = new System.Drawing.Point(214, 212);
            this.textJumlah.Name = "textJumlah";
            this.textJumlah.Size = new System.Drawing.Size(152, 20);
            this.textJumlah.TabIndex = 6;
            // 
            // textHarga
            // 
            this.textHarga.Location = new System.Drawing.Point(214, 258);
            this.textHarga.Name = "textHarga";
            this.textHarga.Size = new System.Drawing.Size(152, 20);
            this.textHarga.TabIndex = 7;
            // 
            // btnDisplay
            // 
            this.btnDisplay.Location = new System.Drawing.Point(422, 349);
            this.btnDisplay.Name = "btnDisplay";
            this.btnDisplay.Size = new System.Drawing.Size(186, 39);
            this.btnDisplay.TabIndex = 53;
            this.btnDisplay.Text = "Display Data";
            this.btnDisplay.UseVisualStyleBackColor = true;
            this.btnDisplay.Click += new System.EventHandler(this.btnDisplay_Click);
            // 
            // textbox_image_path
            // 
            this.textbox_image_path.Location = new System.Drawing.Point(422, 219);
            this.textbox_image_path.Multiline = true;
            this.textbox_image_path.Name = "textbox_image_path";
            this.textbox_image_path.Size = new System.Drawing.Size(186, 20);
            this.textbox_image_path.TabIndex = 52;
            // 
            // btnUploudImage
            // 
            this.btnUploudImage.Location = new System.Drawing.Point(422, 254);
            this.btnUploudImage.Name = "btnUploudImage";
            this.btnUploudImage.Size = new System.Drawing.Size(186, 23);
            this.btnUploudImage.TabIndex = 51;
            this.btnUploudImage.Text = "Uploud Image";
            this.btnUploudImage.UseVisualStyleBackColor = true;
            this.btnUploudImage.Click += new System.EventHandler(this.btnUploudImage_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(534, 394);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 23);
            this.button6.TabIndex = 50;
            this.button6.Text = "Search";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // txtboxCariPengguna
            // 
            this.txtboxCariPengguna.Location = new System.Drawing.Point(24, 394);
            this.txtboxCariPengguna.Multiline = true;
            this.txtboxCariPengguna.Name = "txtboxCariPengguna";
            this.txtboxCariPengguna.Size = new System.Drawing.Size(498, 24);
            this.txtboxCariPengguna.TabIndex = 49;
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(533, 320);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(75, 23);
            this.buttonDelete.TabIndex = 48;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = true;
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Location = new System.Drawing.Point(533, 286);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(75, 23);
            this.buttonUpdate.TabIndex = 47;
            this.buttonUpdate.Text = "Update";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // buttonInsert
            // 
            this.buttonInsert.Location = new System.Drawing.Point(422, 286);
            this.buttonInsert.Name = "buttonInsert";
            this.buttonInsert.Size = new System.Drawing.Size(75, 23);
            this.buttonInsert.TabIndex = 46;
            this.buttonInsert.Text = "Insert";
            this.buttonInsert.UseVisualStyleBackColor = true;
            this.buttonInsert.Click += new System.EventHandler(this.buttonInsert_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(422, 320);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(75, 23);
            this.buttonClear.TabIndex = 45;
            this.buttonClear.Text = "Clear";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // pictureBoxProfile
            // 
            this.pictureBoxProfile.BackColor = System.Drawing.SystemColors.ControlDark;
            this.pictureBoxProfile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBoxProfile.Location = new System.Drawing.Point(422, 24);
            this.pictureBoxProfile.Name = "pictureBoxProfile";
            this.pictureBoxProfile.Size = new System.Drawing.Size(186, 189);
            this.pictureBoxProfile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxProfile.TabIndex = 44;
            this.pictureBoxProfile.TabStop = false;
            // 
            // dataGridViewBarang
            // 
            this.dataGridViewBarang.AllowUserToAddRows = false;
            this.dataGridViewBarang.AllowUserToDeleteRows = false;
            this.dataGridViewBarang.AllowUserToOrderColumns = true;
            this.dataGridViewBarang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBarang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.gambar,
            this.foto,
            this.kode,
            this.nama,
            this.jumlah,
            this.harga,
            this.ubah,
            this.hapus});
            this.dataGridViewBarang.Location = new System.Drawing.Point(25, 435);
            this.dataGridViewBarang.Name = "dataGridViewBarang";
            this.dataGridViewBarang.ReadOnly = true;
            this.dataGridViewBarang.Size = new System.Drawing.Size(584, 166);
            this.dataGridViewBarang.TabIndex = 7;
            this.dataGridViewBarang.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewPegawai_CellContentClick);
            this.dataGridViewBarang.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridViewBarang_CellFormatting);
            // 
            // comboBoxKode
            // 
            this.comboBoxKode.DisplayMember = "Tes1";
            this.comboBoxKode.FormattingEnabled = true;
            this.comboBoxKode.Items.AddRange(new object[] {
            "test1",
            "test2",
            "test3",
            "test4",
            "test5"});
            this.comboBoxKode.Location = new System.Drawing.Point(214, 81);
            this.comboBoxKode.Name = "comboBoxKode";
            this.comboBoxKode.Size = new System.Drawing.Size(152, 21);
            this.comboBoxKode.TabIndex = 55;
            // 
            // textBoxId
            // 
            this.textBoxId.Location = new System.Drawing.Point(46, 565);
            this.textBoxId.Multiline = true;
            this.textBoxId.Name = "textBoxId";
            this.textBoxId.ReadOnly = true;
            this.textBoxId.Size = new System.Drawing.Size(10, 10);
            this.textBoxId.TabIndex = 56;
            this.textBoxId.Visible = false;
            // 
            // gambar
            // 
            this.gambar.HeaderText = "Gambar";
            this.gambar.Name = "gambar";
            this.gambar.ReadOnly = true;
            this.gambar.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // foto
            // 
            this.foto.DataPropertyName = "gambar_barang";
            this.foto.HeaderText = "Foto";
            this.foto.Name = "foto";
            this.foto.ReadOnly = true;
            // 
            // kode
            // 
            this.kode.DataPropertyName = "kode_barang";
            this.kode.HeaderText = "Kode Barang";
            this.kode.Name = "kode";
            this.kode.ReadOnly = true;
            // 
            // nama
            // 
            this.nama.DataPropertyName = "nama_barang";
            this.nama.HeaderText = "Nama Barang";
            this.nama.Name = "nama";
            this.nama.ReadOnly = true;
            // 
            // jumlah
            // 
            this.jumlah.DataPropertyName = "jumlah_barang";
            this.jumlah.HeaderText = "Jumlah Barang";
            this.jumlah.Name = "jumlah";
            this.jumlah.ReadOnly = true;
            // 
            // harga
            // 
            this.harga.DataPropertyName = "harga_barang";
            this.harga.HeaderText = "Harga Barang";
            this.harga.Name = "harga";
            this.harga.ReadOnly = true;
            // 
            // ubah
            // 
            this.ubah.HeaderText = "Ubah";
            this.ubah.Name = "ubah";
            this.ubah.ReadOnly = true;
            this.ubah.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.ubah.Text = "Ubah";
            this.ubah.ToolTipText = "Ubah";
            this.ubah.UseColumnTextForButtonValue = true;
            // 
            // hapus
            // 
            this.hapus.HeaderText = "Hapus";
            this.hapus.Name = "hapus";
            this.hapus.ReadOnly = true;
            this.hapus.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.hapus.Text = "Hapus";
            this.hapus.ToolTipText = "Hapus";
            this.hapus.UseColumnTextForButtonValue = true;
            // 
            // FormBarang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkOrchid;
            this.ClientSize = new System.Drawing.Size(657, 613);
            this.Controls.Add(this.comboBoxKode);
            this.Controls.Add(this.dataGridViewBarang);
            this.Controls.Add(this.btnDisplay);
            this.Controls.Add(this.textbox_image_path);
            this.Controls.Add(this.btnUploudImage);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.txtboxCariPengguna);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.buttonInsert);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.pictureBoxProfile);
            this.Controls.Add(this.textHarga);
            this.Controls.Add(this.textJumlah);
            this.Controls.Add(this.textNama);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxId);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormBarang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormBarang";
            this.Load += new System.EventHandler(this.FormBarang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProfile)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBarang)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textNama;
        private System.Windows.Forms.TextBox textJumlah;
        private System.Windows.Forms.TextBox textHarga;
        private System.Windows.Forms.Button btnDisplay;
        private System.Windows.Forms.TextBox textbox_image_path;
        private System.Windows.Forms.Button btnUploudImage;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.TextBox txtboxCariPengguna;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Button buttonInsert;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.PictureBox pictureBoxProfile;
        private System.Windows.Forms.DataGridView dataGridViewBarang;
        private System.Windows.Forms.ComboBox comboBoxKode;
        private System.Windows.Forms.TextBox textBoxId;
        private System.Windows.Forms.DataGridViewImageColumn gambar;
        private System.Windows.Forms.DataGridViewTextBoxColumn foto;
        private System.Windows.Forms.DataGridViewTextBoxColumn kode;
        private System.Windows.Forms.DataGridViewTextBoxColumn nama;
        private System.Windows.Forms.DataGridViewTextBoxColumn jumlah;
        private System.Windows.Forms.DataGridViewTextBoxColumn harga;
        private System.Windows.Forms.DataGridViewButtonColumn ubah;
        private System.Windows.Forms.DataGridViewButtonColumn hapus;
    }
}