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
            ((System.ComponentModel.ISupportInitialize)dgvPanen).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // dgvPanen
            // 
            dgvPanen.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPanen.Location = new Point(12, 12);
            dgvPanen.Name = "dgvPanen";
            dgvPanen.RowHeadersWidth = 51;
            dgvPanen.Size = new Size(776, 174);
            dgvPanen.TabIndex = 0;
            dgvPanen.CellClick += dgvPanen_CellClick;
            // 
            // panel1
            // 
            panel1.Controls.Add(btnKeluar);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(dtpTanggal);
            panel1.Controls.Add(btnRefresh);
            panel1.Controls.Add(btnVerifikasi);
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
            panel1.Location = new Point(12, 227);
            panel1.Name = "panel1";
            panel1.Size = new Size(776, 184);
            panel1.TabIndex = 1;
            // 
            // btnKeluar
            // 
            btnKeluar.Location = new Point(517, 139);
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
            btnRefresh.Location = new Point(417, 139);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(94, 29);
            btnRefresh.TabIndex = 12;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = true;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // btnVerifikasi
            // 
            btnVerifikasi.Location = new Point(317, 139);
            btnVerifikasi.Name = "btnVerifikasi";
            btnVerifikasi.Size = new Size(94, 29);
            btnVerifikasi.TabIndex = 11;
            btnVerifikasi.Text = "Verifikasi";
            btnVerifikasi.UseVisualStyleBackColor = true;
            btnVerifikasi.Click += btnVerifikasi_Click;
            // 
            // btnHapus
            // 
            btnHapus.Location = new Point(217, 139);
            btnHapus.Name = "btnHapus";
            btnHapus.Size = new Size(94, 29);
            btnHapus.TabIndex = 10;
            btnHapus.Text = "Hapus";
            btnHapus.UseVisualStyleBackColor = true;
            btnHapus.Click += btnHapus_Click;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(117, 139);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(94, 29);
            btnEdit.TabIndex = 9;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnSimpan
            // 
            btnSimpan.Location = new Point(17, 139);
            btnSimpan.Name = "btnSimpan";
            btnSimpan.Size = new Size(94, 29);
            btnSimpan.TabIndex = 8;
            btnSimpan.Text = "Simpan";
            btnSimpan.UseVisualStyleBackColor = true;
            btnSimpan.Click += btnSimpan_Click;
            // 
            // cmbKualitas
            // 
            cmbKualitas.FormattingEnabled = true;
            cmbKualitas.Items.AddRange(new object[] { "Sangat Baik", "Bagus", "Kurang Baik", "Bosok" });
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
            // FormPanen
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Controls.Add(dgvPanen);
            Name = "FormPanen";
            Text = "Manajemen Panen";
            Load += FormPanen_Load;
            ((System.ComponentModel.ISupportInitialize)dgvPanen).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
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
    }
}
