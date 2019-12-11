namespace CoffeCaria
{
    partial class FrmAwalAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAwalAdmin));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnLaporan = new System.Windows.Forms.Button();
            this.btnKeluar = new System.Windows.Forms.Button();
            this.btnDPesanan = new System.Windows.Forms.Button();
            this.btnDMCoffee = new System.Windows.Forms.Button();
            this.pnlDataMenu = new System.Windows.Forms.Panel();
            this.btnReset = new System.Windows.Forms.Button();
            this.dgvLstMenu = new System.Windows.Forms.DataGridView();
            this.nudHarga = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNCoffee = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtIdCoffee = new System.Windows.Forms.TextBox();
            this.btnHapus = new System.Windows.Forms.Button();
            this.btnUbah = new System.Windows.Forms.Button();
            this.btnTambah = new System.Windows.Forms.Button();
            this.pnlDataPesanan = new System.Windows.Forms.Panel();
            this.btnHapusDPesanan = new System.Windows.Forms.Button();
            this.dgvDataPesanan = new System.Windows.Forms.DataGridView();
            this.pnlLaporan = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.bBtnLaporanMenu = new Bunifu.Framework.UI.BunifuThinButton2();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bBtnLaporanPesanan = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnClose = new System.Windows.Forms.Button();
            this.pnlBar = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.pnlDataMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLstMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudHarga)).BeginInit();
            this.pnlDataPesanan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDataPesanan)).BeginInit();
            this.pnlLaporan.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnlBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel1.Controls.Add(this.btnLaporan);
            this.panel1.Controls.Add(this.btnKeluar);
            this.panel1.Controls.Add(this.btnDPesanan);
            this.panel1.Controls.Add(this.btnDMCoffee);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 269);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(678, 48);
            this.panel1.TabIndex = 0;
            // 
            // btnLaporan
            // 
            this.btnLaporan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLaporan.Font = new System.Drawing.Font("Minion Pro", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLaporan.Location = new System.Drawing.Point(290, 3);
            this.btnLaporan.Name = "btnLaporan";
            this.btnLaporan.Size = new System.Drawing.Size(122, 42);
            this.btnLaporan.TabIndex = 5;
            this.btnLaporan.Text = "Laporan";
            this.btnLaporan.UseVisualStyleBackColor = true;
            this.btnLaporan.Click += new System.EventHandler(this.btnLaporan_Click);
            // 
            // btnKeluar
            // 
            this.btnKeluar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKeluar.Font = new System.Drawing.Font("Minion Pro", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKeluar.Location = new System.Drawing.Point(544, 3);
            this.btnKeluar.Name = "btnKeluar";
            this.btnKeluar.Size = new System.Drawing.Size(122, 42);
            this.btnKeluar.TabIndex = 4;
            this.btnKeluar.Text = "Keluar";
            this.btnKeluar.UseVisualStyleBackColor = true;
            this.btnKeluar.Click += new System.EventHandler(this.btnKeluar_Click);
            // 
            // btnDPesanan
            // 
            this.btnDPesanan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDPesanan.Font = new System.Drawing.Font("Minion Pro", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDPesanan.Location = new System.Drawing.Point(162, 3);
            this.btnDPesanan.Name = "btnDPesanan";
            this.btnDPesanan.Size = new System.Drawing.Size(122, 42);
            this.btnDPesanan.TabIndex = 3;
            this.btnDPesanan.Text = "Data Pesanan";
            this.btnDPesanan.UseVisualStyleBackColor = true;
            this.btnDPesanan.Click += new System.EventHandler(this.btnDPesanan_Click);
            // 
            // btnDMCoffee
            // 
            this.btnDMCoffee.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDMCoffee.Font = new System.Drawing.Font("Minion Pro", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDMCoffee.Location = new System.Drawing.Point(12, 3);
            this.btnDMCoffee.Name = "btnDMCoffee";
            this.btnDMCoffee.Size = new System.Drawing.Size(144, 42);
            this.btnDMCoffee.TabIndex = 2;
            this.btnDMCoffee.Text = "Data Menu Coffee ";
            this.btnDMCoffee.UseVisualStyleBackColor = true;
            this.btnDMCoffee.Click += new System.EventHandler(this.btnDMCoffee_Click);
            // 
            // pnlDataMenu
            // 
            this.pnlDataMenu.Controls.Add(this.btnReset);
            this.pnlDataMenu.Controls.Add(this.dgvLstMenu);
            this.pnlDataMenu.Controls.Add(this.nudHarga);
            this.pnlDataMenu.Controls.Add(this.label3);
            this.pnlDataMenu.Controls.Add(this.label2);
            this.pnlDataMenu.Controls.Add(this.txtNCoffee);
            this.pnlDataMenu.Controls.Add(this.label1);
            this.pnlDataMenu.Controls.Add(this.txtIdCoffee);
            this.pnlDataMenu.Controls.Add(this.btnHapus);
            this.pnlDataMenu.Controls.Add(this.btnUbah);
            this.pnlDataMenu.Controls.Add(this.btnTambah);
            this.pnlDataMenu.Location = new System.Drawing.Point(0, 29);
            this.pnlDataMenu.Name = "pnlDataMenu";
            this.pnlDataMenu.Size = new System.Drawing.Size(678, 240);
            this.pnlDataMenu.TabIndex = 2;
            // 
            // btnReset
            // 
            this.btnReset.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReset.ForeColor = System.Drawing.Color.DodgerBlue;
            this.btnReset.Location = new System.Drawing.Point(144, 174);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(96, 32);
            this.btnReset.TabIndex = 12;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // dgvLstMenu
            // 
            this.dgvLstMenu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLstMenu.Location = new System.Drawing.Point(269, 6);
            this.dgvLstMenu.Name = "dgvLstMenu";
            this.dgvLstMenu.Size = new System.Drawing.Size(397, 200);
            this.dgvLstMenu.TabIndex = 11;
            this.dgvLstMenu.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLstPesanan_CellDoubleClick);
            // 
            // nudHarga
            // 
            this.nudHarga.Location = new System.Drawing.Point(143, 87);
            this.nudHarga.Name = "nudHarga";
            this.nudHarga.Size = new System.Drawing.Size(100, 20);
            this.nudHarga.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Minion Pro", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(28, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "Harga Coffee";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Minion Pro", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(28, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Nama Coffee";
            // 
            // txtNCoffee
            // 
            this.txtNCoffee.Location = new System.Drawing.Point(143, 60);
            this.txtNCoffee.Name = "txtNCoffee";
            this.txtNCoffee.Size = new System.Drawing.Size(100, 20);
            this.txtNCoffee.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Minion Pro", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(28, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "IdCoffee";
            // 
            // txtIdCoffee
            // 
            this.txtIdCoffee.Location = new System.Drawing.Point(143, 34);
            this.txtIdCoffee.Name = "txtIdCoffee";
            this.txtIdCoffee.Size = new System.Drawing.Size(100, 20);
            this.txtIdCoffee.TabIndex = 4;
            this.txtIdCoffee.Validating += new System.ComponentModel.CancelEventHandler(this.txtIdCoffee_Validating);
            // 
            // btnHapus
            // 
            this.btnHapus.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnHapus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHapus.ForeColor = System.Drawing.Color.DodgerBlue;
            this.btnHapus.Location = new System.Drawing.Point(144, 124);
            this.btnHapus.Name = "btnHapus";
            this.btnHapus.Size = new System.Drawing.Size(96, 32);
            this.btnHapus.TabIndex = 3;
            this.btnHapus.Text = "Hapus";
            this.btnHapus.UseVisualStyleBackColor = true;
            this.btnHapus.Click += new System.EventHandler(this.btnHapus_Click);
            // 
            // btnUbah
            // 
            this.btnUbah.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnUbah.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUbah.ForeColor = System.Drawing.Color.DodgerBlue;
            this.btnUbah.Location = new System.Drawing.Point(32, 174);
            this.btnUbah.Name = "btnUbah";
            this.btnUbah.Size = new System.Drawing.Size(96, 32);
            this.btnUbah.TabIndex = 2;
            this.btnUbah.Text = "Ubah";
            this.btnUbah.UseVisualStyleBackColor = true;
            this.btnUbah.Click += new System.EventHandler(this.btnUbah_Click);
            // 
            // btnTambah
            // 
            this.btnTambah.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnTambah.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTambah.ForeColor = System.Drawing.Color.DodgerBlue;
            this.btnTambah.Location = new System.Drawing.Point(32, 124);
            this.btnTambah.Name = "btnTambah";
            this.btnTambah.Size = new System.Drawing.Size(96, 32);
            this.btnTambah.TabIndex = 1;
            this.btnTambah.Text = "Tambah";
            this.btnTambah.UseVisualStyleBackColor = true;
            this.btnTambah.Click += new System.EventHandler(this.btnTambah_Click);
            // 
            // pnlDataPesanan
            // 
            this.pnlDataPesanan.Controls.Add(this.btnHapusDPesanan);
            this.pnlDataPesanan.Controls.Add(this.dgvDataPesanan);
            this.pnlDataPesanan.Location = new System.Drawing.Point(0, 29);
            this.pnlDataPesanan.Name = "pnlDataPesanan";
            this.pnlDataPesanan.Size = new System.Drawing.Size(678, 240);
            this.pnlDataPesanan.TabIndex = 3;
            // 
            // btnHapusDPesanan
            // 
            this.btnHapusDPesanan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHapusDPesanan.Font = new System.Drawing.Font("Minion Pro", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHapusDPesanan.ForeColor = System.Drawing.Color.DodgerBlue;
            this.btnHapusDPesanan.Location = new System.Drawing.Point(58, 87);
            this.btnHapusDPesanan.Name = "btnHapusDPesanan";
            this.btnHapusDPesanan.Size = new System.Drawing.Size(133, 44);
            this.btnHapusDPesanan.TabIndex = 1;
            this.btnHapusDPesanan.Text = "Hapus";
            this.btnHapusDPesanan.UseVisualStyleBackColor = true;
            this.btnHapusDPesanan.Click += new System.EventHandler(this.btnHapusDPesanan_Click);
            // 
            // dgvDataPesanan
            // 
            this.dgvDataPesanan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDataPesanan.Location = new System.Drawing.Point(249, 6);
            this.dgvDataPesanan.Name = "dgvDataPesanan";
            this.dgvDataPesanan.Size = new System.Drawing.Size(417, 228);
            this.dgvDataPesanan.TabIndex = 0;
            // 
            // pnlLaporan
            // 
            this.pnlLaporan.Controls.Add(this.panel4);
            this.pnlLaporan.Controls.Add(this.panel3);
            this.pnlLaporan.Location = new System.Drawing.Point(0, 29);
            this.pnlLaporan.Name = "pnlLaporan";
            this.pnlLaporan.Size = new System.Drawing.Size(678, 240);
            this.pnlLaporan.TabIndex = 4;
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel4.Controls.Add(this.pictureBox2);
            this.panel4.Controls.Add(this.bBtnLaporanMenu);
            this.panel4.Location = new System.Drawing.Point(373, 44);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(226, 135);
            this.panel4.TabIndex = 3;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(81, 16);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(69, 56);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // bBtnLaporanMenu
            // 
            this.bBtnLaporanMenu.ActiveBorderThickness = 1;
            this.bBtnLaporanMenu.ActiveCornerRadius = 20;
            this.bBtnLaporanMenu.ActiveFillColor = System.Drawing.Color.DarkCyan;
            this.bBtnLaporanMenu.ActiveForecolor = System.Drawing.Color.White;
            this.bBtnLaporanMenu.ActiveLineColor = System.Drawing.Color.DarkCyan;
            this.bBtnLaporanMenu.BackColor = System.Drawing.SystemColors.Control;
            this.bBtnLaporanMenu.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bBtnLaporanMenu.BackgroundImage")));
            this.bBtnLaporanMenu.ButtonText = "Laporan Menu";
            this.bBtnLaporanMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bBtnLaporanMenu.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bBtnLaporanMenu.ForeColor = System.Drawing.Color.SeaGreen;
            this.bBtnLaporanMenu.IdleBorderThickness = 1;
            this.bBtnLaporanMenu.IdleCornerRadius = 20;
            this.bBtnLaporanMenu.IdleFillColor = System.Drawing.Color.White;
            this.bBtnLaporanMenu.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.bBtnLaporanMenu.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.bBtnLaporanMenu.Location = new System.Drawing.Point(32, 81);
            this.bBtnLaporanMenu.Margin = new System.Windows.Forms.Padding(5);
            this.bBtnLaporanMenu.Name = "bBtnLaporanMenu";
            this.bBtnLaporanMenu.Size = new System.Drawing.Size(165, 41);
            this.bBtnLaporanMenu.TabIndex = 1;
            this.bBtnLaporanMenu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bBtnLaporanMenu.Click += new System.EventHandler(this.bBtnLaporanMenu_Click);
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Controls.Add(this.bBtnLaporanPesanan);
            this.panel3.Location = new System.Drawing.Point(75, 44);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(226, 135);
            this.panel3.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(76, 16);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(69, 56);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // bBtnLaporanPesanan
            // 
            this.bBtnLaporanPesanan.ActiveBorderThickness = 1;
            this.bBtnLaporanPesanan.ActiveCornerRadius = 20;
            this.bBtnLaporanPesanan.ActiveFillColor = System.Drawing.Color.DarkCyan;
            this.bBtnLaporanPesanan.ActiveForecolor = System.Drawing.Color.White;
            this.bBtnLaporanPesanan.ActiveLineColor = System.Drawing.Color.DarkCyan;
            this.bBtnLaporanPesanan.BackColor = System.Drawing.SystemColors.Control;
            this.bBtnLaporanPesanan.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bBtnLaporanPesanan.BackgroundImage")));
            this.bBtnLaporanPesanan.ButtonText = "Laporan Pesanan";
            this.bBtnLaporanPesanan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bBtnLaporanPesanan.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bBtnLaporanPesanan.ForeColor = System.Drawing.Color.SeaGreen;
            this.bBtnLaporanPesanan.IdleBorderThickness = 1;
            this.bBtnLaporanPesanan.IdleCornerRadius = 20;
            this.bBtnLaporanPesanan.IdleFillColor = System.Drawing.Color.White;
            this.bBtnLaporanPesanan.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.bBtnLaporanPesanan.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.bBtnLaporanPesanan.Location = new System.Drawing.Point(32, 81);
            this.bBtnLaporanPesanan.Margin = new System.Windows.Forms.Padding(5);
            this.bBtnLaporanPesanan.Name = "bBtnLaporanPesanan";
            this.bBtnLaporanPesanan.Size = new System.Drawing.Size(165, 41);
            this.bBtnLaporanPesanan.TabIndex = 1;
            this.bBtnLaporanPesanan.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bBtnLaporanPesanan.Click += new System.EventHandler(this.bBtnLaporanPesanan_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.Location = new System.Drawing.Point(650, 2);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(25, 25);
            this.btnClose.TabIndex = 7;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // pnlBar
            // 
            this.pnlBar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pnlBar.Controls.Add(this.btnClose);
            this.pnlBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlBar.Location = new System.Drawing.Point(0, 0);
            this.pnlBar.Name = "pnlBar";
            this.pnlBar.Size = new System.Drawing.Size(678, 29);
            this.pnlBar.TabIndex = 1;
            // 
            // FrmAwalAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(678, 317);
            this.Controls.Add(this.pnlLaporan);
            this.Controls.Add(this.pnlDataPesanan);
            this.Controls.Add(this.pnlDataMenu);
            this.Controls.Add(this.pnlBar);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmAwalAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmAwalAdmin";
            this.panel1.ResumeLayout(false);
            this.pnlDataMenu.ResumeLayout(false);
            this.pnlDataMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLstMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudHarga)).EndInit();
            this.pnlDataPesanan.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDataPesanan)).EndInit();
            this.pnlLaporan.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnlBar.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnDMCoffee;
        private System.Windows.Forms.Panel pnlDataMenu;
        private System.Windows.Forms.Button btnTambah;
        private System.Windows.Forms.Button btnUbah;
        private System.Windows.Forms.Button btnHapus;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtIdCoffee;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNCoffee;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown nudHarga;
        private System.Windows.Forms.DataGridView dgvLstMenu;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnDPesanan;
        private System.Windows.Forms.Panel pnlDataPesanan;
        private System.Windows.Forms.DataGridView dgvDataPesanan;
        private System.Windows.Forms.Button btnHapusDPesanan;
        private System.Windows.Forms.Button btnKeluar;
        private System.Windows.Forms.Button btnLaporan;
        private System.Windows.Forms.Panel pnlLaporan;
        private System.Windows.Forms.Panel panel3;
        private Bunifu.Framework.UI.BunifuThinButton2 bBtnLaporanPesanan;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.PictureBox pictureBox2;
        private Bunifu.Framework.UI.BunifuThinButton2 bBtnLaporanMenu;
        private System.Windows.Forms.Panel pnlBar;
        private System.Windows.Forms.Button btnClose;
    }
}