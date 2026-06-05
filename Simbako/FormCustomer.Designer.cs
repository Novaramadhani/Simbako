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
            panel2 = new Panel();
            lblTotal = new Label();
            lblHarga = new Label();
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
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // dgvProduk
            // 
            dgvProduk.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProduk.Location = new Point(26, 59);
            dgvProduk.Name = "dgvProduk";
            dgvProduk.RowHeadersWidth = 51;
            dgvProduk.Size = new Size(742, 86);
            dgvProduk.TabIndex = 0;
            dgvProduk.CellClick += dgvProduk_CellClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(26, 36);
            label1.Name = "label1";
            label1.Size = new Size(167, 20);
            label1.TabIndex = 1;
            label1.Text = "Daftar Produk Tersedia :";
            // 
            // panel1
            // 
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(txtNoHP);
            panel1.Controls.Add(txtJumlah);
            panel1.Controls.Add(txtNama);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(btnKeluar);
            panel1.Controls.Add(btnNota);
            panel1.Controls.Add(btnBeli);
            panel1.Location = new Point(26, 190);
            panel1.Name = "panel1";
            panel1.Size = new Size(742, 220);
            panel1.TabIndex = 2;
            panel1.Paint += panel1_Paint;
            // 
            // panel2
            // 
            panel2.Controls.Add(lblTotal);
            panel2.Controls.Add(lblHarga);
            panel2.Location = new Point(351, 96);
            panel2.Name = "panel2";
            panel2.Size = new Size(370, 53);
            panel2.TabIndex = 9;
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Location = new Point(3, 30);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(53, 20);
            lblTotal.TabIndex = 1;
            lblTotal.Text = "Total : ";
            lblTotal.Click += label6_Click;
            // 
            // lblHarga
            // 
            lblHarga.AutoSize = true;
            lblHarga.Location = new Point(3, 10);
            lblHarga.Name = "lblHarga";
            lblHarga.Size = new Size(57, 20);
            lblHarga.TabIndex = 0;
            lblHarga.Text = "Harga :";
            // 
            // txtNoHP
            // 
            txtNoHP.Location = new Point(351, 38);
            txtNoHP.Name = "txtNoHP";
            txtNoHP.Size = new Size(370, 27);
            txtNoHP.TabIndex = 8;
            // 
            // txtJumlah
            // 
            txtJumlah.Location = new Point(14, 119);
            txtJumlah.Name = "txtJumlah";
            txtJumlah.Size = new Size(311, 27);
            txtJumlah.TabIndex = 7;
            txtJumlah.TextChanged += txtJumlah_TextChanged;
            // 
            // txtNama
            // 
            txtNama.Location = new Point(14, 38);
            txtNama.Name = "txtNama";
            txtNama.Size = new Size(311, 27);
            txtNama.TabIndex = 6;
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
            btnKeluar.Location = new Point(214, 178);
            btnKeluar.Name = "btnKeluar";
            btnKeluar.Size = new Size(94, 29);
            btnKeluar.TabIndex = 2;
            btnKeluar.Text = "Keluar";
            btnKeluar.UseVisualStyleBackColor = true;
            // 
            // btnNota
            // 
            btnNota.Location = new Point(114, 178);
            btnNota.Name = "btnNota";
            btnNota.Size = new Size(94, 29);
            btnNota.TabIndex = 1;
            btnNota.Text = "Lihat Nota";
            btnNota.UseVisualStyleBackColor = true;
            // 
            // btnBeli
            // 
            btnBeli.Location = new Point(14, 178);
            btnBeli.Name = "btnBeli";
            btnBeli.Size = new Size(94, 29);
            btnBeli.TabIndex = 0;
            btnBeli.Text = "Beli Produk";
            btnBeli.UseVisualStyleBackColor = true;
            // 
            // FormCustomer
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Controls.Add(label1);
            Controls.Add(dgvProduk);
            Name = "FormCustomer";
            Text = "FormCustomer";
            ((System.ComponentModel.ISupportInitialize)dgvProduk).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
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
        private Panel panel2;
        private Label lblTotal;
        private Label lblHarga;
    }
}