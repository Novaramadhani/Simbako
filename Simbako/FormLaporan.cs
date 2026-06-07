using Npgsql;
using Simbako;
using System;
using System.Data;
using System.Windows.Forms;

namespace Simbako
{
    public partial class FormLaporan : Form
    {
        public FormLaporan()
        {
            InitializeComponent();
        }

        private void FormLaporan_Load(object sender, EventArgs e)
        {
            dtpDari.Value = DateTime.Now.AddMonths(-1);
            dtpSampai.Value = DateTime.Now;
            LoadLapPanen();
        }

        private void btnLapPanen_Click(object sender, EventArgs e) => LoadLapPanen();
        private void btnLapProduksi_Click(object sender, EventArgs e) => LoadLapProduksi();
        private void btnLapPenjualan_Click(object sender, EventArgs e) => LoadLapPenjualan();
        private void btnLapStok_Click(object sender, EventArgs e) => LoadLapStok();

        private void LoadLapPanen()
        {
            using var conn = DBConnection.GetConnection();
            conn.Open();
            var cmd = new NpgsqlCommand(
                "SELECT pt.nama_petani, COUNT(p.id_panen) AS jumlah_kali, " +
                "SUM(p.jumlah_panen) AS total_kg, p.kualitas, p.status_verifikasi " +
                "FROM panen p JOIN petani pt ON p.id_petani=pt.id_petani " +
                "WHERE p.tanggal_panen BETWEEN @dari AND @sampai " +
                "GROUP BY pt.nama_petani, p.kualitas, p.status_verifikasi", conn);
            cmd.Parameters.AddWithValue("dari", dtpDari.Value.Date);
            cmd.Parameters.AddWithValue("sampai", dtpSampai.Value.Date);
            var dt = new DataTable();
            new NpgsqlDataAdapter(cmd).Fill(dt);
            dgvLapPanen.DataSource = dt;
        }

        private void LoadLapProduksi()
        {
            using var conn = DBConnection.GetConnection();
            conn.Open();
            var cmd = new NpgsqlCommand(
                "SELECT jenis_proses, COUNT(*) AS jumlah, SUM(hasil_produksi) AS total_hasil, status_produksi " +
                "FROM produksi GROUP BY jenis_proses, status_produksi", conn);
            var dt = new DataTable();
            new NpgsqlDataAdapter(cmd).Fill(dt);
            dgvLapProduksi.DataSource = dt;
        }

        private void LoadLapPenjualan()
        {
            using var conn = DBConnection.GetConnection();
            conn.Open();
            var cmd = new NpgsqlCommand(
                "SELECT pr.nama_produk, SUM(pj.jumlah) AS total_terjual, " +
                "SUM(pj.total_harga) AS total_pendapatan " +
                "FROM penjualan pj JOIN produk pr ON pj.id_produk=pr.id_produk " +
                "WHERE pj.tanggal_penjualan BETWEEN @dari AND @sampai " +
                "GROUP BY pr.nama_produk", conn);
            cmd.Parameters.AddWithValue("dari", dtpDari.Value.Date);
            cmd.Parameters.AddWithValue("sampai", dtpSampai.Value.Date);
            var dt = new DataTable();
            new NpgsqlDataAdapter(cmd).Fill(dt);
            dgvLapPenjualan.DataSource = dt;
        }

        private void LoadLapStok()
        {
            using var conn = DBConnection.GetConnection();
            conn.Open();
            var cmd = new NpgsqlCommand(
                "SELECT nama_produk, stok, harga, kualitas FROM produk ORDER BY stok ASC", conn);
            var dt = new DataTable();
            new NpgsqlDataAdapter(cmd).Fill(dt);
            dgvLapStok.DataSource = dt;
        }

        // 🔧 Tambahan untuk menghindari error Designer
        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Kosongkan atau isi sesuai kebutuhan
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Kosongkan atau isi sesuai kebutuhan
        }

        private void FormLaporan_Load_1(object sender, EventArgs e)
        {

        }

        private void btnKeluar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLapPanen_Click_1(object sender, EventArgs e)
        {
            this.btnLapPanen.Click += new System.EventHandler(this.btnLapPanen_Click);
        }

        private void btnLapProduksi_Click_1(object sender, EventArgs e)
        {
            this.btnLapProduksi.Click += new System.EventHandler(this.btnLapProduksi_Click);
        }

        private void btnLapPenjualan_Click_1(object sender, EventArgs e)
        {
            this.btnLapPenjualan.Click += new System.EventHandler(this.btnLapPenjualan_Click);
        }

        private void btnLapStok_Click_1(object sender, EventArgs e)
        {
            this.btnLapStok.Click += new System.EventHandler(this.btnLapStok_Click);
        }
    }
}
