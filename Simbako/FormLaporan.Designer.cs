namespace Simbako
{
    partial class FormLaporan
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
            tabControl1 = new TabControl();
            Panen = new TabPage();
            dgvLapPanen = new DataGridView();
            Produksi = new TabPage();
            dgvLapProduksi = new DataGridView();
            Penjualan = new TabPage();
            dgvLapPenjualan = new DataGridView();
            Stok = new TabPage();
            dgvLapStok = new DataGridView();
            btnLapPanen = new Button();
            btnLapProduksi = new Button();
            btnLapPenjualan = new Button();
            btnLapStok = new Button();
            panel1 = new Panel();
            dtpSampai = new DateTimePicker();
            dtpDari = new DateTimePicker();
            label2 = new Label();
            label1 = new Label();
            btnKeluar = new Button();
            tabControl1.SuspendLayout();
            Panen.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvLapPanen).BeginInit();
            Produksi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvLapProduksi).BeginInit();
            Penjualan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvLapPenjualan).BeginInit();
            Stok.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvLapStok).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(Panen);
            tabControl1.Controls.Add(Produksi);
            tabControl1.Controls.Add(Penjualan);
            tabControl1.Controls.Add(Stok);
            tabControl1.Font = new Font("Segoe UI Emoji", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tabControl1.Location = new Point(12, 75);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(776, 238);
            tabControl1.TabIndex = 0;
            // 
            // Panen
            // 
            Panen.Controls.Add(dgvLapPanen);
            Panen.Font = new Font("Segoe UI Emoji", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Panen.Location = new Point(4, 29);
            Panen.Name = "Panen";
            Panen.Padding = new Padding(3);
            Panen.Size = new Size(768, 205);
            Panen.TabIndex = 0;
            Panen.Text = "Panen";
            Panen.UseVisualStyleBackColor = true;
            // 
            // dgvLapPanen
            // 
            dgvLapPanen.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvLapPanen.Location = new Point(6, 3);
            dgvLapPanen.Name = "dgvLapPanen";
            dgvLapPanen.RowHeadersWidth = 51;
            dgvLapPanen.Size = new Size(756, 196);
            dgvLapPanen.TabIndex = 0;
            dgvLapPanen.CellContentClick += dgvLapPanen_CellContentClick;
            // 
            // Produksi
            // 
            Produksi.Controls.Add(dgvLapProduksi);
            Produksi.Font = new Font("Segoe UI Emoji", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Produksi.Location = new Point(4, 29);
            Produksi.Name = "Produksi";
            Produksi.Padding = new Padding(3);
            Produksi.Size = new Size(768, 205);
            Produksi.TabIndex = 1;
            Produksi.Text = "Produksi";
            Produksi.UseVisualStyleBackColor = true;
            // 
            // dgvLapProduksi
            // 
            dgvLapProduksi.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvLapProduksi.Location = new Point(6, 3);
            dgvLapProduksi.Name = "dgvLapProduksi";
            dgvLapProduksi.RowHeadersWidth = 51;
            dgvLapProduksi.Size = new Size(756, 196);
            dgvLapProduksi.TabIndex = 0;
            // 
            // Penjualan
            // 
            Penjualan.Controls.Add(dgvLapPenjualan);
            Penjualan.Font = new Font("Segoe UI Emoji", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Penjualan.Location = new Point(4, 29);
            Penjualan.Name = "Penjualan";
            Penjualan.Size = new Size(768, 205);
            Penjualan.TabIndex = 2;
            Penjualan.Text = "Penjualan";
            Penjualan.UseVisualStyleBackColor = true;
            // 
            // dgvLapPenjualan
            // 
            dgvLapPenjualan.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvLapPenjualan.Location = new Point(6, 3);
            dgvLapPenjualan.Name = "dgvLapPenjualan";
            dgvLapPenjualan.RowHeadersWidth = 51;
            dgvLapPenjualan.Size = new Size(756, 196);
            dgvLapPenjualan.TabIndex = 0;
            dgvLapPenjualan.CellContentClick += dgvLapPenjualan_CellContentClick;
            // 
            // Stok
            // 
            Stok.Controls.Add(dgvLapStok);
            Stok.Font = new Font("Segoe UI Emoji", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Stok.Location = new Point(4, 29);
            Stok.Name = "Stok";
            Stok.Size = new Size(768, 205);
            Stok.TabIndex = 3;
            Stok.Text = "Stok";
            Stok.UseVisualStyleBackColor = true;
            // 
            // dgvLapStok
            // 
            dgvLapStok.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvLapStok.Location = new Point(6, 3);
            dgvLapStok.Name = "dgvLapStok";
            dgvLapStok.RowHeadersWidth = 51;
            dgvLapStok.Size = new Size(756, 196);
            dgvLapStok.TabIndex = 5;
            dgvLapStok.CellContentClick += dgvLapStok_CellContentClick;
            // 
            // btnLapPanen
            // 
            btnLapPanen.Location = new Point(22, 333);
            btnLapPanen.Name = "btnLapPanen";
            btnLapPanen.Size = new Size(132, 29);
            btnLapPanen.TabIndex = 1;
            btnLapPanen.Text = "Laporan Panen";
            btnLapPanen.UseVisualStyleBackColor = true;
            btnLapPanen.Click += btnLapPanen_Click;
            // 
            // btnLapProduksi
            // 
            btnLapProduksi.Location = new Point(160, 333);
            btnLapProduksi.Name = "btnLapProduksi";
            btnLapProduksi.Size = new Size(132, 29);
            btnLapProduksi.TabIndex = 2;
            btnLapProduksi.Text = "Laporan Produksi";
            btnLapProduksi.UseVisualStyleBackColor = true;
            btnLapProduksi.Click += btnLapProduksi_Click;
            // 
            // btnLapPenjualan
            // 
            btnLapPenjualan.Location = new Point(298, 333);
            btnLapPenjualan.Name = "btnLapPenjualan";
            btnLapPenjualan.Size = new Size(150, 29);
            btnLapPenjualan.TabIndex = 3;
            btnLapPenjualan.Text = "Laporan Penjualan";
            btnLapPenjualan.UseVisualStyleBackColor = true;
            btnLapPenjualan.Click += btnLapPenjualan_Click;
            // 
            // btnLapStok
            // 
            btnLapStok.Location = new Point(454, 333);
            btnLapStok.Name = "btnLapStok";
            btnLapStok.Size = new Size(132, 29);
            btnLapStok.TabIndex = 4;
            btnLapStok.Text = " Laporan Stok";
            btnLapStok.UseVisualStyleBackColor = true;
            btnLapStok.Click += btnLapStok_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(dtpSampai);
            panel1.Controls.Add(dtpDari);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(22, 32);
            panel1.Name = "panel1";
            panel1.Size = new Size(756, 37);
            panel1.TabIndex = 5;
            // 
            // dtpSampai
            // 
            dtpSampai.Location = new Point(494, 6);
            dtpSampai.Name = "dtpSampai";
            dtpSampai.Size = new Size(250, 27);
            dtpSampai.TabIndex = 3;
            // 
            // dtpDari
            // 
            dtpDari.Location = new Point(81, 6);
            dtpDari.Name = "dtpDari";
            dtpDari.Size = new Size(250, 27);
            dtpDari.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Emoji", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(394, 4);
            label2.Name = "label2";
            label2.Size = new Size(94, 27);
            label2.TabIndex = 1;
            label2.Text = "Sampai :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Emoji", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 5);
            label1.Name = "label1";
            label1.Size = new Size(63, 27);
            label1.TabIndex = 0;
            label1.Text = "Dari :";
            // 
            // btnKeluar
            // 
            btnKeluar.Location = new Point(592, 333);
            btnKeluar.Name = "btnKeluar";
            btnKeluar.Size = new Size(94, 29);
            btnKeluar.TabIndex = 6;
            btnKeluar.Text = "Keluar";
            btnKeluar.UseVisualStyleBackColor = true;
            btnKeluar.Click += btnKeluar_Click;
            // 
            // FormLaporan
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 370);
            Controls.Add(btnKeluar);
            Controls.Add(panel1);
            Controls.Add(btnLapStok);
            Controls.Add(btnLapPenjualan);
            Controls.Add(btnLapProduksi);
            Controls.Add(btnLapPanen);
            Controls.Add(tabControl1);
            Name = "FormLaporan";
            Text = "FormLaporan";
            Load += FormLaporan_Load;
            tabControl1.ResumeLayout(false);
            Panen.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvLapPanen).EndInit();
            Produksi.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvLapProduksi).EndInit();
            Penjualan.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvLapPenjualan).EndInit();
            Stok.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvLapStok).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage Panen;
        private TabPage Produksi;
        private Button btnLapPanen;
        private Button btnLapProduksi;
        private Button btnLapPenjualan;
        private Button btnLapStok;
        private TabPage Penjualan;
        private TabPage Stok;
        private DataGridView dgvLapProduksi;
        private DataGridView dgvLapPanen;
        private DataGridView dgvLapPenjualan;
        private DataGridView dgvLapStok;
        private Panel panel1;
        private DateTimePicker dtpSampai;
        private DateTimePicker dtpDari;
        private Label label2;
        private Label label1;
        private Button btnKeluar;
    }
}