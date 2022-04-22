namespace ProjectUas
{
    partial class FormDataPegawai
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxNama = new System.Windows.Forms.TextBox();
            this.comboBoxPendidikan = new System.Windows.Forms.ComboBox();
            this.textBoxNoHp = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxAlamat = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBoxJenisKelamin = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.dateTimePickerPegawai = new System.Windows.Forms.DateTimePicker();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnUploud = new System.Windows.Forms.Button();
            this.btnInput = new System.Windows.Forms.Button();
            this.dataGridViewPegawai = new System.Windows.Forms.DataGridView();
            this.textbox_image_path = new System.Windows.Forms.TextBox();
            this.buttonRefresh = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPegawai)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(229, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(243, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Input Daftar Pegawai";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.textBoxID, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.textBoxNama, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.comboBoxPendidikan, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.textBoxNoHp, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.label6, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.textBoxAlamat, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.label7, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.comboBoxJenisKelamin, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.label8, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.dateTimePickerPegawai, 1, 3);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(37, 75);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 7;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 53F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 49F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 53F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 76F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(367, 388);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // textBoxID
            // 
            this.textBoxID.Location = new System.Drawing.Point(186, 67);
            this.textBoxID.MaxLength = 15;
            this.textBoxID.Multiline = true;
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.Size = new System.Drawing.Size(178, 46);
            this.textBoxID.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nama";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(18, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "ID";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 128);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Pendidikan";
            // 
            // textBoxNama
            // 
            this.textBoxNama.Location = new System.Drawing.Point(186, 3);
            this.textBoxNama.Multiline = true;
            this.textBoxNama.Name = "textBoxNama";
            this.textBoxNama.Size = new System.Drawing.Size(178, 46);
            this.textBoxNama.TabIndex = 7;
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
            this.comboBoxPendidikan.Location = new System.Drawing.Point(186, 131);
            this.comboBoxPendidikan.Name = "comboBoxPendidikan";
            this.comboBoxPendidikan.Size = new System.Drawing.Size(178, 21);
            this.comboBoxPendidikan.TabIndex = 15;
            // 
            // textBoxNoHp
            // 
            this.textBoxNoHp.Location = new System.Drawing.Point(186, 362);
            this.textBoxNoHp.MaxLength = 13;
            this.textBoxNoHp.Multiline = true;
            this.textBoxNoHp.Name = "textBoxNoHp";
            this.textBoxNoHp.Size = new System.Drawing.Size(178, 23);
            this.textBoxNoHp.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 359);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "No. Hp";
            // 
            // textBoxAlamat
            // 
            this.textBoxAlamat.Location = new System.Drawing.Point(186, 286);
            this.textBoxAlamat.Multiline = true;
            this.textBoxAlamat.Name = "textBoxAlamat";
            this.textBoxAlamat.Size = new System.Drawing.Size(178, 66);
            this.textBoxAlamat.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 283);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Alamat";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 230);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Jenis Kelamin";
            // 
            // comboBoxJenisKelamin
            // 
            this.comboBoxJenisKelamin.FormattingEnabled = true;
            this.comboBoxJenisKelamin.Items.AddRange(new object[] {
            "Laki-Laki",
            "Perempuan"});
            this.comboBoxJenisKelamin.Location = new System.Drawing.Point(186, 233);
            this.comboBoxJenisKelamin.Name = "comboBoxJenisKelamin";
            this.comboBoxJenisKelamin.Size = new System.Drawing.Size(178, 21);
            this.comboBoxJenisKelamin.TabIndex = 12;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(3, 181);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(72, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "Tanggal Lahir";
            // 
            // dateTimePickerPegawai
            // 
            this.dateTimePickerPegawai.Location = new System.Drawing.Point(186, 184);
            this.dateTimePickerPegawai.Name = "dateTimePickerPegawai";
            this.dateTimePickerPegawai.Size = new System.Drawing.Size(178, 20);
            this.dateTimePickerPegawai.TabIndex = 17;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.pictureBox1.Location = new System.Drawing.Point(425, 75);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(263, 213);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // btnUploud
            // 
            this.btnUploud.Location = new System.Drawing.Point(503, 320);
            this.btnUploud.Name = "btnUploud";
            this.btnUploud.Size = new System.Drawing.Size(107, 34);
            this.btnUploud.TabIndex = 4;
            this.btnUploud.Text = "Upload Image";
            this.btnUploud.UseVisualStyleBackColor = true;
            this.btnUploud.Click += new System.EventHandler(this.btnUploud_Click);
            // 
            // btnInput
            // 
            this.btnInput.Location = new System.Drawing.Point(156, 480);
            this.btnInput.Name = "btnInput";
            this.btnInput.Size = new System.Drawing.Size(132, 37);
            this.btnInput.TabIndex = 5;
            this.btnInput.Text = "Input";
            this.btnInput.UseVisualStyleBackColor = true;
            this.btnInput.Click += new System.EventHandler(this.btnInput_Click);
            // 
            // dataGridViewPegawai
            // 
            this.dataGridViewPegawai.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPegawai.Location = new System.Drawing.Point(425, 356);
            this.dataGridViewPegawai.Name = "dataGridViewPegawai";
            this.dataGridViewPegawai.RowHeadersWidth = 123;
            this.dataGridViewPegawai.Size = new System.Drawing.Size(263, 150);
            this.dataGridViewPegawai.TabIndex = 6;
            this.dataGridViewPegawai.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewPegawai_CellContentClick);
            // 
            // textbox_image_path
            // 
            this.textbox_image_path.Location = new System.Drawing.Point(425, 294);
            this.textbox_image_path.Multiline = true;
            this.textbox_image_path.Name = "textbox_image_path";
            this.textbox_image_path.Size = new System.Drawing.Size(263, 20);
            this.textbox_image_path.TabIndex = 7;
            this.textbox_image_path.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // buttonRefresh
            // 
            this.buttonRefresh.Location = new System.Drawing.Point(503, 512);
            this.buttonRefresh.Name = "buttonRefresh";
            this.buttonRefresh.Size = new System.Drawing.Size(107, 34);
            this.buttonRefresh.TabIndex = 8;
            this.buttonRefresh.Text = "Refresh";
            this.buttonRefresh.UseVisualStyleBackColor = true;
            this.buttonRefresh.Click += new System.EventHandler(this.buttonRefresh_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.Red;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.Location = new System.Drawing.Point(594, 12);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(84, 29);
            this.btnLogout.TabIndex = 9;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormDataPegawai
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.ClientSize = new System.Drawing.Size(700, 600);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.buttonRefresh);
            this.Controls.Add(this.textbox_image_path);
            this.Controls.Add(this.dataGridViewPegawai);
            this.Controls.Add(this.btnInput);
            this.Controls.Add(this.btnUploud);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormDataPegawai";
            this.Load += new System.EventHandler(this.FormDataPegawai_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPegawai)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox textBoxID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxNama;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnUploud;
        private System.Windows.Forms.Button btnInput;
        private System.Windows.Forms.ComboBox comboBoxJenisKelamin;
        private System.Windows.Forms.DataGridView dataGridViewPegawai;
        private System.Windows.Forms.TextBox textBoxAlamat;
        private System.Windows.Forms.TextBox textBoxNoHp;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textbox_image_path;
        private System.Windows.Forms.ComboBox comboBoxPendidikan;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dateTimePickerPegawai;
        private System.Windows.Forms.Button buttonRefresh;
        private System.Windows.Forms.Button btnLogout;
    }
}

