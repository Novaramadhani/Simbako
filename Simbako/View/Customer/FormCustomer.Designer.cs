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
            btnKeluar = new Button();
            btnNota = new Button();
            btnBeli = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvProduk).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // dgvProduk
            // 
            dgvProduk.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProduk.Location = new Point(26, 32);
            dgvProduk.Name = "dgvProduk";
            dgvProduk.RowHeadersWidth = 51;
            dgvProduk.Size = new Size(742, 113);
            dgvProduk.TabIndex = 0;
            dgvProduk.CellClick += dgvProduk_CellClick;
            dgvProduk.CellContentClick += dgvProduk_CellContentClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(26, 9);
            label1.Name = "label1";
            label1.Size = new Size(167, 20);
            label1.TabIndex = 1;
            label1.Text = "Daftar Produk Tersedia :";
            // 
            // panel1
            // 
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
            panel1.Controls.Add(btnKeluar);
            panel1.Controls.Add(btnNota);
            panel1.Controls.Add(btnBeli);
            panel1.Location = new Point(26, 151);
            panel1.Name = "panel1";
            panel1.Size = new Size(742, 259);
            panel1.TabIndex = 2;
            panel1.Paint += panel1_Paint;
            // 
            // label6
            // 
            label6.AutoSize = true;
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
            btnRefresh.Location = new Point(211, 217);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(94, 29);
            btnRefresh.TabIndex = 12;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = true;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
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
            txtNoHP.Location = new Point(351, 38);
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
            label4.Location = new Point(14, 96);
            label4.Name = "label4";
            label4.Size = new Size(114, 20);
            label4.TabIndex = 5;
            label4.Text = "Jumlah Beli (kg)";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(351, 15);
            label3.Name = "label3";
            label3.Size = new Size(52, 20);
            label3.TabIndex = 4;
            label3.Text = "No HP";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(14, 15);
            label2.Name = "label2";
            label2.Size = new Size(91, 20);
            label2.TabIndex = 3;
            label2.Text = "Nama Kamu";
            // 
            // btnKeluar
            // 
            btnKeluar.Location = new Point(311, 217);
            btnKeluar.Name = "btnKeluar";
            btnKeluar.Size = new Size(94, 29);
            btnKeluar.TabIndex = 2;
            btnKeluar.Text = "Keluar";
            btnKeluar.UseVisualStyleBackColor = true;
            btnKeluar.Click += btnKeluar_Click_1;
            // 
            // btnNota
            // 
            btnNota.Location = new Point(111, 217);
            btnNota.Name = "btnNota";
            btnNota.Size = new Size(94, 29);
            btnNota.TabIndex = 1;
            btnNota.Text = "Lihat Nota";
            btnNota.UseVisualStyleBackColor = true;
            btnNota.Click += btnNota_Click_1;
            // 
            // btnBeli
            // 
            btnBeli.Location = new Point(11, 217);
            btnBeli.Name = "btnBeli";
            btnBeli.Size = new Size(94, 29);
            btnBeli.TabIndex = 0;
            btnBeli.Text = "Beli Produk";
            btnBeli.UseVisualStyleBackColor = true;
            btnBeli.Click += btnBeli_Click_1;
            // 
            // FormCustomer
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(807, 450);
            Controls.Add(panel1);
            Controls.Add(label1);
            Controls.Add(dgvProduk);
            Name = "FormCustomer";
            Text = "FormCustomer";
            ((System.ComponentModel.ISupportInitialize)dgvProduk).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
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
    }
}