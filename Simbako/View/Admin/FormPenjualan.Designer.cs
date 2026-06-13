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
            ((System.ComponentModel.ISupportInitialize)dgvPenjualan).BeginInit();
            SuspendLayout();
            // 
            // dgvPenjualan
            // 
            dgvPenjualan.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPenjualan.Location = new Point(12, 12);
            dgvPenjualan.Name = "dgvPenjualan";
            dgvPenjualan.RowHeadersWidth = 51;
            dgvPenjualan.Size = new Size(776, 160);
            dgvPenjualan.TabIndex = 0;
            dgvPenjualan.CellClick += dgvPenjualan_CellClick;
            dgvPenjualan.CellContentClick += dgvPenjualan_CellContentClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(50, 195);
            label1.Name = "label1";
            label1.Size = new Size(116, 20);
            label1.TabIndex = 1;
            label1.Text = "Nama Customer";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(50, 248);
            label2.Name = "label2";
            label2.Size = new Size(87, 20);
            label2.TabIndex = 2;
            label2.Text = "Pilih Produk";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(362, 195);
            label3.Name = "label3";
            label3.Size = new Size(52, 20);
            label3.TabIndex = 3;
            label3.Text = "No HP";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(362, 248);
            label4.Name = "label4";
            label4.Size = new Size(87, 20);
            label4.TabIndex = 4;
            label4.Text = "Jumlah (Kg)";
            label4.Click += label4_Click;
            // 
            // txtJumlah
            // 
            txtJumlah.Location = new Point(357, 272);
            txtJumlah.Name = "txtJumlah";
            txtJumlah.Size = new Size(387, 27);
            txtJumlah.TabIndex = 5;
            txtJumlah.TextChanged += txtJumlah_TextChanged;
            // 
            // txtNamaCustomer
            // 
            txtNamaCustomer.Location = new Point(47, 218);
            txtNamaCustomer.Name = "txtNamaCustomer";
            txtNamaCustomer.Size = new Size(304, 27);
            txtNamaCustomer.TabIndex = 6;
            txtNamaCustomer.TextChanged += txtNamaCustomer_TextChanged;
            // 
            // txtNoHP
            // 
            txtNoHP.Location = new Point(357, 218);
            txtNoHP.Name = "txtNoHP";
            txtNoHP.Size = new Size(387, 27);
            txtNoHP.TabIndex = 8;
            txtNoHP.TextChanged += txtNoHP_TextChanged;
            // 
            // cmbProduk
            // 
            cmbProduk.FormattingEnabled = true;
            cmbProduk.Items.AddRange(new object[] { "Tembakau Rajangan", "Tembakau Cerutu", "Tembakau Kretek" });
            cmbProduk.Location = new Point(50, 271);
            cmbProduk.Name = "cmbProduk";
            cmbProduk.Size = new Size(304, 28);
            cmbProduk.TabIndex = 9;
            cmbProduk.SelectedIndexChanged += cmbProduk_SelectedIndexChanged;
            // 
            // btnSimpan
            // 
            btnSimpan.Location = new Point(47, 448);
            btnSimpan.Name = "btnSimpan";
            btnSimpan.Size = new Size(187, 38);
            btnSimpan.TabIndex = 14;
            btnSimpan.Text = "Simpan Transaksi";
            btnSimpan.UseVisualStyleBackColor = true;
            btnSimpan.Click += btnSimpan_Click;
            // 
            // btnRefresh
            // 
            btnRefresh.Location = new Point(362, 448);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(116, 38);
            btnRefresh.TabIndex = 16;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = true;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // btnKeluar
            // 
            btnKeluar.Location = new Point(484, 448);
            btnKeluar.Name = "btnKeluar";
            btnKeluar.Size = new Size(116, 38);
            btnKeluar.TabIndex = 18;
            btnKeluar.Text = "Keluar";
            btnKeluar.UseVisualStyleBackColor = true;
            btnKeluar.Click += btnKeluar_Click;
            // 
            // cmbKualitas
            // 
            cmbKualitas.FormattingEnabled = true;
            cmbKualitas.Items.AddRange(new object[] { "Sangat Baik", "Bagus", "Kurang Baik", "Busuk" });
            cmbKualitas.Location = new Point(362, 327);
            cmbKualitas.Name = "cmbKualitas";
            cmbKualitas.Size = new Size(382, 28);
            cmbKualitas.TabIndex = 19;
            cmbKualitas.SelectedIndexChanged += cmbKualitas_SelectedIndexChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(362, 302);
            label5.Name = "label5";
            label5.Size = new Size(61, 20);
            label5.TabIndex = 20;
            label5.Text = "Kualitas";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(50, 302);
            label6.Name = "label6";
            label6.Size = new Size(61, 20);
            label6.TabIndex = 21;
            label6.Text = "Tanggal";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(50, 325);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(306, 27);
            dateTimePicker1.TabIndex = 22;
            dateTimePicker1.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // btnHapus
            // 
            btnHapus.Location = new Point(240, 448);
            btnHapus.Name = "btnHapus";
            btnHapus.Size = new Size(116, 38);
            btnHapus.TabIndex = 24;
            btnHapus.Text = "Hapus";
            btnHapus.UseVisualStyleBackColor = true;
            btnHapus.Click += btnHapus_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(50, 355);
            label7.Name = "label7";
            label7.Size = new Size(87, 20);
            label7.TabIndex = 25;
            label7.Text = "Total Harga";
            label7.Click += label7_Click;
            // 
            // txtTotal
            // 
            txtTotal.Location = new Point(50, 378);
            txtTotal.Name = "txtTotal";
            txtTotal.Size = new Size(306, 27);
            txtTotal.TabIndex = 26;
            txtTotal.TextChanged += txtTotal_TextChanged;
            // 
            // FormPenjualan
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 498);
            Controls.Add(txtTotal);
            Controls.Add(label7);
            Controls.Add(btnHapus);
            Controls.Add(dateTimePicker1);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(cmbKualitas);
            Controls.Add(btnKeluar);
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
            Name = "FormPenjualan";
            Text = "FormPenjualan";
            ((System.ComponentModel.ISupportInitialize)dgvPenjualan).EndInit();
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
    }
}