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
            dgvProduk = new DataGridView();
            txtHarga = new TextBox();
            txtStok = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            btnSimpan = new Button();
            btnEdit = new Button();
            btnHapus = new Button();
            btnRefresh = new Button();
            cmbKualitas = new ComboBox();
            cmbNamaProduk = new ComboBox();
            btnKeluar = new Button();
            label5 = new Label();
            cmbStatusProduksi = new ComboBox();
            btnUpdateStatus = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvProduk).BeginInit();
            SuspendLayout();
            // 
            // dgvProduk
            // 
            dgvProduk.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProduk.Location = new Point(12, 36);
            dgvProduk.Name = "dgvProduk";
            dgvProduk.RowHeadersWidth = 51;
            dgvProduk.Size = new Size(776, 119);
            dgvProduk.TabIndex = 0;
            dgvProduk.CellClick += dgvProduk_CellClick;
            // 
            // txtHarga
            // 
            txtHarga.Location = new Point(408, 182);
            txtHarga.Name = "txtHarga";
            txtHarga.Size = new Size(348, 27);
            txtHarga.TabIndex = 2;
            txtHarga.TextChanged += txtHarga_TextChanged;
            // 
            // txtStok
            // 
            txtStok.Location = new Point(34, 236);
            txtStok.Name = "txtStok";
            txtStok.Size = new Size(345, 27);
            txtStok.TabIndex = 3;
            txtStok.TextChanged += txtStok_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(29, 158);
            label1.Name = "label1";
            label1.Size = new Size(99, 20);
            label1.TabIndex = 5;
            label1.Text = "Nama Produk";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(34, 212);
            label2.Name = "label2";
            label2.Size = new Size(96, 20);
            label2.TabIndex = 6;
            label2.Text = "Harga per kg";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(408, 158);
            label3.Name = "label3";
            label3.Size = new Size(68, 20);
            label3.TabIndex = 7;
            label3.Text = "Stok (kg)";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(411, 213);
            label4.Name = "label4";
            label4.Size = new Size(65, 20);
            label4.TabIndex = 8;
            label4.Text = "Kualitas ";
            label4.Click += label4_Click;
            // 
            // btnSimpan
            // 
            btnSimpan.Location = new Point(34, 345);
            btnSimpan.Name = "btnSimpan";
            btnSimpan.Size = new Size(94, 29);
            btnSimpan.TabIndex = 9;
            btnSimpan.Text = "Simpan ";
            btnSimpan.UseVisualStyleBackColor = true;
            btnSimpan.Click += btnSimpan_Click;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(134, 345);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(94, 29);
            btnEdit.TabIndex = 10;
            btnEdit.Text = "Edit ";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnHapus
            // 
            btnHapus.Location = new Point(334, 345);
            btnHapus.Name = "btnHapus";
            btnHapus.Size = new Size(94, 29);
            btnHapus.TabIndex = 11;
            btnHapus.Text = "Hapus";
            btnHapus.UseVisualStyleBackColor = true;
            btnHapus.Click += btnHapus_Click;
            // 
            // btnRefresh
            // 
            btnRefresh.Location = new Point(434, 345);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(94, 29);
            btnRefresh.TabIndex = 12;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = true;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // cmbKualitas
            // 
            cmbKualitas.FormattingEnabled = true;
            cmbKualitas.Items.AddRange(new object[] { "Sangat Baik", "Baik", "Kurang Baik", "Bosok" });
            cmbKualitas.Location = new Point(408, 235);
            cmbKualitas.Name = "cmbKualitas";
            cmbKualitas.Size = new Size(348, 28);
            cmbKualitas.TabIndex = 13;
            // 
            // cmbNamaProduk
            // 
            cmbNamaProduk.FormattingEnabled = true;
            cmbNamaProduk.Items.AddRange(new object[] { "Tembakau Rajangan", "Tembakau Cerutu", "Tembakau Kretek" });
            cmbNamaProduk.Location = new Point(34, 181);
            cmbNamaProduk.Name = "cmbNamaProduk";
            cmbNamaProduk.Size = new Size(345, 28);
            cmbNamaProduk.TabIndex = 14;
            // 
            // btnKeluar
            // 
            btnKeluar.Location = new Point(534, 345);
            btnKeluar.Name = "btnKeluar";
            btnKeluar.Size = new Size(94, 29);
            btnKeluar.TabIndex = 15;
            btnKeluar.Text = "Keluar";
            btnKeluar.UseVisualStyleBackColor = true;
            btnKeluar.Click += btnKeluar_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(34, 266);
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
            cmbStatusProduksi.Location = new Point(34, 289);
            cmbStatusProduksi.Name = "cmbStatusProduksi";
            cmbStatusProduksi.Size = new Size(345, 28);
            cmbStatusProduksi.TabIndex = 17;
            cmbStatusProduksi.SelectedIndexChanged += cmbStatusProduksi_SelectedIndexChanged;
            // 
            // btnUpdateStatus
            // 
            btnUpdateStatus.Location = new Point(234, 345);
            btnUpdateStatus.Name = "btnUpdateStatus";
            btnUpdateStatus.Size = new Size(94, 29);
            btnUpdateStatus.TabIndex = 18;
            btnUpdateStatus.Text = "Update";
            btnUpdateStatus.UseVisualStyleBackColor = true;
            btnUpdateStatus.Click += btnUpdateStatus_Click;
            // 
            // FormProduk
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 391);
            Controls.Add(btnUpdateStatus);
            Controls.Add(cmbStatusProduksi);
            Controls.Add(label5);
            Controls.Add(btnKeluar);
            Controls.Add(cmbNamaProduk);
            Controls.Add(cmbKualitas);
            Controls.Add(btnRefresh);
            Controls.Add(btnHapus);
            Controls.Add(btnEdit);
            Controls.Add(btnSimpan);
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
        private Button btnSimpan;
        private Button btnEdit;
        private Button btnHapus;
        private Button btnRefresh;
        private ComboBox cmbKualitas;
        private ComboBox cmbNamaProduk;
        private Button btnKeluar;
        private Label label5;
        private ComboBox cmbStatusProduksi;
        private Button btnUpdateStatus;
    }
}