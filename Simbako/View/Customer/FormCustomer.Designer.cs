namespace Simbako
{
    partial class FormCustomer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCustomer));
            dgvProduk = new DataGridView();
            label1 = new Label();
            panel1 = new Panel();
            label6 = new Label();
            cmbKualitas = new ComboBox();
            btnRefresh = new Button();
            label5 = new Label();
            cmbNamaProduk = new ComboBox();
            txtNoHP = new TextBox();
            txtJumlah = new TextBox();
            txtNama = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            btnNota = new Button();
            btnBeli = new Button();
            btnKeluar = new Button();
            pictureBox1 = new PictureBox();
            label9 = new Label();
            label10 = new Label();
            label8 = new Label();
            pictureBox3 = new PictureBox();
            label7 = new Label();
            label11 = new Label();
            pictureBox4 = new PictureBox();
            pictureBox5 = new PictureBox();
            panel2 = new Panel();
            panel4 = new Panel();
            ((System.ComponentModel.ISupportInitialize)dgvProduk).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            SuspendLayout();
            // 
            // dgvProduk
            // 
            dgvProduk.BackgroundColor = Color.FromArgb(52, 65, 37);
            dgvProduk.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProduk.Location = new Point(244, 197);
            dgvProduk.Name = "dgvProduk";
            dgvProduk.RowHeadersWidth = 51;
            dgvProduk.Size = new Size(817, 342);
            dgvProduk.TabIndex = 0;
            dgvProduk.CellClick += dgvProduk_CellClick;
            dgvProduk.CellContentClick += dgvProduk_CellContentClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.OliveDrab;
            label1.Location = new Point(247, 174);
            label1.Name = "label1";
            label1.Size = new Size(167, 20);
            label1.TabIndex = 1;
            label1.Text = "Daftar Produk Tersedia :";
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkOliveGreen;
            panel1.Controls.Add(label6);
            panel1.Controls.Add(cmbKualitas);
            panel1.Controls.Add(btnRefresh);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(cmbNamaProduk);
            panel1.Controls.Add(txtNoHP);
            panel1.Controls.Add(txtJumlah);
            panel1.Controls.Add(txtNama);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(244, 462);
            panel1.Name = "panel1";
            panel1.Size = new Size(820, 330);
            panel1.TabIndex = 2;
            panel1.Paint += panel1_Paint;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = SystemColors.ControlLightLight;
            label6.Location = new Point(14, 154);
            label6.Name = "label6";
            label6.Size = new Size(61, 20);
            label6.TabIndex = 14;
            label6.Text = "Kualitas";
            // 
            // cmbKualitas
            // 
            cmbKualitas.FormattingEnabled = true;
            cmbKualitas.Items.AddRange(new object[] { "Sangat Baik", "Bagus ", "Kurang Baik", "Busuk" });
            cmbKualitas.Location = new Point(14, 177);
            cmbKualitas.Name = "cmbKualitas";
            cmbKualitas.Size = new Size(311, 28);
            cmbKualitas.TabIndex = 13;
            // 
            // btnRefresh
            // 
            btnRefresh.BackColor = Color.DarkOliveGreen;
            btnRefresh.BackgroundImage = Properties.Resources.Refreshbutton;
            btnRefresh.BackgroundImageLayout = ImageLayout.None;
            btnRefresh.FlatAppearance.BorderSize = 0;
            btnRefresh.FlatStyle = FlatStyle.Flat;
            btnRefresh.Location = new Point(17, 231);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(111, 29);
            btnRefresh.TabIndex = 12;
            btnRefresh.UseVisualStyleBackColor = false;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = SystemColors.ControlLight;
            label5.Location = new Point(354, 96);
            label5.Name = "label5";
            label5.Size = new Size(99, 20);
            label5.TabIndex = 11;
            label5.Text = "Nama Produk";
            // 
            // cmbNamaProduk
            // 
            cmbNamaProduk.FormattingEnabled = true;
            cmbNamaProduk.Location = new Point(354, 118);
            cmbNamaProduk.Name = "cmbNamaProduk";
            cmbNamaProduk.Size = new Size(367, 28);
            cmbNamaProduk.TabIndex = 10;
            cmbNamaProduk.SelectedIndexChanged += cmbNamaProduk_SelectedIndexChanged;
            // 
            // txtNoHP
            // 
            txtNoHP.Location = new Point(354, 38);
            txtNoHP.Name = "txtNoHP";
            txtNoHP.Size = new Size(370, 27);
            txtNoHP.TabIndex = 8;
            txtNoHP.TextChanged += txtNoHP_TextChanged;
            // 
            // txtJumlah
            // 
            txtJumlah.Location = new Point(11, 119);
            txtJumlah.Name = "txtJumlah";
            txtJumlah.Size = new Size(314, 27);
            txtJumlah.TabIndex = 7;
            txtJumlah.TextChanged += txtJumlah_TextChanged;
            // 
            // txtNama
            // 
            txtNama.Location = new Point(14, 38);
            txtNama.Name = "txtNama";
            txtNama.Size = new Size(311, 27);
            txtNama.TabIndex = 6;
            txtNama.TextChanged += txtNama_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = SystemColors.ControlLight;
            label4.Location = new Point(14, 96);
            label4.Name = "label4";
            label4.Size = new Size(114, 20);
            label4.TabIndex = 5;
            label4.Text = "Jumlah Beli (kg)";
            label4.Click += label4_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = SystemColors.ControlLightLight;
            label3.Location = new Point(351, 15);
            label3.Name = "label3";
            label3.Size = new Size(52, 20);
            label3.TabIndex = 4;
            label3.Text = "No HP";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = SystemColors.ControlLightLight;
            label2.Location = new Point(14, 15);
            label2.Name = "label2";
            label2.Size = new Size(91, 20);
            label2.TabIndex = 3;
            label2.Text = "Nama Kamu";
            // 
            // btnNota
            // 
            btnNota.BackColor = Color.FromArgb(0, 64, 0);
            btnNota.BackgroundImage = (Image)resources.GetObject("btnNota.BackgroundImage");
            btnNota.BackgroundImageLayout = ImageLayout.None;
            btnNota.FlatAppearance.BorderSize = 0;
            btnNota.FlatStyle = FlatStyle.Flat;
            btnNota.Location = new Point(3, 293);
            btnNota.Name = "btnNota";
            btnNota.Size = new Size(235, 52);
            btnNota.TabIndex = 1;
            btnNota.UseVisualStyleBackColor = false;
            btnNota.Click += btnNota_Click_1;
            // 
            // btnBeli
            // 
            btnBeli.BackColor = Color.FromArgb(0, 64, 0);
            btnBeli.BackgroundImage = (Image)resources.GetObject("btnBeli.BackgroundImage");
            btnBeli.BackgroundImageLayout = ImageLayout.None;
            btnBeli.FlatAppearance.BorderSize = 0;
            btnBeli.FlatStyle = FlatStyle.Flat;
            btnBeli.Location = new Point(3, 224);
            btnBeli.Name = "btnBeli";
            btnBeli.Size = new Size(235, 50);
            btnBeli.TabIndex = 0;
            btnBeli.UseVisualStyleBackColor = false;
            btnBeli.Click += btnBeli_Click_1;
            // 
            // btnKeluar
            // 
            btnKeluar.BackColor = Color.FromArgb(0, 64, 0);
            btnKeluar.BackgroundImage = Properties.Resources.keluar_button;
            btnKeluar.BackgroundImageLayout = ImageLayout.Center;
            btnKeluar.FlatAppearance.BorderSize = 0;
            btnKeluar.FlatStyle = FlatStyle.Flat;
            btnKeluar.Location = new Point(54, 737);
            btnKeluar.Name = "btnKeluar";
            btnKeluar.Size = new Size(106, 39);
            btnKeluar.TabIndex = 2;
            btnKeluar.UseVisualStyleBackColor = false;
            btnKeluar.Click += btnKeluar_Click_1;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.FromArgb(0, 64, 0);
            pictureBox1.Location = new Point(-44, -18);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(289, 810);
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.DarkOliveGreen;
            label9.Font = new Font("Segoe UI", 15F, FontStyle.Bold | FontStyle.Italic);
            label9.ForeColor = SystemColors.ControlLight;
            label9.Location = new Point(68, 24);
            label9.Name = "label9";
            label9.Size = new Size(127, 35);
            label9.TabIndex = 25;
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
            label10.Location = new Point(68, 59);
            label10.Name = "label10";
            label10.Size = new Size(170, 19);
            label10.TabIndex = 27;
            label10.Text = "Pengelolaan Tembakau";
            label10.Click += label10_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.FlatStyle = FlatStyle.Flat;
            label8.Font = new Font("Segoe UI Historic", 10F, FontStyle.Bold);
            label8.ForeColor = Color.LightGreen;
            label8.Location = new Point(309, 26);
            label8.Name = "label8";
            label8.Size = new Size(149, 23);
            label8.TabIndex = 31;
            label8.Text = "Portal Customer";
            label8.Click += label8_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.Transparent;
            pictureBox3.BackgroundImage = (Image)resources.GetObject("pictureBox3.BackgroundImage");
            pictureBox3.Location = new Point(277, 21);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(33, 34);
            pictureBox3.TabIndex = 30;
            pictureBox3.TabStop = false;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Segoe UI", 30F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label7.ForeColor = SystemColors.ControlLightLight;
            label7.Location = new Point(264, 44);
            label7.Name = "label7";
            label7.Size = new Size(662, 67);
            label7.TabIndex = 29;
            label7.Text = "Katalog Produk Tembakau";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = Color.Transparent;
            label11.FlatStyle = FlatStyle.Flat;
            label11.Font = new Font("Segoe UI Historic", 10.8F, FontStyle.Bold);
            label11.ForeColor = Color.LightGreen;
            label11.Location = new Point(277, 111);
            label11.Name = "label11";
            label11.Size = new Size(418, 25);
            label11.TabIndex = 28;
            label11.Text = "Temukan tembakau berkualitas pilihan terbaik";
            // 
            // pictureBox4
            // 
            pictureBox4.BackColor = Color.FromArgb(26, 81, 38);
            pictureBox4.BackgroundImage = (Image)resources.GetObject("pictureBox4.BackgroundImage");
            pictureBox4.BackgroundImageLayout = ImageLayout.None;
            pictureBox4.Location = new Point(10, 24);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(52, 52);
            pictureBox4.TabIndex = 32;
            pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            pictureBox5.BackColor = Color.Transparent;
            pictureBox5.BackgroundImage = (Image)resources.GetObject("pictureBox5.BackgroundImage");
            pictureBox5.Location = new Point(-21, 127);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(266, 53);
            pictureBox5.TabIndex = 33;
            pictureBox5.TabStop = false;
            pictureBox5.Click += pictureBox5_Click;
            // 
            // panel2
            // 
            panel2.BackgroundImage = Properties.Resources.Line_11;
            panel2.Location = new Point(-2, 98);
            panel2.Name = "panel2";
            panel2.Size = new Size(247, 13);
            panel2.TabIndex = 34;
            // 
            // panel4
            // 
            panel4.BackgroundImage = Properties.Resources.Line_11;
            panel4.Location = new Point(-2, 197);
            panel4.Name = "panel4";
            panel4.Size = new Size(247, 13);
            panel4.TabIndex = 36;
            // 
            // FormCustomer
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1057, 788);
            Controls.Add(panel4);
            Controls.Add(panel2);
            Controls.Add(pictureBox5);
            Controls.Add(pictureBox4);
            Controls.Add(label8);
            Controls.Add(pictureBox3);
            Controls.Add(label7);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(panel1);
            Controls.Add(btnNota);
            Controls.Add(label1);
            Controls.Add(btnBeli);
            Controls.Add(dgvProduk);
            Controls.Add(btnKeluar);
            Controls.Add(pictureBox1);
            Name = "FormCustomer";
            Text = "FormCustomer";
            ((System.ComponentModel.ISupportInitialize)dgvProduk).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvProduk;
        private Label label1;
        private Panel panel1;
        private TextBox txtNoHP;
        private TextBox txtJumlah;
        private TextBox txtNama;
        private Label label4;
        private Label label3;
        private Label label2;
        private Button btnKeluar;
        private Button btnNota;
        private Button btnBeli;
        private Label label5;
        private ComboBox cmbNamaProduk;
        private Button btnRefresh;
        private ComboBox cmbKualitas;
        private Label label6;
        private PictureBox pictureBox1;
        private Label label9;
        private Label label10;
        private Label label8;
        private PictureBox pictureBox3;
        private Label label7;
        private Label label11;
        private PictureBox pictureBox4;
        private PictureBox pictureBox5;
        private Panel panel2;
        private Panel panel4;
    }
}