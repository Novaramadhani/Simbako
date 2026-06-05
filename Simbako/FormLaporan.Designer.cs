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
            Produksi = new TabPage();
            btnLapPanen = new Button();
            btnLapProduksi = new Button();
            btnLapPenjualan = new Button();
            btnLapStok = new Button();
            Penjualan = new TabPage();
            Stok = new TabPage();
            dgvLapProduksi = new DataGridView();
            dgvLapPanen = new DataGridView();
            dgvLapPenjualan = new DataGridView();
            dgvLapStok = new DataGridView();
            panel1 = new Panel();
            label1 = new Label();
            label2 = new Label();
            dtpDari = new DateTimePicker();
            dtpSampai = new DateTimePicker();
            tabControl1.SuspendLayout();
            Panen.SuspendLayout();
            Produksi.SuspendLayout();
            Penjualan.SuspendLayout();
            Stok.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvLapProduksi).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvLapPanen).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvLapPenjualan).BeginInit();
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
            tabControl1.Location = new Point(12, 141);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(776, 172);
            tabControl1.TabIndex = 0;
            // 
            // Panen
            // 
            Panen.Controls.Add(dgvLapPanen);
            Panen.Font = new Font("Segoe UI Emoji", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Panen.Location = new Point(4, 29);
            Panen.Name = "Panen";
            Panen.Padding = new Padding(3);
            Panen.Size = new Size(768, 139);
            Panen.TabIndex = 0;
            Panen.Text = "Panen";
            Panen.UseVisualStyleBackColor = true;
            // 
            // Produksi
            // 
            Produksi.Controls.Add(dgvLapProduksi);
            Produksi.Font = new Font("Segoe UI Emoji", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Produksi.Location = new Point(4, 29);
            Produksi.Name = "Produksi";
            Produksi.Padding = new Padding(3);
            Produksi.Size = new Size(768, 139);
            Produksi.TabIndex = 1;
            Produksi.Text = "Produksi";
            Produksi.UseVisualStyleBackColor = true;
            // 
            // btnLapPanen
            // 
            btnLapPanen.Location = new Point(22, 333);
            btnLapPanen.Name = "btnLapPanen";
            btnLapPanen.Size = new Size(132, 29);
            btnLapPanen.TabIndex = 1;
            btnLapPanen.Text = "Laporan Panen";
            btnLapPanen.UseVisualStyleBackColor = true;
            // 
            // btnLapProduksi
            // 
            btnLapProduksi.Location = new Point(169, 333);
            btnLapProduksi.Name = "btnLapProduksi";
            btnLapProduksi.Size = new Size(132, 29);
            btnLapProduksi.TabIndex = 2;
            btnLapProduksi.Text = "Laporan Produksi";
            btnLapProduksi.UseVisualStyleBackColor = true;
            // 
            // btnLapPenjualan
            // 
            btnLapPenjualan.Location = new Point(319, 333);
            btnLapPenjualan.Name = "btnLapPenjualan";
            btnLapPenjualan.Size = new Size(150, 29);
            btnLapPenjualan.TabIndex = 3;
            btnLapPenjualan.Text = "Laporan Penjualan";
            btnLapPenjualan.UseVisualStyleBackColor = true;
            // 
            // btnLapStok
            // 
            btnLapStok.Location = new Point(488, 333);
            btnLapStok.Name = "btnLapStok";
            btnLapStok.Size = new Size(132, 29);
            btnLapStok.TabIndex = 4;
            btnLapStok.Text = " Laporan Stok";
            btnLapStok.UseVisualStyleBackColor = true;
            // 
            // Penjualan
            // 
            Penjualan.Controls.Add(dgvLapPenjualan);
            Penjualan.Font = new Font("Segoe UI Emoji", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Penjualan.Location = new Point(4, 29);
            Penjualan.Name = "Penjualan";
            Penjualan.Size = new Size(768, 139);
            Penjualan.TabIndex = 2;
            Penjualan.Text = "Penjualan";
            Penjualan.UseVisualStyleBackColor = true;
            // 
            // Stok
            // 
            Stok.Controls.Add(dgvLapStok);
            Stok.Font = new Font("Segoe UI Emoji", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Stok.Location = new Point(4, 29);
            Stok.Name = "Stok";
            Stok.Size = new Size(768, 139);
            Stok.TabIndex = 3;
            Stok.Text = "Stok";
            Stok.UseVisualStyleBackColor = true;
            // 
            // dgvLapProduksi
            // 
            dgvLapProduksi.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvLapProduksi.Location = new Point(6, 6);
            dgvLapProduksi.Name = "dgvLapProduksi";
            dgvLapProduksi.RowHeadersWidth = 51;
            dgvLapProduksi.Size = new Size(756, 127);
            dgvLapProduksi.TabIndex = 0;
            // 
            // dgvLapPanen
            // 
            dgvLapPanen.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvLapPanen.Location = new Point(6, 6);
            dgvLapPanen.Name = "dgvLapPanen";
            dgvLapPanen.RowHeadersWidth = 51;
            dgvLapPanen.Size = new Size(756, 127);
            dgvLapPanen.TabIndex = 0;
            // 
            // dgvLapPenjualan
            // 
            dgvLapPenjualan.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvLapPenjualan.Location = new Point(6, 6);
            dgvLapPenjualan.Name = "dgvLapPenjualan";
            dgvLapPenjualan.RowHeadersWidth = 51;
            dgvLapPenjualan.Size = new Size(756, 127);
            dgvLapPenjualan.TabIndex = 0;
            dgvLapPenjualan.CellContentClick += dataGridView3_CellContentClick;
            // 
            // dgvLapStok
            // 
            dgvLapStok.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvLapStok.Location = new Point(6, 6);
            dgvLapStok.Name = "dgvLapStok";
            dgvLapStok.RowHeadersWidth = 51;
            dgvLapStok.Size = new Size(756, 127);
            dgvLapStok.TabIndex = 5;
            dgvLapStok.CellContentClick += dataGridView1_CellContentClick;
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
            // dtpDari
            // 
            dtpDari.Location = new Point(81, 6);
            dtpDari.Name = "dtpDari";
            dtpDari.Size = new Size(250, 27);
            dtpDari.TabIndex = 2;
            // 
            // dtpSampai
            // 
            dtpSampai.Location = new Point(494, 6);
            dtpSampai.Name = "dtpSampai";
            dtpSampai.Size = new Size(250, 27);
            dtpSampai.TabIndex = 3;
            // 
            // FormLaporan
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 370);
            Controls.Add(panel1);
            Controls.Add(btnLapStok);
            Controls.Add(btnLapPenjualan);
            Controls.Add(btnLapProduksi);
            Controls.Add(btnLapPanen);
            Controls.Add(tabControl1);
            Name = "FormLaporan";
            Text = "FormLaporan";
            tabControl1.ResumeLayout(false);
            Panen.ResumeLayout(false);
            Produksi.ResumeLayout(false);
            Penjualan.ResumeLayout(false);
            Stok.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvLapProduksi).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvLapPanen).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvLapPenjualan).EndInit();
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
    }
}