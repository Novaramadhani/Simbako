namespace Simbako
{
    partial class FormPetani
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
            panel1 = new Panel();
            txtNamaPetani = new TextBox();
            label1 = new Label();
            txtJumlah = new TextBox();
            dtpTanggal = new DateTimePicker();
            cmbKualitas = new ComboBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            btnSimpanPanen = new Button();
            btnLihatStatus = new Button();
            btnKeluar = new Button();
            dgvRiwayatPanen = new DataGridView();
            label6 = new Label();
            label7 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvRiwayatPanen).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(btnSimpanPanen);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(cmbKualitas);
            panel1.Controls.Add(dtpTanggal);
            panel1.Controls.Add(txtJumlah);
            panel1.Controls.Add(txtNamaPetani);
            panel1.Location = new Point(80, 93);
            panel1.Name = "panel1";
            panel1.Size = new Size(723, 250);
            panel1.TabIndex = 0;
            // 
            // txtNamaPetani
            // 
            txtNamaPetani.Location = new Point(28, 70);
            txtNamaPetani.Name = "txtNamaPetani";
            txtNamaPetani.Size = new Size(313, 27);
            txtNamaPetani.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.FlatStyle = FlatStyle.Flat;
            label1.Font = new Font("Segoe UI Historic", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(279, 49);
            label1.Name = "label1";
            label1.Size = new Size(315, 31);
            label1.TabIndex = 1;
            label1.Text = "Portal Petani - Input Panen";
            // 
            // txtJumlah
            // 
            txtJumlah.Location = new Point(28, 132);
            txtJumlah.Name = "txtJumlah";
            txtJumlah.Size = new Size(313, 27);
            txtJumlah.TabIndex = 1;
            // 
            // dtpTanggal
            // 
            dtpTanggal.Location = new Point(364, 70);
            dtpTanggal.Name = "dtpTanggal";
            dtpTanggal.Size = new Size(319, 27);
            dtpTanggal.TabIndex = 3;
            // 
            // cmbKualitas
            // 
            cmbKualitas.FormattingEnabled = true;
            cmbKualitas.Items.AddRange(new object[] { "A", "B", "C" });
            cmbKualitas.Location = new Point(364, 131);
            cmbKualitas.Name = "cmbKualitas";
            cmbKualitas.Size = new Size(319, 28);
            cmbKualitas.TabIndex = 4;
            cmbKualitas.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(28, 47);
            label2.Name = "label2";
            label2.Size = new Size(93, 20);
            label2.TabIndex = 5;
            label2.Text = "Nama Petani";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(28, 109);
            label3.Name = "label3";
            label3.Size = new Size(83, 20);
            label3.TabIndex = 6;
            label3.Text = "Jumlah(Kg)";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(364, 47);
            label4.Name = "label4";
            label4.Size = new Size(104, 20);
            label4.TabIndex = 7;
            label4.Text = "Tanggal Panen";
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(364, 108);
            label5.Name = "label5";
            label5.Size = new Size(61, 20);
            label5.TabIndex = 8;
            label5.Text = "Kualitas";
            // 
            // btnSimpanPanen
            // 
            btnSimpanPanen.Location = new Point(271, 191);
            btnSimpanPanen.Name = "btnSimpanPanen";
            btnSimpanPanen.Size = new Size(163, 29);
            btnSimpanPanen.TabIndex = 9;
            btnSimpanPanen.Text = "Kirim Data Panen";
            btnSimpanPanen.UseVisualStyleBackColor = true;
            // 
            // btnLihatStatus
            // 
            btnLihatStatus.Location = new Point(559, 491);
            btnLihatStatus.Name = "btnLihatStatus";
            btnLihatStatus.Size = new Size(144, 29);
            btnLihatStatus.TabIndex = 10;
            btnLihatStatus.Text = "Refresh";
            btnLihatStatus.UseVisualStyleBackColor = true;
            // 
            // btnKeluar
            // 
            btnKeluar.Location = new Point(709, 491);
            btnKeluar.Name = "btnKeluar";
            btnKeluar.Size = new Size(94, 29);
            btnKeluar.TabIndex = 11;
            btnKeluar.Text = "Keluar";
            btnKeluar.UseVisualStyleBackColor = true;
            // 
            // dgvRiwayatPanen
            // 
            dgvRiwayatPanen.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRiwayatPanen.Location = new Point(80, 385);
            dgvRiwayatPanen.Name = "dgvRiwayatPanen";
            dgvRiwayatPanen.RowHeadersWidth = 51;
            dgvRiwayatPanen.Size = new Size(723, 100);
            dgvRiwayatPanen.TabIndex = 12;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(80, 362);
            label6.Name = "label6";
            label6.Size = new Size(139, 20);
            label6.TabIndex = 13;
            label6.Text = "Riwayat Panen Saya";
            label6.Click += label6_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Emoji", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(315, 22);
            label7.Name = "label7";
            label7.Size = new Size(243, 27);
            label7.TabIndex = 14;
            label7.Text = "Selamat Datang, Petani!";
            // 
            // FormPetani
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(886, 523);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(dgvRiwayatPanen);
            Controls.Add(btnKeluar);
            Controls.Add(label1);
            Controls.Add(btnLihatStatus);
            Controls.Add(panel1);
            Name = "FormPetani";
            Text = "FormPetani";
            Load += FormPetani_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvRiwayatPanen).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private TextBox txtNamaPetani;
        private Label label1;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private ComboBox cmbKualitas;
        private DateTimePicker dtpTanggal;
        private TextBox txtJumlah;
        private Button btnSimpanPanen;
        private Button btnLihatStatus;
        private Button btnKeluar;
        private DataGridView dgvRiwayatPanen;
        private Label label6;
        private Label label7;
    }
}