using Simbako.Repository;
using System;
using System.Windows.Forms;

namespace Simbako
{
    public partial class FormProduksi : Form
    {
        private int selectedId = -1;
        private readonly ProduksiRepository repo;

        public FormProduksi()
        {
            InitializeComponent();
            repo = new ProduksiRepository();
        }

        private void FormProduksi_Load(object sender, EventArgs e)
        {
            cmbStatus.Items.Clear();
            cmbStatus.Items.AddRange(new string[] { "Menunggu", "Proses", "Selesai", "Siap Jual" });

            cmbJenisProses.Items.Clear();
            cmbJenisProses.Items.AddRange(new string[] {
                "Fermentasi", "Pengeringan", "Penggulungan", "Pembungkusan", "Penyimpanan"
            });

            cmbJenisTembakau.Items.Clear();
            cmbJenisTembakau.Items.AddRange(new string[] {
                "Tembakau Rajangan", "Tembakau Kretek", "Tembakau Cerutu"
            });

            cmbKualitas.Items.Clear();
            cmbKualitas.Items.AddRange(new string[] {
                "Sangat Baik", "Bagus", "Kurang Baik", "Busuk"
            });

            LoadPanenCombo();
            LoadDataProduksi();
        }

        private void LoadPanenCombo()
        {
            try
            {
                var list = repo.GetPanenTerverifikasi();
                cmbldPanen.Items.Clear();

                foreach (var panen in list)
                {
                    if (panen.IdPanen > 0)
                    {
                        cmbldPanen.Items.Add(panen.IdPanen.ToString());
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error load panen: " + ex.Message);
            }
        }

        private void LoadDataProduksi()
        {
            try
            {
                dgvProduksi.DataSource = repo.GetAllProduksi();
                dgvProduksi.Columns[0].HeaderText = "ID Produksi";
                dgvProduksi.Columns[1].HeaderText = "ID Panen";
                dgvProduksi.Columns[2].HeaderText = "Nama Produk";
                dgvProduksi.Columns[3].HeaderText = "Jenis Proses";
                dgvProduksi.Columns[4].HeaderText = "Jumlah Diolah (kg)";
                dgvProduksi.Columns[5].HeaderText = "Hasil Produksi (kg)";
                dgvProduksi.Columns[6].HeaderText = "Status Produksi";
                dgvProduksi.Columns[7].HeaderText = "Kualitas";
                dgvProduksi.Columns[8].HeaderText = "Harga (Rp)";
            }
            catch (Exception ex) { MessageBox.Show("Error: " + ex.Message); }
        }

        private void dgvProduksi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var row = dgvProduksi.Rows[e.RowIndex];
                selectedId = int.TryParse(Convert.ToString(row.Cells[0].Value), out int id) ? id : -1;

                cmbldPanen.Text = row.Cells[1].Value?.ToString() ?? string.Empty;
                cmbJenisTembakau.Text = row.Cells[2].Value?.ToString() ?? string.Empty;
                cmbJenisProses.Text = row.Cells[3].Value?.ToString() ?? string.Empty;
                txtJumlahDiolah.Text = row.Cells[4].Value?.ToString() ?? string.Empty;
                txtHasil.Text = row.Cells[5].Value?.ToString() ?? string.Empty;
                cmbStatus.Text = row.Cells[6].Value?.ToString() ?? string.Empty;
                cmbKualitas.Text = row.Cells[7].Value?.ToString() ?? string.Empty;
                txtHarga.Text = row.Cells[8].Value?.ToString() ?? string.Empty;
            }
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            if (selectedId < 0)
            {
                MessageBox.Show("Pilih data dulu!");
                return;
            }

            if (string.IsNullOrEmpty(cmbJenisProses.Text))
            {
                MessageBox.Show("Jenis Proses wajib dipilih!", "Peringatan",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrEmpty(cmbKualitas.Text))
            {
                MessageBox.Show("Kualitas wajib dipilih!", "Peringatan",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                decimal? hasil = string.IsNullOrEmpty(txtHasil.Text) ? null : decimal.Parse(txtHasil.Text);
                decimal? harga = string.IsNullOrEmpty(txtHarga.Text) ? null : decimal.Parse(txtHarga.Text);

                repo.UpdateProduksi(selectedId,
                                    cmbJenisTembakau.Text,
                                    cmbJenisProses.Text,
                                    hasil,
                                    cmbStatus.Text,
                                    cmbKualitas.Text,
                                    harga);

                if (hasil.HasValue)
                {
                    repo.UpdateStokProduk(
                        cmbJenisTembakau.Text,
                        cmbKualitas.Text,
                        hasil.Value,
                        harga
                    );
                }

                MessageBox.Show("Hasil produksi berhasil disimpan dan stok produk diperbarui!");
                LoadDataProduksi();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (selectedId < 0)
            {
                MessageBox.Show("Pilih data dulu!");
                return;
            }

            if (string.IsNullOrEmpty(cmbJenisProses.Text))
            {
                MessageBox.Show("Jenis Proses wajib dipilih!", "Peringatan",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                decimal hasilLama = repo.GetHasilProduksiLama(selectedId);
                decimal? hasilBaru = string.IsNullOrEmpty(txtHasil.Text) ? null : decimal.Parse(txtHasil.Text);
                decimal? harga = string.IsNullOrEmpty(txtHarga.Text) ? null : decimal.Parse(txtHarga.Text);

                repo.EditProduksi(selectedId,
                                  cmbJenisTembakau.Text,
                                  cmbJenisProses.Text,
                                  int.Parse(txtJumlahDiolah.Text),
                                  hasilBaru,
                                  cmbStatus.Text,
                                  cmbKualitas.Text,
                                  harga,
                                  hasilLama);

                MessageBox.Show("Data produksi berhasil diupdate dan stok produk disesuaikan!");
                LoadDataProduksi();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error edit: " + ex.Message);
            }
        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            if (selectedId < 0)
            {
                MessageBox.Show("Pilih data dulu!");
                return;
            }

            if (MessageBox.Show("Hapus data ini?", "Konfirmasi", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    bool success = repo.DeleteProduksi(selectedId);
                    if (success)
                    {
                        MessageBox.Show("Data produksi berhasil dihapus!");
                        LoadDataProduksi();
                        selectedId = -1;
                    }
                    else
                    {
                        MessageBox.Show("Data tidak ditemukan atau sudah terhapus.");
                    }
                }
                catch (Exception ex) { MessageBox.Show("Error hapus: " + ex.Message); }
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadDataProduksi();
            LoadPanenCombo();
        }

        private void btnKeluar_Click(object sender, EventArgs e) => this.Close();

        // Event kosong sesuai Designer
        private void label1_Click(object sender, EventArgs e) { }
        private void label2_Click(object sender, EventArgs e) { }
        private void label3_Click(object sender, EventArgs e) { }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e) { }
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e) { }
        private void textBox1_TextChanged(object sender, EventArgs e) { }
        private void textBox1_TextChanged_1(object sender, EventArgs e) { }
        private void cmbKualitas_SelectedIndexChanged(object sender, EventArgs e) { }
        private void cmbJenisProses_SelectedIndexChanged(object sender, EventArgs e) { }
        private void cmbJenisTembakau_SelectedIndexChanged(object sender, EventArgs e) { }
        private void dgvProduksi_CellContentClick(object sender, DataGridViewCellEventArgs e) { }
        private void txtHasil_TextChanged(object sender, EventArgs e) { }
        private void textBox1_TextChanged_2(object sender, EventArgs e) { }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }
    }
}

