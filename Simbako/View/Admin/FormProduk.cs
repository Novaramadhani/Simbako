using Simbako.Repository;
using Simbako.Model;
using System;
using System.Windows.Forms;

namespace Simbako
{
    public partial class FormProduk : Form
    {
        private readonly ProdukRepository repo;

        public FormProduk()
        {
            InitializeComponent();
            repo = new ProdukRepository();
        }

        private void FormProduk_Load(object sender, EventArgs e)
        {
            LoadData();
            cmbKualitas.Items.Clear();
            cmbKualitas.Items.AddRange(new string[] {
                "Sangat Baik", "Bagus", "Kurang Baik", "Busuk"
            });
        }

        private void LoadData()
        {
            try
            {
                var list = repo.GetPanenTerverifikasi();

                dgvProduk.AutoGenerateColumns = false; // ✅ matikan auto generate
                dgvProduk.Columns.Clear();

                dgvProduk.Columns.Add(new DataGridViewTextBoxColumn
                {
                    DataPropertyName = "Kualitas",
                    Name = "Kualitas",
                    HeaderText = "Kualitas"
                });
                dgvProduk.Columns.Add(new DataGridViewTextBoxColumn
                {
                    DataPropertyName = "JumlahPanen",
                    Name = "JumlahPanen",
                    HeaderText = "Jumlah Panen (kg)"
                });
                dgvProduk.Columns.Add(new DataGridViewTextBoxColumn
                {
                    DataPropertyName = "TanggalPanen",
                    Name = "TanggalPanen",
                    HeaderText = "Tanggal Panen"
                });
                dgvProduk.Columns.Add(new DataGridViewTextBoxColumn
                {
                    DataPropertyName = "StatusVerifikasi",
                    Name = "StatusVerifikasi",
                    HeaderText = "Status"
                });

                dgvProduk.DataSource = list;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error load data: " + ex.Message);
            }
        }

        private void dgvProduk_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var row = dgvProduk.Rows[e.RowIndex];
                cmbKualitas.Text = row.Cells["Kualitas"].Value?.ToString() ?? string.Empty;
            }
        }

        private void btnOlahData_Click(object sender, EventArgs e)
        {
            if (dgvProduk.CurrentRow == null)
            {
                MessageBox.Show("Pilih data panen terlebih dahulu!", "Peringatan",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrEmpty(cmbNamaProduk.Text) ||
                string.IsNullOrEmpty(cmbKualitas.Text) ||
                string.IsNullOrEmpty(cmbStatusProduksi.Text))
            {
                MessageBox.Show("Lengkapi pilihan produk, kualitas, dan status produksi!",
                    "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(txtStok.Text, out int jumlahOlah) || jumlahOlah <= 0)
            {
                MessageBox.Show("Jumlah olah harus berupa angka > 0!", "Peringatan",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!decimal.TryParse(txtHarga.Text, out decimal hargaPerKg) || hargaPerKg <= 0)
            {
                MessageBox.Show("Harga harus berupa angka > 0!", "Peringatan",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string kualitas = cmbKualitas.Text;
            string namaProduk = cmbNamaProduk.Text;
            string statusProduksi = cmbStatusProduksi.Text;

            try
            {
                int? idPanen = repo.GetIdPanen(kualitas, jumlahOlah);
                if (idPanen == null)
                {
                    MessageBox.Show("Tidak ada stok panen yang cukup untuk diolah!",
                        "Stok Tidak Cukup", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                repo.InsertProduksi(idPanen.Value, namaProduk, jumlahOlah, statusProduksi, kualitas, hargaPerKg);

                if (statusProduksi == "Siap Jual")
                {
                    MessageBox.Show("Panen berhasil diolah dan masuk ke stok produk siap jual!",
                        "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show($"Panen berhasil diolah menjadi {namaProduk}. Status: {statusProduksi}",
                        "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                LoadData();
                ClearForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error olah panen: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ClearForm()
        {
            txtStok.Clear();
            txtHarga.Clear();
            cmbKualitas.SelectedIndex = -1;
            cmbNamaProduk.SelectedIndex = -1;
            cmbStatusProduksi.SelectedIndex = -1;
        }

        private void btnKeluar_Click(object sender, EventArgs e) => this.Close();

        // Event kosong biar Designer aman
        private void dgvProduk_CellContentClick(object sender, DataGridViewCellEventArgs e) { }
        private void txtHarga_TextChanged(object sender, EventArgs e) { }
        private void txtStok_TextChanged(object sender, EventArgs e) { }
        private void cmbKualitas_SelectedIndexChanged(object sender, EventArgs e) { }
        private void cmbStatusProduksi_SelectedIndexChanged(object sender, EventArgs e) { }
        private void label1_Click(object sender, EventArgs e) { }
        private void label2_Click(object sender, EventArgs e) { }
        private void label3_Click(object sender, EventArgs e) { }
        private void label4_Click(object sender, EventArgs e) { }
        private void label5_Click(object sender, EventArgs e) { }
    }
}
