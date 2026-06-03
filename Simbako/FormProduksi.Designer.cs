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
            txtJenisProses = new TextBox();
            txtHasil = new TextBox();
            btnSimpan = new Button();
            btnEdit = new Button();
            btnHapus = new Button();
            btnRefresh = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvProduksi).BeginInit();
            SuspendLayout();
            // 
            // dgvProduksi
            // 
            dgvProduksi.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProduksi.Location = new Point(12, 201);
            dgvProduksi.Name = "dgvProduksi";
            dgvProduksi.RowHeadersWidth = 51;
            dgvProduksi.Size = new Size(938, 237);
            dgvProduksi.TabIndex = 0;
            dgvProduksi.CellContentClick += dgvProduksi_CellContentClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(58, 227);
            label1.Name = "label1";
            label1.Size = new Size(163, 20);
            label1.TabIndex = 1;
            label1.Text = " ID Panen (Terverifikasi)";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(482, 227);
            label2.Name = "label2";
            label2.Size = new Size(90, 20);
            label2.TabIndex = 2;
            label2.Text = " Jenis Proses";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(58, 318);
            label3.Name = "label3";
            label3.Size = new Size(109, 20);
            label3.TabIndex = 3;
            label3.Text = "Status Produksi";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(482, 318);
            label4.Name = "label4";
            label4.Size = new Size(134, 20);
            label4.TabIndex = 4;
            label4.Text = "Hasil Produksi (KG)";
            // 
            // cmbldPanen
            // 
            cmbldPanen.FormattingEnabled = true;
            cmbldPanen.Location = new Point(58, 261);
            cmbldPanen.Name = "cmbldPanen";
            cmbldPanen.Size = new Size(401, 28);
            cmbldPanen.TabIndex = 5;
            cmbldPanen.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // cmbStatus
            // 
            cmbStatus.FormattingEnabled = true;
            cmbStatus.Location = new Point(58, 353);
            cmbStatus.Name = "cmbStatus";
            cmbStatus.Size = new Size(401, 28);
            cmbStatus.TabIndex = 6;
            cmbStatus.SelectedIndexChanged += comboBox2_SelectedIndexChanged;
            // 
            // txtJenisProses
            // 
            txtJenisProses.Location = new Point(482, 261);
            txtJenisProses.Name = "txtJenisProses";
            txtJenisProses.Size = new Size(419, 27);
            txtJenisProses.TabIndex = 7;
            txtJenisProses.TextChanged += textBox1_TextChanged;
            // 
            // txtHasil
            // 
            txtHasil.Location = new Point(482, 354);
            txtHasil.Name = "txtHasil";
            txtHasil.Size = new Size(419, 27);
            txtHasil.TabIndex = 8;
            // 
            // btnSimpan
            // 
            btnSimpan.Location = new Point(58, 400);
            btnSimpan.Name = "btnSimpan";
            btnSimpan.Size = new Size(94, 29);
            btnSimpan.TabIndex = 9;
            btnSimpan.Text = "Simpan ";
            btnSimpan.UseVisualStyleBackColor = true;
            btnSimpan.Click += button1_Click;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(158, 400);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(125, 29);
            btnEdit.TabIndex = 10;
            btnEdit.Text = "Update Status";
            btnEdit.UseVisualStyleBackColor = true;
            // 
            // btnHapus
            // 
            btnHapus.Location = new Point(289, 400);
            btnHapus.Name = "btnHapus";
            btnHapus.Size = new Size(94, 29);
            btnHapus.TabIndex = 11;
            btnHapus.Text = "Hapus";
            btnHapus.UseVisualStyleBackColor = true;
            // 
            // btnRefresh
            // 
            btnRefresh.Location = new Point(389, 400);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(94, 29);
            btnRefresh.TabIndex = 12;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = true;
            // 
            // FormProduksi
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(962, 450);
            Controls.Add(btnRefresh);
            Controls.Add(btnHapus);
            Controls.Add(btnEdit);
            Controls.Add(btnSimpan);
            Controls.Add(txtHasil);
            Controls.Add(txtJenisProses);
            Controls.Add(cmbStatus);
            Controls.Add(cmbldPanen);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dgvProduksi);
            Name = "FormProduksi";
            Text = "FormProduksi";
            ((System.ComponentModel.ISupportInitialize)dgvProduksi).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvProduksi;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private ComboBox cmbldPanen;
        private ComboBox cmbStatus;
        private TextBox txtJenisProses;
        private TextBox txtHasil;
        private Button btnSimpan;
        private Button btnEdit;
        private Button btnHapus;
        private Button btnRefresh;
    }
}