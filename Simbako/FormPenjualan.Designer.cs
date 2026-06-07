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
            lblHarga = new Label();
            lblTotal = new Label();
            flowLayoutPanel1 = new FlowLayoutPanel();
            btnHitung = new Button();
            btnSimpan = new Button();
            btnNota = new Button();
            btnRefresh = new Button();
            btnKeluar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvPenjualan).BeginInit();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // dgvPenjualan
            // 
            dgvPenjualan.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPenjualan.Location = new Point(12, 12);
            dgvPenjualan.Name = "dgvPenjualan";
            dgvPenjualan.RowHeadersWidth = 51;
            dgvPenjualan.Size = new Size(776, 121);
            dgvPenjualan.TabIndex = 0;
            dgvPenjualan.CellContentClick += dgvPenjualan_CellContentClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(47, 168);
            label1.Name = "label1";
            label1.Size = new Size(116, 20);
            label1.TabIndex = 1;
            label1.Text = "Nama Customer";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(50, 223);
            label2.Name = "label2";
            label2.Size = new Size(87, 20);
            label2.TabIndex = 2;
            label2.Text = "Pilih Produk";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(360, 168);
            label3.Name = "label3";
            label3.Size = new Size(52, 20);
            label3.TabIndex = 3;
            label3.Text = "No HP";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(357, 221);
            label4.Name = "label4";
            label4.Size = new Size(87, 20);
            label4.TabIndex = 4;
            label4.Text = "Jumlah (Kg)";
            label4.Click += label4_Click;
            // 
            // txtJumlah
            // 
            txtJumlah.Location = new Point(360, 247);
            txtJumlah.Name = "txtJumlah";
            txtJumlah.Size = new Size(382, 27);
            txtJumlah.TabIndex = 5;
            txtJumlah.TextChanged += txtJumlah_TextChanged;
            // 
            // txtNamaCustomer
            // 
            txtNamaCustomer.Location = new Point(47, 191);
            txtNamaCustomer.Name = "txtNamaCustomer";
            txtNamaCustomer.Size = new Size(304, 27);
            txtNamaCustomer.TabIndex = 6;
            txtNamaCustomer.TextChanged += txtNamaCustomer_TextChanged;
            // 
            // txtNoHP
            // 
            txtNoHP.Location = new Point(357, 191);
            txtNoHP.Name = "txtNoHP";
            txtNoHP.Size = new Size(382, 27);
            txtNoHP.TabIndex = 8;
            txtNoHP.TextChanged += txtNoHP_TextChanged;
            // 
            // cmbProduk
            // 
            cmbProduk.FormattingEnabled = true;
            cmbProduk.Items.AddRange(new object[] { "Tembakau Rajangan", "Tembakau Cerutu", "Tembakau Kretek" });
            cmbProduk.Location = new Point(50, 246);
            cmbProduk.Name = "cmbProduk";
            cmbProduk.Size = new Size(304, 28);
            cmbProduk.TabIndex = 9;
            cmbProduk.SelectedIndexChanged += cmbProduk_SelectedIndexChanged;
            // 
            // lblHarga
            // 
            lblHarga.AutoSize = true;
            lblHarga.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblHarga.ForeColor = Color.Red;
            lblHarga.Location = new Point(3, 0);
            lblHarga.Name = "lblHarga";
            lblHarga.Size = new Size(93, 28);
            lblHarga.TabIndex = 10;
            lblHarga.Text = "lblHarga";
            lblHarga.Click += label5_Click;
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotal.ForeColor = Color.Green;
            lblTotal.Location = new Point(102, 0);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(119, 28);
            lblTotal.TabIndex = 11;
            lblTotal.Text = "Total Rp : 0";
            lblTotal.Click += lblTotal_Click;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(lblHarga);
            flowLayoutPanel1.Controls.Add(lblTotal);
            flowLayoutPanel1.Location = new Point(47, 296);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(692, 73);
            flowLayoutPanel1.TabIndex = 12;
            // 
            // btnHitung
            // 
            btnHitung.Location = new Point(47, 388);
            btnHitung.Name = "btnHitung";
            btnHitung.Size = new Size(125, 38);
            btnHitung.TabIndex = 13;
            btnHitung.Text = "Hitung Total";
            btnHitung.UseVisualStyleBackColor = true;
            btnHitung.Click += btnHitung_Click;
            // 
            // btnSimpan
            btnSimpan.Location = new Point(178, 388);
            btnSimpan.Name = "btnSimpan";
            btnSimpan.Size = new Size(187, 38);
            btnSimpan.TabIndex = 14;
            btnSimpan.Text = "Simpan Transaksi";
            btnSimpan.UseVisualStyleBackColor = true;
            btnSimpan.Click += btnSimpan_Click;
            // 
            // btnNota
            // 
            btnNota.Location = new Point(371, 388);
            btnNota.Name = "btnNota";
            btnNota.Size = new Size(116, 38);
            btnNota.TabIndex = 15;
            btnNota.Text = "Cetak Nota";
            btnNota.UseVisualStyleBackColor = true;
            btnNota.Click += btnNota_Click;
            // 
            // btnRefresh
            // 
            btnRefresh.Location = new Point(493, 388);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(116, 38);
            btnRefresh.TabIndex = 16;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = true;
            // 
            // btnKeluar
            // 
            btnKeluar.Location = new Point(615, 388);
            btnKeluar.Name = "btnKeluar";
            btnKeluar.Size = new Size(116, 38);
            btnKeluar.TabIndex = 18;
            btnKeluar.Text = "Keluar";
            btnKeluar.UseVisualStyleBackColor = true;
            btnKeluar.Click += btnKeluar_Click;
            // 
            // FormPenjualan
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnKeluar);
            Controls.Add(btnRefresh);
            Controls.Add(btnNota);
            Controls.Add(btnSimpan);
            Controls.Add(btnHitung);
            Controls.Add(flowLayoutPanel1);
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
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
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
        private Label lblHarga;
        private Label lblTotal;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button btnHitung;
        private Button btnSimpan;
        private Button btnNota;
        private Button btnRefresh;
        private Button btnKeluar;
    }
}