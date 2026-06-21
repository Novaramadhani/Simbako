namespace Simbako
{
    partial class FormPetani
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPetani));
            panel1 = new Panel();
            btnSimpanPanen = new Button();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            cmbKualitas = new ComboBox();
            dtpTanggal = new DateTimePicker();
            txtJumlah = new TextBox();
            txtNamaPetani = new TextBox();
            label1 = new Label();
            btnLihatStatus = new Button();
            btnKeluar = new Button();
            dgvRiwayatPanen = new DataGridView();
            label6 = new Label();
            label7 = new Label();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            pictureBox3 = new PictureBox();
            label8 = new Label();
            panel2 = new Panel();
            pictureBox5 = new PictureBox();
            pictureBox4 = new PictureBox();
            label9 = new Label();
            label10 = new Label();
            panel3 = new Panel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvRiwayatPanen).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.BackgroundImage = Properties.Resources.bgbelakangpetani1;
            panel1.Controls.Add(btnSimpanPanen);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(cmbKualitas);
            panel1.Controls.Add(dtpTanggal);
            panel1.Controls.Add(txtJumlah);
            panel1.Controls.Add(txtNamaPetani);
            panel1.Location = new Point(272, 197);
            panel1.Name = "panel1";
            panel1.Size = new Size(773, 207);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint_1;
            // 
            // btnSimpanPanen
            // 
            btnSimpanPanen.BackColor = Color.Transparent;
            btnSimpanPanen.BackgroundImage = Properties.Resources.kirim_dta_panen;
            btnSimpanPanen.BackgroundImageLayout = ImageLayout.Center;
            btnSimpanPanen.ForeColor = SystemColors.ControlText;
            btnSimpanPanen.Location = new Point(275, 155);
            btnSimpanPanen.Name = "btnSimpanPanen";
            btnSimpanPanen.Size = new Size(178, 40);
            btnSimpanPanen.TabIndex = 9;
            btnSimpanPanen.UseVisualStyleBackColor = false;
            btnSimpanPanen.Click += btnSimpanPanen_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = SystemColors.ControlLightLight;
            label5.Location = new Point(394, 85);
            label5.Name = "label5";
            label5.Size = new Size(61, 20);
            label5.TabIndex = 8;
            label5.Text = "Kualitas";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = SystemColors.ControlLightLight;
            label4.Location = new Point(394, 24);
            label4.Name = "label4";
            label4.Size = new Size(104, 20);
            label4.TabIndex = 7;
            label4.Text = "Tanggal Panen";
            label4.Click += label4_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = SystemColors.ControlLightLight;
            label3.Location = new Point(58, 86);
            label3.Name = "label3";
            label3.Size = new Size(83, 20);
            label3.TabIndex = 6;
            label3.Text = "Jumlah(Kg)";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = SystemColors.ControlLightLight;
            label2.Location = new Point(58, 24);
            label2.Name = "label2";
            label2.Size = new Size(93, 20);
            label2.TabIndex = 5;
            label2.Text = "Nama Petani";
            // 
            // cmbKualitas
            // 
            cmbKualitas.Font = new Font("Segoe UI", 10F);
            cmbKualitas.FormattingEnabled = true;
            cmbKualitas.Items.AddRange(new object[] { "Sangat Baik", "Bagus", "Kurang Baik", "Busuk" });
            cmbKualitas.Location = new Point(394, 108);
            cmbKualitas.Name = "cmbKualitas";
            cmbKualitas.Size = new Size(297, 31);
            cmbKualitas.TabIndex = 4;
            cmbKualitas.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // dtpTanggal
            // 
            dtpTanggal.Font = new Font("Segoe UI", 10F);
            dtpTanggal.Location = new Point(394, 47);
            dtpTanggal.Name = "dtpTanggal";
            dtpTanggal.Size = new Size(297, 30);
            dtpTanggal.TabIndex = 3;
            // 
            // txtJumlah
            // 
            txtJumlah.Font = new Font("Segoe UI", 10F);
            txtJumlah.Location = new Point(58, 109);
            txtJumlah.Multiline = true;
            txtJumlah.Name = "txtJumlah";
            txtJumlah.Size = new Size(285, 27);
            txtJumlah.TabIndex = 1;
            // 
            // txtNamaPetani
            // 
            txtNamaPetani.Font = new Font("Segoe UI", 10F);
            txtNamaPetani.Location = new Point(58, 47);
            txtNamaPetani.Name = "txtNamaPetani";
            txtNamaPetani.Size = new Size(285, 30);
            txtNamaPetani.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.FlatStyle = FlatStyle.Flat;
            label1.Font = new Font("Segoe UI Historic", 10.8F, FontStyle.Bold);
            label1.ForeColor = Color.LightGreen;
            label1.Location = new Point(285, 115);
            label1.Name = "label1";
            label1.Size = new Size(438, 25);
            label1.TabIndex = 1;
            label1.Text = "Pantau setoran dan status verifikasi panen Anda";
            label1.Click += label1_Click_1;
            // 
            // btnLihatStatus
            // 
            btnLihatStatus.BackColor = Color.Transparent;
            btnLihatStatus.BackgroundImage = Properties.Resources.Button1;
            btnLihatStatus.Location = new Point(285, 729);
            btnLihatStatus.Name = "btnLihatStatus";
            btnLihatStatus.Size = new Size(107, 39);
            btnLihatStatus.TabIndex = 10;
            btnLihatStatus.UseVisualStyleBackColor = false;
            btnLihatStatus.Click += btnLihatStatus_Click_1;
            // 
            // btnKeluar
            // 
            btnKeluar.BackColor = Color.FromArgb(0, 64, 0);
            btnKeluar.BackgroundImage = Properties.Resources.Button;
            btnKeluar.FlatAppearance.BorderSize = 0;
            btnKeluar.FlatStyle = FlatStyle.Flat;
            btnKeluar.Location = new Point(74, 731);
            btnKeluar.Name = "btnKeluar";
            btnKeluar.Size = new Size(94, 37);
            btnKeluar.TabIndex = 11;
            btnKeluar.UseVisualStyleBackColor = false;
            btnKeluar.Click += btnKeluar_Click_1;
            // 
            // dgvRiwayatPanen
            // 
            dgvRiwayatPanen.BackgroundColor = Color.FromArgb(43, 66, 46);
            dgvRiwayatPanen.BorderStyle = BorderStyle.Fixed3D;
            dgvRiwayatPanen.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRiwayatPanen.Location = new Point(272, 438);
            dgvRiwayatPanen.Name = "dgvRiwayatPanen";
            dgvRiwayatPanen.RowHeadersWidth = 51;
            dgvRiwayatPanen.Size = new Size(773, 281);
            dgvRiwayatPanen.TabIndex = 12;
            dgvRiwayatPanen.CellContentClick += dgvRiwayatPanen_CellContentClick;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(283, 415);
            label6.Name = "label6";
            label6.Size = new Size(155, 20);
            label6.TabIndex = 13;
            label6.Text = "Riwayat Setoran Saya ";
            label6.Click += label6_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Segoe UI", 30F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label7.ForeColor = SystemColors.ControlLightLight;
            label7.Location = new Point(272, 48);
            label7.Name = "label7";
            label7.Size = new Size(612, 67);
            label7.TabIndex = 14;
            label7.Text = "Selamat Datang, Petani!";
            label7.Click += label7_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.FromArgb(0, 64, 0);
            pictureBox2.ErrorImage = null;
            pictureBox2.Location = new Point(-35, -31);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(289, 816);
            pictureBox2.TabIndex = 16;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click_2;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(240, 167);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(819, 618);
            pictureBox1.TabIndex = 17;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click_3;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.Transparent;
            pictureBox3.BackgroundImage = Properties.Resources.Icon;
            pictureBox3.Location = new Point(285, 25);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(33, 34);
            pictureBox3.TabIndex = 18;
            pictureBox3.TabStop = false;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.FlatStyle = FlatStyle.Flat;
            label8.Font = new Font("Segoe UI Historic", 10F, FontStyle.Bold);
            label8.ForeColor = Color.LightGreen;
            label8.Location = new Point(317, 30);
            label8.Name = "label8";
            label8.Size = new Size(121, 23);
            label8.TabIndex = 19;
            label8.Text = "Portal Petani";
            label8.Click += label8_Click;
            // 
            // panel2
            // 
            panel2.BackgroundImage = Properties.Resources.Line_11;
            panel2.Location = new Point(0, 102);
            panel2.Name = "panel2";
            panel2.Size = new Size(254, 13);
            panel2.TabIndex = 22;
            // 
            // pictureBox5
            // 
            pictureBox5.BackColor = Color.Transparent;
            pictureBox5.BackgroundImage = (Image)resources.GetObject("pictureBox5.BackgroundImage");
            pictureBox5.Location = new Point(-22, 132);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(276, 46);
            pictureBox5.TabIndex = 21;
            pictureBox5.TabStop = false;
            pictureBox5.Click += pictureBox5_Click;
            // 
            // pictureBox4
            // 
            pictureBox4.BackColor = Color.FromArgb(0, 64, 0);
            pictureBox4.BackgroundImage = (Image)resources.GetObject("pictureBox4.BackgroundImage");
            pictureBox4.BackgroundImageLayout = ImageLayout.None;
            pictureBox4.Location = new Point(14, 28);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(52, 54);
            pictureBox4.TabIndex = 23;
            pictureBox4.TabStop = false;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.DarkOliveGreen;
            label9.Font = new Font("Segoe UI", 15F, FontStyle.Bold | FontStyle.Italic);
            label9.ForeColor = SystemColors.ControlLight;
            label9.Location = new Point(74, 27);
            label9.Name = "label9";
            label9.Size = new Size(127, 35);
            label9.TabIndex = 24;
            label9.Text = "SIMBAKO";
            label9.Click += label9_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.DarkGreen;
            label10.FlatStyle = FlatStyle.Flat;
            label10.Font = new Font("Segoe UI Historic", 8F, FontStyle.Bold);
            label10.ForeColor = Color.DarkGray;
            label10.Location = new Point(74, 62);
            label10.Name = "label10";
            label10.Size = new Size(170, 19);
            label10.TabIndex = 25;
            label10.Text = "Pengelolaan Tembakau";
            // 
            // panel3
            // 
            panel3.BackgroundImage = Properties.Resources.Line_11;
            panel3.Location = new Point(0, 204);
            panel3.Name = "panel3";
            panel3.Size = new Size(254, 13);
            panel3.TabIndex = 26;
            panel3.Paint += panel3_Paint;
            // 
            // FormPetani
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonFace;
            BackgroundImage = Properties.Resources.Personal_productivity_dashboard1;
            ClientSize = new Size(1057, 788);
            Controls.Add(panel3);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(pictureBox4);
            Controls.Add(panel2);
            Controls.Add(pictureBox5);
            Controls.Add(label8);
            Controls.Add(pictureBox3);
            Controls.Add(dgvRiwayatPanen);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(btnKeluar);
            Controls.Add(label1);
            Controls.Add(btnLihatStatus);
            Controls.Add(panel1);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            DoubleBuffered = true;
            Name = "FormPetani";
            Text = "FormPetani";
            Load += FormPetani_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvRiwayatPanen).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private TextBox txtNamaPetani;
        private Label label1;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private ComboBox cmbKualitas;
        private DateTimePicker dtpTanggal;
        private TextBox txtJumlah;
        private Button btnSimpanPanen;
        private Button btnLihatStatus;
        private Button btnKeluar;
        private DataGridView dgvRiwayatPanen;
        private Label label6;
        private Label label7;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private PictureBox pictureBox3;
        private Label label8;
        private Label label9;
        private Panel panel2;
        private PictureBox pictureBox5;
        private PictureBox pictureBox4;
        private Label label10;
        private Panel panel3;
    }
}