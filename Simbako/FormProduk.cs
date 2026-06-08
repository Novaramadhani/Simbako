using System;
using System.Windows.Forms;
using Npgsql;

namespace Simbako
{
    public partial class FormProduk : Form
    {
        public FormProduk()
        {
            InitializeComponent();
        }

        private void FormProduk_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        // Tampilkan stok panen mentah group by kualitas
        private void LoadData()
        {
            try
            {
                using var conn = DBConnection.GetConnection();
                conn.Open();
                var cmd = new NpgsqlCommand(
                    "SELECT kualitas, SUM(jumlah_panen) AS total_panen " +
                    "FROM panen WHERE status_verifikasi = 'Terverifikasi' " +
                    "GROUP BY kualitas ORDER BY kualitas", conn);

                var adapter = new NpgsqlDataAdapter(cmd);
                var dt = new System.Data.DataTable();
                adapter.Fill(dt);
                dgvProduk.DataSource = dt;

                if (dgvProduk.Columns.Count >= 2)
                {
                    dgvProduk.Columns[0].HeaderText = "Kualitas";
                    dgvProduk.Columns[1].HeaderText = "Jumlah Panen (kg)";
                }
            }
            catch (Exception ex) { MessageBox.Show("Error load data: " + ex.Message); }
        }


        // Klik baris → isi cmbKualitas otomatis
        private void dgvProduk_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var row = dgvProduk.Rows[e.RowIndex];
                cmbKualitas.Text = row.Cells[0].Value?.ToString() ?? "";
            }
        }

        // Tombol Olah Data
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
                using var conn = DBConnection.GetConnection();
                conn.Open();

                // Cari id_panen yang stoknya cukup
                var cmdGetId = new NpgsqlCommand(
                    "SELECT id_panen FROM panen " +
                    "WHERE kualitas = @kualitas::kualitas_enum " +
                    "AND status_verifikasi = 'Terverifikasi' " +
                    "AND jumlah_panen >= @jumlah " +
                    "ORDER BY id_panen LIMIT 1", conn);
                cmdGetId.Parameters.AddWithValue("kualitas", kualitas);
                cmdGetId.Parameters.AddWithValue("jumlah", (decimal)jumlahOlah);

                object result = cmdGetId.ExecuteScalar();
                if (result == null)
                {
                    MessageBox.Show("Tidak ada stok panen yang cukup untuk diolah!",
                        "Stok Tidak Cukup", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                int idPanen = Convert.ToInt32(result);

                // Insert ke tabel produksi (harga ikut disimpan)
                var cmdInsert = new NpgsqlCommand(
                    "INSERT INTO produksi (id_panen, nama_produk, jumlah_diolah, status_produksi, kualitas, harga) " +
                    "VALUES (@id, @nama, @jumlah, @status, @kualitas, @harga)", conn);

                cmdInsert.Parameters.AddWithValue("id", idPanen);
                cmdInsert.Parameters.AddWithValue("nama", namaProduk);
                cmdInsert.Parameters.AddWithValue("jumlah", (decimal)jumlahOlah);
                cmdInsert.Parameters.AddWithValue("status", statusProduksi);
                cmdInsert.Parameters.AddWithValue("kualitas", kualitas);
                cmdInsert.Parameters.AddWithValue("harga", hargaPerKg);
                cmdInsert.ExecuteNonQuery();

                // Update stok panen mentah
                var cmdUpdate = new NpgsqlCommand(
                    "UPDATE panen SET jumlah_panen = jumlah_panen - @jumlah " +
                    "WHERE id_panen = @id", conn);
                cmdUpdate.Parameters.AddWithValue("jumlah", (decimal)jumlahOlah);
                cmdUpdate.Parameters.AddWithValue("id", idPanen);
                cmdUpdate.ExecuteNonQuery();

                // Jika status Siap Jual → masuk ke tabel produk otomatis
                if (statusProduksi == "Siap Jual")
                {
                    var cmdProduk = new NpgsqlCommand(
                        "INSERT INTO produk (nama_produk, stok, harga, kualitas, status_verifikasi) " +
                        "VALUES (@nama, @stok, @harga, @kual, 'Siap Jual') " +
                        "ON CONFLICT (nama_produk, kualitas) DO UPDATE " +
                        "SET stok = produk.stok + @stok, harga = @harga", conn);

                    cmdProduk.Parameters.AddWithValue("nama", namaProduk);
                    cmdProduk.Parameters.AddWithValue("stok", (decimal)jumlahOlah);
                    cmdProduk.Parameters.AddWithValue("harga", hargaPerKg);
                    cmdProduk.Parameters.AddWithValue("kual", kualitas);
                    cmdProduk.ExecuteNonQuery();

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

        private void btnKeluar_Click(object sender, EventArgs e) { this.Close(); }

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
