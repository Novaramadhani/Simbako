namespace Simbako
{
    partial class FormLaporan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLaporan));
            tabControl1 = new TabControl();
            Panen = new TabPage();
            dgvLapPanen = new DataGridView();
            Produksi = new TabPage();
            dgvLapProduksi = new DataGridView();
            Penjualan = new TabPage();
            dgvLapPenjualan = new DataGridView();
            Stok = new TabPage();
            dgvLapStok = new DataGridView();
            btnLapPanen = new Button();
            btnLapProduksi = new Button();
            btnLapPenjualan = new Button();
            btnLapStok = new Button();
            panel1 = new Panel();
            dtpSampai = new DateTimePicker();
            dtpDari = new DateTimePicker();
            label2 = new Label();
            label1 = new Label();
            btnKeluar = new Button();
            pictureBox5 = new PictureBox();
            panel3 = new Panel();
            panel2 = new Panel();
            pictureBox4 = new PictureBox();
            label10 = new Label();
            label8 = new Label();
            pictureBox3 = new PictureBox();
            label12 = new Label();
            pictureBox2 = new PictureBox();
            label11 = new Label();
            tabControl1.SuspendLayout();
            Panen.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvLapPanen).BeginInit();
            Produksi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvLapProduksi).BeginInit();
            Penjualan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvLapPenjualan).BeginInit();
            Stok.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvLapStok).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(Panen);
            tabControl1.Controls.Add(Produksi);
            tabControl1.Controls.Add(Penjualan);
            tabControl1.Controls.Add(Stok);
            tabControl1.Font = new Font("Segoe UI Emoji", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tabControl1.Location = new Point(259, 157);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(776, 530);
            tabControl1.TabIndex = 0;
            // 
            // Panen
            // 
            Panen.Controls.Add(dgvLapPanen);
            Panen.Font = new Font("Segoe UI Emoji", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Panen.Location = new Point(4, 29);
            Panen.Name = "Panen";
            Panen.Padding = new Padding(3);
            Panen.Size = new Size(768, 497);
            Panen.TabIndex = 0;
            Panen.Text = "Panen";
            Panen.UseVisualStyleBackColor = true;
            // 
            // dgvLapPanen
            // 
            dgvLapPanen.BackgroundColor = Color.DarkOliveGreen;
            dgvLapPanen.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvLapPanen.Location = new Point(6, 3);
            dgvLapPanen.Name = "dgvLapPanen";
            dgvLapPanen.RowHeadersWidth = 51;
            dgvLapPanen.Size = new Size(756, 488);
            dgvLapPanen.TabIndex = 0;
            dgvLapPanen.CellContentClick += dgvLapPanen_CellContentClick;
            // 
            // Produksi
            // 
            Produksi.Controls.Add(dgvLapProduksi);
            Produksi.Font = new Font("Segoe UI Emoji", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Produksi.Location = new Point(4, 29);
            Produksi.Name = "Produksi";
            Produksi.Padding = new Padding(3);
            Produksi.Size = new Size(768, 497);
            Produksi.TabIndex = 1;
            Produksi.Text = "Produksi";
            Produksi.UseVisualStyleBackColor = true;
            // 
            // dgvLapProduksi
            // 
            dgvLapProduksi.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvLapProduksi.Location = new Point(6, 3);
            dgvLapProduksi.Name = "dgvLapProduksi";
            dgvLapProduksi.RowHeadersWidth = 51;
            dgvLapProduksi.Size = new Size(756, 196);
            dgvLapProduksi.TabIndex = 0;
            // 
            // Penjualan
            // 
            Penjualan.Controls.Add(dgvLapPenjualan);
            Penjualan.Font = new Font("Segoe UI Emoji", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Penjualan.Location = new Point(4, 29);
            Penjualan.Name = "Penjualan";
            Penjualan.Size = new Size(768, 497);
            Penjualan.TabIndex = 2;
            Penjualan.Text = "Penjualan";
            Penjualan.UseVisualStyleBackColor = true;
            // 
            // dgvLapPenjualan
            // 
            dgvLapPenjualan.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvLapPenjualan.Location = new Point(6, 3);
            dgvLapPenjualan.Name = "dgvLapPenjualan";
            dgvLapPenjualan.RowHeadersWidth = 51;
            dgvLapPenjualan.Size = new Size(756, 196);
            dgvLapPenjualan.TabIndex = 0;
            dgvLapPenjualan.CellContentClick += dgvLapPenjualan_CellContentClick;
            // 
            // Stok
            // 
            Stok.Controls.Add(dgvLapStok);
            Stok.Font = new Font("Segoe UI Emoji", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Stok.Location = new Point(4, 29);
            Stok.Name = "Stok";
            Stok.Size = new Size(768, 497);
            Stok.TabIndex = 3;
            Stok.Text = "Stok";
            Stok.UseVisualStyleBackColor = true;
            // 
            // dgvLapStok
            // 
            dgvLapStok.BackgroundColor = Color.DarkOliveGreen;
            dgvLapStok.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvLapStok.Location = new Point(6, 3);
            dgvLapStok.Name = "dgvLapStok";
            dgvLapStok.RowHeadersWidth = 51;
            dgvLapStok.Size = new Size(756, 491);
            dgvLapStok.TabIndex = 5;
            dgvLapStok.CellContentClick += dgvLapStok_CellContentClick;
            // 
            // btnLapPanen
            // 
            btnLapPanen.BackColor = Color.FromArgb(0, 64, 0);
            btnLapPanen.BackgroundImage = Properties.Resources.laporan_panen_dashboard;
            btnLapPanen.BackgroundImageLayout = ImageLayout.None;
            btnLapPanen.FlatAppearance.BorderSize = 0;
            btnLapPanen.FlatStyle = FlatStyle.Flat;
            btnLapPanen.Location = new Point(5, 211);
            btnLapPanen.Name = "btnLapPanen";
            btnLapPanen.Size = new Size(240, 52);
            btnLapPanen.TabIndex = 1;
            btnLapPanen.UseVisualStyleBackColor = false;
            btnLapPanen.Click += btnLapPanen_Click;
            // 
            // btnLapProduksi
            // 
            btnLapProduksi.BackColor = Color.FromArgb(0, 64, 0);
            btnLapProduksi.BackgroundImage = Properties.Resources.Laporan_Produksi;
            btnLapProduksi.BackgroundImageLayout = ImageLayout.None;
            btnLapProduksi.FlatAppearance.BorderSize = 0;
            btnLapProduksi.FlatStyle = FlatStyle.Flat;
            btnLapProduksi.Location = new Point(5, 272);
            btnLapProduksi.Name = "btnLapProduksi";
            btnLapProduksi.Size = new Size(241, 54);
            btnLapProduksi.TabIndex = 2;
            btnLapProduksi.UseVisualStyleBackColor = false;
            btnLapProduksi.Click += btnLapProduksi_Click;
            // 
            // btnLapPenjualan
            // 
            btnLapPenjualan.BackColor = Color.FromArgb(0, 64, 0);
            btnLapPenjualan.BackgroundImage = Properties.Resources.laporan_Penjualan;
            btnLapPenjualan.BackgroundImageLayout = ImageLayout.None;
            btnLapPenjualan.FlatAppearance.BorderSize = 0;
            btnLapPenjualan.FlatStyle = FlatStyle.Flat;
            btnLapPenjualan.Location = new Point(5, 333);
            btnLapPenjualan.Name = "btnLapPenjualan";
            btnLapPenjualan.Size = new Size(238, 53);
            btnLapPenjualan.TabIndex = 3;
            btnLapPenjualan.UseVisualStyleBackColor = false;
            btnLapPenjualan.Click += btnLapPenjualan_Click;
            // 
            // btnLapStok
            // 
            btnLapStok.BackColor = Color.FromArgb(0, 64, 0);
            btnLapStok.BackgroundImage = Properties.Resources.Laporan_Stuck;
            btnLapStok.BackgroundImageLayout = ImageLayout.None;
            btnLapStok.FlatAppearance.BorderSize = 0;
            btnLapStok.FlatStyle = FlatStyle.Flat;
            btnLapStok.Location = new Point(5, 395);
            btnLapStok.Name = "btnLapStok";
            btnLapStok.Size = new Size(242, 53);
            btnLapStok.TabIndex = 4;
            btnLapStok.UseVisualStyleBackColor = false;
            btnLapStok.Click += btnLapStok_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(dtpSampai);
            panel1.Controls.Add(dtpDari);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(259, 114);
            panel1.Name = "panel1";
            panel1.Size = new Size(776, 37);
            panel1.TabIndex = 5;
            // 
            // dtpSampai
            // 
            dtpSampai.Location = new Point(516, 5);
            dtpSampai.Name = "dtpSampai";
            dtpSampai.Size = new Size(250, 27);
            dtpSampai.TabIndex = 3;
            // 
            // dtpDari
            // 
            dtpDari.Location = new Point(117, 6);
            dtpDari.Name = "dtpDari";
            dtpDari.Size = new Size(250, 27);
            dtpDari.TabIndex = 2;
            dtpDari.ValueChanged += dtpDari_ValueChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Emoji", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ControlLightLight;
            label2.Location = new Point(416, 3);
            label2.Name = "label2";
            label2.Size = new Size(94, 27);
            label2.TabIndex = 1;
            label2.Text = "Sampai :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Emoji", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(12, 5);
            label1.Name = "label1";
            label1.Size = new Size(63, 27);
            label1.TabIndex = 0;
            label1.Text = "Dari :";
            // 
            // btnKeluar
            // 
            btnKeluar.BackColor = Color.FromArgb(0, 64, 0);
            btnKeluar.BackgroundImage = Properties.Resources.keluar_button4;
            btnKeluar.BackgroundImageLayout = ImageLayout.None;
            btnKeluar.FlatAppearance.BorderSize = 0;
            btnKeluar.FlatStyle = FlatStyle.Flat;
            btnKeluar.Location = new Point(70, 714);
            btnKeluar.Name = "btnKeluar";
            btnKeluar.Size = new Size(108, 45);
            btnKeluar.TabIndex = 6;
            btnKeluar.UseVisualStyleBackColor = false;
            btnKeluar.Click += btnKeluar_Click;
            // 
            // pictureBox5
            // 
            pictureBox5.BackColor = Color.FromArgb(0, 64, 0);
            pictureBox5.BackgroundImage = (Image)resources.GetObject("pictureBox5.BackgroundImage");
            pictureBox5.Location = new Point(-17, 114);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(264, 53);
            pictureBox5.TabIndex = 78;
            pictureBox5.TabStop = false;
            // 
            // panel3
            // 
            panel3.BackgroundImage = Properties.Resources.Line_11;
            panel3.Location = new Point(0, 178);
            panel3.Name = "panel3";
            panel3.Size = new Size(247, 13);
            panel3.TabIndex = 77;
            // 
            // panel2
            // 
            panel2.BackgroundImage = Properties.Resources.Line_11;
            panel2.Location = new Point(0, 95);
            panel2.Name = "panel2";
            panel2.Size = new Size(1067, 13);
            panel2.TabIndex = 76;
            // 
            // pictureBox4
            // 
            pictureBox4.BackColor = Color.FromArgb(26, 81, 38);
            pictureBox4.BackgroundImage = (Image)resources.GetObject("pictureBox4.BackgroundImage");
            pictureBox4.BackgroundImageLayout = ImageLayout.None;
            pictureBox4.Location = new Point(12, 24);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(52, 52);
            pictureBox4.TabIndex = 75;
            pictureBox4.TabStop = false;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.DarkGreen;
            label10.FlatStyle = FlatStyle.Flat;
            label10.Font = new Font("Segoe UI Historic", 8F, FontStyle.Bold);
            label10.ForeColor = Color.DarkGray;
            label10.Location = new Point(70, 59);
            label10.Name = "label10";
            label10.Size = new Size(170, 19);
            label10.TabIndex = 74;
            label10.Text = "Pengelolaan Tembakau";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.DarkOliveGreen;
            label8.Font = new Font("Segoe UI", 15F, FontStyle.Bold | FontStyle.Italic);
            label8.ForeColor = SystemColors.ControlLight;
            label8.Location = new Point(70, 24);
            label8.Name = "label8";
            label8.Size = new Size(127, 35);
            label8.TabIndex = 73;
            label8.Text = "SIMBAKO";
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.FromArgb(0, 64, 0);
            pictureBox3.Location = new Point(-42, -4);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(289, 796);
            pictureBox3.TabIndex = 72;
            pictureBox3.TabStop = false;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.BackColor = Color.Transparent;
            label12.FlatStyle = FlatStyle.Flat;
            label12.Font = new Font("Segoe UI Historic", 10.8F, FontStyle.Bold);
            label12.ForeColor = Color.LightGreen;
            label12.Location = new Point(340, 58);
            label12.Name = "label12";
            label12.Size = new Size(170, 25);
            label12.TabIndex = 82;
            label12.Text = "Semangat Admin!";
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.BackgroundImage = (Image)resources.GetObject("pictureBox2.BackgroundImage");
            pictureBox2.BackgroundImageLayout = ImageLayout.None;
            pictureBox2.Location = new Point(279, 23);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(54, 54);
            pictureBox2.TabIndex = 80;
            pictureBox2.TabStop = false;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = Color.Transparent;
            label11.Font = new Font("Segoe UI", 20F, FontStyle.Bold | FontStyle.Italic);
            label11.ForeColor = SystemColors.ControlLightLight;
            label11.Location = new Point(338, 12);
            label11.Name = "label11";
            label11.Size = new Size(365, 46);
            label11.TabIndex = 81;
            label11.Text = "Laporan Administrasi";
            // 
            // FormLaporan
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(50, 75, 41);
            ClientSize = new Size(1057, 788);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(pictureBox2);
            Controls.Add(btnLapStok);
            Controls.Add(btnLapPenjualan);
            Controls.Add(btnLapProduksi);
            Controls.Add(btnLapPanen);
            Controls.Add(btnKeluar);
            Controls.Add(pictureBox5);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(pictureBox4);
            Controls.Add(label10);
            Controls.Add(label8);
            Controls.Add(pictureBox3);
            Controls.Add(panel1);
            Controls.Add(tabControl1);
            Name = "FormLaporan";
            Text = "FormLaporan";
            Load += FormLaporan_Load;
            tabControl1.ResumeLayout(false);
            Panen.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvLapPanen).EndInit();
            Produksi.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvLapProduksi).EndInit();
            Penjualan.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvLapPenjualan).EndInit();
            Stok.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvLapStok).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TabControl tabControl1;
        private TabPage Panen;
        private TabPage Produksi;
        private Button btnLapPanen;
        private Button btnLapProduksi;
        private Button btnLapPenjualan;
        private Button btnLapStok;
        private TabPage Penjualan;
        private TabPage Stok;
        private DataGridView dgvLapProduksi;
        private DataGridView dgvLapPanen;
        private DataGridView dgvLapPenjualan;
        private DataGridView dgvLapStok;
        private Panel panel1;
        private DateTimePicker dtpSampai;
        private DateTimePicker dtpDari;
        private Label label2;
        private Label label1;
        private Button btnKeluar;
        private PictureBox pictureBox5;
        private Panel panel3;
        private Panel panel2;
        private PictureBox pictureBox4;
        private Label label10;
        private Label label8;
        private PictureBox pictureBox3;
        private Label label12;
        private PictureBox pictureBox2;
        private Label label11;
    }
}