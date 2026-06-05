using System;
using System.Windows.Forms;

namespace Simbako
{
    public partial class FormDashboardAdmin : Form
    {
        public FormDashboardAdmin()
        {
            InitializeComponent();
        }

        // Event handler untuk Load (Form2_Load)
        private void Form2_Load(object sender, EventArgs e)
        {
            // Bisa dikosongkan atau isi sesuai kebutuhan
            // Contoh: MessageBox.Show("Dashboard Admin siap digunakan!");
        }

        // Event handler untuk label1_Click
        private void label1_Click(object sender, EventArgs e)
        {
            // Bisa dikosongkan atau isi sesuai kebutuhan
            // Contoh: MessageBox.Show("Label diklik!");
        }

        // Event handler untuk flowLayoutPanel2_Paint
        private void flowLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {
            // Bisa dikosongkan atau isi sesuai kebutuhan
            // Contoh: e.Graphics.DrawRectangle(Pens.Black, flowLayoutPanel2.ClientRectangle);
        }

        // Event handler untuk menu strip
        private void panenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Navigasi ke FormPanen
            FormPanen formPanen = new FormPanen();
            formPanen.Show();
        }

        private void produksiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Navigasi ke FormProduksi
            FormProduksi formProduksi = new FormProduksi();
            formProduksi.Show();
        }

        private void produkToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Navigasi ke FormProduk
            FormProduk formProduk = new FormProduk();
            formProduk.Show();
        }

        private void penjualanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Navigasi ke FormPenjualan
            FormPenjualan formPenjualan = new FormPenjualan();
            formPenjualan.Show();
        }

        private void laporanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Navigasi ke FormLaporan
            FormLaporan formLaporan = new FormLaporan();
            formLaporan.Show();
        }

        private void keluarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Tutup dashboard dan kembali ke Form1 (login/utama)
            this.Close();
            Application.OpenForms["Form1"]?.Show();
        }
    }
}
