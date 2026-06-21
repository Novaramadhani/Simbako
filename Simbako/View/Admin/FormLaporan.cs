using Simbako.Repository;
using System;
using System.Windows.Forms;

namespace Simbako
{
    public partial class FormLaporan : Form
    {
        private readonly LaporanRepository repo;

        public FormLaporan()
        {
            InitializeComponent();
            repo = new LaporanRepository();
        }

        private void FormLaporan_Load(object sender, EventArgs e)
        {
            dtpDari.Value = DateTime.Now.AddMonths(-1);
            dtpSampai.Value = DateTime.Now;
            LoadLapPanen();
        }

        //  Tombol langsung panggil fungsi
        private void btnLapPanen_Click(object sender, EventArgs e) => LoadLapPanen();
        private void btnLapProduksi_Click(object sender, EventArgs e) => LoadLapProduksi();
        private void btnLapPenjualan_Click(object sender, EventArgs e) => LoadLapPenjualan();
        private void btnLapStok_Click(object sender, EventArgs e) => LoadLapStok();

        //  Laporan Panen
        private void LoadLapPanen()
        {
            var data = repo.GetLapPanen(dtpDari.Value, dtpSampai.Value);
            dgvLapPanen.DataSource = data;

            dgvLapPanen.Columns[0].HeaderText = "Nama Petani";
            dgvLapPanen.Columns[1].HeaderText = "Jumlah Kali Panen";
            dgvLapPanen.Columns[2].HeaderText = "Total (kg)";
            dgvLapPanen.Columns[3].HeaderText = "Kualitas"; // otomatis ikut "Busuk"
            dgvLapPanen.Columns[4].HeaderText = "Status";
        }

        //  Laporan Produksi
        private void LoadLapProduksi()
        {
            var data = repo.GetLapProduksi(dtpDari.Value, dtpSampai.Value);
            dgvLapProduksi.DataSource = data;

            dgvLapProduksi.Columns[0].HeaderText = "ID Produksi";
            dgvLapProduksi.Columns[1].HeaderText = "Jenis Proses";
            dgvLapProduksi.Columns[2].HeaderText = "Jumlah Diolah";
            dgvLapProduksi.Columns[3].HeaderText = "Hasil Produksi";
            dgvLapProduksi.Columns[4].HeaderText = "Kualitas"; // otomatis ikut "Busuk"
            dgvLapProduksi.Columns[5].HeaderText = "Status";
            dgvLapProduksi.Columns[6].HeaderText = "Tanggal";
        }

        //  Laporan Penjualan
        private void LoadLapPenjualan()
        {
            var data = repo.GetLapPenjualan(dtpDari.Value, dtpSampai.Value);
            dgvLapPenjualan.DataSource = data;

            dgvLapPenjualan.Columns[0].HeaderText = "Tanggal";
            dgvLapPenjualan.Columns[1].HeaderText = "Customer";
            dgvLapPenjualan.Columns[2].HeaderText = "Produk";
            dgvLapPenjualan.Columns[3].HeaderText = "Kualitas"; // otomatis ikut "Busuk"
            dgvLapPenjualan.Columns[4].HeaderText = "Jumlah (kg)";
            dgvLapPenjualan.Columns[5].HeaderText = "Total Harga (Rp)";
        }

        //  Laporan Stok
        private void LoadLapStok()
        {
            var data = repo.GetLapStok();
            dgvLapStok.DataSource = data;

            dgvLapStok.Columns[0].HeaderText = "ID Produk";
            dgvLapStok.Columns[1].HeaderText = "Produk";
            dgvLapStok.Columns[2].HeaderText = "Stok";
            dgvLapStok.Columns[3].HeaderText = "Harga";
            dgvLapStok.Columns[4].HeaderText = "Kualitas"; // otomatis ikut "Busuk"
            dgvLapStok.Columns[5].HeaderText = "Status";
        }

        //  Tambahan untuk menghindari error Designer
        private void dgvLapPanen_CellContentClick(object sender, DataGridViewCellEventArgs e) { }
        private void dgvLapPenjualan_CellContentClick(object sender, DataGridViewCellEventArgs e) { }
        private void dgvLapStok_CellContentClick(object sender, DataGridViewCellEventArgs e) { }
        private void dgvLapProduksi_CellContentClick(object sender, DataGridViewCellEventArgs e) { }

        private void btnKeluar_Click(object sender, EventArgs e) => this.Close();

        private void dtpDari_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
