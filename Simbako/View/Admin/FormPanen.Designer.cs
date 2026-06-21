namespace Simbako
{
    partial class FormPanen
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPanen));
            dgvPanen = new DataGridView();
            panel1 = new Panel();
            btnKeluar = new Button();
            label5 = new Label();
            dtpTanggal = new DateTimePicker();
            btnRefresh = new Button();
            btnVerifikasi = new Button();
            btnHapus = new Button();
            btnEdit = new Button();
            btnSimpan = new Button();
            cmbKualitas = new ComboBox();
            txtJumlah = new TextBox();
            txtNamaPetani = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            pictureBox5 = new PictureBox();
            panel3 = new Panel();
            panel2 = new Panel();
            pictureBox4 = new PictureBox();
            label10 = new Label();
            label8 = new Label();
            pictureBox3 = new PictureBox();
            panel4 = new Panel();
            label12 = new Label();
            label11 = new Label();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dgvPanen).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // dgvPanen
            // 
            dgvPanen.BackgroundColor = Color.DarkOliveGreen;
            dgvPanen.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPanen.Location = new Point(269, 116);
            dgvPanen.Name = "dgvPanen";
            dgvPanen.RowHeadersWidth = 51;
            dgvPanen.Size = new Size(776, 375);
            dgvPanen.TabIndex = 0;
            dgvPanen.CellClick += dgvPanen_CellClick;
            dgvPanen.CellContentClick += dgvPanen_CellContentClick_1;
            // 
            // panel1
            // 
            panel1.Controls.Add(label5);
            panel1.Controls.Add(dtpTanggal);
            panel1.Controls.Add(btnRefresh);
            panel1.Controls.Add(btnHapus);
            panel1.Controls.Add(btnEdit);
            panel1.Controls.Add(btnSimpan);
            panel1.Controls.Add(cmbKualitas);
            panel1.Controls.Add(txtJumlah);
            panel1.Controls.Add(txtNamaPetani);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.ForeColor = SystemColors.ControlLightLight;
            panel1.Location = new Point(269, 527);
            panel1.Name = "panel1";
            panel1.Size = new Size(776, 216);
            panel1.TabIndex = 1;
            panel1.Paint += panel1_Paint;
            // 
            // btnKeluar
            // 
            btnKeluar.BackColor = Color.FromArgb(0, 64, 0);
            btnKeluar.BackgroundImage = Properties.Resources.keluar_button;
            btnKeluar.BackgroundImageLayout = ImageLayout.None;
            btnKeluar.FlatAppearance.BorderSize = 0;
            btnKeluar.FlatStyle = FlatStyle.Flat;
            btnKeluar.ForeColor = SystemColors.ControlText;
            btnKeluar.Location = new Point(72, 719);
            btnKeluar.Name = "btnKeluar";
            btnKeluar.Size = new Size(112, 38);
            btnKeluar.TabIndex = 15;
            btnKeluar.UseVisualStyleBackColor = false;
            btnKeluar.Click += btnKeluar_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(360, 14);
            label5.Name = "label5";
            label5.Size = new Size(104, 20);
            label5.TabIndex = 14;
            label5.Text = "Tanggal Panen";
            // 
            // dtpTanggal
            // 
            dtpTanggal.Location = new Point(360, 37);
            dtpTanggal.Name = "dtpTanggal";
            dtpTanggal.Size = new Size(342, 27);
            dtpTanggal.TabIndex = 13;
            // 
            // btnRefresh
            // 
            btnRefresh.BackgroundImage = Properties.Resources.Refreshbutton3;
            btnRefresh.BackgroundImageLayout = ImageLayout.None;
            btnRefresh.FlatAppearance.BorderSize = 0;
            btnRefresh.FlatStyle = FlatStyle.Flat;
            btnRefresh.ForeColor = SystemColors.ControlText;
            btnRefresh.Location = new Point(345, 160);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(114, 29);
            btnRefresh.TabIndex = 12;
            btnRefresh.UseVisualStyleBackColor = true;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // btnVerifikasi
            // 
            btnVerifikasi.BackColor = Color.FromArgb(0, 64, 0);
            btnVerifikasi.BackgroundImage = (Image)resources.GetObject("btnVerifikasi.BackgroundImage");
            btnVerifikasi.BackgroundImageLayout = ImageLayout.None;
            btnVerifikasi.FlatAppearance.BorderSize = 0;
            btnVerifikasi.FlatStyle = FlatStyle.Flat;
            btnVerifikasi.ForeColor = SystemColors.ControlText;
            btnVerifikasi.Location = new Point(6, 211);
            btnVerifikasi.Name = "btnVerifikasi";
            btnVerifikasi.Size = new Size(242, 52);
            btnVerifikasi.TabIndex = 11;
            btnVerifikasi.UseVisualStyleBackColor = false;
            btnVerifikasi.Click += btnVerifikasi_Click;
            // 
            // btnHapus
            // 
            btnHapus.BackgroundImage = Properties.Resources.hapu1;
            btnHapus.BackgroundImageLayout = ImageLayout.None;
            btnHapus.FlatAppearance.BorderSize = 0;
            btnHapus.FlatStyle = FlatStyle.Flat;
            btnHapus.ForeColor = SystemColors.ControlText;
            btnHapus.Location = new Point(242, 160);
            btnHapus.Name = "btnHapus";
            btnHapus.Size = new Size(96, 37);
            btnHapus.TabIndex = 10;
            btnHapus.UseVisualStyleBackColor = true;
            btnHapus.Click += btnHapus_Click;
            // 
            // btnEdit
            // 
            btnEdit.BackColor = Color.Transparent;
            btnEdit.BackgroundImage = Properties.Resources.edit_Button;
            btnEdit.BackgroundImageLayout = ImageLayout.None;
            btnEdit.FlatAppearance.BorderSize = 0;
            btnEdit.FlatStyle = FlatStyle.Flat;
            btnEdit.ForeColor = SystemColors.ControlText;
            btnEdit.Location = new Point(130, 161);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(107, 32);
            btnEdit.TabIndex = 9;
            btnEdit.UseVisualStyleBackColor = false;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnSimpan
            // 
            btnSimpan.BackColor = Color.Transparent;
            btnSimpan.BackgroundImage = Properties.Resources.simpan_button;
            btnSimpan.BackgroundImageLayout = ImageLayout.None;
            btnSimpan.FlatAppearance.BorderSize = 0;
            btnSimpan.FlatStyle = FlatStyle.Flat;
            btnSimpan.ForeColor = SystemColors.ControlText;
            btnSimpan.Location = new Point(21, 161);
            btnSimpan.Name = "btnSimpan";
            btnSimpan.Size = new Size(105, 29);
            btnSimpan.TabIndex = 8;
            btnSimpan.UseVisualStyleBackColor = false;
            btnSimpan.Click += btnSimpan_Click;
            // 
            // cmbKualitas
            // 
            cmbKualitas.FormattingEnabled = true;
            cmbKualitas.Items.AddRange(new object[] { "Sangat Baik", "Bagus", "Kurang Baik", "Busuk" });
            cmbKualitas.Location = new Point(360, 102);
            cmbKualitas.Name = "cmbKualitas";
            cmbKualitas.Size = new Size(342, 28);
            cmbKualitas.TabIndex = 7;
            cmbKualitas.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // txtJumlah
            // 
            txtJumlah.Location = new Point(21, 103);
            txtJumlah.Name = "txtJumlah";
            txtJumlah.Size = new Size(311, 27);
            txtJumlah.TabIndex = 5;
            txtJumlah.TextChanged += textBox2_TextChanged;
            // 
            // txtNamaPetani
            // 
            txtNamaPetani.Location = new Point(21, 37);
            txtNamaPetani.Name = "txtNamaPetani";
            txtNamaPetani.Size = new Size(311, 27);
            txtNamaPetani.TabIndex = 4;
            txtNamaPetani.TextChanged += textBox1_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(360, 80);
            label4.Name = "label4";
            label4.Size = new Size(61, 20);
            label4.TabIndex = 3;
            label4.Text = "Kualitas";
            label4.Click += label4_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(360, 14);
            label3.Name = "label3";
            label3.Size = new Size(0, 20);
            label3.TabIndex = 2;
            label3.Click += label3_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(21, 80);
            label2.Name = "label2";
            label2.Size = new Size(85, 20);
            label2.TabIndex = 1;
            label2.Text = "Jumlah (kg)";
            label2.Click += label2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(17, 14);
            label1.Name = "label1";
            label1.Size = new Size(93, 20);
            label1.TabIndex = 0;
            label1.Text = "Nama Petani";
            label1.Click += label1_Click;
            // 
            // pictureBox5
            // 
            pictureBox5.BackColor = Color.FromArgb(0, 64, 0);
            pictureBox5.BackgroundImage = (Image)resources.GetObject("pictureBox5.BackgroundImage");
            pictureBox5.Location = new Point(-15, 116);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(264, 53);
            pictureBox5.TabIndex = 70;
            pictureBox5.TabStop = false;
            // 
            // panel3
            // 
            panel3.BackgroundImage = Properties.Resources.Line_11;
            panel3.Location = new Point(2, 180);
            panel3.Name = "panel3";
            panel3.Size = new Size(247, 13);
            panel3.TabIndex = 69;
            // 
            // panel2
            // 
            panel2.BackgroundImage = Properties.Resources.Line_11;
            panel2.Location = new Point(2, 97);
            panel2.Name = "panel2";
            panel2.Size = new Size(247, 13);
            panel2.TabIndex = 68;
            // 
            // pictureBox4
            // 
            pictureBox4.BackColor = Color.FromArgb(26, 81, 38);
            pictureBox4.BackgroundImage = (Image)resources.GetObject("pictureBox4.BackgroundImage");
            pictureBox4.BackgroundImageLayout = ImageLayout.None;
            pictureBox4.Location = new Point(14, 26);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(52, 52);
            pictureBox4.TabIndex = 67;
            pictureBox4.TabStop = false;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.DarkGreen;
            label10.FlatStyle = FlatStyle.Flat;
            label10.Font = new Font("Segoe UI Historic", 8F, FontStyle.Bold);
            label10.ForeColor = Color.DarkGray;
            label10.Location = new Point(72, 61);
            label10.Name = "label10";
            label10.Size = new Size(170, 19);
            label10.TabIndex = 66;
            label10.Text = "Pengelolaan Tembakau";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.DarkOliveGreen;
            label8.Font = new Font("Segoe UI", 15F, FontStyle.Bold | FontStyle.Italic);
            label8.ForeColor = SystemColors.ControlLight;
            label8.Location = new Point(72, 26);
            label8.Name = "label8";
            label8.Size = new Size(127, 35);
            label8.TabIndex = 65;
            label8.Text = "SIMBAKO";
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.FromArgb(0, 64, 0);
            pictureBox3.Location = new Point(-40, -2);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(289, 796);
            pictureBox3.TabIndex = 64;
            pictureBox3.TabStop = false;
            pictureBox3.Click += pictureBox3_Click;
            // 
            // panel4
            // 
            panel4.BackgroundImage = Properties.Resources.Line_11;
            panel4.Location = new Point(250, 97);
            panel4.Name = "panel4";
            panel4.Size = new Size(817, 13);
            panel4.TabIndex = 74;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.BackColor = Color.Transparent;
            label12.FlatStyle = FlatStyle.Flat;
            label12.Font = new Font("Segoe UI Historic", 10.8F, FontStyle.Bold);
            label12.ForeColor = Color.LightGreen;
            label12.Location = new Point(348, 55);
            label12.Name = "label12";
            label12.Size = new Size(352, 25);
            label12.TabIndex = 73;
            label12.Text = "Silahkan di Inputkan Dengan Hati-Hati";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = Color.Transparent;
            label11.Font = new Font("Segoe UI", 20F, FontStyle.Bold | FontStyle.Italic);
            label11.ForeColor = SystemColors.ControlLightLight;
            label11.Location = new Point(346, 9);
            label11.Name = "label11";
            label11.Size = new Size(314, 46);
            label11.TabIndex = 72;
            label11.Text = "Manajemen Panen";
            label11.Click += label11_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.BackgroundImage = (Image)resources.GetObject("pictureBox2.BackgroundImage");
            pictureBox2.BackgroundImageLayout = ImageLayout.None;
            pictureBox2.Location = new Point(287, 20);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(54, 54);
            pictureBox2.TabIndex = 71;
            pictureBox2.TabStop = false;
            // 
            // FormPanen
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(37, 63, 38);
            ClientSize = new Size(1057, 788);
            Controls.Add(btnVerifikasi);
            Controls.Add(panel4);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(pictureBox2);
            Controls.Add(btnKeluar);
            Controls.Add(pictureBox5);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(pictureBox4);
            Controls.Add(label10);
            Controls.Add(label8);
            Controls.Add(pictureBox3);
            Controls.Add(panel1);
            Controls.Add(dgvPanen);
            Name = "FormPanen";
            Text = "Manajemen Panen";
            Load += FormPanen_Load;
            ((System.ComponentModel.ISupportInitialize)dgvPanen).EndInit();
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

        private DataGridView dgvPanen;
        private Panel panel1;
        private ComboBox cmbKualitas;
        private TextBox txtJumlah;
        private TextBox txtNamaPetani;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button btnRefresh;
        private Button btnVerifikasi;
        private Button btnHapus;
        private Button btnEdit;
        private Button btnSimpan;
        private Label label5;
        private DateTimePicker dtpTanggal;
        private Button btnKeluar;
        private PictureBox pictureBox5;
        private Panel panel3;
        private Panel panel2;
        private PictureBox pictureBox4;
        private Label label10;
        private Label label8;
        private PictureBox pictureBox3;
        private Panel panel4;
        private Label label12;
        private Label label11;
        private PictureBox pictureBox2;
    }
}
