using Simbako.Repository;
using Simbako.Model;
using System;
using System.Windows.Forms;

namespace Simbako
{
    public partial class FormPenjualan : Form
    {
        private int? selectedId = null;
        private decimal hargaSatuan = 0;
        private readonly PenjualanRepository repo;

        public FormPenjualan()
        {
            InitializeComponent();
            repo = new PenjualanRepository();
        }

        private void FormPenjualan_Load(object sender, EventArgs e)
        {
            LoadProdukCombo();
            LoadKualitasCombo();
            LoadData();
        }

        private void LoadProdukCombo()
        {
            cmbProduk.Items.Clear();
            var listProduk = repo.GetProdukList();
            foreach (var produk in listProduk)
            {
                cmbProduk.Items.Add(produk);
            }
        }

        private void LoadKualitasCombo()
        {
            cmbKualitas.Items.Clear();
            var listKualitas = repo.GetKualitasList();
            foreach (var kualitas in listKualitas)
            {
                cmbKualitas.Items.Add(kualitas);
            }
        }

        private void dgvPenjualan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dgvPenjualan.Rows[e.RowIndex].Cells[0].Value != null)
            {
                var row = dgvPenjualan.Rows[e.RowIndex];
                selectedId = Convert.ToInt32(row.Cells[0].Value);

                txtNamaCustomer.Text = row.Cells[1].Value?.ToString() ?? string.Empty;
                txtNoHP.Text = row.Cells[2].Value?.ToString() ?? string.Empty;
                cmbProduk.Text = row.Cells[3].Value?.ToString() ?? string.Empty;
                cmbKualitas.Text = row.Cells[4].Value?.ToString() ?? string.Empty;
                txtJumlah.Text = row.Cells[5].Value?.ToString() ?? string.Empty;
                txtTotal.Text = row.Cells[6].Value?.ToString() ?? string.Empty;
                dateTimePicker1.Value = Convert.ToDateTime(row.Cells[7].Value);

                UpdateHarga();
            }
        }

        private void cmbProduk_SelectedIndexChanged(object sender, EventArgs e) => UpdateHarga();
        private void cmbKualitas_SelectedIndexChanged(object sender, EventArgs e) => UpdateHarga();

        private void UpdateHarga()
        {
            if (string.IsNullOrEmpty(cmbProduk.Text) || string.IsNullOrEmpty(cmbKualitas.Text))
                return;

            var kualitasValue = cmbKualitas.Text.Trim(); // ✅ pastikan cocok dengan enum
            var harga = repo.GetHarga(cmbProduk.Text, kualitasValue);
            if (harga.HasValue)
            {
                hargaSatuan = harga.Value;
                if (decimal.TryParse(txtJumlah.Text, out decimal jml))
                {
                    decimal total = hargaSatuan * jml;
                    txtTotal.Text = $"Total: Rp {total:N0}";
                }
            }
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtNamaCustomer.Text) || string.IsNullOrWhiteSpace(txtNoHP.Text))
                {
                    MessageBox.Show("Nama dan No HP wajib diisi!");
                    return;
                }
                if (string.IsNullOrWhiteSpace(cmbProduk.Text))
                {
                    MessageBox.Show("Produk wajib dipilih!");
                    return;
                }
                if (string.IsNullOrWhiteSpace(cmbKualitas.Text))
                {
                    MessageBox.Show("Kualitas wajib dipilih!");
                    return;
                }
                if (string.IsNullOrWhiteSpace(txtJumlah.Text))
                {
                    MessageBox.Show("Jumlah wajib diisi!");
                    return;
                }

                int idCust = repo.GetOrCreateCustomer(txtNamaCustomer.Text, txtNoHP.Text);
                int? idProduk = repo.GetIdProduk(cmbProduk.Text);
                if (idProduk == null)
                {
                    MessageBox.Show("Produk tidak ditemukan!");
                    return;
                }

                if (!decimal.TryParse(txtJumlah.Text, out decimal jml))
                {
                    MessageBox.Show("Jumlah harus berupa angka!");
                    return;
                }
                decimal total = hargaSatuan * jml;

                var kualitasValue = cmbKualitas.Text.Trim(); // ✅ pastikan cocok dengan enum

                if (selectedId == null)
                {
                    repo.InsertPenjualan(idCust, idProduk.Value, kualitasValue, jml, total, dateTimePicker1.Value);
                    MessageBox.Show("Transaksi baru berhasil disimpan!");
                }
                else
                {
                    repo.UpdatePenjualan(selectedId.Value, idCust, idProduk.Value, kualitasValue, jml, total, dateTimePicker1.Value);
                    MessageBox.Show("Transaksi berhasil diperbarui!");
                }

                LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error simpan transaksi: " + ex.Message);
            }
        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            if (selectedId == null)
            {
                MessageBox.Show("Pilih transaksi dulu dari tabel!");
                return;
            }

            var confirm = MessageBox.Show("Apakah kamu yakin ingin menghapus transaksi ini?",
                                          "Konfirmasi Hapus", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (confirm == DialogResult.Yes)
            {
                try
                {
                    repo.DeletePenjualan(selectedId.Value);
                    MessageBox.Show("Transaksi berhasil dihapus!");
                    LoadData();
                    selectedId = null;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error hapus transaksi: " + ex.Message);
                }
            }
        }

        private void LoadData()
        {
            try
            {
                var list = repo.GetAllPenjualan();
                dgvPenjualan.DataSource = list;

                dgvPenjualan.Columns[0].HeaderText = "ID Penjualan";
                dgvPenjualan.Columns[1].HeaderText = "Nama Customer";
                dgvPenjualan.Columns[2].HeaderText = "No HP";
                dgvPenjualan.Columns[3].HeaderText = "Produk";
                dgvPenjualan.Columns[4].HeaderText = "Kualitas";
                dgvPenjualan.Columns[5].HeaderText = "Jumlah (kg)";
                dgvPenjualan.Columns[6].HeaderText = "Total Harga";
                dgvPenjualan.Columns[7].HeaderText = "Tanggal";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error load data penjualan: " + ex.Message);
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e) => LoadData();
        private void btnKeluar_Click(object sender, EventArgs e) => this.Close();

        // Event kosong biar Designer aman
        private void label1_Click(object sender, EventArgs e) { }
        private void label2_Click(object sender, EventArgs e) { }
        private void label3_Click(object sender, EventArgs e) { }
        private void label4_Click(object sender, EventArgs e) { }
        private void label5_Click(object sender, EventArgs e) { }
        private void lblTotal_Click(object sender, EventArgs e) { }
        private void txtJumlah_TextChanged(object sender, EventArgs e) { }
        private void txtNamaCustomer_TextChanged(object sender, EventArgs e) { }
        private void txtNoHP_TextChanged(object sender, EventArgs e) { }
        private void dgvPenjualan_CellContentClick(object sender, DataGridViewCellEventArgs e) { }
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e) { }
        private void label7_Click(object sender, EventArgs e) { }
        private void txtTotal_TextChanged(object sender, EventArgs e) { }
        private void dgvPenjualan_CellClick_1(object sender, DataGridViewCellEventArgs e) { }
    }
}
