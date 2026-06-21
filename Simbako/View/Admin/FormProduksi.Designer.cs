namespace Simbako
{
    partial class FormProduksi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormProduksi));
            dgvProduksi = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            cmbldPanen = new ComboBox();
            cmbStatus = new ComboBox();
            txtHasil = new TextBox();
            btnSimpan = new Button();
            btnEdit = new Button();
            btnHapus = new Button();
            btnRefresh = new Button();
            panel1 = new Panel();
            label9 = new Label();
            txtHarga = new TextBox();
            label8 = new Label();
            cmbJenisTembakau = new ComboBox();
            label5 = new Label();
            cmbKualitas = new ComboBox();
            label6 = new Label();
            txtJumlahDiolah = new TextBox();
            cmbJenisProses = new ComboBox();
            btnKeluar = new Button();
            pictureBox4 = new PictureBox();
            label10 = new Label();
            label7 = new Label();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            panel3 = new Panel();
            pictureBox5 = new PictureBox();
            label11 = new Label();
            pictureBox2 = new PictureBox();
            label12 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvProduksi).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // dgvProduksi
            // 
            dgvProduksi.BackgroundColor = Color.DarkKhaki;
            dgvProduksi.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProduksi.Location = new Point(253, 118);
            dgvProduksi.Name = "dgvProduksi";
            dgvProduksi.RowHeadersWidth = 51;
            dgvProduksi.Size = new Size(791, 284);
            dgvProduksi.TabIndex = 0;
            dgvProduksi.CellClick += dgvProduksi_CellClick;
            dgvProduksi.CellContentClick += dgvProduksi_CellContentClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Emoji", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(34, 13);
            label1.Name = "label1";
            label1.Size = new Size(185, 20);
            label1.TabIndex = 1;
            label1.Text = "ID Panen (Terverifikasi)";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Emoji", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(420, 13);
            label2.Name = "label2";
            label2.Size = new Size(103, 20);
            label2.TabIndex = 2;
            label2.Text = " Jenis Proses";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Emoji", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ControlLight;
            label3.Location = new Point(34, 78);
            label3.Name = "label3";
            label3.Size = new Size(124, 20);
            label3.TabIndex = 3;
            label3.Text = "Status Produksi";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Emoji", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(420, 78);
            label4.Name = "label4";
            label4.Size = new Size(154, 20);
            label4.TabIndex = 4;
            label4.Text = "Hasil Produksi (KG)";
            label4.Click += label4_Click;
            // 
            // cmbldPanen
            // 
            cmbldPanen.FormattingEnabled = true;
            cmbldPanen.Location = new Point(34, 36);
            cmbldPanen.Name = "cmbldPanen";
            cmbldPanen.Size = new Size(338, 28);
            cmbldPanen.TabIndex = 5;
            cmbldPanen.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // cmbStatus
            // 
            cmbStatus.FormattingEnabled = true;
            cmbStatus.Items.AddRange(new object[] { "Menunggu", "Proses", "Selesai", "Siap Jual" });
            cmbStatus.Location = new Point(34, 100);
            cmbStatus.Name = "cmbStatus";
            cmbStatus.Size = new Size(338, 28);
            cmbStatus.TabIndex = 6;
            cmbStatus.SelectedIndexChanged += comboBox2_SelectedIndexChanged;
            // 
            // txtHasil
            // 
            txtHasil.Location = new Point(424, 101);
            txtHasil.Name = "txtHasil";
            txtHasil.Size = new Size(338, 27);
            txtHasil.TabIndex = 8;
            txtHasil.TextChanged += txtHasil_TextChanged;
            // 
            // btnSimpan
            // 
            btnSimpan.BackColor = Color.FromArgb(0, 64, 0);
            btnSimpan.BackgroundImage = (Image)resources.GetObject("btnSimpan.BackgroundImage");
            btnSimpan.BackgroundImageLayout = ImageLayout.None;
            btnSimpan.FlatAppearance.BorderSize = 0;
            btnSimpan.FlatStyle = FlatStyle.Flat;
            btnSimpan.ForeColor = SystemColors.ControlText;
            btnSimpan.Location = new Point(3, 214);
            btnSimpan.Name = "btnSimpan";
            btnSimpan.Size = new Size(242, 58);
            btnSimpan.TabIndex = 9;
            btnSimpan.UseVisualStyleBackColor = false;
            btnSimpan.Click += btnSimpan_Click;
            // 
            // btnEdit
            // 
            btnEdit.BackColor = Color.FromArgb(0, 64, 0);
            btnEdit.BackgroundImage = (Image)resources.GetObject("btnEdit.BackgroundImage");
            btnEdit.BackgroundImageLayout = ImageLayout.None;
            btnEdit.FlatAppearance.BorderSize = 0;
            btnEdit.FlatStyle = FlatStyle.Flat;
            btnEdit.ForeColor = SystemColors.ControlText;
            btnEdit.Location = new Point(3, 286);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(242, 54);
            btnEdit.TabIndex = 10;
            btnEdit.UseVisualStyleBackColor = false;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnHapus
            // 
            btnHapus.BackColor = Color.Transparent;
            btnHapus.BackgroundImage = (Image)resources.GetObject("btnHapus.BackgroundImage");
            btnHapus.BackgroundImageLayout = ImageLayout.None;
            btnHapus.FlatAppearance.BorderSize = 0;
            btnHapus.FlatStyle = FlatStyle.Flat;
            btnHapus.ForeColor = SystemColors.ControlText;
            btnHapus.Location = new Point(254, 271);
            btnHapus.Name = "btnHapus";
            btnHapus.Size = new Size(94, 31);
            btnHapus.TabIndex = 11;
            btnHapus.UseVisualStyleBackColor = false;
            btnHapus.Click += btnHapus_Click;
            // 
            // btnRefresh
            // 
            btnRefresh.BackgroundImage = Properties.Resources.Refreshbutton1;
            btnRefresh.BackgroundImageLayout = ImageLayout.None;
            btnRefresh.FlatAppearance.BorderSize = 0;
            btnRefresh.FlatStyle = FlatStyle.Flat;
            btnRefresh.ForeColor = SystemColors.ControlText;
            btnRefresh.Location = new Point(354, 271);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(110, 33);
            btnRefresh.TabIndex = 12;
            btnRefresh.UseVisualStyleBackColor = true;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(label9);
            panel1.Controls.Add(txtHarga);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(cmbJenisTembakau);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(cmbKualitas);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(txtJumlahDiolah);
            panel1.Controls.Add(cmbJenisProses);
            panel1.Controls.Add(btnRefresh);
            panel1.Controls.Add(txtHasil);
            panel1.Controls.Add(btnHapus);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(cmbStatus);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(cmbldPanen);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label1);
            panel1.ForeColor = SystemColors.ControlLightLight;
            panel1.Location = new Point(255, 448);
            panel1.Name = "panel1";
            panel1.Size = new Size(789, 317);
            panel1.TabIndex = 13;
            panel1.Paint += panel1_Paint;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Emoji", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(424, 196);
            label9.Name = "label9";
            label9.Size = new Size(55, 20);
            label9.TabIndex = 25;
            label9.Text = "Harga";
            label9.Click += label9_Click;
            // 
            // txtHarga
            // 
            txtHarga.Location = new Point(424, 220);
            txtHarga.Name = "txtHarga";
            txtHarga.Size = new Size(338, 27);
            txtHarga.TabIndex = 23;
            txtHarga.TextChanged += textBox1_TextChanged_2;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Emoji", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(34, 196);
            label8.Name = "label8";
            label8.Size = new Size(127, 20);
            label8.TabIndex = 22;
            label8.Text = "Jenis Tembakau";
            // 
            // cmbJenisTembakau
            // 
            cmbJenisTembakau.FormattingEnabled = true;
            cmbJenisTembakau.Items.AddRange(new object[] { "Tembakau Rajangan", "Tembakau Kretek", "Tembakau Cerutu" });
            cmbJenisTembakau.Location = new Point(34, 219);
            cmbJenisTembakau.Name = "cmbJenisTembakau";
            cmbJenisTembakau.Size = new Size(338, 28);
            cmbJenisTembakau.TabIndex = 21;
            cmbJenisTembakau.SelectedIndexChanged += cmbJenisTembakau_SelectedIndexChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Emoji", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(420, 136);
            label5.Name = "label5";
            label5.Size = new Size(69, 20);
            label5.TabIndex = 19;
            label5.Text = "Kualitas";
            label5.Click += label5_Click;
            // 
            // cmbKualitas
            // 
            cmbKualitas.FormattingEnabled = true;
            cmbKualitas.Items.AddRange(new object[] { "Sangat Baik", "Bagus", "Kurang Baik", "Busuk" });
            cmbKualitas.Location = new Point(424, 159);
            cmbKualitas.Name = "cmbKualitas";
            cmbKualitas.Size = new Size(338, 28);
            cmbKualitas.TabIndex = 18;
            cmbKualitas.SelectedIndexChanged += cmbKualitas_SelectedIndexChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Emoji", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(34, 136);
            label6.Name = "label6";
            label6.Size = new Size(136, 20);
            label6.TabIndex = 17;
            label6.Text = "Jumlah Olah (kg)";
            // 
            // txtJumlahDiolah
            // 
            txtJumlahDiolah.Location = new Point(34, 159);
            txtJumlahDiolah.Name = "txtJumlahDiolah";
            txtJumlahDiolah.Size = new Size(338, 27);
            txtJumlahDiolah.TabIndex = 15;
            txtJumlahDiolah.TextChanged += textBox1_TextChanged_1;
            // 
            // cmbJenisProses
            // 
            cmbJenisProses.FormattingEnabled = true;
            cmbJenisProses.Items.AddRange(new object[] { "Fermentasi", "Pengeringan", "Penggulungan", "Pembungkusan", "Penyimpanan" });
            cmbJenisProses.Location = new Point(424, 36);
            cmbJenisProses.Name = "cmbJenisProses";
            cmbJenisProses.Size = new Size(338, 28);
            cmbJenisProses.TabIndex = 13;
            cmbJenisProses.SelectedIndexChanged += cmbJenisProses_SelectedIndexChanged;
            // 
            // btnKeluar
            // 
            btnKeluar.BackColor = Color.FromArgb(0, 64, 0);
            btnKeluar.BackgroundImage = Properties.Resources.keluar_button1;
            btnKeluar.FlatAppearance.BorderSize = 0;
            btnKeluar.FlatStyle = FlatStyle.Flat;
            btnKeluar.ForeColor = SystemColors.ControlText;
            btnKeluar.Location = new Point(57, 726);
            btnKeluar.Name = "btnKeluar";
            btnKeluar.Size = new Size(100, 39);
            btnKeluar.TabIndex = 14;
            btnKeluar.UseVisualStyleBackColor = false;
            btnKeluar.Click += btnKeluar_Click;
            // 
            // pictureBox4
            // 
            pictureBox4.BackColor = Color.FromArgb(26, 81, 38);
            pictureBox4.BackgroundImage = (Image)resources.GetObject("pictureBox4.BackgroundImage");
            pictureBox4.BackgroundImageLayout = ImageLayout.None;
            pictureBox4.Location = new Point(10, 28);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(52, 52);
            pictureBox4.TabIndex = 36;
            pictureBox4.TabStop = false;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.DarkGreen;
            label10.FlatStyle = FlatStyle.Flat;
            label10.Font = new Font("Segoe UI Historic", 8F, FontStyle.Bold);
            label10.ForeColor = Color.DarkGray;
            label10.Location = new Point(68, 63);
            label10.Name = "label10";
            label10.Size = new Size(170, 19);
            label10.TabIndex = 35;
            label10.Text = "Pengelolaan Tembakau";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.DarkOliveGreen;
            label7.Font = new Font("Segoe UI", 15F, FontStyle.Bold | FontStyle.Italic);
            label7.ForeColor = SystemColors.ControlLight;
            label7.Location = new Point(68, 28);
            label7.Name = "label7";
            label7.Size = new Size(127, 35);
            label7.TabIndex = 34;
            label7.Text = "SIMBAKO";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.FromArgb(0, 64, 0);
            pictureBox1.Location = new Point(-44, -14);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(289, 810);
            pictureBox1.TabIndex = 33;
            pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackgroundImage = Properties.Resources.Line_11;
            panel2.Location = new Point(-2, 99);
            panel2.Name = "panel2";
            panel2.Size = new Size(1114, 13);
            panel2.TabIndex = 37;
            // 
            // panel3
            // 
            panel3.BackgroundImage = Properties.Resources.Line_11;
            panel3.Location = new Point(-2, 182);
            panel3.Name = "panel3";
            panel3.Size = new Size(247, 13);
            panel3.TabIndex = 38;
            // 
            // pictureBox5
            // 
            pictureBox5.BackColor = Color.FromArgb(0, 64, 0);
            pictureBox5.BackgroundImage = (Image)resources.GetObject("pictureBox5.BackgroundImage");
            pictureBox5.Location = new Point(-19, 118);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(264, 53);
            pictureBox5.TabIndex = 39;
            pictureBox5.TabStop = false;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = Color.Transparent;
            label11.Font = new Font("Segoe UI", 20F, FontStyle.Bold | FontStyle.Italic);
            label11.ForeColor = SystemColors.ControlLightLight;
            label11.Location = new Point(321, 9);
            label11.Name = "label11";
            label11.Size = new Size(355, 46);
            label11.TabIndex = 40;
            label11.Text = "Manajemen Produksi";
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.BackgroundImage = (Image)resources.GetObject("pictureBox2.BackgroundImage");
            pictureBox2.BackgroundImageLayout = ImageLayout.None;
            pictureBox2.Location = new Point(271, 22);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(52, 52);
            pictureBox2.TabIndex = 41;
            pictureBox2.TabStop = false;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.BackColor = Color.Transparent;
            label12.FlatStyle = FlatStyle.Flat;
            label12.Font = new Font("Segoe UI Historic", 10.8F, FontStyle.Bold);
            label12.ForeColor = Color.LightGreen;
            label12.Location = new Point(329, 55);
            label12.Name = "label12";
            label12.Size = new Size(262, 25);
            label12.TabIndex = 42;
            label12.Text = "Silahkan isi dengan hati-hati";
            label12.Click += label12_Click;
            // 
            // FormProduksi
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkOliveGreen;
            ClientSize = new Size(1054, 788);
            Controls.Add(btnSimpan);
            Controls.Add(btnEdit);
            Controls.Add(label12);
            Controls.Add(pictureBox2);
            Controls.Add(label11);
            Controls.Add(pictureBox5);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(pictureBox4);
            Controls.Add(label10);
            Controls.Add(btnKeluar);
            Controls.Add(label7);
            Controls.Add(pictureBox1);
            Controls.Add(panel1);
            Controls.Add(dgvProduksi);
            Name = "FormProduksi";
            Text = "Form - Produksi";
            ((System.ComponentModel.ISupportInitialize)dgvProduksi).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvProduksi;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private ComboBox cmbldPanen;
        private ComboBox cmbStatus;
        private TextBox txtHasil;
        private Button btnSimpan;
        private Button btnEdit;
        private Button btnHapus;
        private Button btnRefresh;
        private Panel panel1;
        private ComboBox cmbJenisProses;
        private Button btnKeluar;
        private TextBox txtJumlahDiolah;
        private Label label5;
        private ComboBox cmbKualitas;
        private Label label6;
        private Label label8;
        private ComboBox cmbJenisTembakau;
        private Label label9;
        private TextBox txtHarga;
        private PictureBox pictureBox4;
        private Label label10;
        private Label label7;
        private PictureBox pictureBox1;
        private Panel panel2;
        private Panel panel3;
        private PictureBox pictureBox5;
        private Label label11;
        private PictureBox pictureBox2;
        private Label label12;
    }
}