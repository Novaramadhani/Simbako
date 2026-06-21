namespace Simbako
{
    partial class FormPenjualan
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPenjualan));
            dgvPenjualan = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtJumlah = new TextBox();
            txtNamaCustomer = new TextBox();
            txtNoHP = new TextBox();
            cmbProduk = new ComboBox();
            btnSimpan = new Button();
            btnRefresh = new Button();
            btnKeluar = new Button();
            cmbKualitas = new ComboBox();
            label5 = new Label();
            label6 = new Label();
            dateTimePicker1 = new DateTimePicker();
            btnHapus = new Button();
            label7 = new Label();
            txtTotal = new TextBox();
            pictureBox5 = new PictureBox();
            panel3 = new Panel();
            panel2 = new Panel();
            pictureBox4 = new PictureBox();
            label10 = new Label();
            label8 = new Label();
            pictureBox3 = new PictureBox();
            panel1 = new Panel();
            label12 = new Label();
            label11 = new Label();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dgvPenjualan).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // dgvPenjualan
            // 
            dgvPenjualan.BackgroundColor = Color.DarkOliveGreen;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Window;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.ControlLightLight;
            dataGridViewCellStyle1.SelectionForeColor = Color.Black;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvPenjualan.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvPenjualan.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPenjualan.EditMode = DataGridViewEditMode.EditProgrammatically;
            dgvPenjualan.Location = new Point(253, 126);
            dgvPenjualan.Name = "dgvPenjualan";
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvPenjualan.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvPenjualan.RowHeadersWidth = 51;
            dgvPenjualan.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPenjualan.Size = new Size(795, 314);
            dgvPenjualan.TabIndex = 0;
            dgvPenjualan.CellClick += dgvPenjualan_CellClick;
            dgvPenjualan.CellContentClick += dgvPenjualan_CellContentClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(285, 464);
            label1.Name = "label1";
            label1.Size = new Size(116, 20);
            label1.TabIndex = 1;
            label1.Text = "Nama Customer";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(285, 517);
            label2.Name = "label2";
            label2.Size = new Size(87, 20);
            label2.TabIndex = 2;
            label2.Text = "Pilih Produk";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(646, 464);
            label3.Name = "label3";
            label3.Size = new Size(52, 20);
            label3.TabIndex = 3;
            label3.Text = "No HP";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(646, 517);
            label4.Name = "label4";
            label4.Size = new Size(87, 20);
            label4.TabIndex = 4;
            label4.Text = "Jumlah (Kg)";
            label4.Click += label4_Click;
            // 
            // txtJumlah
            // 
            txtJumlah.Location = new Point(648, 541);
            txtJumlah.Name = "txtJumlah";
            txtJumlah.Size = new Size(387, 27);
            txtJumlah.TabIndex = 5;
            txtJumlah.TextChanged += txtJumlah_TextChanged;
            // 
            // txtNamaCustomer
            // 
            txtNamaCustomer.Location = new Point(287, 487);
            txtNamaCustomer.Name = "txtNamaCustomer";
            txtNamaCustomer.Size = new Size(304, 27);
            txtNamaCustomer.TabIndex = 6;
            txtNamaCustomer.TextChanged += txtNamaCustomer_TextChanged;
            // 
            // txtNoHP
            // 
            txtNoHP.Location = new Point(649, 487);
            txtNoHP.Name = "txtNoHP";
            txtNoHP.Size = new Size(387, 27);
            txtNoHP.TabIndex = 8;
            txtNoHP.TextChanged += txtNoHP_TextChanged;
            // 
            // cmbProduk
            // 
            cmbProduk.FormattingEnabled = true;
            cmbProduk.Items.AddRange(new object[] { "Tembakau Rajangan", "Tembakau Cerutu", "Tembakau Kretek" });
            cmbProduk.Location = new Point(285, 540);
            cmbProduk.Name = "cmbProduk";
            cmbProduk.Size = new Size(306, 28);
            cmbProduk.TabIndex = 9;
            cmbProduk.SelectedIndexChanged += cmbProduk_SelectedIndexChanged;
            // 
            // btnSimpan
            // 
            btnSimpan.BackgroundImage = (Image)resources.GetObject("btnSimpan.BackgroundImage");
            btnSimpan.BackgroundImageLayout = ImageLayout.None;
            btnSimpan.FlatAppearance.BorderSize = 0;
            btnSimpan.FlatStyle = FlatStyle.Flat;
            btnSimpan.ForeColor = SystemColors.ControlText;
            btnSimpan.Location = new Point(282, 704);
            btnSimpan.Name = "btnSimpan";
            btnSimpan.Size = new Size(176, 38);
            btnSimpan.TabIndex = 14;
            btnSimpan.UseVisualStyleBackColor = true;
            btnSimpan.Click += btnSimpan_Click;
            // 
            // btnRefresh
            // 
            btnRefresh.BackColor = Color.Transparent;
            btnRefresh.BackgroundImage = Properties.Resources.Refreshbutton2;
            btnRefresh.BackgroundImageLayout = ImageLayout.None;
            btnRefresh.FlatAppearance.BorderSize = 0;
            btnRefresh.FlatStyle = FlatStyle.Flat;
            btnRefresh.ForeColor = SystemColors.ControlText;
            btnRefresh.Location = new Point(555, 704);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(116, 38);
            btnRefresh.TabIndex = 16;
            btnRefresh.UseVisualStyleBackColor = false;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // btnKeluar
            // 
            btnKeluar.BackColor = Color.FromArgb(0, 64, 0);
            btnKeluar.BackgroundImage = Properties.Resources.keluar_button3;
            btnKeluar.BackgroundImageLayout = ImageLayout.None;
            btnKeluar.FlatAppearance.BorderSize = 0;
            btnKeluar.FlatStyle = FlatStyle.Flat;
            btnKeluar.ForeColor = SystemColors.ControlText;
            btnKeluar.Location = new Point(56, 726);
            btnKeluar.Name = "btnKeluar";
            btnKeluar.Size = new Size(116, 38);
            btnKeluar.TabIndex = 18;
            btnKeluar.UseVisualStyleBackColor = false;
            btnKeluar.Click += btnKeluar_Click;
            // 
            // cmbKualitas
            // 
            cmbKualitas.FormattingEnabled = true;
            cmbKualitas.Items.AddRange(new object[] { "Sangat Baik", "Bagus", "Kurang Baik", "Busuk" });
            cmbKualitas.Location = new Point(646, 596);
            cmbKualitas.Name = "cmbKualitas";
            cmbKualitas.Size = new Size(390, 28);
            cmbKualitas.TabIndex = 19;
            cmbKualitas.SelectedIndexChanged += cmbKualitas_SelectedIndexChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(646, 571);
            label5.Name = "label5";
            label5.Size = new Size(61, 20);
            label5.TabIndex = 20;
            label5.Text = "Kualitas";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(282, 571);
            label6.Name = "label6";
            label6.Size = new Size(61, 20);
            label6.TabIndex = 21;
            label6.Text = "Tanggal";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(285, 594);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(306, 27);
            dateTimePicker1.TabIndex = 22;
            dateTimePicker1.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // btnHapus
            // 
            btnHapus.BackgroundImage = Properties.Resources.hapu;
            btnHapus.BackgroundImageLayout = ImageLayout.None;
            btnHapus.FlatAppearance.BorderSize = 0;
            btnHapus.FlatStyle = FlatStyle.Flat;
            btnHapus.ForeColor = SystemColors.ControlText;
            btnHapus.Location = new Point(450, 704);
            btnHapus.Name = "btnHapus";
            btnHapus.Size = new Size(99, 38);
            btnHapus.TabIndex = 24;
            btnHapus.UseVisualStyleBackColor = true;
            btnHapus.Click += btnHapus_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(282, 624);
            label7.Name = "label7";
            label7.Size = new Size(87, 20);
            label7.TabIndex = 25;
            label7.Text = "Total Harga";
            label7.Click += label7_Click;
            // 
            // txtTotal
            // 
            txtTotal.Location = new Point(285, 647);
            txtTotal.Name = "txtTotal";
            txtTotal.Size = new Size(306, 27);
            txtTotal.TabIndex = 26;
            txtTotal.TextChanged += txtTotal_TextChanged;
            // 
            // pictureBox5
            // 
            pictureBox5.BackColor = Color.FromArgb(0, 64, 0);
            pictureBox5.BackgroundImage = (Image)resources.GetObject("pictureBox5.BackgroundImage");
            pictureBox5.Location = new Point(-20, 123);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(264, 53);
            pictureBox5.TabIndex = 62;
            pictureBox5.TabStop = false;
            // 
            // panel3
            // 
            panel3.BackgroundImage = Properties.Resources.Line_11;
            panel3.Location = new Point(-3, 187);
            panel3.Name = "panel3";
            panel3.Size = new Size(247, 13);
            panel3.TabIndex = 61;
            // 
            // panel2
            // 
            panel2.BackgroundImage = Properties.Resources.Line_11;
            panel2.Location = new Point(-3, 104);
            panel2.Name = "panel2";
            panel2.Size = new Size(247, 13);
            panel2.TabIndex = 60;
            // 
            // pictureBox4
            // 
            pictureBox4.BackColor = Color.FromArgb(26, 81, 38);
            pictureBox4.BackgroundImage = (Image)resources.GetObject("pictureBox4.BackgroundImage");
            pictureBox4.BackgroundImageLayout = ImageLayout.None;
            pictureBox4.Location = new Point(9, 33);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(52, 52);
            pictureBox4.TabIndex = 59;
            pictureBox4.TabStop = false;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.DarkGreen;
            label10.FlatStyle = FlatStyle.Flat;
            label10.Font = new Font("Segoe UI Historic", 8F, FontStyle.Bold);
            label10.ForeColor = Color.DarkGray;
            label10.Location = new Point(67, 68);
            label10.Name = "label10";
            label10.Size = new Size(170, 19);
            label10.TabIndex = 58;
            label10.Text = "Pengelolaan Tembakau";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.DarkOliveGreen;
            label8.Font = new Font("Segoe UI", 15F, FontStyle.Bold | FontStyle.Italic);
            label8.ForeColor = SystemColors.ControlLight;
            label8.Location = new Point(67, 33);
            label8.Name = "label8";
            label8.Size = new Size(127, 35);
            label8.TabIndex = 57;
            label8.Text = "SIMBAKO";
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.FromArgb(0, 64, 0);
            pictureBox3.Location = new Point(-45, -1);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(289, 802);
            pictureBox3.TabIndex = 56;
            pictureBox3.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackgroundImage = Properties.Resources.Line_11;
            panel1.Location = new Point(245, 104);
            panel1.Name = "panel1";
            panel1.Size = new Size(817, 13);
            panel1.TabIndex = 66;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.BackColor = Color.Transparent;
            label12.FlatStyle = FlatStyle.Flat;
            label12.Font = new Font("Segoe UI Historic", 10.8F, FontStyle.Bold);
            label12.ForeColor = Color.LightGreen;
            label12.Location = new Point(343, 63);
            label12.Name = "label12";
            label12.Size = new Size(179, 25);
            label12.TabIndex = 65;
            label12.Text = "Selamat Berbelanja";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = Color.Transparent;
            label11.Font = new Font("Segoe UI", 20F, FontStyle.Bold | FontStyle.Italic);
            label11.ForeColor = SystemColors.ControlLightLight;
            label11.Location = new Point(341, 17);
            label11.Name = "label11";
            label11.Size = new Size(271, 46);
            label11.TabIndex = 64;
            label11.Text = "Form Penjualan";
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.BackgroundImage = (Image)resources.GetObject("pictureBox2.BackgroundImage");
            pictureBox2.BackgroundImageLayout = ImageLayout.None;
            pictureBox2.Location = new Point(282, 28);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(54, 54);
            pictureBox2.TabIndex = 63;
            pictureBox2.TabStop = false;
            // 
            // FormPenjualan
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(35, 63, 37);
            ClientSize = new Size(1057, 788);
            Controls.Add(btnKeluar);
            Controls.Add(panel1);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox5);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(pictureBox4);
            Controls.Add(label10);
            Controls.Add(label8);
            Controls.Add(pictureBox3);
            Controls.Add(txtTotal);
            Controls.Add(label7);
            Controls.Add(btnHapus);
            Controls.Add(dateTimePicker1);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(cmbKualitas);
            Controls.Add(btnRefresh);
            Controls.Add(btnSimpan);
            Controls.Add(cmbProduk);
            Controls.Add(txtNoHP);
            Controls.Add(txtNamaCustomer);
            Controls.Add(txtJumlah);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dgvPenjualan);
            ForeColor = SystemColors.ControlLightLight;
            Name = "FormPenjualan";
            Text = "FormPenjualan";
            Load += FormPenjualan_Load_1;
            ((System.ComponentModel.ISupportInitialize)dgvPenjualan).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvPenjualan;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtJumlah;
        private TextBox txtNamaCustomer;
        private TextBox txtNoHP;
        private ComboBox cmbProduk;
        private Button btnSimpan;
        private Button btnRefresh;
        private Button btnKeluar;
        private ComboBox cmbKualitas;
        private Label label5;
        private Label label6;
        private DateTimePicker dateTimePicker1;
        private Button btnHapus;
        private Label label7;
        private TextBox txtTotal;
        private PictureBox pictureBox5;
        private Panel panel3;
        private Panel panel2;
        private PictureBox pictureBox4;
        private Label label10;
        private Label label8;
        private PictureBox pictureBox3;
        private Panel panel1;
        private Label label12;
        private Label label11;
        private PictureBox pictureBox2;
    }
}