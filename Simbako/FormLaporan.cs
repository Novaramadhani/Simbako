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

        // ✅ Tombol langsung panggil fungsi
        private void btnLapPanen_Click(object sender, EventArgs e) => LoadLapPanen();
        private void btnLapProduksi_Click(object sender, EventArgs e) => LoadLapProduksi();
        private void btnLapPenjualan_Click(object sender, EventArgs e) => LoadLapPenjualan();
        private void btnLapStok_Click(object sender, EventArgs e) => LoadLapStok();

        // ✅ Laporan Panen
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

        // ✅ Laporan Produksi (detail per proses)
        private void LoadLapProduksi()
        {
            using var conn = DBConnection.GetConnection();
            conn.Open();
            var cmd = new NpgsqlCommand(
                "SELECT id_produksi, id_panen, jenis_proses, jumlah_diolah, hasil_produksi, kualitas, status_produksi, tanggal_produksi " +
                "FROM produksi " +
                "WHERE tanggal_produksi BETWEEN @dari AND @sampai " +
                "ORDER BY tanggal_produksi DESC", conn);

            cmd.Parameters.AddWithValue("dari", dtpDari.Value.Date);
            cmd.Parameters.AddWithValue("sampai", dtpSampai.Value.Date);

            var dt = new DataTable();
            new NpgsqlDataAdapter(cmd).Fill(dt);
            dgvLapProduksi.DataSource = dt;
        }


        // ✅ Laporan Penjualan (Customer + Produk)
        private void LoadLapPenjualan()
        {
            using var conn = DBConnection.GetConnection();
            conn.Open();
            var cmd = new NpgsqlCommand(
                "SELECT pj.tanggal_penjualan, c.nama_customer, pr.nama_produk, pj.kualitas, pj.jumlah, pj.total_harga " +
                "FROM penjualan pj " +
                "JOIN produk pr ON pj.id_produk = pr.id_produk " +
                "JOIN customer c ON pj.id_customer = c.id_customer " +
                "WHERE pj.tanggal_penjualan BETWEEN @dari AND @sampai " +
                "ORDER BY pj.tanggal_penjualan DESC", conn);

            cmd.Parameters.AddWithValue("dari", dtpDari.Value.Date);
            cmd.Parameters.AddWithValue("sampai", dtpSampai.Value.Date);

            var dt = new DataTable();
            new NpgsqlDataAdapter(cmd).Fill(dt);
            dgvLapPenjualan.DataSource = dt;

            // Optional: ubah header
            dgvLapPenjualan.Columns[0].HeaderText = "Tanggal";
            dgvLapPenjualan.Columns[1].HeaderText = "Customer";
            dgvLapPenjualan.Columns[2].HeaderText = "Produk";
            dgvLapPenjualan.Columns[3].HeaderText = "Kualitas";
            dgvLapPenjualan.Columns[4].HeaderText = "Jumlah (kg)";
            dgvLapPenjualan.Columns[5].HeaderText = "Total Harga (Rp)";
        }

        // ✅ Laporan Stok
        private void LoadLapStok()
        {
            using var conn = DBConnection.GetConnection();
            conn.Open();
            var cmd = new NpgsqlCommand(
                "SELECT id_produk, nama_produk, stok, harga, kualitas, status_verifikasi " +
                "FROM produk ORDER BY stok ASC", conn);

            var dt = new DataTable();
            new NpgsqlDataAdapter(cmd).Fill(dt);
            dgvLapStok.DataSource = dt;

            // Optional: ubah header
            dgvLapStok.Columns[0].HeaderText = "ID Produk";
            dgvLapStok.Columns[1].HeaderText = "Produk";
            dgvLapStok.Columns[2].HeaderText = "Stok";
            dgvLapStok.Columns[3].HeaderText = "Harga";
            dgvLapStok.Columns[4].HeaderText = "Kualitas";
            dgvLapStok.Columns[5].HeaderText = "Status";
        }

        // ✅ Tambahan untuk menghindari error Designer
        private void dgvLapPanen_CellContentClick(object sender, DataGridViewCellEventArgs e) { }
        private void dgvLapPenjualan_CellContentClick(object sender, DataGridViewCellEventArgs e) { }
        private void dgvLapStok_CellContentClick(object sender, DataGridViewCellEventArgs e) { }
        private void dgvLapProduksi_CellContentClick(object sender, DataGridViewCellEventArgs e) { }

        private void btnKeluar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
