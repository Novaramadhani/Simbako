using Simbako.Repository;
using Simbako.Model;
using System;
using System.Linq;
using System.Windows.Forms;

namespace Simbako
{
    public partial class FormCustomer : Form
    {
        private readonly CustomerRepository repo;
        private decimal currentHarga = 0;

        public FormCustomer()
        {
            InitializeComponent();
            repo = new CustomerRepository();
        }

        private void FormCustomer_Load(object sender, EventArgs e)
        {
            LoadProdukTersedia();
            cmbKualitas.Items.Clear();
            cmbKualitas.Items.AddRange(new string[] {
                "Sangat Baik", "Bagus", "Kurang Baik", "Busuk"
            });
        }

        private void LoadProdukTersedia()
        {
            try
            {
                var list = repo.GetProdukSiapJual();

                dgvProduk.AutoGenerateColumns = false;
                dgvProduk.Columns.Clear();

                dgvProduk.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "IdProduk", Name = "IdProduk", HeaderText = "ID Produk" });
                dgvProduk.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "NamaProduk", Name = "NamaProduk", HeaderText = "Nama Produk" });
                dgvProduk.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "Stok", Name = "Stok", HeaderText = "Stok" });
                dgvProduk.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "Harga", Name = "Harga", HeaderText = "Harga" });
                dgvProduk.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "Kualitas", Name = "Kualitas", HeaderText = "Kualitas" });
                dgvProduk.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "StatusVerifikasi", Name = "StatusVerifikasi", HeaderText = "Status" });

                dgvProduk.DataSource = list;

                // isi ComboBox dengan nama produk unik
                var produkUnik = list
                    .GroupBy(p => p.NamaProduk)
                    .Select(g => g.First())
                    .ToList();

                cmbNamaProduk.DataSource = produkUnik;
                cmbNamaProduk.DisplayMember = "NamaProduk";
                cmbNamaProduk.ValueMember = "NamaProduk";
                cmbNamaProduk.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error load produk: " + ex.Message);
            }
        }

        private void dgvProduk_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var row = dgvProduk.Rows[e.RowIndex];

                // isi otomatis field dari tabel
                cmbNamaProduk.Text = row.Cells["NamaProduk"].Value?.ToString() ?? string.Empty;
                cmbKualitas.Text = row.Cells["Kualitas"].Value?.ToString() ?? string.Empty;

                currentHarga = Convert.ToDecimal(row.Cells["Harga"].Value);
                txtJumlah.Text = "1"; // default jumlah beli
            }
        }

        private void btnBeli_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNama.Text) || string.IsNullOrWhiteSpace(txtNoHP.Text))
            {
                MessageBox.Show("Nama dan No HP wajib diisi!");
                return;
            }

            if (string.IsNullOrEmpty(cmbNamaProduk.Text) || string.IsNullOrEmpty(cmbKualitas.Text))
            {
                MessageBox.Show("Pilih produk dan kualitas terlebih dahulu!");
                return;
            }

            if (!decimal.TryParse(txtJumlah.Text, out decimal jumlah) || jumlah <= 0)
            {
                MessageBox.Show("Jumlah belum diisi dengan benar!");
                return;
            }

            string namaProduk = cmbNamaProduk.Text;
            var hargaStok = repo.GetHargaStokByNama(namaProduk, cmbKualitas.Text);

            if (hargaStok == null)
            {
                MessageBox.Show("Produk dengan kualitas ini tidak ditemukan!");
                return;
            }

            currentHarga = hargaStok.Value.harga;
            int stok = hargaStok.Value.stok;

            if (jumlah > stok)
            {
                MessageBox.Show("Stok tidak mencukupi!");
                return;
            }

            decimal total = currentHarga * jumlah;
            int idCust = repo.GetOrCreateCustomer(txtNama.Text, txtNoHP.Text);

            int idProduk = 0;
            if (dgvProduk.CurrentRow != null && dgvProduk.CurrentRow.Cells["IdProduk"].Value != null)
            {
                idProduk = Convert.ToInt32(dgvProduk.CurrentRow.Cells["IdProduk"].Value);
            }
            repo.InsertPenjualan(idCust, idProduk, jumlah, total, cmbKualitas.Text);

            MessageBox.Show("Pembelian berhasil!");
            LoadProdukTersedia();
        }

        private void btnNota_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cmbNamaProduk.Text) || string.IsNullOrEmpty(cmbKualitas.Text))
            {
                MessageBox.Show("Pilih produk dan kualitas terlebih dahulu!");
                return;
            }

            if (!decimal.TryParse(txtJumlah.Text, out decimal jumlah) || jumlah <= 0)
            {
                MessageBox.Show("Jumlah belum diisi dengan benar!");
                return;
            }

            if (currentHarga <= 0)
            {
                MessageBox.Show("Produk dengan kualitas ini tidak ditemukan!");
                return;
            }

            decimal total = currentHarga * jumlah;

            MessageBox.Show(
                $"Nota:\n" +
                $"Nama: {txtNama.Text}\n" +
                $"No HP: {txtNoHP.Text}\n" +
                $"Produk: {cmbNamaProduk.Text}\n" +
                $"Kualitas: {cmbKualitas.Text}\n" +
                $"Jumlah: {jumlah} kg\n" +
                $"Harga: Rp {currentHarga:N0}\n" +
                $"Total: Rp {total:N0}",
                "Nota Pembelian",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );
        }

        private void btnRefresh_Click(object sender, EventArgs e) => LoadProdukTersedia();
        private void btnKeluar_Click_1(object sender, EventArgs e) => this.Close();

        private void cmbNamaProduk_SelectedIndexChanged(object sender, EventArgs e) => UpdateHarga();
        private void cmbKualitas_SelectedIndexChanged(object sender, EventArgs e) => UpdateHarga();

        private void UpdateHarga()
        {
            if (string.IsNullOrEmpty(cmbNamaProduk.Text) || string.IsNullOrEmpty(cmbKualitas.Text)) return;

            var hargaStok = repo.GetHargaStokByNama(cmbNamaProduk.Text, cmbKualitas.Text);

            if (hargaStok != null)
            {
                currentHarga = hargaStok.Value.harga;
            }
            else
            {
                currentHarga = 0;
            }
        }

        private void HitungTotal() { /* kosong karena label dihapus */ }

        // Event kosong biar Designer aman
        private void dgvProduk_CellContentClick(object sender, DataGridViewCellEventArgs e) { }
        private void txtNama_TextChanged(object sender, EventArgs e) { }
        private void txtNoHP_TextChanged(object sender, EventArgs e) { }
        private void panel1_Paint(object sender, PaintEventArgs e) { }
        private void txtJumlah_TextChanged(object sender, EventArgs e) { }
    }
}
