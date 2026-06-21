namespace Simbako
{
    partial class FormProduk
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormProduk));
            dgvProduk = new DataGridView();
            txtHarga = new TextBox();
            txtStok = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            cmbKualitas = new ComboBox();
            cmbNamaProduk = new ComboBox();
            btnKeluar = new Button();
            label5 = new Label();
            cmbStatusProduksi = new ComboBox();
            btnOlahData = new Button();
            pictureBox2 = new PictureBox();
            label11 = new Label();
            label12 = new Label();
            pictureBox5 = new PictureBox();
            panel3 = new Panel();
            panel2 = new Panel();
            pictureBox4 = new PictureBox();
            label10 = new Label();
            label7 = new Label();
            pictureBox3 = new PictureBox();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)dgvProduk).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // dgvProduk
            // 
            dgvProduk.BackgroundColor = Color.DarkOliveGreen;
            dgvProduk.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProduk.Location = new Point(269, 135);
            dgvProduk.Name = "dgvProduk";
            dgvProduk.RowHeadersWidth = 51;
            dgvProduk.Size = new Size(776, 335);
            dgvProduk.TabIndex = 0;
            dgvProduk.CellClick += dgvProduk_CellClick;
            dgvProduk.CellContentClick += dgvProduk_CellContentClick;
            // 
            // txtHarga
            // 
            txtHarga.Location = new Point(276, 586);
            txtHarga.Name = "txtHarga";
            txtHarga.Size = new Size(348, 27);
            txtHarga.TabIndex = 2;
            txtHarga.TextChanged += txtHarga_TextChanged;
            // 
            // txtStok
            // 
            txtStok.Location = new Point(650, 526);
            txtStok.Name = "txtStok";
            txtStok.Size = new Size(345, 27);
            txtStok.TabIndex = 3;
            txtStok.TextChanged += txtStok_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(271, 503);
            label1.Name = "label1";
            label1.Size = new Size(99, 20);
            label1.TabIndex = 5;
            label1.Text = "Nama Produk";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = SystemColors.ControlLightLight;
            label2.Location = new Point(276, 563);
            label2.Name = "label2";
            label2.Size = new Size(96, 20);
            label2.TabIndex = 6;
            label2.Text = "Harga per kg";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = SystemColors.ControlLightLight;
            label3.Location = new Point(650, 503);
            label3.Name = "label3";
            label3.Size = new Size(68, 20);
            label3.TabIndex = 7;
            label3.Text = "Stok (kg)";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = SystemColors.ControlLightLight;
            label4.Location = new Point(653, 564);
            label4.Name = "label4";
            label4.Size = new Size(65, 20);
            label4.TabIndex = 8;
            label4.Text = "Kualitas ";
            label4.Click += label4_Click;
            // 
            // cmbKualitas
            // 
            cmbKualitas.FormattingEnabled = true;
            cmbKualitas.Items.AddRange(new object[] { "Sangat Baik", "Baik", "Kurang Baik", "Busuk" });
            cmbKualitas.Location = new Point(650, 586);
            cmbKualitas.Name = "cmbKualitas";
            cmbKualitas.Size = new Size(348, 28);
            cmbKualitas.TabIndex = 13;
            // 
            // cmbNamaProduk
            // 
            cmbNamaProduk.FormattingEnabled = true;
            cmbNamaProduk.Items.AddRange(new object[] { "Tembakau Rajangan", "Tembakau Cerutu", "Tembakau Kretek" });
            cmbNamaProduk.Location = new Point(276, 526);
            cmbNamaProduk.Name = "cmbNamaProduk";
            cmbNamaProduk.Size = new Size(345, 28);
            cmbNamaProduk.TabIndex = 14;
            // 
            // btnKeluar
            // 
            btnKeluar.BackColor = Color.FromArgb(0, 64, 0);
            btnKeluar.BackgroundImage = Properties.Resources.keluar_button2;
            btnKeluar.FlatAppearance.BorderSize = 0;
            btnKeluar.FlatStyle = FlatStyle.Flat;
            btnKeluar.Location = new Point(52, 724);
            btnKeluar.Name = "btnKeluar";
            btnKeluar.Size = new Size(115, 43);
            btnKeluar.TabIndex = 15;
            btnKeluar.UseVisualStyleBackColor = false;
            btnKeluar.Click += btnKeluar_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = SystemColors.ControlLightLight;
            label5.Location = new Point(276, 621);
            label5.Name = "label5";
            label5.Size = new Size(109, 20);
            label5.TabIndex = 16;
            label5.Text = "Status Produksi";
            label5.Click += label5_Click;
            // 
            // cmbStatusProduksi
            // 
            cmbStatusProduksi.FormattingEnabled = true;
            cmbStatusProduksi.Items.AddRange(new object[] { "Menunggu", "Proses", "Selesai", "Siap Jual" });
            cmbStatusProduksi.Location = new Point(276, 644);
            cmbStatusProduksi.Name = "cmbStatusProduksi";
            cmbStatusProduksi.Size = new Size(345, 28);
            cmbStatusProduksi.TabIndex = 17;
            cmbStatusProduksi.SelectedIndexChanged += cmbStatusProduksi_SelectedIndexChanged;
            // 
            // btnOlahData
            // 
            btnOlahData.BackColor = Color.FromArgb(0, 64, 0);
            btnOlahData.BackgroundImage = Properties.Resources.olah_data_button;
            btnOlahData.BackgroundImageLayout = ImageLayout.None;
            btnOlahData.FlatAppearance.BorderSize = 0;
            btnOlahData.FlatStyle = FlatStyle.Flat;
            btnOlahData.Location = new Point(3, 220);
            btnOlahData.Name = "btnOlahData";
            btnOlahData.Size = new Size(239, 51);
            btnOlahData.TabIndex = 19;
            btnOlahData.UseVisualStyleBackColor = false;
            btnOlahData.Click += btnOlahData_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.BackgroundImage = (Image)resources.GetObject("pictureBox2.BackgroundImage");
            pictureBox2.BackgroundImageLayout = ImageLayout.None;
            pictureBox2.Location = new Point(278, 31);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(54, 54);
            pictureBox2.TabIndex = 42;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = Color.Transparent;
            label11.Font = new Font("Segoe UI", 20F, FontStyle.Bold | FontStyle.Italic);
            label11.ForeColor = SystemColors.ControlLightLight;
            label11.Location = new Point(332, 19);
            label11.Name = "label11";
            label11.Size = new Size(446, 46);
            label11.TabIndex = 43;
            label11.Text = "Katalog Produk Tembakau";
            label11.Click += label11_Click;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.BackColor = Color.Transparent;
            label12.FlatStyle = FlatStyle.Flat;
            label12.Font = new Font("Segoe UI Historic", 10.8F, FontStyle.Bold);
            label12.ForeColor = Color.LightGreen;
            label12.Location = new Point(332, 66);
            label12.Name = "label12";
            label12.Size = new Size(179, 25);
            label12.TabIndex = 44;
            label12.Text = "Selamat Berbelanja";
            label12.Click += label12_Click;
            // 
            // pictureBox5
            // 
            pictureBox5.BackColor = Color.FromArgb(0, 64, 0);
            pictureBox5.BackgroundImage = (Image)resources.GetObject("pictureBox5.BackgroundImage");
            pictureBox5.Location = new Point(-19, 124);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(264, 53);
            pictureBox5.TabIndex = 53;
            pictureBox5.TabStop = false;
            // 
            // panel3
            // 
            panel3.BackgroundImage = Properties.Resources.Line_11;
            panel3.Location = new Point(-2, 188);
            panel3.Name = "panel3";
            panel3.Size = new Size(247, 13);
            panel3.TabIndex = 52;
            // 
            // panel2
            // 
            panel2.BackgroundImage = Properties.Resources.Line_11;
            panel2.Location = new Point(-2, 105);
            panel2.Name = "panel2";
            panel2.Size = new Size(247, 13);
            panel2.TabIndex = 51;
            // 
            // pictureBox4
            // 
            pictureBox4.BackColor = Color.FromArgb(26, 81, 38);
            pictureBox4.BackgroundImage = (Image)resources.GetObject("pictureBox4.BackgroundImage");
            pictureBox4.BackgroundImageLayout = ImageLayout.None;
            pictureBox4.Location = new Point(10, 34);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(52, 52);
            pictureBox4.TabIndex = 50;
            pictureBox4.TabStop = false;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.DarkGreen;
            label10.FlatStyle = FlatStyle.Flat;
            label10.Font = new Font("Segoe UI Historic", 8F, FontStyle.Bold);
            label10.ForeColor = Color.DarkGray;
            label10.Location = new Point(68, 69);
            label10.Name = "label10";
            label10.Size = new Size(170, 19);
            label10.TabIndex = 49;
            label10.Text = "Pengelolaan Tembakau";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.DarkOliveGreen;
            label7.Font = new Font("Segoe UI", 15F, FontStyle.Bold | FontStyle.Italic);
            label7.ForeColor = SystemColors.ControlLight;
            label7.Location = new Point(68, 34);
            label7.Name = "label7";
            label7.Size = new Size(127, 35);
            label7.TabIndex = 48;
            label7.Text = "SIMBAKO";
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.FromArgb(0, 64, 0);
            pictureBox3.Location = new Point(-44, -8);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(289, 810);
            pictureBox3.TabIndex = 47;
            pictureBox3.TabStop = false;
            pictureBox3.Click += pictureBox3_Click;
            // 
            // panel1
            // 
            panel1.BackgroundImage = Properties.Resources.Line_11;
            panel1.Location = new Point(242, 105);
            panel1.Name = "panel1";
            panel1.Size = new Size(817, 13);
            panel1.TabIndex = 54;
            // 
            // FormProduk
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(57, 84, 52);
            ClientSize = new Size(1057, 788);
            Controls.Add(btnKeluar);
            Controls.Add(btnOlahData);
            Controls.Add(panel1);
            Controls.Add(pictureBox5);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(pictureBox4);
            Controls.Add(label10);
            Controls.Add(label7);
            Controls.Add(pictureBox3);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(pictureBox2);
            Controls.Add(cmbStatusProduksi);
            Controls.Add(label5);
            Controls.Add(cmbNamaProduk);
            Controls.Add(cmbKualitas);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtStok);
            Controls.Add(txtHarga);
            Controls.Add(dgvProduk);
            Name = "FormProduk";
            Text = "FormProduk";
            Load += FormProduk_Load;
            ((System.ComponentModel.ISupportInitialize)dgvProduk).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvProduk;
        private TextBox txtHarga;
        private TextBox txtStok;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private ComboBox cmbKualitas;
        private ComboBox cmbNamaProduk;
        private Button btnKeluar;
        private Label label5;
        private ComboBox cmbStatusProduksi;
        private Button btnOlahData;
        private PictureBox pictureBox2;
        private Label label11;
        private Label label12;
        private PictureBox pictureBox5;
        private Panel panel3;
        private Panel panel2;
        private PictureBox pictureBox4;
        private Label label10;
        private Label label7;
        private PictureBox pictureBox3;
        private Panel panel1;
    }
}