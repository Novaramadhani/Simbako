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
            cmbJenisProses = new ComboBox();
            btnKeluar = new Button();
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
            dgvProduksi.CellContentClick += dgvProduksi_CellContentClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Emoji", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(22, 33);
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
            label2.Location = new Point(476, 33);
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
            label3.Location = new Point(22, 120);
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
            label4.Location = new Point(476, 120);
            label4.Name = "label4";
            label4.Size = new Size(154, 20);
            label4.TabIndex = 4;
            label4.Text = "Hasil Produksi (KG)";
            // 
            // cmbldPanen
            // 
            cmbldPanen.FormattingEnabled = true;
            cmbldPanen.Location = new Point(22, 56);
            cmbldPanen.Name = "cmbldPanen";
            cmbldPanen.Size = new Size(401, 28);
            cmbldPanen.TabIndex = 5;
            cmbldPanen.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // cmbStatus
            // 
            cmbStatus.FormattingEnabled = true;
            cmbStatus.Items.AddRange(new object[] { "Menunggu", "Proses", "Selesai", "Siap Jual" });
            cmbStatus.Location = new Point(22, 143);
            cmbStatus.Name = "cmbStatus";
            cmbStatus.Size = new Size(401, 28);
            cmbStatus.TabIndex = 6;
            cmbStatus.SelectedIndexChanged += comboBox2_SelectedIndexChanged;
            // 
            // txtHasil
            // 
            txtHasil.Location = new Point(476, 143);
            txtHasil.Name = "txtHasil";
            txtHasil.Size = new Size(419, 27);
            txtHasil.TabIndex = 8;
            // 
            // btnSimpan
            // 
            btnSimpan.Location = new Point(22, 201);
            btnSimpan.Name = "btnSimpan";
            btnSimpan.Size = new Size(94, 29);
            btnSimpan.TabIndex = 9;
            btnSimpan.Text = "Simpan ";
            btnSimpan.UseVisualStyleBackColor = true;
            btnSimpan.Click += btnSimpan_Click;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(122, 201);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(125, 29);
            btnEdit.TabIndex = 10;
            btnEdit.Text = "Update";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnHapus
            // 
            btnHapus.Location = new Point(253, 201);
            btnHapus.Name = "btnHapus";
            btnHapus.Size = new Size(94, 29);
            btnHapus.TabIndex = 11;
            btnHapus.Text = "Hapus";
            btnHapus.UseVisualStyleBackColor = true;
            // 
            // btnRefresh
            // 
            btnRefresh.Location = new Point(353, 201);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(94, 29);
            btnRefresh.TabIndex = 12;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = true;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // panel1
            // 
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
            panel1.Location = new Point(12, 181);
            panel1.Name = "panel1";
            panel1.Size = new Size(938, 233);
            panel1.TabIndex = 13;
            // 
            // cmbJenisProses
            // 
            cmbJenisProses.FormattingEnabled = true;
            cmbJenisProses.Items.AddRange(new object[] { "Fermentasi", "Pengeringan", "Penggulungan", "Pembungkusan", "Penyimpanan" });
            cmbJenisProses.Location = new Point(479, 56);
            cmbJenisProses.Name = "cmbJenisProses";
            cmbJenisProses.Size = new Size(416, 28);
            cmbJenisProses.TabIndex = 13;
            cmbJenisProses.SelectedIndexChanged += cmbJenisProses_SelectedIndexChanged;
            // 
            // btnKeluar
            // 
            btnKeluar.Location = new Point(453, 201);
            btnKeluar.Name = "btnKeluar";
            btnKeluar.Size = new Size(94, 29);
            btnKeluar.TabIndex = 14;
            btnKeluar.Text = "Keluar";
            btnKeluar.UseVisualStyleBackColor = true;
            btnKeluar.Click += btnKeluar_Click;
            // 
            // FormProduksi
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(962, 450);
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
    }
}