namespace ProjectUas
{
    partial class MDIContainer
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.inputDataPegawaiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inputDataPegawaiToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.daftarPegawaiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataBarangToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inputDataBarangToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.daftarBarangToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inputDataPegawaiToolStripMenuItem,
            this.dataBarangToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(734, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // inputDataPegawaiToolStripMenuItem
            // 
            this.inputDataPegawaiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inputDataPegawaiToolStripMenuItem1,
            this.daftarPegawaiToolStripMenuItem});
            this.inputDataPegawaiToolStripMenuItem.Name = "inputDataPegawaiToolStripMenuItem";
            this.inputDataPegawaiToolStripMenuItem.Size = new System.Drawing.Size(90, 20);
            this.inputDataPegawaiToolStripMenuItem.Text = "Data Pegawai";
            // 
            // inputDataPegawaiToolStripMenuItem1
            // 
            this.inputDataPegawaiToolStripMenuItem1.Name = "inputDataPegawaiToolStripMenuItem1";
            this.inputDataPegawaiToolStripMenuItem1.Size = new System.Drawing.Size(176, 22);
            this.inputDataPegawaiToolStripMenuItem1.Text = "Input Data Pegawai";
            this.inputDataPegawaiToolStripMenuItem1.Click += new System.EventHandler(this.inputDataPegawaiToolStripMenuItem1_Click);
            // 
            // daftarPegawaiToolStripMenuItem
            // 
            this.daftarPegawaiToolStripMenuItem.Name = "daftarPegawaiToolStripMenuItem";
            this.daftarPegawaiToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.daftarPegawaiToolStripMenuItem.Text = "Daftar Pegawai";
            this.daftarPegawaiToolStripMenuItem.Click += new System.EventHandler(this.daftarPegawaiToolStripMenuItem_Click);
            // 
            // dataBarangToolStripMenuItem
            // 
            this.dataBarangToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inputDataBarangToolStripMenuItem,
            this.daftarBarangToolStripMenuItem});
            this.dataBarangToolStripMenuItem.Name = "dataBarangToolStripMenuItem";
            this.dataBarangToolStripMenuItem.Size = new System.Drawing.Size(83, 20);
            this.dataBarangToolStripMenuItem.Text = "Data Barang";
            // 
            // inputDataBarangToolStripMenuItem
            // 
            this.inputDataBarangToolStripMenuItem.Name = "inputDataBarangToolStripMenuItem";
            this.inputDataBarangToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.inputDataBarangToolStripMenuItem.Text = "Input Data Barang";
            // 
            // daftarBarangToolStripMenuItem
            // 
            this.daftarBarangToolStripMenuItem.Name = "daftarBarangToolStripMenuItem";
            this.daftarBarangToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.daftarBarangToolStripMenuItem.Text = "Daftar Barang";
            // 
            // MDIContainer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 611);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MDIContainer";
            this.Text = "MDIContainer";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem inputDataPegawaiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inputDataPegawaiToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem daftarPegawaiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dataBarangToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inputDataBarangToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem daftarBarangToolStripMenuItem;
    }
}