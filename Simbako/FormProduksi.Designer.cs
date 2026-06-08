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
            label8 = new Label();
            cmbJenisTembakau = new ComboBox();
            label5 = new Label();
            cmbKualitas = new ComboBox();
            label6 = new Label();
            txtJumlahDiolah = new TextBox();
            btnKeluar = new Button();
            cmbJenisProses = new ComboBox();
            txtHarga = new TextBox();
            label9 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvProduksi).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // dgvProduksi
            // 
            dgvProduksi.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProduksi.Location = new Point(12, 12);
            dgvProduksi.Name = "dgvProduksi";
            dgvProduksi.RowHeadersWidth = 51;
            dgvProduksi.Size = new Size(938, 149);
            dgvProduksi.TabIndex = 0;
            dgvProduksi.CellClick += dgvProduksi_CellClick;
            dgvProduksi.CellContentClick += dgvProduksi_CellContentClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Emoji", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 13);
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
            label2.Location = new Point(453, 13);
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
            label3.Location = new Point(12, 78);
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
            label4.Location = new Point(453, 78);
            label4.Name = "label4";
            label4.Size = new Size(154, 20);
            label4.TabIndex = 4;
            label4.Text = "Hasil Produksi (KG)";
            // 
            // cmbldPanen
            // 
            cmbldPanen.FormattingEnabled = true;
            cmbldPanen.Location = new Point(12, 36);
            cmbldPanen.Name = "cmbldPanen";
            cmbldPanen.Size = new Size(416, 28);
            cmbldPanen.TabIndex = 5;
            cmbldPanen.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // cmbStatus
            // 
            cmbStatus.FormattingEnabled = true;
            cmbStatus.Items.AddRange(new object[] { "Menunggu", "Proses", "Selesai", "Siap Jual" });
            cmbStatus.Location = new Point(12, 100);
            cmbStatus.Name = "cmbStatus";
            cmbStatus.Size = new Size(416, 28);
            cmbStatus.TabIndex = 6;
            cmbStatus.SelectedIndexChanged += comboBox2_SelectedIndexChanged;
            // 
            // txtHasil
            // 
            txtHasil.Location = new Point(453, 100);
            txtHasil.Name = "txtHasil";
            txtHasil.Size = new Size(416, 27);
            txtHasil.TabIndex = 8;
            txtHasil.TextChanged += txtHasil_TextChanged;
            // 
            // btnSimpan
            // 
            btnSimpan.Location = new Point(12, 256);
            btnSimpan.Name = "btnSimpan";
            btnSimpan.Size = new Size(94, 29);
            btnSimpan.TabIndex = 9;
            btnSimpan.Text = "Simpan ";
            btnSimpan.UseVisualStyleBackColor = true;
            btnSimpan.Click += btnSimpan_Click;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(112, 256);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(125, 29);
            btnEdit.TabIndex = 10;
            btnEdit.Text = "Update";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnHapus
            // 
            btnHapus.Location = new Point(243, 256);
            btnHapus.Name = "btnHapus";
            btnHapus.Size = new Size(94, 29);
            btnHapus.TabIndex = 11;
            btnHapus.Text = "Hapus";
            btnHapus.UseVisualStyleBackColor = true;
            btnHapus.Click += btnHapus_Click;
            // 
            // btnRefresh
            // 
            btnRefresh.Location = new Point(343, 256);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(94, 29);
            btnRefresh.TabIndex = 12;
            btnRefresh.Text = "Refresh";
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
            panel1.Controls.Add(btnKeluar);
            panel1.Controls.Add(cmbJenisProses);
            panel1.Controls.Add(btnRefresh);
            panel1.Controls.Add(txtHasil);
            panel1.Controls.Add(btnHapus);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(btnSimpan);
            panel1.Controls.Add(cmbStatus);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(btnEdit);
            panel1.Controls.Add(cmbldPanen);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(12, 167);
            panel1.Name = "panel1";
            panel1.Size = new Size(938, 298);
            panel1.TabIndex = 13;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Emoji", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(453, 190);
            label8.Name = "label8";
            label8.Size = new Size(127, 20);
            label8.TabIndex = 22;
            label8.Text = "Jenis Tembakau";
            // 
            // cmbJenisTembakau
            // 
            cmbJenisTembakau.FormattingEnabled = true;
            cmbJenisTembakau.Items.AddRange(new object[] { "Tembakau Rajangan", "Tembakau Kretek", "Tembakau Cerutu" });
            cmbJenisTembakau.Location = new Point(453, 213);
            cmbJenisTembakau.Name = "cmbJenisTembakau";
            cmbJenisTembakau.Size = new Size(416, 28);
            cmbJenisTembakau.TabIndex = 21;
            cmbJenisTembakau.SelectedIndexChanged += cmbJenisTembakau_SelectedIndexChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Emoji", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(453, 135);
            label5.Name = "label5";
            label5.Size = new Size(69, 20);
            label5.TabIndex = 19;
            label5.Text = "Kualitas";
            // 
            // cmbKualitas
            // 
            cmbKualitas.FormattingEnabled = true;
            cmbKualitas.Items.AddRange(new object[] { "Sangat Baik", "Bagus", "Kurang Baik", "Bosok" });
            cmbKualitas.Location = new Point(453, 158);
            cmbKualitas.Name = "cmbKualitas";
            cmbKualitas.Size = new Size(416, 28);
            cmbKualitas.TabIndex = 18;
            cmbKualitas.SelectedIndexChanged += cmbKualitas_SelectedIndexChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Emoji", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(12, 136);
            label6.Name = "label6";
            label6.Size = new Size(136, 20);
            label6.TabIndex = 17;
            label6.Text = "Jumlah Olah (kg)";
            // 
            // txtJumlahDiolah
            // 
            txtJumlahDiolah.Location = new Point(12, 159);
            txtJumlahDiolah.Name = "txtJumlahDiolah";
            txtJumlahDiolah.Size = new Size(416, 27);
            txtJumlahDiolah.TabIndex = 15;
            txtJumlahDiolah.TextChanged += textBox1_TextChanged_1;
            // 
            // btnKeluar
            // 
            btnKeluar.Location = new Point(443, 256);
            btnKeluar.Name = "btnKeluar";
            btnKeluar.Size = new Size(94, 29);
            btnKeluar.TabIndex = 14;
            btnKeluar.Text = "Keluar";
            btnKeluar.UseVisualStyleBackColor = true;
            btnKeluar.Click += btnKeluar_Click;
            // 
            // cmbJenisProses
            // 
            cmbJenisProses.FormattingEnabled = true;
            cmbJenisProses.Items.AddRange(new object[] { "Fermentasi", "Pengeringan", "Penggulungan", "Pembungkusan", "Penyimpanan" });
            cmbJenisProses.Location = new Point(453, 36);
            cmbJenisProses.Name = "cmbJenisProses";
            cmbJenisProses.Size = new Size(416, 28);
            cmbJenisProses.TabIndex = 13;
            cmbJenisProses.SelectedIndexChanged += cmbJenisProses_SelectedIndexChanged;
            // 
            // txtHarga
            // 
            txtHarga.Location = new Point(12, 213);
            txtHarga.Name = "txtHarga";
            txtHarga.Size = new Size(416, 27);
            txtHarga.TabIndex = 23;
            txtHarga.TextChanged += textBox1_TextChanged_2;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Emoji", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(12, 190);
            label9.Name = "label9";
            label9.Size = new Size(55, 20);
            label9.TabIndex = 25;
            label9.Text = "Harga";
            // 
            // FormProduksi
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(962, 477);
            Controls.Add(panel1);
            Controls.Add(dgvProduksi);
            Name = "FormProduksi";
            Text = "Form - Produksi";
            ((System.ComponentModel.ISupportInitialize)dgvProduksi).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
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
    }
}